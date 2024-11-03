namespace PoddApp
{
    partial class RedigeraEgenskaper
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
            cbChooseAttribute = new ComboBox();
            cbChoosePodcast = new ComboBox();
            lblChoosePodcast = new Label();
            lblChooseAttribute = new Label();
            lblChangeName = new Label();
            lblChangeCategory = new Label();
            cbChangeCategory = new ComboBox();
            txtChangeName = new TextBox();
            btnAcceptChange = new Button();
            btnAbortChange = new Button();
            SuspendLayout();
            // 
            // cbChooseAttribute
            // 
            cbChooseAttribute.Cursor = Cursors.Hand;
            cbChooseAttribute.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChooseAttribute.FormattingEnabled = true;
            cbChooseAttribute.Items.AddRange(new object[] { "Namn", "Kategori" });
            cbChooseAttribute.Location = new Point(222, 94);
            cbChooseAttribute.Margin = new Padding(3, 4, 3, 4);
            cbChooseAttribute.Name = "cbChooseAttribute";
            cbChooseAttribute.Size = new Size(162, 28);
            cbChooseAttribute.TabIndex = 0;
            cbChooseAttribute.Visible = false;
            cbChooseAttribute.SelectedIndexChanged += cbChooseAttribute_SelectedIndexChanged;
            // 
            // cbChoosePodcast
            // 
            cbChoosePodcast.Cursor = Cursors.Hand;
            cbChoosePodcast.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChoosePodcast.FormattingEnabled = true;
            cbChoosePodcast.Location = new Point(222, 60);
            cbChoosePodcast.Margin = new Padding(3, 4, 3, 4);
            cbChoosePodcast.Name = "cbChoosePodcast";
            cbChoosePodcast.Size = new Size(162, 28);
            cbChoosePodcast.TabIndex = 1;
            cbChoosePodcast.SelectedIndexChanged += cbChoosePodcast_SelectedIndexChanged;
            // 
            // lblChoosePodcast
            // 
            lblChoosePodcast.AutoSize = true;
            lblChoosePodcast.Location = new Point(80, 62);
            lblChoosePodcast.Name = "lblChoosePodcast";
            lblChoosePodcast.Size = new Size(124, 20);
            lblChoosePodcast.TabIndex = 2;
            lblChoosePodcast.Text = "Podcast att ändra";
            // 
            // lblChooseAttribute
            // 
            lblChooseAttribute.AutoSize = true;
            lblChooseAttribute.Location = new Point(69, 97);
            lblChooseAttribute.Name = "lblChooseAttribute";
            lblChooseAttribute.Size = new Size(136, 20);
            lblChooseAttribute.TabIndex = 3;
            lblChooseAttribute.Text = "Egenskap att ändra";
            lblChooseAttribute.Visible = false;
            // 
            // lblChangeName
            // 
            lblChangeName.AutoSize = true;
            lblChangeName.Location = new Point(45, 166);
            lblChangeName.Name = "lblChangeName";
            lblChangeName.Size = new Size(159, 20);
            lblChangeName.TabIndex = 5;
            lblChangeName.Text = "Nytt namn på podcast:";
            lblChangeName.Visible = false;
            // 
            // lblChangeCategory
            // 
            lblChangeCategory.AutoSize = true;
            lblChangeCategory.Location = new Point(114, 131);
            lblChangeCategory.Name = "lblChangeCategory";
            lblChangeCategory.Size = new Size(89, 20);
            lblChangeCategory.TabIndex = 6;
            lblChangeCategory.Text = "Byt kategori";
            lblChangeCategory.Visible = false;
            // 
            // cbChangeCategory
            // 
            cbChangeCategory.Cursor = Cursors.Hand;
            cbChangeCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChangeCategory.FormattingEnabled = true;
            cbChangeCategory.Location = new Point(222, 129);
            cbChangeCategory.Margin = new Padding(3, 4, 3, 4);
            cbChangeCategory.Name = "cbChangeCategory";
            cbChangeCategory.Size = new Size(162, 28);
            cbChangeCategory.TabIndex = 7;
            cbChangeCategory.Visible = false;
            // 
            // txtChangeName
            // 
            txtChangeName.Cursor = Cursors.IBeam;
            txtChangeName.Location = new Point(222, 163);
            txtChangeName.Margin = new Padding(3, 4, 3, 4);
            txtChangeName.Name = "txtChangeName";
            txtChangeName.Size = new Size(162, 27);
            txtChangeName.TabIndex = 8;
            txtChangeName.Visible = false;
            // 
            // btnAcceptChange
            // 
            btnAcceptChange.BackColor = Color.GhostWhite;
            btnAcceptChange.Cursor = Cursors.Hand;
            btnAcceptChange.Location = new Point(114, 239);
            btnAcceptChange.Margin = new Padding(3, 4, 3, 4);
            btnAcceptChange.Name = "btnAcceptChange";
            btnAcceptChange.Size = new Size(86, 30);
            btnAcceptChange.TabIndex = 9;
            btnAcceptChange.Text = "Godkänn";
            btnAcceptChange.UseVisualStyleBackColor = false;
            btnAcceptChange.Click += btnAcceptChange_Click;
            // 
            // btnAbortChange
            // 
            btnAbortChange.BackColor = Color.GhostWhite;
            btnAbortChange.Cursor = Cursors.Hand;
            btnAbortChange.Location = new Point(244, 239);
            btnAbortChange.Margin = new Padding(3, 4, 3, 4);
            btnAbortChange.Name = "btnAbortChange";
            btnAbortChange.Size = new Size(86, 30);
            btnAbortChange.TabIndex = 10;
            btnAbortChange.Text = "Avbryt";
            btnAbortChange.UseVisualStyleBackColor = false;
            btnAbortChange.Click += btnAbortChange_Click;
            // 
            // RedigeraEgenskaper
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 333);
            Controls.Add(btnAbortChange);
            Controls.Add(btnAcceptChange);
            Controls.Add(txtChangeName);
            Controls.Add(cbChangeCategory);
            Controls.Add(lblChangeCategory);
            Controls.Add(lblChangeName);
            Controls.Add(lblChooseAttribute);
            Controls.Add(lblChoosePodcast);
            Controls.Add(cbChoosePodcast);
            Controls.Add(cbChooseAttribute);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RedigeraEgenskaper";
            Text = "Redigera flöde";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbChooseAttribute;
        private ComboBox cbChoosePodcast;
        private Label lblChoosePodcast;
        private Label lblChooseAttribute;
        private Label lblChangeName;
        private Label lblChangeCategory;
        private ComboBox cbChangeCategory;
        private TextBox txtChangeName;
        private Button btnAcceptChange;
        private Button btnAbortChange;
    }
}