namespace PoddApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeader = new Label();
            btnNyttFlodeLaggTill = new Button();
            txtNyttFlodeURL = new TextBox();
            txtVisaKategorier = new RichTextBox();
            cbNyttFlodeKategori = new ComboBox();
            lblSkapaNyttFlodeKategori = new Label();
            lblSkapaNyttFlode = new Label();
            lblAvsnittLista = new Label();
            btnRedigeraFloden = new Button();
            btnRaderaFloden = new Button();
            lblMinaKategorier = new Label();
            btnRaderaKategori = new Button();
            btnLaggTillKategori = new Button();
            txtLaggTillKategori = new TextBox();
            lblLaggTillNyKategori = new Label();
            lblLaggTillNyKategoriTitel = new Label();
            lblLaggTillFlodeURL = new Label();
            lblAvsnittBeskrivning = new Label();
            txtAvsnittBeskrivning = new RichTextBox();
            txtVisaFloden = new ListBox();
            txtVisaAvsnitt = new ListBox();
            lblLaggTillFlodeNamn = new Label();
            txtNyttFlodeNamn = new TextBox();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(513, 31);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(54, 15);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Podcasts";
            lblHeader.Click += label1_Click;
            // 
            // btnNyttFlodeLaggTill
            // 
            btnNyttFlodeLaggTill.BackColor = SystemColors.GradientActiveCaption;
            btnNyttFlodeLaggTill.Location = new Point(318, 180);
            btnNyttFlodeLaggTill.Margin = new Padding(2);
            btnNyttFlodeLaggTill.Name = "btnNyttFlodeLaggTill";
            btnNyttFlodeLaggTill.Size = new Size(78, 21);
            btnNyttFlodeLaggTill.TabIndex = 1;
            btnNyttFlodeLaggTill.Text = "Lägg till";
            btnNyttFlodeLaggTill.UseVisualStyleBackColor = false;
            btnNyttFlodeLaggTill.Click += button1_Click;
            // 
            // txtNyttFlodeURL
            // 
            txtNyttFlodeURL.Location = new Point(128, 154);
            txtNyttFlodeURL.Name = "txtNyttFlodeURL";
            txtNyttFlodeURL.PlaceholderText = "https://www.exempel.com/rss";
            txtNyttFlodeURL.Size = new Size(186, 23);
            txtNyttFlodeURL.TabIndex = 3;
            txtNyttFlodeURL.TextChanged += txtNyttFlodeURL_TextChanged;
            // 
            // txtVisaKategorier
            // 
            txtVisaKategorier.Location = new Point(886, 213);
            txtVisaKategorier.Margin = new Padding(3, 2, 3, 2);
            txtVisaKategorier.Name = "txtVisaKategorier";
            txtVisaKategorier.Size = new Size(274, 119);
            txtVisaKategorier.TabIndex = 6;
            txtVisaKategorier.Text = "";
            // 
            // cbNyttFlodeKategori
            // 
            cbNyttFlodeKategori.FormattingEnabled = true;
            cbNyttFlodeKategori.Items.AddRange(new object[] { "Skräck", "Komedi" });
            cbNyttFlodeKategori.Location = new Point(128, 180);
            cbNyttFlodeKategori.Margin = new Padding(3, 2, 3, 2);
            cbNyttFlodeKategori.Name = "cbNyttFlodeKategori";
            cbNyttFlodeKategori.Size = new Size(186, 23);
            cbNyttFlodeKategori.TabIndex = 8;
            // 
            // lblSkapaNyttFlodeKategori
            // 
            lblSkapaNyttFlodeKategori.AutoSize = true;
            lblSkapaNyttFlodeKategori.Location = new Point(65, 183);
            lblSkapaNyttFlodeKategori.Name = "lblSkapaNyttFlodeKategori";
            lblSkapaNyttFlodeKategori.Size = new Size(51, 15);
            lblSkapaNyttFlodeKategori.TabIndex = 11;
            lblSkapaNyttFlodeKategori.Text = "Kategori";
            // 
            // lblSkapaNyttFlode
            // 
            lblSkapaNyttFlode.AutoSize = true;
            lblSkapaNyttFlode.Location = new Point(164, 107);
            lblSkapaNyttFlode.Name = "lblSkapaNyttFlode";
            lblSkapaNyttFlode.Size = new Size(92, 15);
            lblSkapaNyttFlode.TabIndex = 12;
            lblSkapaNyttFlode.Text = "Skapa nytt flöde";
            lblSkapaNyttFlode.Click += label4_Click;
            // 
            // lblAvsnittLista
            // 
            lblAvsnittLista.AutoSize = true;
            lblAvsnittLista.Location = new Point(549, 180);
            lblAvsnittLista.Name = "lblAvsnittLista";
            lblAvsnittLista.Size = new Size(44, 15);
            lblAvsnittLista.TabIndex = 13;
            lblAvsnittLista.Text = "Avsnitt";
            lblAvsnittLista.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRedigeraFloden
            // 
            btnRedigeraFloden.BackColor = SystemColors.GradientActiveCaption;
            btnRedigeraFloden.Location = new Point(49, 556);
            btnRedigeraFloden.Margin = new Padding(2);
            btnRedigeraFloden.Name = "btnRedigeraFloden";
            btnRedigeraFloden.Size = new Size(157, 21);
            btnRedigeraFloden.TabIndex = 17;
            btnRedigeraFloden.Text = "Redigera";
            btnRedigeraFloden.UseVisualStyleBackColor = false;
            // 
            // btnRaderaFloden
            // 
            btnRaderaFloden.BackColor = SystemColors.GradientActiveCaption;
            btnRaderaFloden.Location = new Point(233, 556);
            btnRaderaFloden.Margin = new Padding(2);
            btnRaderaFloden.Name = "btnRaderaFloden";
            btnRaderaFloden.Size = new Size(150, 21);
            btnRaderaFloden.TabIndex = 18;
            btnRaderaFloden.Text = "Radera";
            btnRaderaFloden.UseVisualStyleBackColor = false;
            // 
            // lblMinaKategorier
            // 
            lblMinaKategorier.AutoSize = true;
            lblMinaKategorier.Location = new Point(970, 160);
            lblMinaKategorier.Name = "lblMinaKategorier";
            lblMinaKategorier.Size = new Size(90, 15);
            lblMinaKategorier.TabIndex = 19;
            lblMinaKategorier.Text = "Mina kategorier";
            // 
            // btnRaderaKategori
            // 
            btnRaderaKategori.BackColor = SystemColors.GradientActiveCaption;
            btnRaderaKategori.Location = new Point(1053, 335);
            btnRaderaKategori.Margin = new Padding(2);
            btnRaderaKategori.Name = "btnRaderaKategori";
            btnRaderaKategori.Size = new Size(107, 21);
            btnRaderaKategori.TabIndex = 20;
            btnRaderaKategori.Text = "Radera";
            btnRaderaKategori.UseVisualStyleBackColor = false;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.BackColor = SystemColors.GradientActiveCaption;
            btnLaggTillKategori.Location = new Point(1068, 394);
            btnLaggTillKategori.Margin = new Padding(2);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(92, 21);
            btnLaggTillKategori.TabIndex = 21;
            btnLaggTillKategori.Text = "Lägg till";
            btnLaggTillKategori.UseVisualStyleBackColor = false;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click;
            // 
            // txtLaggTillKategori
            // 
            txtLaggTillKategori.Location = new Point(937, 395);
            txtLaggTillKategori.Name = "txtLaggTillKategori";
            txtLaggTillKategori.Size = new Size(121, 23);
            txtLaggTillKategori.TabIndex = 22;
            // 
            // lblLaggTillNyKategori
            // 
            lblLaggTillNyKategori.AutoSize = true;
            lblLaggTillNyKategori.Location = new Point(961, 366);
            lblLaggTillNyKategori.Name = "lblLaggTillNyKategori";
            lblLaggTillNyKategori.Size = new Size(111, 15);
            lblLaggTillNyKategori.TabIndex = 23;
            lblLaggTillNyKategori.Text = "Lägg till ny kategori";
            // 
            // lblLaggTillNyKategoriTitel
            // 
            lblLaggTillNyKategoriTitel.AutoSize = true;
            lblLaggTillNyKategoriTitel.Location = new Point(886, 398);
            lblLaggTillNyKategoriTitel.Name = "lblLaggTillNyKategoriTitel";
            lblLaggTillNyKategoriTitel.Size = new Size(29, 15);
            lblLaggTillNyKategoriTitel.TabIndex = 24;
            lblLaggTillNyKategoriTitel.Text = "Titel";
            // 
            // lblLaggTillFlodeURL
            // 
            lblLaggTillFlodeURL.AutoSize = true;
            lblLaggTillFlodeURL.Location = new Point(92, 157);
            lblLaggTillFlodeURL.Name = "lblLaggTillFlodeURL";
            lblLaggTillFlodeURL.Size = new Size(28, 15);
            lblLaggTillFlodeURL.TabIndex = 25;
            lblLaggTillFlodeURL.Text = "URL";
            lblLaggTillFlodeURL.Click += label1_Click_1;
            // 
            // lblAvsnittBeskrivning
            // 
            lblAvsnittBeskrivning.AutoSize = true;
            lblAvsnittBeskrivning.Location = new Point(565, 418);
            lblAvsnittBeskrivning.Name = "lblAvsnittBeskrivning";
            lblAvsnittBeskrivning.Size = new Size(68, 15);
            lblAvsnittBeskrivning.TabIndex = 26;
            lblAvsnittBeskrivning.Text = "Beskrivning";
            lblAvsnittBeskrivning.TextAlign = ContentAlignment.MiddleCenter;
            lblAvsnittBeskrivning.Click += lblAvsnittBeskrivning_Click;
            // 
            // txtAvsnittBeskrivning
            // 
            txtAvsnittBeskrivning.Location = new Point(442, 442);
            txtAvsnittBeskrivning.Margin = new Padding(3, 2, 3, 2);
            txtAvsnittBeskrivning.Name = "txtAvsnittBeskrivning";
            txtAvsnittBeskrivning.Size = new Size(316, 119);
            txtAvsnittBeskrivning.TabIndex = 27;
            txtAvsnittBeskrivning.Text = "";
            // 
            // txtVisaFloden
            // 
            txtVisaFloden.FormattingEnabled = true;
            txtVisaFloden.ItemHeight = 15;
            txtVisaFloden.Location = new Point(92, 223);
            txtVisaFloden.Margin = new Padding(3, 2, 3, 2);
            txtVisaFloden.Name = "txtVisaFloden";
            txtVisaFloden.Size = new Size(257, 244);
            txtVisaFloden.TabIndex = 28;
            txtVisaFloden.SelectedIndexChanged += txtVisaFloden_SelectedIndexChanged;
            // 
            // txtVisaAvsnitt
            // 
            txtVisaAvsnitt.FormattingEnabled = true;
            txtVisaAvsnitt.ItemHeight = 15;
            txtVisaAvsnitt.Location = new Point(442, 220);
            txtVisaAvsnitt.Margin = new Padding(3, 2, 3, 2);
            txtVisaAvsnitt.Name = "txtVisaAvsnitt";
            txtVisaAvsnitt.Size = new Size(316, 184);
            txtVisaAvsnitt.TabIndex = 29;
            txtVisaAvsnitt.SelectedIndexChanged += txtVisaAvsnitt_SelectedIndexChanged;
            // 
            // lblLaggTillFlodeNamn
            // 
            lblLaggTillFlodeNamn.AutoSize = true;
            lblLaggTillFlodeNamn.Location = new Point(76, 128);
            lblLaggTillFlodeNamn.Name = "lblLaggTillFlodeNamn";
            lblLaggTillFlodeNamn.Size = new Size(40, 15);
            lblLaggTillFlodeNamn.TabIndex = 30;
            lblLaggTillFlodeNamn.Text = "Namn";
            lblLaggTillFlodeNamn.Click += lblPodcastNamn_Click;
            // 
            // txtNyttFlodeNamn
            // 
            txtNyttFlodeNamn.Location = new Point(128, 125);
            txtNyttFlodeNamn.Name = "txtNyttFlodeNamn";
            txtNyttFlodeNamn.PlaceholderText = "Creepypodden i P3";
            txtNyttFlodeNamn.Size = new Size(186, 23);
            txtNyttFlodeNamn.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 586);
            Controls.Add(txtNyttFlodeNamn);
            Controls.Add(lblLaggTillFlodeNamn);
            Controls.Add(txtVisaAvsnitt);
            Controls.Add(txtVisaFloden);
            Controls.Add(txtAvsnittBeskrivning);
            Controls.Add(lblAvsnittBeskrivning);
            Controls.Add(lblLaggTillFlodeURL);
            Controls.Add(lblLaggTillNyKategoriTitel);
            Controls.Add(lblLaggTillNyKategori);
            Controls.Add(txtLaggTillKategori);
            Controls.Add(btnLaggTillKategori);
            Controls.Add(btnRaderaKategori);
            Controls.Add(lblMinaKategorier);
            Controls.Add(btnRaderaFloden);
            Controls.Add(btnRedigeraFloden);
            Controls.Add(lblAvsnittLista);
            Controls.Add(lblSkapaNyttFlode);
            Controls.Add(lblSkapaNyttFlodeKategori);
            Controls.Add(cbNyttFlodeKategori);
            Controls.Add(txtVisaKategorier);
            Controls.Add(txtNyttFlodeURL);
            Controls.Add(btnNyttFlodeLaggTill);
            Controls.Add(lblHeader);
            Cursor = Cursors.IBeam;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnNyttFlodeLaggTill;
        private TextBox txtNyttFlodeURL;
        private RichTextBox txtVisaKategorier;
        private ComboBox cbNyttFlodeKategori;
        private Label lblSkapaNyttFlodeKategori;
        private Label lblSkapaNyttFlode;
        private Label lblAvsnittLista;
        private Button btnRedigeraFloden;
        private Button btnRaderaFloden;
        private Label lblMinaKategorier;
        private Button btnRaderaKategori;
        private Button btnLaggTillKategori;
        private TextBox txtLaggTillKategori;
        private Label lblLaggTillNyKategori;
        private Label lblLaggTillNyKategoriTitel;
        private Label lblLaggTillFlodeURL;
        private Label lblAvsnittBeskrivning;
        private RichTextBox txtAvsnittBeskrivning;
        private ListBox txtVisaFloden;
        private ListBox txtVisaAvsnitt;
        private Label lblLaggTillFlodeNamn;
        private TextBox txtNyttFlodeNamn;
    }
}
