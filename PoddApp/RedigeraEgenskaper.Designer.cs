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
            cbChooseAttribute.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChooseAttribute.FormattingEnabled = true;
            cbChooseAttribute.Items.AddRange(new object[] { "Namn", "Kategori" });
            cbChooseAttribute.Location = new Point(277, 118);
            cbChooseAttribute.Margin = new Padding(4, 5, 4, 5);
            cbChooseAttribute.Name = "cbChooseAttribute";
            cbChooseAttribute.Size = new Size(201, 33);
            cbChooseAttribute.TabIndex = 0;
            cbChooseAttribute.Visible = false;
            cbChooseAttribute.SelectedIndexChanged += cbChooseAttribute_SelectedIndexChanged;
            // 
            // cbChoosePodcast
            // 
            cbChoosePodcast.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChoosePodcast.FormattingEnabled = true;
            cbChoosePodcast.Location = new Point(277, 75);
            cbChoosePodcast.Margin = new Padding(4, 5, 4, 5);
            cbChoosePodcast.Name = "cbChoosePodcast";
            cbChoosePodcast.Size = new Size(201, 33);
            cbChoosePodcast.TabIndex = 1;
            cbChoosePodcast.SelectedIndexChanged += cbChoosePodcast_SelectedIndexChanged;
            // 
            // lblChoosePodcast
            // 
            lblChoosePodcast.AutoSize = true;
            lblChoosePodcast.Location = new Point(100, 78);
            lblChoosePodcast.Margin = new Padding(4, 0, 4, 0);
            lblChoosePodcast.Name = "lblChoosePodcast";
            lblChoosePodcast.Size = new Size(150, 25);
            lblChoosePodcast.TabIndex = 2;
            lblChoosePodcast.Text = "Podcast att ändra";
            // 
            // lblChooseAttribute
            // 
            lblChooseAttribute.AutoSize = true;
            lblChooseAttribute.Location = new Point(86, 121);
            lblChooseAttribute.Margin = new Padding(4, 0, 4, 0);
            lblChooseAttribute.Name = "lblChooseAttribute";
            lblChooseAttribute.Size = new Size(164, 25);
            lblChooseAttribute.TabIndex = 3;
            lblChooseAttribute.Text = "Egenskap att ändra";
            lblChooseAttribute.Visible = false;
            // 
            // lblChangeName
            // 
            lblChangeName.AutoSize = true;
            lblChangeName.Location = new Point(56, 207);
            lblChangeName.Margin = new Padding(4, 0, 4, 0);
            lblChangeName.Name = "lblChangeName";
            lblChangeName.Size = new Size(194, 25);
            lblChangeName.TabIndex = 5;
            lblChangeName.Text = "Nytt namn på podcast:";
            lblChangeName.Visible = false;
            // 
            // lblChangeCategory
            // 
            lblChangeCategory.AutoSize = true;
            lblChangeCategory.Location = new Point(143, 164);
            lblChangeCategory.Margin = new Padding(4, 0, 4, 0);
            lblChangeCategory.Name = "lblChangeCategory";
            lblChangeCategory.Size = new Size(107, 25);
            lblChangeCategory.TabIndex = 6;
            lblChangeCategory.Text = "Byt kategori";
            lblChangeCategory.Visible = false;
            // 
            // cbChangeCategory
            // 
            cbChangeCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChangeCategory.FormattingEnabled = true;
            cbChangeCategory.Location = new Point(277, 161);
            cbChangeCategory.Margin = new Padding(4, 5, 4, 5);
            cbChangeCategory.Name = "cbChangeCategory";
            cbChangeCategory.Size = new Size(201, 33);
            cbChangeCategory.TabIndex = 7;
            cbChangeCategory.Visible = false;
            // 
            // txtChangeName
            // 
            txtChangeName.Location = new Point(277, 204);
            txtChangeName.Margin = new Padding(4, 5, 4, 5);
            txtChangeName.Name = "txtChangeName";
            txtChangeName.Size = new Size(201, 31);
            txtChangeName.TabIndex = 8;
            txtChangeName.Visible = false;
            // 
            // btnAcceptChange
            // 
            btnAcceptChange.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnAcceptChange.FlatStyle = FlatStyle.Flat;
            btnAcceptChange.Location = new Point(143, 299);
            btnAcceptChange.Margin = new Padding(4, 5, 4, 5);
            btnAcceptChange.Name = "btnAcceptChange";
            btnAcceptChange.Size = new Size(107, 38);
            btnAcceptChange.TabIndex = 9;
            btnAcceptChange.Text = "Godkänn";
            btnAcceptChange.UseVisualStyleBackColor = true;
            btnAcceptChange.Click += btnAcceptChange_Click;
            // 
            // btnAbortChange
            // 
            btnAbortChange.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnAbortChange.FlatStyle = FlatStyle.Flat;
            btnAbortChange.Location = new Point(305, 299);
            btnAbortChange.Margin = new Padding(4, 5, 4, 5);
            btnAbortChange.Name = "btnAbortChange";
            btnAbortChange.Size = new Size(107, 38);
            btnAbortChange.TabIndex = 10;
            btnAbortChange.Text = "Avbryt";
            btnAbortChange.UseVisualStyleBackColor = true;
            btnAbortChange.Click += btnAbortChange_Click;
            // 
            // RedigeraEgenskaper
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 416);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "RedigeraEgenskaper";
            Text = "Form2";
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