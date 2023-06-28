namespace Pe_Example
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
            dgvList = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtSalary = new NumericUpDown();
            txtPhone = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSalary).BeginInit();
            SuspendLayout();
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(23, 64);
            dgvList.Name = "dgvList";
            dgvList.RowTemplate.Height = 25;
            dgvList.Size = new Size(816, 543);
            dgvList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(865, 64);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Action";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(865, 197);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 2;
            label2.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(868, 353);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(868, 426);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 4;
            label4.Text = "Phone";
            // 
            // txtName
            // 
            txtName.Location = new Point(990, 194);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 23);
            txtName.TabIndex = 7;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(990, 350);
            txtSalary.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(127, 23);
            txtSalary.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(990, 423);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(221, 23);
            txtPhone.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(883, 509);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 59);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1010, 509);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(77, 59);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1134, 509);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 59);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radMale.Location = new Point(990, 271);
            radMale.Name = "radMale";
            radMale.Size = new Size(60, 24);
            radMale.TabIndex = 5;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = true;
            radMale.CheckedChanged += radMale_CheckedChanged;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radFemale.Location = new Point(1095, 271);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(75, 24);
            radFemale.TabIndex = 6;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = true;
            radFemale.CheckedChanged += radFemale_CheckedChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(927, 599);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 649);
            Controls.Add(txtID);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPhone);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private NumericUpDown txtSalary;
        private TextBox txtPhone;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private RadioButton radMale;
        private RadioButton radFemale;
        private TextBox txtID;
    }
}