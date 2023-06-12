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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btnLoad = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            txtTitle = new Label();
            dgvEmployeerList = new DataGridView();
            button1 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(169, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(169, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(524, 93);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(188, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(524, 134);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(188, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(524, 171);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(188, 23);
            textBox6.TabIndex = 11;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(143, 209);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 46);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(315, 209);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 46);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(496, 209);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 46);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
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
            // 
            // button1
            // 
            button1.Location = new Point(664, 209);
            button1.Name = "button1";
            button1.Size = new Size(75, 46);
            button1.TabIndex = 17;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dgvEmployeerList);
            Controls.Add(txtTitle);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnDelete;
        private Label txtTitle;
        private DataGridView dgvEmployeerList;
        private Button button1;
    }
}