namespace WinFormsApp1HoanDt
{
    partial class Form2
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
            lblUserName = new Label();
            lblPassWord = new Label();
            txtUserName = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            BtnLogOut = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(189, 113);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(62, 15);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "UserName";
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Location = new Point(189, 157);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(59, 15);
            lblPassWord.TabIndex = 1;
            lblPassWord.Text = "PassWord";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(292, 110);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(292, 154);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '+';
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(214, 215);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // BtnLogOut
            // 
            BtnLogOut.Location = new Point(345, 215);
            BtnLogOut.Name = "BtnLogOut";
            BtnLogOut.Size = new Size(75, 23);
            BtnLogOut.TabIndex = 5;
            BtnLogOut.Text = "LogOut";
            BtnLogOut.UseVisualStyleBackColor = true;
            BtnLogOut.Click += BtnLogOut_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLogOut);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUserName);
            Controls.Add(lblPassWord);
            Controls.Add(lblUserName);
            Name = "Form2";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblPassWord;
        private TextBox txtUserName;
        private TextBox txtPass;
        private Button btnLogin;
        private Button BtnLogOut;
    }
}