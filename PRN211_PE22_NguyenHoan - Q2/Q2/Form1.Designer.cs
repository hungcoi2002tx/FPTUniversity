namespace Q2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            cboCourtesy = new ComboBox();
            cboDepartment = new ComboBox();
            dtpDOB = new DateTimePicker();
            btnAdd = new Button();
            dgvEmployees = new DataGridView();
            btnInsertAll = new Button();
            dgvList = new DataGridView();
            btnUpdate = new Button();
            txtID = new TextBox();
            label7 = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 67);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 118);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(570, 26);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "Title of Courtesy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(570, 71);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(570, 123);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 4;
            label5.Text = "Date of Birth";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(318, 64);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(181, 27);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(318, 118);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(181, 27);
            txtLastName.TabIndex = 7;
            // 
            // cboCourtesy
            // 
            cboCourtesy.FormattingEnabled = true;
            cboCourtesy.Items.AddRange(new object[] { "Dr.", "Mr.", "Mrs.", "Ms." });
            cboCourtesy.Location = new Point(711, 26);
            cboCourtesy.Margin = new Padding(3, 4, 3, 4);
            cboCourtesy.Name = "cboCourtesy";
            cboCourtesy.Size = new Size(52, 28);
            cboCourtesy.TabIndex = 8;
            // 
            // cboDepartment
            // 
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Location = new Point(711, 71);
            cboDepartment.Margin = new Padding(3, 4, 3, 4);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(228, 28);
            cboDepartment.TabIndex = 9;
            cboDepartment.ValueMember = "DepartmentID";
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(711, 123);
            dtpDOB.Margin = new Padding(3, 4, 3, 4);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(247, 27);
            dtpDOB.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(973, 49);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 56);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 174);
            dgvEmployees.Margin = new Padding(3, 4, 3, 4);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.RowTemplate.Height = 25;
            dgvEmployees.Size = new Size(728, 275);
            dgvEmployees.TabIndex = 12;
            // 
            // btnInsertAll
            // 
            btnInsertAll.Location = new Point(1124, 49);
            btnInsertAll.Margin = new Padding(3, 4, 3, 4);
            btnInsertAll.Name = "btnInsertAll";
            btnInsertAll.Size = new Size(108, 56);
            btnInsertAll.TabIndex = 13;
            btnInsertAll.Text = "Insert All into Database";
            btnInsertAll.UseVisualStyleBackColor = true;
            btnInsertAll.Click += btnInsertAll_Click;
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(769, 174);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 51;
            dgvList.RowTemplate.Height = 29;
            dgvList.Size = new Size(758, 275);
            dgvList.TabIndex = 14;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1253, 49);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 56);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(318, 21);
            txtID.Name = "txtID";
            txtID.Size = new Size(51, 27);
            txtID.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(183, 23);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 17;
            label7.Text = "Employee ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1365, 49);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 56);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1532, 460);
            Controls.Add(btnDelete);
            Controls.Add(label7);
            Controls.Add(txtID);
            Controls.Add(btnUpdate);
            Controls.Add(dgvList);
            Controls.Add(btnInsertAll);
            Controls.Add(dgvEmployees);
            Controls.Add(btnAdd);
            Controls.Add(dtpDOB);
            Controls.Add(cboDepartment);
            Controls.Add(cboCourtesy);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
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
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox cboCourtesy;
        private ComboBox cboDepartment;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private DataGridView dgvEmployees;
        private Button button2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DateTimePicker dtpDOB;
        private Button btnAdd;
        private Button btnInsertAll;
        private DataGridView dataGridView1;
        private DataGridView dgvList;
        private Button btnUpdate;
        private TextBox txtID;
        private Label label7;
        private Button btnDelete;
    }
}