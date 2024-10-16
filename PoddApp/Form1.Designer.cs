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
            richTextBox1 = new RichTextBox();
            txtVisaKategorier = new RichTextBox();
            cbNyttFlodeKategori = new ComboBox();
            txtNyttFlodeNamn = new TextBox();
            lblSkapaNyttFlodeNamn = new Label();
            lblSkapaNyttFlodeKategori = new Label();
            lblSkapaNyttFlode = new Label();
            lblMinaFloden = new Label();
            txtMinaFloden = new RichTextBox();
            cbMinaFloden = new ComboBox();
            btnVisaFloden = new Button();
            btnRedigeraFloden = new Button();
            btnRaderaFloden = new Button();
            lblMinaKategorier = new Label();
            btnRaderaKategori = new Button();
            btnLaggTillKategori = new Button();
            txtLaggTillKategori = new TextBox();
            lblLaggTillNyKategori = new Label();
            lblLaggTillNyKategoriTitel = new Label();
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
            txtNyttFlodeURL.Location = new Point(56, 240);
            txtNyttFlodeURL.Margin = new Padding(3, 4, 3, 4);
            txtNyttFlodeURL.Name = "txtNyttFlodeURL";
            txtNyttFlodeURL.Size = new Size(302, 27);
            txtNyttFlodeURL.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(56, 284);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(396, 486);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
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
            cbNyttFlodeKategori.Location = new Point(146, 205);
            cbNyttFlodeKategori.Name = "cbNyttFlodeKategori";
            cbNyttFlodeKategori.Size = new Size(212, 28);
            cbNyttFlodeKategori.TabIndex = 8;
            // 
            // txtNyttFlodeNamn
            // 
            txtNyttFlodeNamn.Location = new Point(146, 160);
            txtNyttFlodeNamn.Name = "txtNyttFlodeNamn";
            txtNyttFlodeNamn.Size = new Size(212, 27);
            txtNyttFlodeNamn.TabIndex = 9;
            // 
            // lblSkapaNyttFlodeNamn
            // 
            lblSkapaNyttFlodeNamn.AutoSize = true;
            lblSkapaNyttFlodeNamn.Location = new Point(91, 163);
            lblSkapaNyttFlodeNamn.Name = "lblSkapaNyttFlodeNamn";
            lblSkapaNyttFlodeNamn.Size = new Size(49, 20);
            lblSkapaNyttFlodeNamn.TabIndex = 10;
            lblSkapaNyttFlodeNamn.Text = "Namn";
            lblSkapaNyttFlodeNamn.Click += label2_Click_1;
            // 
            // lblSkapaNyttFlodeKategori
            // 
            lblSkapaNyttFlodeKategori.AutoSize = true;
            lblSkapaNyttFlodeKategori.Location = new Point(74, 208);
            lblSkapaNyttFlodeKategori.Name = "lblSkapaNyttFlodeKategori";
            lblSkapaNyttFlodeKategori.Size = new Size(66, 20);
            lblSkapaNyttFlodeKategori.TabIndex = 11;
            lblSkapaNyttFlodeKategori.Text = "Kategori";
            // 
            // lblSkapaNyttFlode
            // 
            lblSkapaNyttFlode.AutoSize = true;
            lblSkapaNyttFlode.Location = new Point(172, 112);
            lblSkapaNyttFlode.Name = "lblSkapaNyttFlode";
            lblSkapaNyttFlode.Size = new Size(117, 20);
            lblSkapaNyttFlode.TabIndex = 12;
            lblSkapaNyttFlode.Text = "Skapa nytt flöde";
            lblSkapaNyttFlode.Click += label4_Click;
            // 
            // lblMinaFloden
            // 
            lblMinaFloden.AutoSize = true;
            lblMinaFloden.Location = new Point(633, 205);
            lblMinaFloden.Name = "lblMinaFloden";
            lblMinaFloden.Size = new Size(89, 20);
            lblMinaFloden.TabIndex = 13;
            lblMinaFloden.Text = "Mina flöden";
            // 
            // txtMinaFloden
            // 
            txtMinaFloden.Location = new Point(484, 284);
            txtMinaFloden.Name = "txtMinaFloden";
            txtMinaFloden.Size = new Size(382, 442);
            txtMinaFloden.TabIndex = 14;
            txtMinaFloden.Text = "";
            // 
            // cbMinaFloden
            // 
            cbMinaFloden.FormattingEnabled = true;
            cbMinaFloden.Location = new Point(484, 242);
            cbMinaFloden.Name = "cbMinaFloden";
            cbMinaFloden.Size = new Size(279, 28);
            cbMinaFloden.TabIndex = 15;
            // 
            // btnVisaFloden
            // 
            btnVisaFloden.BackColor = SystemColors.GradientActiveCaption;
            btnVisaFloden.Location = new Point(777, 241);
            btnVisaFloden.Margin = new Padding(2, 3, 2, 3);
            btnVisaFloden.Name = "btnVisaFloden";
            btnVisaFloden.Size = new Size(89, 28);
            btnVisaFloden.TabIndex = 16;
            btnVisaFloden.Text = "Visa";
            btnVisaFloden.UseVisualStyleBackColor = false;
            // 
            // btnRedigeraFloden
            // 
            btnRedigeraFloden.BackColor = SystemColors.GradientActiveCaption;
            btnRedigeraFloden.Location = new Point(484, 742);
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
            btnRaderaFloden.Location = new Point(694, 742);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 782);
            Controls.Add(lblLaggTillNyKategoriTitel);
            Controls.Add(lblLaggTillNyKategori);
            Controls.Add(txtLaggTillKategori);
            Controls.Add(btnLaggTillKategori);
            Controls.Add(btnRaderaKategori);
            Controls.Add(lblMinaKategorier);
            Controls.Add(btnRaderaFloden);
            Controls.Add(btnRedigeraFloden);
            Controls.Add(btnVisaFloden);
            Controls.Add(cbMinaFloden);
            Controls.Add(txtMinaFloden);
            Controls.Add(lblMinaFloden);
            Controls.Add(lblSkapaNyttFlode);
            Controls.Add(lblSkapaNyttFlodeKategori);
            Controls.Add(lblSkapaNyttFlodeNamn);
            Controls.Add(txtNyttFlodeNamn);
            Controls.Add(cbNyttFlodeKategori);
            Controls.Add(txtVisaKategorier);
            Controls.Add(richTextBox1);
            Controls.Add(txtNyttFlodeURL);
            Controls.Add(btnNyttFlodeLaggTill);
            Controls.Add(lblHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnNyttFlodeLaggTill;
        private TextBox txtNyttFlodeURL;
        private RichTextBox richTextBox1;
        private RichTextBox txtVisaKategorier;
        private ComboBox cbNyttFlodeKategori;
        private TextBox txtNyttFlodeNamn;
        private Label lblSkapaNyttFlodeNamn;
        private Label lblSkapaNyttFlodeKategori;
        private Label lblSkapaNyttFlode;
        private Label lblMinaFloden;
        private RichTextBox txtMinaFloden;
        private ComboBox cbMinaFloden;
        private Button btnVisaFloden;
        private Button btnRedigeraFloden;
        private Button btnRaderaFloden;
        private Label lblMinaKategorier;
        private Button btnRaderaKategori;
        private Button btnLaggTillKategori;
        private TextBox txtLaggTillKategori;
        private Label lblLaggTillNyKategori;
        private Label lblLaggTillNyKategoriTitel;
    }
}
