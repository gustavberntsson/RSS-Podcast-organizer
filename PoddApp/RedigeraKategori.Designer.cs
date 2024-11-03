namespace PoddApp
{
    partial class RedigeraKategori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbRedigeraKategori = new ComboBox();
            label1 = new Label();
            btnAvbrytKategoriAndring = new Button();
            txtRedigeraKategori = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnSparaKategoriAndring = new Button();
            SuspendLayout();
            // 
            // cbRedigeraKategori
            // 
            cbRedigeraKategori.Cursor = Cursors.Hand;
            cbRedigeraKategori.FormattingEnabled = true;
            cbRedigeraKategori.Location = new Point(163, 112);
            cbRedigeraKategori.Margin = new Padding(3, 2, 3, 2);
            cbRedigeraKategori.Name = "cbRedigeraKategori";
            cbRedigeraKategori.Size = new Size(133, 23);
            cbRedigeraKategori.TabIndex = 0;
            cbRedigeraKategori.SelectedIndexChanged += cbRedigeraKategori_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 61);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Redigera kategori";
            // 
            // btnAvbrytKategoriAndring
            // 
            btnAvbrytKategoriAndring.BackColor = SystemColors.ButtonHighlight;
            btnAvbrytKategoriAndring.Cursor = Cursors.Hand;
            btnAvbrytKategoriAndring.Location = new Point(237, 220);
            btnAvbrytKategoriAndring.Margin = new Padding(3, 2, 3, 2);
            btnAvbrytKategoriAndring.Name = "btnAvbrytKategoriAndring";
            btnAvbrytKategoriAndring.Size = new Size(82, 22);
            btnAvbrytKategoriAndring.TabIndex = 2;
            btnAvbrytKategoriAndring.Text = "Avbryt";
            btnAvbrytKategoriAndring.UseVisualStyleBackColor = false;
            btnAvbrytKategoriAndring.Click += btnAvbrytKategoriAndring_Click;
            // 
            // txtRedigeraKategori
            // 
            txtRedigeraKategori.Cursor = Cursors.IBeam;
            txtRedigeraKategori.Location = new Point(163, 158);
            txtRedigeraKategori.Margin = new Padding(3, 2, 3, 2);
            txtRedigeraKategori.Name = "txtRedigeraKategori";
            txtRedigeraKategori.Size = new Size(133, 23);
            txtRedigeraKategori.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 158);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 4;
            label2.Text = "Nytt namn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 114);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 5;
            label3.Text = "Kategori att ändra";
            // 
            // btnSparaKategoriAndring
            // 
            btnSparaKategoriAndring.BackColor = SystemColors.ButtonHighlight;
            btnSparaKategoriAndring.Cursor = Cursors.Hand;
            btnSparaKategoriAndring.Location = new Point(131, 220);
            btnSparaKategoriAndring.Margin = new Padding(3, 2, 3, 2);
            btnSparaKategoriAndring.Name = "btnSparaKategoriAndring";
            btnSparaKategoriAndring.Size = new Size(82, 22);
            btnSparaKategoriAndring.TabIndex = 6;
            btnSparaKategoriAndring.Text = "Spara";
            btnSparaKategoriAndring.UseVisualStyleBackColor = false;
            btnSparaKategoriAndring.Click += btnSparaKategoriAndring_Click;
            // 
            // RedigeraKategori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 338);
            Controls.Add(btnSparaKategoriAndring);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRedigeraKategori);
            Controls.Add(btnAvbrytKategoriAndring);
            Controls.Add(label1);
            Controls.Add(cbRedigeraKategori);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RedigeraKategori";
            Text = "Redigera kategori";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbRedigeraKategori;
        private Label label1;
        private Button btnAvbrytKategoriAndring;
        private TextBox txtRedigeraKategori;
        private Label label2;
        private Label label3;
        private Button btnSparaKategoriAndring;
    }
}