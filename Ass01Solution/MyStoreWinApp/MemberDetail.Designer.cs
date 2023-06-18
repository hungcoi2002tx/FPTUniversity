namespace MyStoreWinApp
{
    partial class MemberDetail
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
            lblTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtID = new TextBox();
            txtPass = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(31, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(352, 59);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Employee Detail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 135);
            label1.Name = "label1";
            label1.Size = new Size(25, 21);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 393);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 2;
            label2.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 338);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 3;
            label3.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 284);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 228);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 5;
            label5.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(31, 183);
            label6.Name = "label6";
            label6.Size = new Size(40, 21);
            label6.TabIndex = 6;
            label6.Text = "Pass";
            // 
            // txtID
            // 
            txtID.Location = new Point(128, 133);
            txtID.Name = "txtID";
            txtID.Size = new Size(229, 23);
            txtID.TabIndex = 7;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(128, 181);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(229, 23);
            txtPass.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.AcceptsReturn = true;
            txtName.Location = new Point(128, 226);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 23);
            txtName.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 282);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(128, 336);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(229, 23);
            txtCity.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(128, 391);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(229, 23);
            txtCountry.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(83, 451);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(205, 451);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // MemberDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 508);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtPass);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "MemberDetail";
            Text = "MemberDetail";
            Load += MemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtID;
        private TextBox txtPass;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Button btnSave;
        private Button btnCancel;
    }
}