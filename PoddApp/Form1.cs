using BL;
using DL;
using Models;

namespace PoddApp
{
    public partial class Form1 : Form
    {
        PoddController poddController = new PoddController();
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rssLank = txtNyttFlodeURL.Text;

            poddController.HamtaAvsnittFranRss(rssLank);

            txtVisaFloden.Items.Add("RSS Flöde");

            //txtVisaAvsnitt.DataSource = poddController.HamtaAllaAvsnitt();

            //txtVisaAvsnitt.DisplayMember = "Rubrik";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Avsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLaggTillKategori_Click(object sender, EventArgs e)
        {

        }

        private void txtNyttFlodeURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtMinaFloden_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAvsnittBeskrivning_Click(object sender, EventArgs e)
        {

        }

        private void txtVisaFloden_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVisaAvsnitt.DataSource = poddController.HamtaAllaAvsnitt();

            txtVisaAvsnitt.DisplayMember = "Rubrik";
        }

        private void txtVisaAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
