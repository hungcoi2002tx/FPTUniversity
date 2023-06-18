namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMemberID = new TextBox();
            txtMemberName = new TextBox();
            txtCity = new TextBox();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            txtCountry = new TextBox();
            btnLoad = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            txtTitle = new Label();
            dgvEmployeerList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeerList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 99);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Member ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 134);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Member Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 96);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 134);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Pass";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 171);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(451, 171);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "Country";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(169, 96);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(188, 23);
            txtMemberID.TabIndex = 6;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(169, 134);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(188, 23);
            txtMemberName.TabIndex = 7;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(169, 171);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(188, 23);
            txtCity.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(524, 93);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(524, 134);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(188, 23);
            txtPass.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(524, 171);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(188, 23);
            txtCountry.TabIndex = 11;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(143, 209);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 46);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(315, 209);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 46);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(496, 209);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 46);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font(".VnTimeH", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTitle.Location = new Point(63, 24);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(313, 38);
            txtTitle.TabIndex = 15;
            txtTitle.Text = "FStore Employeer";
            // 
            // dgvEmployeerList
            // 
            dgvEmployeerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeerList.Location = new Point(12, 270);
            dgvEmployeerList.Name = "dgvEmployeerList";
            dgvEmployeerList.RowTemplate.Height = 25;
            dgvEmployeerList.Size = new Size(776, 168);
            dgvEmployeerList.TabIndex = 16;
            dgvEmployeerList.DoubleClick += dgvEmployeerList_DoubleClick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(664, 209);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 46);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(dgvEmployeerList);
            Controls.Add(txtTitle);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(txtCountry);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(txtCity);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployeerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private TextBox txtCity;
        private TextBox txtEmail;
        private TextBox txtPass;
        private TextBox txtCountry;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnDelete;
        private Label txtTitle;
        private DataGridView dgvEmployeerList;
        private Button btnClose;
    }
}