﻿namespace PoddApp
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
            cbRedigeraKategori.Location = new Point(164, 88);
            cbRedigeraKategori.Name = "cbRedigeraKategori";
            cbRedigeraKategori.Size = new Size(151, 28);
            cbRedigeraKategori.TabIndex = 0;
            cbRedigeraKategori.SelectedIndexChanged += cbRedigeraKategori_SelectedIndexChanged;
            // 
            // btnAvbrytKategoriAndring
            // 
            btnAvbrytKategoriAndring.BackColor = Color.GhostWhite;
            btnAvbrytKategoriAndring.Cursor = Cursors.Hand;
            btnAvbrytKategoriAndring.Location = new Point(221, 216);
            btnAvbrytKategoriAndring.Name = "btnAvbrytKategoriAndring";
            btnAvbrytKategoriAndring.Size = new Size(94, 29);
            btnAvbrytKategoriAndring.TabIndex = 2;
            btnAvbrytKategoriAndring.Text = "Avbryt";
            btnAvbrytKategoriAndring.UseVisualStyleBackColor = false;
            btnAvbrytKategoriAndring.Click += btnAvbrytKategoriAndring_Click;
            // 
            // txtRedigeraKategori
            // 
            txtRedigeraKategori.Cursor = Cursors.IBeam;
            txtRedigeraKategori.Location = new Point(164, 150);
            txtRedigeraKategori.Name = "txtRedigeraKategori";
            txtRedigeraKategori.Size = new Size(151, 27);
            txtRedigeraKategori.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 150);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 4;
            label2.Text = "Nytt namn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 91);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 5;
            label3.Text = "Kategori att ändra";
            // 
            // btnSparaKategoriAndring
            // 
            btnSparaKategoriAndring.BackColor = Color.GhostWhite;
            btnSparaKategoriAndring.Cursor = Cursors.Hand;
            btnSparaKategoriAndring.Location = new Point(100, 216);
            btnSparaKategoriAndring.Name = "btnSparaKategoriAndring";
            btnSparaKategoriAndring.Size = new Size(94, 29);
            btnSparaKategoriAndring.TabIndex = 6;
            btnSparaKategoriAndring.Text = "Spara";
            btnSparaKategoriAndring.UseVisualStyleBackColor = false;
            btnSparaKategoriAndring.Click += btnSparaKategoriAndring_Click;
            // 
            // RedigeraKategori
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 383);
            Controls.Add(btnSparaKategoriAndring);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRedigeraKategori);
            Controls.Add(btnAvbrytKategoriAndring);
            Controls.Add(cbRedigeraKategori);
            Name = "RedigeraKategori";
            Text = "Redigera kategori";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbRedigeraKategori;
        private Button btnAvbrytKategoriAndring;
        private TextBox txtRedigeraKategori;
        private Label label2;
        private Label label3;
        private Button btnSparaKategoriAndring;
    }
}