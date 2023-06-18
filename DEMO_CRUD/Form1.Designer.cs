namespace DEMO_CRUD
{
    partial class frmCRUD
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
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            dgvData = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 13);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "CategoryID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 60);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 1;
            label2.Text = "CategoryName";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(214, 16);
            txtCategoryID.Margin = new Padding(3, 2, 3, 2);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(446, 23);
            txtCategoryID.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(214, 64);
            txtCategoryName.Margin = new Padding(3, 2, 3, 2);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(446, 23);
            txtCategoryName.TabIndex = 3;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(46, 99);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 29;
            dgvData.Size = new Size(613, 188);
            dgvData.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(46, 307);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(82, 22);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(214, 307);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(407, 307);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(578, 307);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dgvData);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCRUD";
            Text = "CRUD_DEMO";
            Load += frmCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private DataGridView dgvData;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
    }
}