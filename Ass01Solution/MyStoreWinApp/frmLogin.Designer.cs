namespace MyStoreWinApp
{
    partial class frmLogin
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
            label2 = new Label();
            btnLogin = new Button();
            btnCancel = new Button();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 88);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 133);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Pass";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(58, 205);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(183, 205);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(162, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(140, 130);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(162, 23);
            txtPass.TabIndex = 5;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 371);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Button btnCancel;
        private TextBox txtEmail;
        private TextBox txtPass;
    }
}