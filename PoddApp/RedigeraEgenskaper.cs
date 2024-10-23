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

namespace PoddApp
{
    public partial class RedigeraEgenskaper : Form
    {
        private List<AvsnittRepository> _allapoddar;

        public RedigeraEgenskaper(List<AvsnittRepository> allapoddar, List<string> kategorier)
        {
            InitializeComponent();
            _allapoddar = allapoddar;
            FyllKategoriLista(kategorier);
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
        private void btnAcceptChange_Click(object sender, EventArgs e)
        {
            string valdPodcast = cbChoosePodcast.SelectedItem.ToString();
            string valdAttribut = cbChooseAttribute.SelectedItem.ToString();
            foreach (var podcast in _allapoddar)
            {
                if (podcast.GetNamn().Equals(valdPodcast))
                {
                    if (valdAttribut == "Namn")
                    {
                        if (podcast.GetNamn().Equals(txtChangeName.Text))
                        {
                            MessageBox.Show("Podcasten heter redan " + txtChangeName.Text);
                            return;
                        }
                        else
                        {
                            podcast.SetNamn(txtChangeName.Text);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else if (valdAttribut == "Kategori")
                    {
                        if (cbChangeCategory.SelectedItem.ToString() == podcast.GetKategori())
                        {
                            MessageBox.Show("Podcasten är redan av kategorin " + cbChangeCategory.SelectedItem.ToString());
                            return;
                        }
                        else
                        {
                            podcast.SetKategori(cbChangeCategory.SelectedItem.ToString());
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    return;
                }
            }
        }
        private void btnAbortChange_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
