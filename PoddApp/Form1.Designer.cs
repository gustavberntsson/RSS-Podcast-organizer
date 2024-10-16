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
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(586, 41);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(66, 20);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Podcasts";
            lblHeader.Click += label1_Click;
            // 
            // btnNyttFlodeLaggTill
            // 
            btnNyttFlodeLaggTill.BackColor = SystemColors.GradientActiveCaption;
            btnNyttFlodeLaggTill.Location = new Point(363, 240);
            btnNyttFlodeLaggTill.Margin = new Padding(2, 3, 2, 3);
            btnNyttFlodeLaggTill.Name = "btnNyttFlodeLaggTill";
            btnNyttFlodeLaggTill.Size = new Size(89, 28);
            btnNyttFlodeLaggTill.TabIndex = 1;
            btnNyttFlodeLaggTill.Text = "Lägg till";
            btnNyttFlodeLaggTill.UseVisualStyleBackColor = false;
            btnNyttFlodeLaggTill.Click += button1_Click;
            // 
            // txtNyttFlodeURL
            // 
            txtNyttFlodeURL.Location = new Point(146, 206);
            txtNyttFlodeURL.Margin = new Padding(3, 4, 3, 4);
            txtNyttFlodeURL.Name = "txtNyttFlodeURL";
            txtNyttFlodeURL.PlaceholderText = "https://www.exempel.com/rss";
            txtNyttFlodeURL.Size = new Size(212, 27);
            txtNyttFlodeURL.TabIndex = 3;
            txtNyttFlodeURL.TextChanged += txtNyttFlodeURL_TextChanged;
            // 
            // txtVisaKategorier
            // 
            txtVisaKategorier.Location = new Point(1012, 284);
            txtVisaKategorier.Name = "txtVisaKategorier";
            txtVisaKategorier.Size = new Size(313, 157);
            txtVisaKategorier.TabIndex = 6;
            txtVisaKategorier.Text = "";
            // 
            // cbNyttFlodeKategori
            // 
            cbNyttFlodeKategori.FormattingEnabled = true;
            cbNyttFlodeKategori.Location = new Point(146, 240);
            cbNyttFlodeKategori.Name = "cbNyttFlodeKategori";
            cbNyttFlodeKategori.Size = new Size(212, 28);
            cbNyttFlodeKategori.TabIndex = 8;
            // 
            // lblSkapaNyttFlodeKategori
            // 
            lblSkapaNyttFlodeKategori.AutoSize = true;
            lblSkapaNyttFlodeKategori.Location = new Point(74, 244);
            lblSkapaNyttFlodeKategori.Name = "lblSkapaNyttFlodeKategori";
            lblSkapaNyttFlodeKategori.Size = new Size(66, 20);
            lblSkapaNyttFlodeKategori.TabIndex = 11;
            lblSkapaNyttFlodeKategori.Text = "Kategori";
            // 
            // lblSkapaNyttFlode
            // 
            lblSkapaNyttFlode.AutoSize = true;
            lblSkapaNyttFlode.Location = new Point(182, 164);
            lblSkapaNyttFlode.Name = "lblSkapaNyttFlode";
            lblSkapaNyttFlode.Size = new Size(117, 20);
            lblSkapaNyttFlode.TabIndex = 12;
            lblSkapaNyttFlode.Text = "Skapa nytt flöde";
            lblSkapaNyttFlode.Click += label4_Click;
            // 
            // lblAvsnittLista
            // 
            lblAvsnittLista.AutoSize = true;
            lblAvsnittLista.Location = new Point(627, 240);
            lblAvsnittLista.Name = "lblAvsnittLista";
            lblAvsnittLista.Size = new Size(54, 20);
            lblAvsnittLista.TabIndex = 13;
            lblAvsnittLista.Text = "Avsnitt";
            lblAvsnittLista.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRedigeraFloden
            // 
            btnRedigeraFloden.BackColor = SystemColors.GradientActiveCaption;
            btnRedigeraFloden.Location = new Point(56, 742);
            btnRedigeraFloden.Margin = new Padding(2, 3, 2, 3);
            btnRedigeraFloden.Name = "btnRedigeraFloden";
            btnRedigeraFloden.Size = new Size(179, 28);
            btnRedigeraFloden.TabIndex = 17;
            btnRedigeraFloden.Text = "Redigera";
            btnRedigeraFloden.UseVisualStyleBackColor = false;
            // 
            // btnRaderaFloden
            // 
            btnRaderaFloden.BackColor = SystemColors.GradientActiveCaption;
            btnRaderaFloden.Location = new Point(266, 742);
            btnRaderaFloden.Margin = new Padding(2, 3, 2, 3);
            btnRaderaFloden.Name = "btnRaderaFloden";
            btnRaderaFloden.Size = new Size(172, 28);
            btnRaderaFloden.TabIndex = 18;
            btnRaderaFloden.Text = "Radera";
            btnRaderaFloden.UseVisualStyleBackColor = false;
            // 
            // lblMinaKategorier
            // 
            lblMinaKategorier.AutoSize = true;
            lblMinaKategorier.Location = new Point(1109, 213);
            lblMinaKategorier.Name = "lblMinaKategorier";
            lblMinaKategorier.Size = new Size(114, 20);
            lblMinaKategorier.TabIndex = 19;
            lblMinaKategorier.Text = "Mina kategorier";
            // 
            // btnRaderaKategori
            // 
            btnRaderaKategori.BackColor = SystemColors.GradientActiveCaption;
            btnRaderaKategori.Location = new Point(1203, 447);
            btnRaderaKategori.Margin = new Padding(2, 3, 2, 3);
            btnRaderaKategori.Name = "btnRaderaKategori";
            btnRaderaKategori.Size = new Size(122, 28);
            btnRaderaKategori.TabIndex = 20;
            btnRaderaKategori.Text = "Radera";
            btnRaderaKategori.UseVisualStyleBackColor = false;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.BackColor = SystemColors.GradientActiveCaption;
            btnLaggTillKategori.Location = new Point(1220, 526);
            btnLaggTillKategori.Margin = new Padding(2, 3, 2, 3);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(105, 28);
            btnLaggTillKategori.TabIndex = 21;
            btnLaggTillKategori.Text = "Lägg till";
            btnLaggTillKategori.UseVisualStyleBackColor = false;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click;
            // 
            // txtLaggTillKategori
            // 
            txtLaggTillKategori.Location = new Point(1071, 527);
            txtLaggTillKategori.Margin = new Padding(3, 4, 3, 4);
            txtLaggTillKategori.Name = "txtLaggTillKategori";
            txtLaggTillKategori.Size = new Size(138, 27);
            txtLaggTillKategori.TabIndex = 22;
            // 
            // lblLaggTillNyKategori
            // 
            lblLaggTillNyKategori.AutoSize = true;
            lblLaggTillNyKategori.Location = new Point(1098, 488);
            lblLaggTillNyKategori.Name = "lblLaggTillNyKategori";
            lblLaggTillNyKategori.Size = new Size(141, 20);
            lblLaggTillNyKategori.TabIndex = 23;
            lblLaggTillNyKategori.Text = "Lägg till ny kategori";
            // 
            // lblLaggTillNyKategoriTitel
            // 
            lblLaggTillNyKategoriTitel.AutoSize = true;
            lblLaggTillNyKategoriTitel.Location = new Point(1012, 530);
            lblLaggTillNyKategoriTitel.Name = "lblLaggTillNyKategoriTitel";
            lblLaggTillNyKategoriTitel.Size = new Size(38, 20);
            lblLaggTillNyKategoriTitel.TabIndex = 24;
            lblLaggTillNyKategoriTitel.Text = "Titel";
            // 
            // lblLaggTillFlodeURL
            // 
            lblLaggTillFlodeURL.AutoSize = true;
            lblLaggTillFlodeURL.Location = new Point(105, 209);
            lblLaggTillFlodeURL.Name = "lblLaggTillFlodeURL";
            lblLaggTillFlodeURL.Size = new Size(35, 20);
            lblLaggTillFlodeURL.TabIndex = 25;
            lblLaggTillFlodeURL.Text = "URL";
            lblLaggTillFlodeURL.Click += label1_Click_1;
            // 
            // lblAvsnittBeskrivning
            // 
            lblAvsnittBeskrivning.AutoSize = true;
            lblAvsnittBeskrivning.Location = new Point(646, 558);
            lblAvsnittBeskrivning.Name = "lblAvsnittBeskrivning";
            lblAvsnittBeskrivning.Size = new Size(84, 20);
            lblAvsnittBeskrivning.TabIndex = 26;
            lblAvsnittBeskrivning.Text = "Beskrivning";
            lblAvsnittBeskrivning.TextAlign = ContentAlignment.MiddleCenter;
            lblAvsnittBeskrivning.Click += lblAvsnittBeskrivning_Click;
            // 
            // txtAvsnittBeskrivning
            // 
            txtAvsnittBeskrivning.Location = new Point(505, 590);
            txtAvsnittBeskrivning.Name = "txtAvsnittBeskrivning";
            txtAvsnittBeskrivning.Size = new Size(361, 157);
            txtAvsnittBeskrivning.TabIndex = 27;
            txtAvsnittBeskrivning.Text = "";
            // 
            // txtVisaFloden
            // 
            txtVisaFloden.FormattingEnabled = true;
            txtVisaFloden.Location = new Point(105, 297);
            txtVisaFloden.Name = "txtVisaFloden";
            txtVisaFloden.Size = new Size(293, 324);
            txtVisaFloden.TabIndex = 28;
            // 
            // txtVisaAvsnitt
            // 
            txtVisaAvsnitt.FormattingEnabled = true;
            txtVisaAvsnitt.Location = new Point(505, 294);
            txtVisaAvsnitt.Name = "txtVisaAvsnitt";
            txtVisaAvsnitt.Size = new Size(361, 244);
            txtVisaAvsnitt.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 782);
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
            Margin = new Padding(3, 4, 3, 4);
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
    }
}
