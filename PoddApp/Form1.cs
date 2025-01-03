using BL;
using DL;
using Models;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace PoddApp
{
    public partial class Form1 : Form
    {
        List<AvsnittRepository> _allapoddar;
        PoddController poddController = new PoddController();
        private List<string> kategorier;

        public Form1()
        {
            InitializeComponent();
            AsyncInit();
        }

        private async Task AsyncInit()
        {
            await Task.Delay(2000);
            try
            {
                await poddController.LaddaFranXml("poddar.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel intr�ffade vid laddning av poddar: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                await Task.Run(() => poddController.LasaKategorierFranXml("kategorier.xml"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel intr�ffade vid laddning av kategorier: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                _allapoddar = poddController.HamtaAllaPoddar();
                FyllKategoriLista(GetKategorier());
                UppdateraPoddLista();
                await Task.Run(() => LaddaKategorierFranXml("kategorier.xml"));
                rbNamn.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel intr�ffade vid initialiseringen: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtVisaFloden.Items.Count > 0)
            {
                txtVisaFloden.SelectedIndex = 0;
            }
        }

        public List<string> GetKategorier()
        {
            List<string> kategorier = new List<string>();
            foreach (var item in txtVisaKategorier.Items)
            {
                kategorier.Add(item.ToString());
            }
            return kategorier;
        }

        public void FyllKategoriLista(List<string> kategorier)
        {
            cbNyttFlodeKategori.Items.Clear();
            foreach (var kategori in kategorier)
            {
                cbNyttFlodeKategori.Items.Add(kategori);
            }
        }

        private void UppdateraPoddLista()
        {
            txtVisaFloden.Items.Clear();
            string valdKategori = txtVisaKategorier.SelectedItem?.ToString();

            var filtreradePoddar = string.IsNullOrEmpty(valdKategori) ?
                _allapoddar :
                _allapoddar.Where(p => p.GetKategori() == valdKategori).ToList();

            foreach (var podcast in filtreradePoddar)
            {
                txtVisaFloden.Items.Add(podcast.GetNamn());
            }
        }


        public void sorteraLista()
        {
            //Rensar textruta
            txtVisaFloden.Items.Clear();

            //LINQ-query f�r att sortera poddarna efter namn
            var SorteraNamn =
                from namn in _allapoddar
                orderby namn.GetNamn()
                select namn;

            //L�gger till poddarna i listan
            foreach (var namn in SorteraNamn)
            {
                //L�gger till poddarna i listan
                txtVisaFloden.Items.Add(namn.GetNamn());
            }
        }

        public void sorteraLista(bool kategoricheck)
        {
            //Rensar textruta
            txtVisaFloden.Items.Clear();

            //LINQ-query f�r att sortera poddarna efter kategori
            var SorteraKategori =
                   from kategori in _allapoddar
                   orderby kategori.GetKategori()
                   select kategori;

            //Skapar en str�ng f�r att h�lla koll p� vilken kategori som visas
            string currentCategory = "";
            foreach (var pod in SorteraKategori)
            {
                //H�mtar kategorin f�r podden
                string kategori = pod.GetKategori();
                if (kategori != currentCategory)
                {
                    //L�gger till en linje f�r att separera kategorierna
                    if (!string.IsNullOrEmpty(currentCategory))
                    {
                        txtVisaFloden.Items.Add("----------");
                    }
                    //L�gger till kategorin i listan
                    currentCategory = kategori;
                    txtVisaFloden.Items.Add(kategori);
                }
                //L�gger till poddarna i listan
                txtVisaFloden.Items.Add(pod.GetNamn());
            }
        }

        private async void btnNyttFlodeLaggTill_Click(object sender, EventArgs e)
        {
            string rssLank = txtNyttFlodeURL.Text;
            string valdKategori = cbNyttFlodeKategori.Text;
            string podcastNamn = string.IsNullOrEmpty(txtNyttFlodeNamn.Text) ? rssLank : txtNyttFlodeNamn.Text;

            if (!Validering.KollaTextruta(rssLank))
            {
                MessageBox.Show("Du m�ste fylla i en giltig RSS-l�nk", "Ogiltig RSS-l�nk");
                return;
            }

            if (!Validering.KollaKategori(valdKategori))
            {
                MessageBox.Show("Du m�ste v�lja en kategori", "Ingen kategori vald");
                return;
            }

            if (!Validering.KollaUniktNamn(_allapoddar, podcastNamn))
            {
                MessageBox.Show("Namnet p� podcasten �r inte unikt", "Byt namn p� podcast");
                return;
            }

            try
            {
                await poddController.HamtaAvsnittFranRss(podcastNamn, rssLank, valdKategori);
                txtVisaFloden.Items.Add(podcastNamn);
                rbNamn.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"V�nligen kontrollera att l�nken leder till ett RSS-fl�de: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtVisaFloden_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtVisaAvsnitt.Text = "";
            txtVisaAvsnitt.DataSource = null;

            if (txtVisaFloden.SelectedItem != null)
            {
                string valtPoddNamn = txtVisaFloden.SelectedItem.ToString();
                var valdPodd = _allapoddar.FirstOrDefault(p => p.GetNamn() == valtPoddNamn);

                if (valdPodd != null)
                {
                    var poddVisare = valdPodd.HamtaAllaAvsnitt();
                    txtVisaAvsnitt.DataSource = poddVisare;
                    txtVisaAvsnitt.DisplayMember = "Rubrik";
                }
            }
            else
            {
                MessageBox.Show("Kunde inte hitta n�gon podcast");
            }
        }

        private void txtVisaAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int avsnittIndex = txtVisaAvsnitt.SelectedIndex;
                txtAvsnittBeskrivning.Text = "";

                if (txtVisaFloden.SelectedIndex >= 0 && avsnittIndex >= 0)
                {
                    string valtPoddNamn = txtVisaFloden.SelectedItem.ToString();
                    var valdPodd = _allapoddar.FirstOrDefault(p => p.GetNamn() == valtPoddNamn);
                    var valdPoddAvsnittLista = valdPodd.HamtaAllaAvsnitt();
                    var valtAvsnitt = valdPoddAvsnittLista[avsnittIndex];

                    txtAvsnittBeskrivning.Text = valtAvsnitt.Beskrivning;

                    if (txtAvsnittBeskrivning.Text == "")
                    {
                        txtAvsnittBeskrivning.Text = "Beskrivning saknas";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod n�r avsnittet laddades: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRaderaKategori_Click(object sender, EventArgs e)
        {
            if (txtVisaKategorier.SelectedIndex >= 0)
            {
                string valdKategori = txtVisaKategorier.SelectedItem.ToString();

                if (Validering.KollaKategoriAnv�ndning(_allapoddar, valdKategori))
                {
                    MessageBox.Show("Det finns poddar kopplade till denna kategori. "
                        + "Antingen ta bort dessa poddar eller �ndra deras kategori innan du kan forts�tta.",
                        "Kategori �r i bruk",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show(
                    $"�r du s�ker p� att du vill radera kategorin '{valdKategori}'?",
                    "Bekr�fta radering",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    txtVisaKategorier.Items.Remove(valdKategori);

                    FyllKategoriLista(GetKategorier());

                    try
                    {
                        SparaKategorierTillXml("kategorier.xml");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ett fel intr�ffade vid sparande av kategorier: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show($"Kategorin '{valdKategori}' har raderats.");
                }
            }
            else
            {
                MessageBox.Show("V�lj en kategori att radera.");
            }
        }

        public void SparaKategorierTillXml(string filnamn)
        {
            try
            {
                using (XmlWriter writer = XmlWriter.Create(filnamn))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Kategorier");

                    foreach (var kategori in txtVisaKategorier.Items)
                    {
                        writer.WriteElementString("Kategori", kategori.ToString());
                    }

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod vid sparande till XML: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LaddaKategorierFranXml(string filnamn)
        {
            txtVisaKategorier.Items.Clear();
            if (!File.Exists(filnamn))
            {
                return;
            }

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filnamn);

                XmlNodeList kategoriNodes = doc.SelectNodes("/Kategorier/Kategori");
                foreach (XmlNode kategoriNode in kategoriNodes)
                {
                    string kategori = kategoriNode.InnerText;
                    if (!txtVisaKategorier.Items.Contains(kategori))
                    {
                        txtVisaKategorier.Items.Add(kategori);
                    }
                }

                FyllKategoriLista(GetKategorier());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod vid laddning av kategorier fr�n XML: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtVisaKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            UppdateraPoddLista();

            if (txtVisaFloden.Items.Count > 0)
            {
                txtVisaFloden.SelectedIndex = 0;
            }

            else
            {
                txtVisaAvsnitt.DataSource = null;
                txtAvsnittBeskrivning.Text = "";
            }

        }
        private void LaddaKategorier()
        {
            kategorier = poddController.LasaKategorierFranXml("kategorier.xml");
            txtVisaKategorier.Items.Clear();
            foreach (string kategori in kategorier)
            {
                txtVisaKategorier.Items.Add(kategori);
            }

            if (txtVisaKategorier.Items.Count > 0)
            {
                txtVisaKategorier.SelectedIndex = 0;
            }
        }

        private void btnLaggTillKategori_Click(object sender, EventArgs e)
        {
            string nyKategori = txtLaggTillKategori.Text.Trim();

            if (!Validering.KollaKategori(nyKategori))
            {
                MessageBox.Show("Du m�ste fylla i en kategori", "Ogiltig kategori");
                return;
            }

            if (!Validering.KollaUnikKategori(txtVisaKategorier.Items, nyKategori))
            {
                MessageBox.Show("Kategorin finns redan", "Kategori finns redan");
                return;
            }

            txtVisaKategorier.Items.Add(nyKategori);
            FyllKategoriLista(GetKategorier());

            SparaKategorierTillXml("kategorier.xml");

            txtLaggTillKategori.Text = "";
        }

        private void btnRedigeraFloden_Click(object sender, EventArgs e)
        {
            using (var redigeraEgenskaper = new RedigeraEgenskaper(_allapoddar, GetKategorier(), poddController))
            {
                if (redigeraEgenskaper.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Dina �ndringar har sparats");
                    UppdateraPoddLista();
                    rbNamn.Checked = true;
                }

                else if (redigeraEgenskaper.DialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Dina �ndringar har inte sparats");
                    rbNamn.Checked = true;
                }
            }
        }

        private void btnRaderaFloden_Click(object sender, EventArgs e)
        {
            if (txtVisaFloden.SelectedIndex >= 0)
            {
                String valtPoddNamn = txtVisaFloden.SelectedItem.ToString();

                DialogResult dialogResult = MessageBox.Show(
                $"�r du s�ker p� att du vill radera podcasten '{valtPoddNamn}'?",
                "Bekr�fta radering",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {

                    var poddAttTaBort = _allapoddar.FirstOrDefault(p => p.GetNamn() == valtPoddNamn);

                    if (poddAttTaBort != null)
                    {
                        _allapoddar.Remove(poddAttTaBort);
                        poddController.SparaTillXml("poddar.xml");
                        UppdateraPoddLista();
                        rbNamn.Checked = true;

                        txtVisaAvsnitt.DataSource = null;
                        txtAvsnittBeskrivning.Text = "";

                        MessageBox.Show($"Podcasten '{valtPoddNamn}' har raderats.");
                    }
                    rbNamn.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("V�lj en podcast att radera.");
            }
        }


        private void rbNamn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbNamn.Checked)
                {
                    sorteraLista();
                }
            } catch {
                MessageBox.Show("Det fanns inga poddar att sortera", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbKategori_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbKategori.Checked)
                {
                    bool kategori = true;
                    sorteraLista(kategori);
                }
            }
            catch
            {
                MessageBox.Show("Det fanns inga poddar att sortera", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRedigeraKategori_Click(object sender, EventArgs e)
        {
            using (var redigeraKategori = new RedigeraKategori(GetKategorier(), poddController))
            {
                if (redigeraKategori.ShowDialog() == DialogResult.OK)
                {
                    LaddaKategorierFranXml("kategorier.xml");
                    UppdateraPoddLista();
                    rbNamn.Checked = true;
                }
                else if (redigeraKategori.DialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Dina �ndringar har inte sparats");
                    rbNamn.Checked = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

