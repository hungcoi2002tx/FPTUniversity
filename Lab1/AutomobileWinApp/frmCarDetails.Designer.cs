namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            btnSave = new Button();
            btnCancel = new Button();
            lblCarID = new Label();
            lblCarName = new Label();
            lblManufacturer = new Label();
            lblPrice = new Label();
            lblReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtReleaseYear = new MaskedTextBox();
            txtPrice = new MaskedTextBox();
            cboManufacturer = new ComboBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(169, 284);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(263, 284);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblCarID
            // 
            lblCarID.AutoSize = true;
            lblCarID.Location = new Point(54, 64);
            lblCarID.Name = "lblCarID";
            lblCarID.Size = new Size(38, 15);
            lblCarID.TabIndex = 2;
            lblCarID.Text = "Car Id";
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Location = new Point(54, 107);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(60, 15);
            lblCarName.TabIndex = 3;
            lblCarName.Text = "Car Name";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(54, 156);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(79, 15);
            lblManufacturer.TabIndex = 4;
            lblManufacturer.Text = "Manufacturer";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(54, 189);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.Location = new Point(54, 229);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(71, 15);
            lblReleaseYear.TabIndex = 6;
            lblReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(151, 64);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(205, 23);
            txtCarID.TabIndex = 7;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(151, 107);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(205, 23);
            txtCarName.TabIndex = 12;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(151, 229);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(205, 23);
            txtReleaseYear.TabIndex = 15;
            txtReleaseYear.Text = "0";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(151, 189);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(205, 23);
            txtPrice.TabIndex = 16;
            txtPrice.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(151, 153);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(203, 23);
            cboManufacturer.TabIndex = 17;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 376);
            Controls.Add(cboManufacturer);
            Controls.Add(txtPrice);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lblReleaseYear);
            Controls.Add(lblPrice);
            Controls.Add(lblManufacturer);
            Controls.Add(lblCarName);
            Controls.Add(lblCarID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Label lblCarID;
        private Label lblCarName;
        private Label lblManufacturer;
        private Label lblPrice;
        private Label lblReleaseYear;
        private TextBox txtCarID;
        private TextBox txtManufacturer;
        private TextBox txtCarName;
        private MaskedTextBox txtReleaseYear;

        private MaskedTextBox txtPrice;
        private ComboBox cboManufacturer;
    }
}