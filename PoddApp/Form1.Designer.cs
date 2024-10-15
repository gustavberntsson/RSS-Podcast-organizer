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
            label1 = new Label();
            button1 = new Button();
            Avsnitt = new ListBox();
            textBox1 = new TextBox();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Poddbert";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(264, 68);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Avsnitt
            // 
            Avsnitt.FormattingEnabled = true;
            Avsnitt.ItemHeight = 15;
            Avsnitt.Items.AddRange(new object[] { "Poddbert", "Poddvard", "Podden" });
            Avsnitt.Location = new Point(698, 174);
            Avsnitt.MultiColumn = true;
            Avsnitt.Name = "Avsnitt";
            Avsnitt.Size = new Size(193, 184);
            Avsnitt.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(426, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.Location = new Point(46, 153);
            listView1.Name = "listView1";
            listView1.Size = new Size(333, 205);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 596);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(Avsnitt);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ListBox Avsnitt;
        private TextBox textBox1;
        private ListView listView1;
    }
}
