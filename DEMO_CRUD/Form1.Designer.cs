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
            label1.Location = new Point(53, 17);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 0;
            label1.Text = "CategoryID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 80);
            label2.Name = "label2";
            label2.Size = new Size(174, 32);
            label2.TabIndex = 1;
            label2.Text = "CategoryName";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(245, 22);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(509, 27);
            txtCategoryID.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(245, 85);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(509, 27);
            txtCategoryName.TabIndex = 3;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(53, 132);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 29;
            dgvData.Size = new Size(701, 251);
            dgvData.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(53, 409);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(245, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(465, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(660, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmCRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dgvData);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label2);
            Controls.Add(label1);
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