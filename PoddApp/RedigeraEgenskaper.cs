using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DL;
using Models;

namespace PoddApp
{
    public partial class RedigeraEgenskaper : Form
    {
        private List<AvsnittRepository> _allapoddar;

        private readonly PoddController _poddController;

        public RedigeraEgenskaper(List<AvsnittRepository> allapoddar, List<string> kategorier, PoddController poddController)
        {
            InitializeComponent();
            _allapoddar = allapoddar;
            _poddController = poddController;
            FyllKategoriLista(kategorier);
            FyllPoddLista();
        }

        public void FyllPoddLista()
        {
            //rensar först
            cbChoosePodcast.Items.Clear();
            foreach (var podcast in _allapoddar)
            {
                cbChoosePodcast.Items.Add(podcast.GetNamn());
            }
        }

        private void FyllKategoriLista(List<string> kategorier)
        {
            //rensar först
            cbChangeCategory.Items.Clear();
            foreach (var kategori in kategorier)
            {
                    cbChangeCategory.Items.Add(kategori);
            }
        }
        private void cbChoosePodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChoosePodcast.SelectedItem != null)
            {
                
                lblChooseAttribute.Visible = true;
                cbChooseAttribute.Visible = true;

            }
            else
            {
                lblChooseAttribute.Visible = false;
                cbChooseAttribute.Visible = false;
            }
        }

        private void cbChooseAttribute_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valdAttribut = cbChooseAttribute.SelectedItem.ToString();
            if (valdAttribut == "Namn")
            {
                lblChangeName.Visible = true;
                txtChangeName.Visible = true;
                lblChangeCategory.Visible = false;
                cbChangeCategory.Visible = false;
            }
            else if (valdAttribut == "Kategori")
            {
                lblChangeName.Visible = false;
                txtChangeName.Visible = false;
                lblChangeCategory.Visible = true;
                cbChangeCategory.Visible = true;
            }
        }

        private async void btnAcceptChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbChoosePodcast.SelectedItem == null)
                {
                    MessageBox.Show("Ingen podcast vald", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbChooseAttribute.SelectedItem == null)
                {
                    MessageBox.Show("Du måste välja vilken egenskap du vill ändra", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string valdPodcast = cbChoosePodcast.SelectedItem.ToString();
                string valdAttribut = cbChooseAttribute.SelectedItem.ToString();

                foreach (var podcast in _allapoddar)
                {
                    if (podcast.GetNamn().Equals(valdPodcast))
                    {
                        if (valdAttribut == "Namn")
                        {
                            if (string.IsNullOrWhiteSpace(txtChangeName.Text))
                            {
                                MessageBox.Show("Du måste ange ett nytt namn", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (podcast.GetNamn().Equals(txtChangeName.Text))
                            {
                                MessageBox.Show("Podcasten heter redan " + txtChangeName.Text);
                                return;
                            }
                            else
                            {
                                podcast.SetNamn(txtChangeName.Text);
                            }
                        }
                        else if (valdAttribut == "Kategori")
                        {
                            if (cbChangeCategory.SelectedItem == null)
                            {
                                MessageBox.Show("Du måste välja en ny kategori", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            var kategoriNamn = cbChangeCategory.SelectedItem.ToString();
                            var kategori = new Kategori(kategoriNamn);
                            podcast.SetKategori(kategori);
                        }

                        //Asynkront spara till XML
                        await SparaTillXml();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ett fel uppstod: " + ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SparaTillXml()
        {
            await _poddController.SparaTillXml("poddar.xml");
        }
        private void btnAbortChange_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
