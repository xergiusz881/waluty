namespace waluty
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            TextBox11 = new TextBox();
            TextBox2 = new TextBox();
            TextBox3 = new TextBox();
            TextBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(26, 407);
            button1.Name = "button1";
            button1.Size = new Size(103, 31);
            button1.TabIndex = 1;
            button1.Text = "pobierz api";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 132);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 269);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(TextBox11, 0, 1);
            tableLayoutPanel1.Controls.Add(TextBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(TextBox3, 2, 1);
            tableLayoutPanel1.Controls.Add(TextBox4, 3, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(776, 114);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // TextBox11
            // 
            TextBox11.Dock = DockStyle.Fill;
            TextBox11.Location = new Point(3, 60);
            TextBox11.Name = "TextBox11";
            TextBox11.ReadOnly = true;
            TextBox11.Size = new Size(188, 23);
            TextBox11.TabIndex = 0;
            TextBox11.Text = "USD";
            // 
            // TextBox2
            // 
            TextBox2.Dock = DockStyle.Fill;
            TextBox2.Location = new Point(197, 60);
            TextBox2.Name = "TextBox2";
            TextBox2.ReadOnly = true;
            TextBox2.Size = new Size(188, 23);
            TextBox2.TabIndex = 1;
            TextBox2.Text = "GBP";
            // 
            // TextBox3
            // 
            TextBox3.Dock = DockStyle.Fill;
            TextBox3.Location = new Point(391, 60);
            TextBox3.Name = "TextBox3";
            TextBox3.ReadOnly = true;
            TextBox3.Size = new Size(188, 23);
            TextBox3.TabIndex = 2;
            TextBox3.Text = "CHF";
            // 
            // TextBox4
            // 
            TextBox4.Dock = DockStyle.Fill;
            TextBox4.Location = new Point(585, 60);
            TextBox4.Name = "TextBox4";
            TextBox4.ReadOnly = true;
            TextBox4.Size = new Size(188, 23);
            TextBox4.TabIndex = 3;
            TextBox4.Text = "EUR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 57);
            label1.TabIndex = 4;
            label1.Text = "kurs USD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(197, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 57);
            label2.TabIndex = 5;
            label2.Text = "kurs GBP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(391, 0);
            label3.Name = "label3";
            label3.Size = new Size(188, 57);
            label3.TabIndex = 6;
            label3.Text = "kurs CHF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(585, 0);
            label4.Name = "label4";
            label4.Size = new Size(188, 57);
            label4.TabIndex = 7;
            label4.Text = "kurs EUR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private RichTextBox richTextBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox TextBox11;
        private TextBox TextBox2;
        private TextBox TextBox3;
        private TextBox TextBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
