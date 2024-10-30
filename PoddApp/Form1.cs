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

        public Form1()
        {
            InitializeComponent();

            try
            {
                poddController.LaddaFranXml("poddar.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel inträffade vid laddning av poddar: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                _allapoddar = poddController.HamtaAllaPoddar();
                FyllKategoriLista(GetKategorier());
                UppdateraPoddLista();
                LaddaKategorierFranXml("kategorier.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel inträffade vid initialiseringen: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }

        public void sorteraLista(bool kategoricheck)
        {
         
        }

        private void btnNyttFlodeLaggTill_Click(object sender, EventArgs e)
        {
            string rssLank = txtNyttFlodeURL.Text;
            string valdKategori = cbNyttFlodeKategori.Text;
            string podcastNamn = string.IsNullOrEmpty(txtNyttFlodeNamn.Text) ? rssLank : txtNyttFlodeNamn.Text;

            if (!Validering.KollaTextruta(rssLank))
            {
                MessageBox.Show("Du måste fylla i en giltig RSS-länk", "Ogiltig RSS-länk");
                return;
            }

            if (!Validering.KollaKategori(valdKategori))
            {
                MessageBox.Show("Du måste välja en kategori", "Ingen kategori vald");
                return;
            }

            if (!Validering.KollaUniktNamn(_allapoddar, podcastNamn))
            {
                MessageBox.Show("Namnet på podcasten är inte unikt", "Byt namn på podcast");
                return;
            }

            try
            {
                poddController.HamtaAvsnittFranRss(podcastNamn, rssLank, valdKategori);
                txtVisaFloden.Items.Add(podcastNamn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Vänligen kontrollera att länken leder till ett RSS-flöde: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Kunde inte hitta någon podcast");
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
                MessageBox.Show($"Ett fel uppstod när avsnittet laddades: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRaderaKategori_Click(object sender, EventArgs e)
        {
            if (txtVisaKategorier.SelectedIndex >= 0)
            {
                string valdKategori = txtVisaKategorier.SelectedItem.ToString();

                if (Validering.KollaKategoriAnvändning(_allapoddar, valdKategori))
                {
                    MessageBox.Show("Det finns poddar kopplade till denna kategori. "
                        + "Antingen ta bort dessa poddar eller ändra deras kategori innan du kan fortsätta.",
                        "Kategori är i bruk",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show(
                    $"Är du säker på att du vill radera kategorin '{valdKategori}'?",
                    "Bekräfta radering",
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
                        MessageBox.Show($"Ett fel inträffade vid sparande av kategorier: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show($"Kategorin '{valdKategori}' har raderats.");
                }
            }
            else
            {
                MessageBox.Show("Välj en kategori att radera.");
            }
        }

        private void SparaKategorierTillXml(string filnamn)
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
                MessageBox.Show($"Ett fel uppstod vid laddning av kategorier från XML: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnLaggTillKategori_Click(object sender, EventArgs e)
        {
            string nyKategori = txtLaggTillKategori.Text.Trim();

            if (!Validering.KollaKategori(nyKategori))
            {
                MessageBox.Show("Du måste fylla i en kategori", "Ogiltig kategori");
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
                    MessageBox.Show("Dina ändringar har sparats");
                    UppdateraPoddLista();
                }

                else if (redigeraEgenskaper.DialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Dina ändringar har inte sparats");
                }
            }
        }

        private void btnRaderaFloden_Click(object sender, EventArgs e)
        {
            if (txtVisaFloden.SelectedIndex >= 0)
            {
                String valtPoddNamn = txtVisaFloden.SelectedItem.ToString();

                DialogResult dialogResult = MessageBox.Show(
                $"Är du säker på att du vill radera podcasten '{valtPoddNamn}'?",
                "Bekräfta radering",
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

                        txtVisaAvsnitt.DataSource = null;
                        txtAvsnittBeskrivning.Text = "";

                        MessageBox.Show($"Podcasten '{valtPoddNamn}' har raderats.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Välj en podcast att radera.");
            }
        }

        private void rbNamn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNamn.Checked)
            {
                sorteraLista();
            }
        }

        private void rbKategori_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKategori.Checked)
            {
                bool kategori = true;
                sorteraLista(kategori);
            }
        }
    }
}

