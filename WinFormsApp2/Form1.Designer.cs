namespace WinFormsApp2
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
            btn1 = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.DialogResult = DialogResult.Ignore;
            btn1.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = Color.Coral;
            btn1.Location = new Point(28, 39);
            btn1.Name = "btn1";
            btn1.Size = new Size(267, 59);
            btn1.TabIndex = 1;
            btn1.Text = "button1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 510);
            Controls.Add(btn1);
            Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "The First Form";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btn1;
    }
}