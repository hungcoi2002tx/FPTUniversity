namespace WinFormsApp2
{
    partial class Form3
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(345, 197);
            btn1.Margin = new Padding(3, 4, 3, 4);
            btn1.Name = "btn1";
            btn1.Size = new Size(86, 31);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(528, 197);
            btn2.Margin = new Padding(3, 4, 3, 4);
            btn2.Name = "btn2";
            btn2.Size = new Size(86, 31);
            btn2.TabIndex = 1;
            btn2.Text = "1";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(345, 289);
            btn3.Margin = new Padding(3, 4, 3, 4);
            btn3.Name = "btn3";
            btn3.Size = new Size(86, 31);
            btn3.TabIndex = 2;
            btn3.Text = "2";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(528, 289);
            btn4.Margin = new Padding(3, 4, 3, 4);
            btn4.Name = "btn4";
            btn4.Size = new Size(86, 31);
            btn4.TabIndex = 3;
            btn4.Text = "3";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
    }
}