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
            lblHeader.Font = new Font("Segoe UI", 17F);
            lblHeader.ForeColor = Color.FromArgb(204, 230, 135, 130);
            lblHeader.Location = new Point(672, 51);
            lblHeader.Margin = new Padding(5, 0, 5, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(151, 46);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Podcasts";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.Click += label1_Click;
            // 
            // btnNyttFlodeLaggTill
            // 
            btnNyttFlodeLaggTill.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnNyttFlodeLaggTill.FlatStyle = FlatStyle.Flat;
            btnNyttFlodeLaggTill.Location = new Point(236, 365);
            btnNyttFlodeLaggTill.Margin = new Padding(5);
            btnNyttFlodeLaggTill.Name = "btnNyttFlodeLaggTill";
            btnNyttFlodeLaggTill.Size = new Size(125, 35);
            btnNyttFlodeLaggTill.TabIndex = 1;
            btnNyttFlodeLaggTill.Text = "Lägg till";
            btnNyttFlodeLaggTill.UseVisualStyleBackColor = false;
            btnNyttFlodeLaggTill.Click += button1_Click;
            // 
            // txtNyttFlodeURL
            // 
            txtNyttFlodeURL.Location = new Point(157, 257);
            txtNyttFlodeURL.Margin = new Padding(5);
            txtNyttFlodeURL.Name = "txtNyttFlodeURL";
            txtNyttFlodeURL.PlaceholderText = "https://www.exempel.com/rss";
            txtNyttFlodeURL.Size = new Size(289, 31);
            txtNyttFlodeURL.TabIndex = 3;
            txtNyttFlodeURL.TextChanged += txtNyttFlodeURL_TextChanged;
            // 
            // txtVisaKategorier
            // 
            txtVisaKategorier.Location = new Point(1042, 204);
            txtVisaKategorier.Margin = new Padding(5);
            txtVisaKategorier.Name = "txtVisaKategorier";
            txtVisaKategorier.Size = new Size(426, 276);
            txtVisaKategorier.TabIndex = 6;
            txtVisaKategorier.Text = "";
            txtVisaKategorier.TextChanged += txtVisaKategorier_TextChanged;
            // 
            // cbNyttFlodeKategori
            // 
            cbNyttFlodeKategori.FormattingEnabled = true;
            cbNyttFlodeKategori.Items.AddRange(new object[] { "Skräck", "Komedi" });
            cbNyttFlodeKategori.Location = new Point(157, 307);
            cbNyttFlodeKategori.Margin = new Padding(5);
            cbNyttFlodeKategori.Name = "cbNyttFlodeKategori";
            cbNyttFlodeKategori.Size = new Size(289, 33);
            cbNyttFlodeKategori.TabIndex = 8;
            // 
            // lblSkapaNyttFlodeKategori
            // 
            lblSkapaNyttFlodeKategori.AutoSize = true;
            lblSkapaNyttFlodeKategori.Location = new Point(65, 310);
            lblSkapaNyttFlodeKategori.Margin = new Padding(5, 0, 5, 0);
            lblSkapaNyttFlodeKategori.Name = "lblSkapaNyttFlodeKategori";
            lblSkapaNyttFlodeKategori.Size = new Size(78, 25);
            lblSkapaNyttFlodeKategori.TabIndex = 11;
            lblSkapaNyttFlodeKategori.Text = "Kategori";
            // 
            // lblSkapaNyttFlode
            // 
            lblSkapaNyttFlode.AutoSize = true;
            lblSkapaNyttFlode.Font = new Font("Segoe UI", 11F);
            lblSkapaNyttFlode.Location = new Point(215, 155);
            lblSkapaNyttFlode.Margin = new Padding(5, 0, 5, 0);
            lblSkapaNyttFlode.Name = "lblSkapaNyttFlode";
            lblSkapaNyttFlode.Size = new Size(170, 30);
            lblSkapaNyttFlode.TabIndex = 12;
            lblSkapaNyttFlode.Text = "Skapa nytt flöde";
            lblSkapaNyttFlode.Click += label4_Click;
            // 
            // lblAvsnittLista
            // 
            lblAvsnittLista.AutoSize = true;
            lblAvsnittLista.Location = new Point(714, 151);
            lblAvsnittLista.Margin = new Padding(5, 0, 5, 0);
            lblAvsnittLista.Name = "lblAvsnittLista";
            lblAvsnittLista.Size = new Size(67, 25);
            lblAvsnittLista.TabIndex = 13;
            lblAvsnittLista.Text = "Avsnitt";
            lblAvsnittLista.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRedigeraFloden
            // 
            btnRedigeraFloden.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnRedigeraFloden.FlatStyle = FlatStyle.Flat;
            btnRedigeraFloden.Location = new Point(134, 790);
            btnRedigeraFloden.Margin = new Padding(5);
            btnRedigeraFloden.Name = "btnRedigeraFloden";
            btnRedigeraFloden.Size = new Size(158, 40);
            btnRedigeraFloden.TabIndex = 17;
            btnRedigeraFloden.Text = "Redigera";
            btnRedigeraFloden.UseVisualStyleBackColor = false;
            // 
            // btnRaderaFloden
            // 
            btnRaderaFloden.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnRaderaFloden.FlatStyle = FlatStyle.Flat;
            btnRaderaFloden.Location = new Point(318, 790);
            btnRaderaFloden.Margin = new Padding(5);
            btnRaderaFloden.Name = "btnRaderaFloden";
            btnRaderaFloden.Size = new Size(150, 40);
            btnRaderaFloden.TabIndex = 18;
            btnRaderaFloden.Text = "Radera";
            btnRaderaFloden.UseVisualStyleBackColor = false;
            btnRaderaFloden.Click += btnRaderaFloden_Click;
            // 
            // lblMinaKategorier
            // 
            lblMinaKategorier.AutoSize = true;
            lblMinaKategorier.Location = new Point(1187, 155);
            lblMinaKategorier.Margin = new Padding(5, 0, 5, 0);
            lblMinaKategorier.Name = "lblMinaKategorier";
            lblMinaKategorier.Size = new Size(136, 25);
            lblMinaKategorier.TabIndex = 19;
            lblMinaKategorier.Text = "Mina kategorier";
            lblMinaKategorier.Click += lblMinaKategorier_Click;
            // 
            // btnRaderaKategori
            // 
            btnRaderaKategori.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnRaderaKategori.FlatStyle = FlatStyle.Flat;
            btnRaderaKategori.Location = new Point(1359, 488);
            btnRaderaKategori.Margin = new Padding(2, 3, 2, 3);
            btnRaderaKategori.Name = "btnRaderaKategori";
            btnRaderaKategori.Size = new Size(109, 35);
            btnRaderaKategori.TabIndex = 20;
            btnRaderaKategori.Text = "Radera";
            btnRaderaKategori.UseVisualStyleBackColor = false;
            btnRaderaKategori.Click += btnRaderaKategori_Click;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnLaggTillKategori.FlatStyle = FlatStyle.Flat;
            btnLaggTillKategori.Location = new Point(1200, 677);
            btnLaggTillKategori.Margin = new Padding(5);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(112, 37);
            btnLaggTillKategori.TabIndex = 21;
            btnLaggTillKategori.Text = "Lägg till";
            btnLaggTillKategori.UseVisualStyleBackColor = false;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click;
            // 
            // txtLaggTillKategori
            // 
            txtLaggTillKategori.Location = new Point(1172, 624);
            txtLaggTillKategori.Margin = new Padding(5);
            txtLaggTillKategori.Name = "txtLaggTillKategori";
            txtLaggTillKategori.Size = new Size(166, 31);
            txtLaggTillKategori.TabIndex = 22;
            // 
            // lblLaggTillNyKategori
            // 
            lblLaggTillNyKategori.AutoSize = true;
            lblLaggTillNyKategori.Font = new Font("Segoe UI", 11F);
            lblLaggTillNyKategori.Location = new Point(1155, 564);
            lblLaggTillNyKategori.Margin = new Padding(5, 0, 5, 0);
            lblLaggTillNyKategori.Name = "lblLaggTillNyKategori";
            lblLaggTillNyKategori.Size = new Size(203, 30);
            lblLaggTillNyKategori.TabIndex = 23;
            lblLaggTillNyKategori.Text = "Lägg till ny kategori";
            lblLaggTillNyKategori.Click += lblLaggTillNyKategori_Click;
            // 
            // lblLaggTillNyKategoriTitel
            // 
            lblLaggTillNyKategoriTitel.AutoSize = true;
            lblLaggTillNyKategoriTitel.Location = new Point(1102, 627);
            lblLaggTillNyKategoriTitel.Margin = new Padding(5, 0, 5, 0);
            lblLaggTillNyKategoriTitel.Name = "lblLaggTillNyKategoriTitel";
            lblLaggTillNyKategoriTitel.Size = new Size(44, 25);
            lblLaggTillNyKategoriTitel.TabIndex = 24;
            lblLaggTillNyKategoriTitel.Text = "Titel";
            lblLaggTillNyKategoriTitel.Click += lblLaggTillNyKategoriTitel_Click;
            // 
            // lblLaggTillFlodeURL
            // 
            lblLaggTillFlodeURL.AutoSize = true;
            lblLaggTillFlodeURL.Location = new Point(100, 260);
            lblLaggTillFlodeURL.Margin = new Padding(5, 0, 5, 0);
            lblLaggTillFlodeURL.Name = "lblLaggTillFlodeURL";
            lblLaggTillFlodeURL.Size = new Size(43, 25);
            lblLaggTillFlodeURL.TabIndex = 25;
            lblLaggTillFlodeURL.Text = "URL";
            lblLaggTillFlodeURL.Click += label1_Click_1;
            // 
            // lblAvsnittBeskrivning
            // 
            lblAvsnittBeskrivning.AutoSize = true;
            lblAvsnittBeskrivning.Location = new Point(704, 519);
            lblAvsnittBeskrivning.Margin = new Padding(5, 0, 5, 0);
            lblAvsnittBeskrivning.Name = "lblAvsnittBeskrivning";
            lblAvsnittBeskrivning.Size = new Size(102, 25);
            lblAvsnittBeskrivning.TabIndex = 26;
            lblAvsnittBeskrivning.Text = "Beskrivning";
            lblAvsnittBeskrivning.Click += lblAvsnittBeskrivning_Click;
            // 
            // txtAvsnittBeskrivning
            // 
            txtAvsnittBeskrivning.Location = new Point(553, 564);
            txtAvsnittBeskrivning.Margin = new Padding(5);
            txtAvsnittBeskrivning.Name = "txtAvsnittBeskrivning";
            txtAvsnittBeskrivning.Size = new Size(412, 266);
            txtAvsnittBeskrivning.TabIndex = 27;
            txtAvsnittBeskrivning.Text = "";
            txtAvsnittBeskrivning.TextChanged += txtAvsnittBeskrivning_TextChanged;
            // 
            // txtVisaFloden
            // 
            txtVisaFloden.FormattingEnabled = true;
            txtVisaFloden.ItemHeight = 25;
            txtVisaFloden.Location = new Point(134, 429);
            txtVisaFloden.Margin = new Padding(5);
            txtVisaFloden.Name = "txtVisaFloden";
            txtVisaFloden.Size = new Size(334, 329);
            txtVisaFloden.TabIndex = 28;
            txtVisaFloden.SelectedIndexChanged += txtVisaFloden_SelectedIndexChanged;
            // 
            // txtVisaAvsnitt
            // 
            txtVisaAvsnitt.FormattingEnabled = true;
            txtVisaAvsnitt.ItemHeight = 25;
            txtVisaAvsnitt.Location = new Point(553, 204);
            txtVisaAvsnitt.Margin = new Padding(5);
            txtVisaAvsnitt.Name = "txtVisaAvsnitt";
            txtVisaAvsnitt.Size = new Size(412, 279);
            txtVisaAvsnitt.TabIndex = 29;
            txtVisaAvsnitt.SelectedIndexChanged += txtVisaAvsnitt_SelectedIndexChanged;
            // 
            // lblLaggTillFlodeNamn
            // 
            lblLaggTillFlodeNamn.AutoSize = true;
            lblLaggTillFlodeNamn.Location = new Point(83, 210);
            lblLaggTillFlodeNamn.Margin = new Padding(5, 0, 5, 0);
            lblLaggTillFlodeNamn.Name = "lblLaggTillFlodeNamn";
            lblLaggTillFlodeNamn.Size = new Size(60, 25);
            lblLaggTillFlodeNamn.TabIndex = 30;
            lblLaggTillFlodeNamn.Text = "Namn";
            lblLaggTillFlodeNamn.Click += lblPodcastNamn_Click;
            // 
            // txtNyttFlodeNamn
            // 
            txtNyttFlodeNamn.Location = new Point(157, 207);
            txtNyttFlodeNamn.Margin = new Padding(5);
            txtNyttFlodeNamn.Name = "txtNyttFlodeNamn";
            txtNyttFlodeNamn.PlaceholderText = "Creepypodden i P3";
            txtNyttFlodeNamn.Size = new Size(289, 31);
            txtNyttFlodeNamn.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1560, 889);
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
            Margin = new Padding(5);
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
