using BL;
using DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using static System.Windows.Forms.DataFormats;

namespace PoddApp
{
    public partial class RedigeraKategori : Form
    {

        private List <String> _allakategorier;

        private readonly PoddController _poddController;


        public RedigeraKategori(List <String> allakategorier, PoddController poddController)
        {
            InitializeComponent();
            _allakategorier = allakategorier;
            _poddController = poddController;
            FyllKategoriLista();
        }

        private void btnSparaKategoriAndring_Click(object sender, EventArgs e)
        {
            if (cbRedigeraKategori.SelectedItem == null)
            {
                MessageBox.Show("Du måste välja en kategori");
                return;
            }

            string valdKategori = cbRedigeraKategori.SelectedItem.ToString();
            string nyKategori = txtRedigeraKategori.Text.Trim();

            if (!Validering.KollaTextruta(nyKategori))
            {
                MessageBox.Show("Du måste skriva in en kategori");
                return;
            }

            if (!Validering.KollaKategori(nyKategori))
            {
                MessageBox.Show("Ogiltigt kategorinamn");
                return;
            }

            if (_allakategorier.Contains(nyKategori) && !valdKategori.Equals(nyKategori))
            {
                MessageBox.Show("Kategorin finns redan");
                return;
            }

            int index = _allakategorier.IndexOf(valdKategori);
            if (index != -1)
            {
                _allakategorier[index] = nyKategori;

                // Uppdatera både kategorier.xml och poddar.xml
                _poddController.UppdateraKategoriNamnIAllaPoddar(valdKategori, nyKategori);
                SparaTillXml();

                MessageBox.Show("Kategorin har ändrats");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SparaTillXml()
        {
            _poddController.SparaKategorierTillXml("kategorier.xml", _allakategorier);
        }
        private void FyllKategoriLista()
        {
            //rensar först
            cbRedigeraKategori.Items.Clear();
            foreach (var kategori in _allakategorier)
            {
                cbRedigeraKategori.Items.Add(kategori);
            }
        }

        private void cbRedigeraKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRedigeraKategori.SelectedItem != null)
            {
                txtRedigeraKategori.Text = cbRedigeraKategori.SelectedItem.ToString();
            }
        }
    }
}
