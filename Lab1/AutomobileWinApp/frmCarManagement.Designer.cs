﻿namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lblCarID = new Label();
            lblCarName = new Label();
            lblManufacturer = new Label();
            lblPrice = new Label();
            lblReleasedYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtManufacturer = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dvgCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgCarList).BeginInit();
            SuspendLayout();
            // 
            // lblCarID
            // 
            lblCarID.AutoSize = true;
            lblCarID.Location = new Point(38, 46);
            lblCarID.Name = "lblCarID";
            lblCarID.Size = new Size(39, 15);
            lblCarID.TabIndex = 0;
            lblCarID.Text = "Car ID";
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Location = new Point(38, 89);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(60, 15);
            lblCarName.TabIndex = 1;
            lblCarName.Text = "Car Name";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(38, 129);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(79, 15);
            lblManufacturer.TabIndex = 2;
            lblManufacturer.Text = "Manufacturer";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(445, 46);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price";
            // 
            // lblReleasedYear
            // 
            lblReleasedYear.AutoSize = true;
            lblReleasedYear.Location = new Point(445, 89);
            lblReleasedYear.Name = "lblReleasedYear";
            lblReleasedYear.Size = new Size(78, 15);
            lblReleasedYear.TabIndex = 4;
            lblReleasedYear.Text = "Released Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(133, 43);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(227, 23);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(133, 86);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(227, 23);
            txtCarName.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(133, 126);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(227, 23);
            txtManufacturer.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(538, 46);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(227, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(538, 89);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(227, 23);
            txtReleaseYear.TabIndex = 9;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(158, 172);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(83, 23);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(358, 172);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(83, 23);
            btnNew.TabIndex = 11;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(556, 172);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dvgCarList
            // 
            dvgCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCarList.Location = new Point(38, 226);
            dvgCarList.Name = "dvgCarList";
            dvgCarList.RowHeadersWidth = 51;
            dvgCarList.RowTemplate.Height = 25;
            dvgCarList.Size = new Size(716, 150);
            dvgCarList.TabIndex = 13;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(358, 401);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(83, 23);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(dvgCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lblReleasedYear);
            Controls.Add(lblPrice);
            Controls.Add(lblManufacturer);
            Controls.Add(lblCarName);
            Controls.Add(lblCarID);
            Name = "frmCarManagement";
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dvgCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCarID;
        private Label lblCarName;
        private Label lblManufacturer;
        private Label lblPrice;
        private Label lblReleasedYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private TextBox txtManufacturer;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dvgCarList;
        private Button btnClose;
    }
}