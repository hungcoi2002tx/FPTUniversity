namespace WinFormsApp2
{
    partial class Pt8
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
            groupBox1 = new GroupBox();
            groupBox5 = new GroupBox();
            textBox3 = new TextBox();
            label8 = new Label();
            richTextBox3 = new RichTextBox();
            button6 = new Button();
            label9 = new Label();
            label10 = new Label();
            comboBox11 = new ComboBox();
            comboBox12 = new ComboBox();
            groupBox4 = new GroupBox();
            textBox2 = new TextBox();
            label5 = new Label();
            richTextBox2 = new RichTextBox();
            button5 = new Button();
            label6 = new Label();
            label7 = new Label();
            comboBox9 = new ComboBox();
            comboBox10 = new ComboBox();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            button4 = new Button();
            label3 = new Label();
            label2 = new Label();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            groupBox2 = new GroupBox();
            comboBox8 = new ComboBox();
            comboBox7 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 255);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.ForeColor = Color.FromArgb(192, 0, 0);
            groupBox1.Location = new Point(-1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(801, 592);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Về Kỹ Năng";
            groupBox1.Paint += groupBox1_Paint;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox3);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(richTextBox3);
            groupBox5.Controls.Add(button6);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(comboBox11);
            groupBox5.Controls.Add(comboBox12);
            groupBox5.ForeColor = Color.FromArgb(192, 0, 0);
            groupBox5.Location = new Point(10, 434);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(789, 152);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Kỹ Năng \"Khác\"";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(279, 67);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 23);
            textBox3.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(0, 0, 192);
            label8.Location = new Point(113, 66);
            label8.Name = "label8";
            label8.Size = new Size(140, 15);
            label8.TabIndex = 25;
            label8.Text = "Số Năm Sử Dụng Nếu Có";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(127, 91);
            richTextBox3.Margin = new Padding(3, 2, 3, 2);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(549, 48);
            richTextBox3.TabIndex = 19;
            richTextBox3.Text = "";
            // 
            // button6
            // 
            button6.ForeColor = Color.FromArgb(192, 0, 0);
            button6.Location = new Point(436, 66);
            button6.Name = "button6";
            button6.Size = new Size(54, 23);
            button6.TabIndex = 21;
            button6.Text = "Save";
            button6.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(0, 0, 192);
            label9.Location = new Point(207, 35);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 24;
            label9.Text = "Trình Độ:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(0, 0, 192);
            label10.Location = new Point(207, 13);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 22;
            label10.Text = "Kỹ Năng:";
            // 
            // comboBox11
            // 
            comboBox11.BackColor = SystemColors.InactiveBorder;
            comboBox11.FormattingEnabled = true;
            comboBox11.Items.AddRange(new object[] { "Tiếng Pháp", "Tiếng Anh", "Tiếng Ấn Độ", "Tiếng Việt Nam", "Tiếng Thạch Thất" });
            comboBox11.Location = new Point(279, 13);
            comboBox11.Name = "comboBox11";
            comboBox11.Size = new Size(132, 23);
            comboBox11.TabIndex = 23;
            comboBox11.Text = "--Chọn Ngôn Ngữ--";
            comboBox11.UseWaitCursor = true;
            // 
            // comboBox12
            // 
            comboBox12.BackColor = SystemColors.InactiveBorder;
            comboBox12.FormattingEnabled = true;
            comboBox12.Items.AddRange(new object[] { "Sơ Cấp", "Cao Cấp", "Cực Kỳ Cao Cấp", "Đẳng Cấp" });
            comboBox12.Location = new Point(279, 35);
            comboBox12.Name = "comboBox12";
            comboBox12.Size = new Size(132, 23);
            comboBox12.TabIndex = 20;
            comboBox12.Text = "--Chọn Trình Độ--";
            comboBox12.UseWaitCursor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(richTextBox2);
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(comboBox9);
            groupBox4.Controls.Add(comboBox10);
            groupBox4.ForeColor = Color.FromArgb(192, 0, 0);
            groupBox4.Location = new Point(10, 271);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(793, 157);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kỹ Năng \"Mềm\"";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(282, 70);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(116, 69);
            label5.Name = "label5";
            label5.Size = new Size(140, 15);
            label5.TabIndex = 17;
            label5.Text = "Số Năm Sử Dụng Nếu Có";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(130, 94);
            richTextBox2.Margin = new Padding(3, 2, 3, 2);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(549, 48);
            richTextBox2.TabIndex = 11;
            richTextBox2.Text = "";
            // 
            // button5
            // 
            button5.ForeColor = Color.FromArgb(192, 0, 0);
            button5.Location = new Point(439, 69);
            button5.Name = "button5";
            button5.Size = new Size(54, 23);
            button5.TabIndex = 13;
            button5.Text = "Save";
            button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(210, 38);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 16;
            label6.Text = "Trình Độ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(0, 0, 192);
            label7.Location = new Point(210, 16);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 14;
            label7.Text = "Kỹ Năng:";
            // 
            // comboBox9
            // 
            comboBox9.BackColor = SystemColors.InactiveBorder;
            comboBox9.FormattingEnabled = true;
            comboBox9.Items.AddRange(new object[] { "Tiếng Pháp", "Tiếng Anh", "Tiếng Ấn Độ", "Tiếng Việt Nam", "Tiếng Thạch Thất" });
            comboBox9.Location = new Point(282, 16);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(132, 23);
            comboBox9.TabIndex = 15;
            comboBox9.Text = "--Chọn Ngôn Ngữ--";
            comboBox9.UseWaitCursor = true;
            // 
            // comboBox10
            // 
            comboBox10.BackColor = SystemColors.InactiveBorder;
            comboBox10.FormattingEnabled = true;
            comboBox10.Items.AddRange(new object[] { "Sơ Cấp", "Cao Cấp", "Cực Kỳ Cao Cấp", "Đẳng Cấp" });
            comboBox10.Location = new Point(282, 38);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(132, 23);
            comboBox10.TabIndex = 12;
            comboBox10.Text = "--Chọn Trình Độ--";
            comboBox10.UseWaitCursor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(comboBox5);
            groupBox3.Controls.Add(comboBox4);
            groupBox3.ForeColor = Color.FromArgb(192, 0, 0);
            groupBox3.Location = new Point(10, 128);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(793, 137);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kỹ Năng Máy Tính";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 62);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(108, 61);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 9;
            label4.Text = "Số Năm Sử Dụng Nếu Có";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(122, 86);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(549, 48);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button4
            // 
            button4.ForeColor = Color.FromArgb(192, 0, 0);
            button4.Location = new Point(432, 61);
            button4.Name = "button4";
            button4.Size = new Size(54, 23);
            button4.TabIndex = 5;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(203, 30);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 8;
            label3.Text = "Trình Độ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(203, 8);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Kỹ Năng:";
            // 
            // comboBox5
            // 
            comboBox5.BackColor = SystemColors.InactiveBorder;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Tiếng Pháp", "Tiếng Anh", "Tiếng Ấn Độ", "Tiếng Việt Nam", "Tiếng Thạch Thất" });
            comboBox5.Location = new Point(275, 8);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(132, 23);
            comboBox5.TabIndex = 7;
            comboBox5.Text = "--Chọn Ngôn Ngữ--";
            comboBox5.UseWaitCursor = true;
            // 
            // comboBox4
            // 
            comboBox4.BackColor = SystemColors.InactiveBorder;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Sơ Cấp", "Cao Cấp", "Cực Kỳ Cao Cấp", "Đẳng Cấp" });
            comboBox4.Location = new Point(275, 30);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(132, 23);
            comboBox4.TabIndex = 4;
            comboBox4.Text = "--Chọn Trình Độ--";
            comboBox4.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox8);
            groupBox2.Controls.Add(comboBox7);
            groupBox2.Controls.Add(comboBox6);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.ForeColor = Color.FromArgb(192, 0, 0);
            groupBox2.Location = new Point(10, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(793, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ngoại Ngữ";
            // 
            // comboBox8
            // 
            comboBox8.BackColor = SystemColors.InactiveBorder;
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "Sơ Cấp", "Cao Cấp", "Cực Kỳ Cao Cấp", "Đẳng Cấp" });
            comboBox8.Location = new Point(432, 16);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(123, 23);
            comboBox8.TabIndex = 7;
            comboBox8.Text = "--Chọn Trình Độ--";
            comboBox8.UseWaitCursor = true;
            // 
            // comboBox7
            // 
            comboBox7.BackColor = SystemColors.InactiveBorder;
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "Sơ Cấp", "Cao Cấp", "Cực Kỳ Cao Cấp", "Đẳng Cấp" });
            comboBox7.Location = new Point(432, 77);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(123, 23);
            comboBox7.TabIndex = 6;
            comboBox7.Text = "--Chọn Trình Độ--";
            comboBox7.UseWaitCursor = true;
            // 
            // comboBox6
            // 
            comboBox6.BackColor = SystemColors.InactiveBorder;
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Sơ Cấp", "Cao Cấp", "Cực Kỳ Cao Cấp", "Đẳng Cấp" });
            comboBox6.Location = new Point(432, 45);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(123, 23);
            comboBox6.TabIndex = 5;
            comboBox6.Text = "--Chọn Trình Độ--";
            comboBox6.UseWaitCursor = true;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = SystemColors.InactiveBorder;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Tiếng Pháp", "Tiếng Anh", "Tiếng Ấn Độ", "Tiếng Việt Nam", "Tiếng Thạch Thất" });
            comboBox3.Location = new Point(275, 77);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(132, 23);
            comboBox3.TabIndex = 3;
            comboBox3.Text = "--Chọn Ngôn Ngữ--";
            comboBox3.UseWaitCursor = true;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.InactiveBorder;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Tiếng Pháp", "Tiếng Anh", "Tiếng Ấn Độ", "Tiếng Việt Nam", "Tiếng Thạch Thất" });
            comboBox2.Location = new Point(275, 45);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(132, 23);
            comboBox2.TabIndex = 2;
            comboBox2.Text = "--Chọn Ngôn Ngữ--";
            comboBox2.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveBorder;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tiếng Pháp", "Tiếng Anh", "Tiếng Ấn Độ", "Tiếng Việt Nam", "Tiếng Thạch Thất" });
            comboBox1.Location = new Point(275, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "--Chọn Ngôn Ngữ--";
            comboBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(142, 19);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Trình Độ Ngoại Ngữ:";
            // 
            // button1
            // 
            button1.ForeColor = Color.FromArgb(192, 0, 0);
            button1.Location = new Point(559, 600);
            button1.Name = "button1";
            button1.Size = new Size(54, 23);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(647, 600);
            button2.Name = "button2";
            button2.Size = new Size(54, 23);
            button2.TabIndex = 3;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = Color.FromArgb(192, 0, 0);
            button3.Location = new Point(734, 600);
            button3.Name = "button3";
            button3.Size = new Size(54, 23);
            button3.TabIndex = 4;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            // 
            // Pt8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 634);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Pt8";
            Text = "Pt8";
            Load += Pt8_Load;
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox7;
        private ComboBox comboBox6;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label3;
        private Label label2;
        private ComboBox comboBox5;
        private Button button4;
        private ComboBox comboBox8;
        private RichTextBox richTextBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private RichTextBox richTextBox2;
        private Button button5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox9;
        private ComboBox comboBox10;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label8;
        private RichTextBox richTextBox3;
        private Button button6;
        private Label label9;
        private Label label10;
        private ComboBox comboBox11;
        private ComboBox comboBox12;
    }
}