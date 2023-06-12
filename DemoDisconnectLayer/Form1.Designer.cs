namespace DemoDisconnectLayer
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
            button1 = new Button();
            btnViewCategory = new Button();
            btnClose = new Button();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(33, 26);
            button1.Name = "button1";
            button1.Size = new Size(246, 50);
            button1.TabIndex = 0;
            button1.Text = "View Products";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnViewCategory
            // 
            btnViewCategory.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewCategory.Location = new Point(448, 26);
            btnViewCategory.Name = "btnViewCategory";
            btnViewCategory.Size = new Size(248, 50);
            btnViewCategory.TabIndex = 1;
            btnViewCategory.Text = "View Categories";
            btnViewCategory.UseVisualStyleBackColor = true;
            btnViewCategory.Click += btnViewCategory_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(273, 376);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(218, 47);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(33, 100);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 29;
            dgvData.Size = new Size(730, 255);
            dgvData.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvData);
            Controls.Add(btnClose);
            Controls.Add(btnViewCategory);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyStore";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnViewCategory;
        private Button btnClose;
        private DataGridView dgvData;
    }
}