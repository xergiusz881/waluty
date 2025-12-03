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
            CHF_IN = new RadioButton();
            GBP_IN = new RadioButton();
            EUR_IN = new RadioButton();
            USD_IN = new RadioButton();
            PLN_IN = new RadioButton();
            groupBox2 = new GroupBox();
            CHF_OUT = new RadioButton();
            GBP_OUT = new RadioButton();
            EUR_OUT = new RadioButton();
            USD_OUT = new RadioButton();
            PLN_OUT = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            sAmout = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            tableLayoutPanel1.SetColumnSpan(button1, 2);
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(403, 375);
            button1.Name = "button1";
            button1.Size = new Size(394, 72);
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
            tableLayoutPanel1.Controls.Add(button1, 2, 4);
            tableLayoutPanel1.Controls.Add(TextBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(TextBox3, 2, 1);
            tableLayoutPanel1.Controls.Add(TextBox4, 3, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox2, 2, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 2, 3);
            tableLayoutPanel1.Controls.Add(sAmout, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox5, 3, 3);
            tableLayoutPanel1.Controls.Add(button2, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9045916F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9045916F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42.8577232F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66643F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // TextBox11
            // 
            TextBox11.Dock = DockStyle.Fill;
            TextBox11.Location = new Point(3, 56);
            TextBox11.Name = "TextBox11";
            TextBox11.ReadOnly = true;
            TextBox11.Size = new Size(194, 23);
            TextBox11.TabIndex = 0;
            TextBox11.Text = "USD";
            // 
            // TextBox2
            // 
            TextBox2.Dock = DockStyle.Fill;
            TextBox2.Location = new Point(203, 56);
            TextBox2.Name = "TextBox2";
            TextBox2.ReadOnly = true;
            TextBox2.Size = new Size(194, 23);
            TextBox2.TabIndex = 1;
            TextBox2.Text = "GBP";
            // 
            // TextBox3
            // 
            TextBox3.Dock = DockStyle.Fill;
            TextBox3.Location = new Point(403, 56);
            TextBox3.Name = "TextBox3";
            TextBox3.ReadOnly = true;
            TextBox3.Size = new Size(194, 23);
            TextBox3.TabIndex = 2;
            TextBox3.Text = "CHF";
            // 
            // TextBox4
            // 
            TextBox4.Dock = DockStyle.Fill;
            TextBox4.Location = new Point(603, 56);
            TextBox4.Name = "TextBox4";
            TextBox4.ReadOnly = true;
            TextBox4.Size = new Size(194, 23);
            TextBox4.TabIndex = 3;
            TextBox4.Text = "EUR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 53);
            label1.TabIndex = 4;
            label1.Text = "kurs USD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(203, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 53);
            label2.TabIndex = 5;
            label2.Text = "kurs GBP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(403, 0);
            label3.Name = "label3";
            label3.Size = new Size(194, 53);
            label3.TabIndex = 6;
            label3.Text = "kurs CHF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(603, 0);
            label4.Name = "label4";
            label4.Size = new Size(194, 53);
            label4.TabIndex = 7;
            label4.Text = "kurs EUR";
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(CHF_IN);
            groupBox1.Controls.Add(GBP_IN);
            groupBox1.Controls.Add(EUR_IN);
            groupBox1.Controls.Add(USD_IN);
            groupBox1.Controls.Add(PLN_IN);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 186);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "waluta_zródłowa";
            // 
            // CHF_IN
            // 
            CHF_IN.AutoSize = true;
            CHF_IN.Location = new Point(18, 132);
            CHF_IN.Name = "CHF_IN";
            CHF_IN.Size = new Size(48, 19);
            CHF_IN.TabIndex = 4;
            CHF_IN.Text = "CHF";
            CHF_IN.UseVisualStyleBackColor = true;
            // 
            // GBP_IN
            // 
            GBP_IN.AutoSize = true;
            GBP_IN.Location = new Point(17, 106);
            GBP_IN.Name = "GBP_IN";
            GBP_IN.Size = new Size(47, 19);
            GBP_IN.TabIndex = 3;
            GBP_IN.Text = "GBP";
            GBP_IN.UseVisualStyleBackColor = true;
            // 
            // EUR_IN
            // 
            EUR_IN.AutoSize = true;
            EUR_IN.Location = new Point(18, 82);
            EUR_IN.Name = "EUR_IN";
            EUR_IN.Size = new Size(46, 19);
            EUR_IN.TabIndex = 2;
            EUR_IN.Text = "EUR";
            EUR_IN.UseVisualStyleBackColor = true;
            // 
            // USD_IN
            // 
            USD_IN.AutoSize = true;
            USD_IN.Location = new Point(18, 57);
            USD_IN.Name = "USD_IN";
            USD_IN.Size = new Size(47, 19);
            USD_IN.TabIndex = 1;
            USD_IN.Text = "USD";
            USD_IN.UseVisualStyleBackColor = true;
            // 
            // PLN_IN
            // 
            PLN_IN.AutoSize = true;
            PLN_IN.Checked = true;
            PLN_IN.Location = new Point(18, 32);
            PLN_IN.Name = "PLN_IN";
            PLN_IN.Size = new Size(47, 19);
            PLN_IN.TabIndex = 0;
            PLN_IN.TabStop = true;
            PLN_IN.Text = "PLN";
            PLN_IN.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox2, 2);
            groupBox2.Controls.Add(CHF_OUT);
            groupBox2.Controls.Add(GBP_OUT);
            groupBox2.Controls.Add(EUR_OUT);
            groupBox2.Controls.Add(USD_OUT);
            groupBox2.Controls.Add(PLN_OUT);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(403, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 186);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "waluta_docelowa";
            // 
            // CHF_OUT
            // 
            CHF_OUT.AutoSize = true;
            CHF_OUT.Location = new Point(26, 131);
            CHF_OUT.Name = "CHF_OUT";
            CHF_OUT.Size = new Size(48, 19);
            CHF_OUT.TabIndex = 4;
            CHF_OUT.Text = "CHF";
            CHF_OUT.UseVisualStyleBackColor = true;
            // 
            // GBP_OUT
            // 
            GBP_OUT.AutoSize = true;
            GBP_OUT.Location = new Point(26, 106);
            GBP_OUT.Name = "GBP_OUT";
            GBP_OUT.Size = new Size(47, 19);
            GBP_OUT.TabIndex = 3;
            GBP_OUT.Text = "GBP";
            GBP_OUT.UseVisualStyleBackColor = true;
            // 
            // EUR_OUT
            // 
            EUR_OUT.AutoSize = true;
            EUR_OUT.Location = new Point(26, 81);
            EUR_OUT.Name = "EUR_OUT";
            EUR_OUT.Size = new Size(46, 19);
            EUR_OUT.TabIndex = 2;
            EUR_OUT.Text = "EUR";
            EUR_OUT.UseVisualStyleBackColor = true;
            // 
            // USD_OUT
            // 
            USD_OUT.AutoSize = true;
            USD_OUT.Location = new Point(26, 56);
            USD_OUT.Name = "USD_OUT";
            USD_OUT.Size = new Size(47, 19);
            USD_OUT.TabIndex = 1;
            USD_OUT.Text = "USD";
            USD_OUT.UseVisualStyleBackColor = true;
            // 
            // PLN_OUT
            // 
            PLN_OUT.AutoSize = true;
            PLN_OUT.Checked = true;
            PLN_OUT.Location = new Point(26, 31);
            PLN_OUT.Name = "PLN_OUT";
            PLN_OUT.Size = new Size(47, 19);
            PLN_OUT.TabIndex = 0;
            PLN_OUT.TabStop = true;
            PLN_OUT.Text = "PLN";
            PLN_OUT.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 298);
            label5.Name = "label5";
            label5.Size = new Size(194, 74);
            label5.TabIndex = 10;
            label5.Text = "label5";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(403, 298);
            label6.Name = "label6";
            label6.Size = new Size(194, 74);
            label6.TabIndex = 11;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sAmout
            // 
            sAmout.Dock = DockStyle.Fill;
            sAmout.Location = new Point(203, 301);
            sAmout.Name = "sAmout";
            sAmout.Size = new Size(194, 23);
            sAmout.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Fill;
            textBox5.Location = new Point(603, 301);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(194, 23);
            textBox5.TabIndex = 13;
            // 
            // button2
            // 
            tableLayoutPanel1.SetColumnSpan(button2, 2);
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(3, 375);
            button2.Name = "button2";
            button2.Size = new Size(394, 72);
            button2.TabIndex = 14;
            button2.Text = "przelicz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += convert;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
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
        private RadioButton CHF_IN;
        private RadioButton GBP_IN;
        private RadioButton EUR_IN;
        private RadioButton USD_IN;
        private RadioButton PLN_IN;
        private RadioButton CHF_OUT;
        private RadioButton GBP_OUT;
        private RadioButton EUR_OUT;
        private RadioButton USD_OUT;
        private RadioButton PLN_OUT;
        private Label label5;
        private Label label6;
        private TextBox sAmout;
        private TextBox textBox5;
        private Button button2;
    }
}
