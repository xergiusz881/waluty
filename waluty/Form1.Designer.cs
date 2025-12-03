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
            tableLayoutPanel1 = new TableLayoutPanel();
            TextBox11 = new TextBox();
            TextBox2 = new TextBox();
            TextBox3 = new TextBox();
            TextBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton10 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            button1.Click += loadFromAPI;
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
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox2, 2, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel1.Size = new Size(776, 251);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // TextBox11
            // 
            TextBox11.Dock = DockStyle.Fill;
            TextBox11.Location = new Point(3, 38);
            TextBox11.Name = "TextBox11";
            TextBox11.ReadOnly = true;
            TextBox11.Size = new Size(188, 23);
            TextBox11.TabIndex = 0;
            TextBox11.Text = "USD";
            // 
            // TextBox2
            // 
            TextBox2.Dock = DockStyle.Fill;
            TextBox2.Location = new Point(197, 38);
            TextBox2.Name = "TextBox2";
            TextBox2.ReadOnly = true;
            TextBox2.Size = new Size(188, 23);
            TextBox2.TabIndex = 1;
            TextBox2.Text = "GBP";
            // 
            // TextBox3
            // 
            TextBox3.Dock = DockStyle.Fill;
            TextBox3.Location = new Point(391, 38);
            TextBox3.Name = "TextBox3";
            TextBox3.ReadOnly = true;
            TextBox3.Size = new Size(188, 23);
            TextBox3.TabIndex = 2;
            TextBox3.Text = "CHF";
            // 
            // TextBox4
            // 
            TextBox4.Dock = DockStyle.Fill;
            TextBox4.Location = new Point(585, 38);
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
            label1.Size = new Size(188, 35);
            label1.TabIndex = 4;
            label1.Text = "kurs USD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(197, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 35);
            label2.TabIndex = 5;
            label2.Text = "kurs GBP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(391, 0);
            label3.Name = "label3";
            label3.Size = new Size(188, 35);
            label3.TabIndex = 6;
            label3.Text = "kurs CHF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(585, 0);
            label4.Name = "label4";
            label4.Size = new Size(188, 35);
            label4.TabIndex = 7;
            label4.Text = "kurs EUR";
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 175);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "waluta_zródłowa";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(20, 132);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(94, 19);
            radioButton5.TabIndex = 4;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(20, 102);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 3;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(20, 77);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(18, 57);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(18, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox2, 2);
            groupBox2.Controls.Add(radioButton10);
            groupBox2.Controls.Add(radioButton9);
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(391, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(382, 175);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "waluta_docelowa";
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(26, 127);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(100, 19);
            radioButton10.TabIndex = 4;
            radioButton10.Text = "radioButton10";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(26, 102);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(94, 19);
            radioButton9.TabIndex = 3;
            radioButton9.Text = "radioButton9";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(26, 77);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(94, 19);
            radioButton8.TabIndex = 2;
            radioButton8.Text = "radioButton8";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(26, 56);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(94, 19);
            radioButton7.TabIndex = 1;
            radioButton7.Text = "radioButton7";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Checked = true;
            radioButton6.Location = new Point(26, 31);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(94, 19);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += loadFromAPI;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox TextBox11;
        private TextBox TextBox2;
        private TextBox TextBox3;
        private TextBox TextBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
    }
}
