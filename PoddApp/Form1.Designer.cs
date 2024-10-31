namespace PoddApp
{
    //Partial class = kan vara uppdelad i flera filer.
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

        //Städar upp resurser när formuläret inte längre behövs.
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
            txtVisaKategorier = new ListBox();
            label1 = new Label();
            rbNamn = new RadioButton();
            rbKategori = new RadioButton();
            btnRedigeraKategori = new Button();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 24F);
            lblHeader.ForeColor = Color.DimGray;
            lblHeader.Location = new Point(517, 23);
            lblHeader.Margin = new Padding(5, 0, 5, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(177, 54);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Podcasts";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNyttFlodeLaggTill
            // 
            btnNyttFlodeLaggTill.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnNyttFlodeLaggTill.Cursor = Cursors.Hand;
            btnNyttFlodeLaggTill.FlatStyle = FlatStyle.Flat;
            btnNyttFlodeLaggTill.Location = new Point(255, 283);
            btnNyttFlodeLaggTill.Margin = new Padding(5, 4, 5, 4);
            btnNyttFlodeLaggTill.Name = "btnNyttFlodeLaggTill";
            btnNyttFlodeLaggTill.Size = new Size(120, 32);
            btnNyttFlodeLaggTill.TabIndex = 1;
            btnNyttFlodeLaggTill.Text = "Lägg till";
            btnNyttFlodeLaggTill.UseVisualStyleBackColor = false;
            btnNyttFlodeLaggTill.Click += btnNyttFlodeLaggTill_Click;
            // 
            // txtNyttFlodeURL
            // 
            txtNyttFlodeURL.Location = new Point(126, 205);
            txtNyttFlodeURL.Margin = new Padding(5, 4, 5, 4);
            txtNyttFlodeURL.Name = "txtNyttFlodeURL";
            txtNyttFlodeURL.PlaceholderText = "https://www.exempel.com/rss";
            txtNyttFlodeURL.Size = new Size(249, 27);
            txtNyttFlodeURL.TabIndex = 3;
            // 
            // cbNyttFlodeKategori
            // 
            cbNyttFlodeKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNyttFlodeKategori.FormattingEnabled = true;
            cbNyttFlodeKategori.Location = new Point(126, 245);
            cbNyttFlodeKategori.Margin = new Padding(5, 4, 5, 4);
            cbNyttFlodeKategori.Name = "cbNyttFlodeKategori";
            cbNyttFlodeKategori.Size = new Size(249, 28);
            cbNyttFlodeKategori.TabIndex = 8;
            // 
            // lblSkapaNyttFlodeKategori
            // 
            lblSkapaNyttFlodeKategori.AutoSize = true;
            lblSkapaNyttFlodeKategori.Location = new Point(53, 248);
            lblSkapaNyttFlodeKategori.Margin = new Padding(5, 0, 5, 0);
            lblSkapaNyttFlodeKategori.Name = "lblSkapaNyttFlodeKategori";
            lblSkapaNyttFlodeKategori.Size = new Size(66, 20);
            lblSkapaNyttFlodeKategori.TabIndex = 11;
            lblSkapaNyttFlodeKategori.Text = "Kategori";
            // 
            // lblSkapaNyttFlode
            // 
            lblSkapaNyttFlode.AutoSize = true;
            lblSkapaNyttFlode.Font = new Font("Arial Rounded MT Bold", 12F);
            lblSkapaNyttFlode.ForeColor = Color.DarkSlateBlue;
            lblSkapaNyttFlode.Location = new Point(171, 113);
            lblSkapaNyttFlode.Margin = new Padding(5, 0, 5, 0);
            lblSkapaNyttFlode.Name = "lblSkapaNyttFlode";
            lblSkapaNyttFlode.Size = new Size(167, 23);
            lblSkapaNyttFlode.TabIndex = 12;
            lblSkapaNyttFlode.Text = "Skapa nytt flöde";
            // 
            // lblAvsnittLista
            // 
            lblAvsnittLista.AutoSize = true;
            lblAvsnittLista.Font = new Font("Arial Rounded MT Bold", 12F);
            lblAvsnittLista.ForeColor = Color.DarkSlateBlue;
            lblAvsnittLista.Location = new Point(562, 113);
            lblAvsnittLista.Margin = new Padding(5, 0, 5, 0);
            lblAvsnittLista.Name = "lblAvsnittLista";
            lblAvsnittLista.Size = new Size(77, 23);
            lblAvsnittLista.TabIndex = 13;
            lblAvsnittLista.Text = "Avsnitt";
            lblAvsnittLista.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRedigeraFloden
            // 
            btnRedigeraFloden.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnRedigeraFloden.Cursor = Cursors.Hand;
            btnRedigeraFloden.FlatStyle = FlatStyle.Flat;
            btnRedigeraFloden.Location = new Point(107, 632);
            btnRedigeraFloden.Margin = new Padding(5, 4, 5, 4);
            btnRedigeraFloden.Name = "btnRedigeraFloden";
            btnRedigeraFloden.Size = new Size(120, 32);
            btnRedigeraFloden.TabIndex = 17;
            btnRedigeraFloden.Text = "Redigera";
            btnRedigeraFloden.UseVisualStyleBackColor = false;
            btnRedigeraFloden.Click += btnRedigeraFloden_Click;
            // 
            // btnRaderaFloden
            // 
            btnRaderaFloden.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnRaderaFloden.Cursor = Cursors.Hand;
            btnRaderaFloden.FlatStyle = FlatStyle.Flat;
            btnRaderaFloden.Location = new Point(255, 632);
            btnRaderaFloden.Margin = new Padding(5, 4, 5, 4);
            btnRaderaFloden.Name = "btnRaderaFloden";
            btnRaderaFloden.Size = new Size(120, 32);
            btnRaderaFloden.TabIndex = 18;
            btnRaderaFloden.Text = "Radera";
            btnRaderaFloden.UseVisualStyleBackColor = false;
            btnRaderaFloden.Click += btnRaderaFloden_Click;
            // 
            // lblMinaKategorier
            // 
            lblMinaKategorier.AutoSize = true;
            lblMinaKategorier.Font = new Font("Arial Rounded MT Bold", 12F);
            lblMinaKategorier.ForeColor = Color.DarkSlateBlue;
            lblMinaKategorier.Location = new Point(923, 113);
            lblMinaKategorier.Margin = new Padding(5, 0, 5, 0);
            lblMinaKategorier.Name = "lblMinaKategorier";
            lblMinaKategorier.Size = new Size(163, 23);
            lblMinaKategorier.TabIndex = 19;
            lblMinaKategorier.Text = "Mina kategorier";
            // 
            // btnRaderaKategori
            // 
            btnRaderaKategori.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnRaderaKategori.Cursor = Cursors.Hand;
            btnRaderaKategori.FlatStyle = FlatStyle.Flat;
            btnRaderaKategori.Location = new Point(1053, 403);
            btnRaderaKategori.Margin = new Padding(1, 3, 1, 3);
            btnRaderaKategori.Name = "btnRaderaKategori";
            btnRaderaKategori.Size = new Size(120, 32);
            btnRaderaKategori.TabIndex = 20;
            btnRaderaKategori.Text = "Radera";
            btnRaderaKategori.UseVisualStyleBackColor = false;
            btnRaderaKategori.Click += btnRaderaKategori_Click;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnLaggTillKategori.Cursor = Cursors.Hand;
            btnLaggTillKategori.FlatStyle = FlatStyle.Flat;
            btnLaggTillKategori.Location = new Point(1094, 537);
            btnLaggTillKategori.Margin = new Padding(5, 4, 5, 4);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(120, 32);
            btnLaggTillKategori.TabIndex = 21;
            btnLaggTillKategori.Text = "Lägg till";
            btnLaggTillKategori.UseVisualStyleBackColor = false;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click;
            // 
            // txtLaggTillKategori
            // 
            txtLaggTillKategori.Location = new Point(937, 540);
            txtLaggTillKategori.Margin = new Padding(5, 4, 5, 4);
            txtLaggTillKategori.Name = "txtLaggTillKategori";
            txtLaggTillKategori.Size = new Size(133, 27);
            txtLaggTillKategori.TabIndex = 22;
            // 
            // lblLaggTillNyKategori
            // 
            lblLaggTillNyKategori.AutoSize = true;
            lblLaggTillNyKategori.Font = new Font("Arial Rounded MT Bold", 12F);
            lblLaggTillNyKategori.ForeColor = Color.DarkSlateBlue;
            lblLaggTillNyKategori.Location = new Point(923, 492);
            lblLaggTillNyKategori.Margin = new Padding(5, 0, 5, 0);
            lblLaggTillNyKategori.Name = "lblLaggTillNyKategori";
            lblLaggTillNyKategori.Size = new Size(201, 23);
            lblLaggTillNyKategori.TabIndex = 23;
            lblLaggTillNyKategori.Text = "Lägg till ny kategori";
            // 
            // lblLaggTillNyKategoriTitel
            // 
            lblLaggTillNyKategoriTitel.AutoSize = true;
            lblLaggTillNyKategoriTitel.Location = new Point(881, 542);
            lblLaggTillNyKategoriTitel.Margin = new Padding(5, 0, 5, 0);
            lblLaggTillNyKategoriTitel.Name = "lblLaggTillNyKategoriTitel";
            lblLaggTillNyKategoriTitel.Size = new Size(38, 20);
            lblLaggTillNyKategoriTitel.TabIndex = 24;
            lblLaggTillNyKategoriTitel.Text = "Titel";
            // 
            // lblLaggTillFlodeURL
            // 
            lblLaggTillFlodeURL.AutoSize = true;
            lblLaggTillFlodeURL.Location = new Point(80, 208);
            lblLaggTillFlodeURL.Margin = new Padding(5, 0, 5, 0);
            lblLaggTillFlodeURL.Name = "lblLaggTillFlodeURL";
            lblLaggTillFlodeURL.Size = new Size(35, 20);
            lblLaggTillFlodeURL.TabIndex = 25;
            lblLaggTillFlodeURL.Text = "URL";
            // 
            // lblAvsnittBeskrivning
            // 
            lblAvsnittBeskrivning.AutoSize = true;
            lblAvsnittBeskrivning.Font = new Font("Arial Rounded MT Bold", 12F);
            lblAvsnittBeskrivning.ForeColor = Color.DarkSlateBlue;
            lblAvsnittBeskrivning.Location = new Point(553, 408);
            lblAvsnittBeskrivning.Margin = new Padding(5, 0, 5, 0);
            lblAvsnittBeskrivning.Name = "lblAvsnittBeskrivning";
            lblAvsnittBeskrivning.Size = new Size(125, 23);
            lblAvsnittBeskrivning.TabIndex = 26;
            lblAvsnittBeskrivning.Text = "Beskrivning";
            // 
            // txtAvsnittBeskrivning
            // 
            txtAvsnittBeskrivning.Location = new Point(442, 451);
            txtAvsnittBeskrivning.Margin = new Padding(5, 4, 5, 4);
            txtAvsnittBeskrivning.Name = "txtAvsnittBeskrivning";
            txtAvsnittBeskrivning.ReadOnly = true;
            txtAvsnittBeskrivning.Size = new Size(331, 213);
            txtAvsnittBeskrivning.TabIndex = 27;
            txtAvsnittBeskrivning.Text = "";
            // 
            // txtVisaFloden
            // 
            txtVisaFloden.FormattingEnabled = true;
            txtVisaFloden.Location = new Point(107, 323);
            txtVisaFloden.Margin = new Padding(5, 4, 5, 4);
            txtVisaFloden.Name = "txtVisaFloden";
            txtVisaFloden.Size = new Size(268, 284);
            txtVisaFloden.TabIndex = 28;
            txtVisaFloden.SelectedIndexChanged += txtVisaFloden_SelectedIndexChanged;
            // 
            // txtVisaAvsnitt
            // 
            txtVisaAvsnitt.FormattingEnabled = true;
            txtVisaAvsnitt.Location = new Point(442, 163);
            txtVisaAvsnitt.Margin = new Padding(5, 4, 5, 4);
            txtVisaAvsnitt.Name = "txtVisaAvsnitt";
            txtVisaAvsnitt.Size = new Size(331, 224);
            txtVisaAvsnitt.TabIndex = 29;
            txtVisaAvsnitt.SelectedIndexChanged += txtVisaAvsnitt_SelectedIndexChanged;
            // 
            // lblLaggTillFlodeNamn
            // 
            lblLaggTillFlodeNamn.AutoSize = true;
            lblLaggTillFlodeNamn.Location = new Point(66, 168);
            lblLaggTillFlodeNamn.Margin = new Padding(5, 0, 5, 0);
            lblLaggTillFlodeNamn.Name = "lblLaggTillFlodeNamn";
            lblLaggTillFlodeNamn.Size = new Size(49, 20);
            lblLaggTillFlodeNamn.TabIndex = 30;
            lblLaggTillFlodeNamn.Text = "Namn";
            // 
            // txtNyttFlodeNamn
            // 
            txtNyttFlodeNamn.Location = new Point(126, 165);
            txtNyttFlodeNamn.Margin = new Padding(5, 4, 5, 4);
            txtNyttFlodeNamn.Name = "txtNyttFlodeNamn";
            txtNyttFlodeNamn.Size = new Size(249, 27);
            txtNyttFlodeNamn.TabIndex = 31;
            // 
            // txtVisaKategorier
            // 
            txtVisaKategorier.FormattingEnabled = true;
            txtVisaKategorier.Location = new Point(833, 163);
            txtVisaKategorier.Margin = new Padding(3, 4, 3, 4);
            txtVisaKategorier.Name = "txtVisaKategorier";
            txtVisaKategorier.Size = new Size(340, 224);
            txtVisaKategorier.TabIndex = 32;
            txtVisaKategorier.SelectedIndexChanged += txtVisaKategorier_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 415);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(60, 20);
            label1.TabIndex = 33;
            label1.Text = "Sortera:";
            label1.Click += label1_Click;
            // 
            // rbNamn
            // 
            rbNamn.AutoSize = true;
            rbNamn.Location = new Point(12, 439);
            rbNamn.Margin = new Padding(3, 4, 3, 4);
            rbNamn.Name = "rbNamn";
            rbNamn.Size = new Size(70, 24);
            rbNamn.TabIndex = 34;
            rbNamn.TabStop = true;
            rbNamn.Text = "Namn";
            rbNamn.UseVisualStyleBackColor = true;
            rbNamn.CheckedChanged += rbNamn_CheckedChanged;
            // 
            // rbKategori
            // 
            rbKategori.AutoSize = true;
            rbKategori.Location = new Point(12, 471);
            rbKategori.Margin = new Padding(3, 4, 3, 4);
            rbKategori.Name = "rbKategori";
            rbKategori.Size = new Size(87, 24);
            rbKategori.TabIndex = 35;
            rbKategori.TabStop = true;
            rbKategori.Text = "Kategori";
            rbKategori.UseVisualStyleBackColor = true;
            rbKategori.CheckedChanged += rbKategori_CheckedChanged;
            // 
            // btnRedigeraKategori
            // 
            btnRedigeraKategori.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnRedigeraKategori.Cursor = Cursors.Hand;
            btnRedigeraKategori.FlatStyle = FlatStyle.Flat;
            btnRedigeraKategori.Location = new Point(833, 403);
            btnRedigeraKategori.Margin = new Padding(1, 3, 1, 3);
            btnRedigeraKategori.Name = "btnRedigeraKategori";
            btnRedigeraKategori.Size = new Size(120, 32);
            btnRedigeraKategori.TabIndex = 36;
            btnRedigeraKategori.Text = "Redigera";
            btnRedigeraKategori.UseVisualStyleBackColor = false;
            btnRedigeraKategori.Click += btnRedigeraKategori_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1248, 705);
            Controls.Add(btnRedigeraKategori);
            Controls.Add(rbKategori);
            Controls.Add(rbNamn);
            Controls.Add(label1);
            Controls.Add(txtVisaKategorier);
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
            Controls.Add(txtNyttFlodeURL);
            Controls.Add(btnNyttFlodeLaggTill);
            Controls.Add(lblHeader);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lblHeader;
        private Button btnNyttFlodeLaggTill;
        private TextBox txtNyttFlodeURL;
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
        private ListBox txtVisaKategorier;
        private Label label1;
        private RadioButton rbNamn;
        private RadioButton rbKategori;
        private Button btnRedigeraKategori;
    }
}
