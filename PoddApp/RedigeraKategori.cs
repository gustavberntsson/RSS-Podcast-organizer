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

namespace PoddApp
{
    public partial class RedigeraKategori : Form
    {

        private List<AvsnittRepository> _allakategorier;

        private readonly PoddController _poddController;

        public RedigeraKategori(List<AvsnittRepository> allakategorier, PoddController poddController, List<string> kategorier)
        {
            InitializeComponent();
            _allakategorier = allakategorier;
            _poddController = poddController;

            FyllKategoriLista(kategorier);
        }

        private void btnSparaKategoriAndring_Click(object sender, EventArgs e)
        {

        }
        private void FyllKategoriLista(List<string> kategorier)
        {
            //rensar först
            cbRedigeraKategori.Items.Clear();
            foreach (var kategori in kategorier)
            {
                cbRedigeraKategori.Items.Add(kategori);
            }
        }

        private void cbRedigeraKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
