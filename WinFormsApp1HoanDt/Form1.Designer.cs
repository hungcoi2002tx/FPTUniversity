namespace WinFormsApp1HoanDt
{
    partial class frmMainForm
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
            components = new System.ComponentModel.Container();
            btnLogin = new Button();
            btnReset = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            xemPhimLạnhToolStripMenuItem = new ToolStripMenuItem();
            xemPhimChấnThànhToolStripMenuItem = new ToolStripMenuItem();
            xemPhimTháiBéoToolStripMenuItem = new ToolStripMenuItem();
            phimNóngToolStripMenuItem = new ToolStripMenuItem();
            phimLạnhToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            aToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(126, 176);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 22);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(224, 176);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(82, 22);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(429, 109);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(429, 131);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 112);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 142);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "PassWord";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 112);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 142);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '3';
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(224, 215);
            maskedTextBox1.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(110, 23);
            maskedTextBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "kha", "an ", "cut" });
            comboBox1.Location = new Point(280, 258);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(429, 231);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(216, 96);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 231);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 96);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(224, 303);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 12;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(280, 80);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(200, 100);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 72);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, xemPhimLạnhToolStripMenuItem, xemPhimChấnThànhToolStripMenuItem, xemPhimTháiBéoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(110, 20);
            toolStripMenuItem1.Text = "Xem &sphim nóng";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // xemPhimLạnhToolStripMenuItem
            // 
            xemPhimLạnhToolStripMenuItem.Name = "xemPhimLạnhToolStripMenuItem";
            xemPhimLạnhToolStripMenuItem.Size = new Size(100, 20);
            xemPhimLạnhToolStripMenuItem.Text = "Xem phim lạnh";
            // 
            // xemPhimChấnThànhToolStripMenuItem
            // 
            xemPhimChấnThànhToolStripMenuItem.Name = "xemPhimChấnThànhToolStripMenuItem";
            xemPhimChấnThànhToolStripMenuItem.Size = new Size(137, 20);
            xemPhimChấnThànhToolStripMenuItem.Text = "Xem phim chấn thành";
            // 
            // xemPhimTháiBéoToolStripMenuItem
            // 
            xemPhimTháiBéoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { phimNóngToolStripMenuItem, phimLạnhToolStripMenuItem });
            xemPhimTháiBéoToolStripMenuItem.Name = "xemPhimTháiBéoToolStripMenuItem";
            xemPhimTháiBéoToolStripMenuItem.Size = new Size(120, 20);
            xemPhimTháiBéoToolStripMenuItem.Text = "Xem phim thái béo";
            // 
            // phimNóngToolStripMenuItem
            // 
            phimNóngToolStripMenuItem.Name = "phimNóngToolStripMenuItem";
            phimNóngToolStripMenuItem.Size = new Size(133, 22);
            phimNóngToolStripMenuItem.Text = "phim nóng";
            // 
            // phimLạnhToolStripMenuItem
            // 
            phimLạnhToolStripMenuItem.Name = "phimLạnhToolStripMenuItem";
            phimLạnhToolStripMenuItem.Size = new Size(133, 22);
            phimLạnhToolStripMenuItem.Text = "phim lạnh";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 316);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(700, 22);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "â";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(44, 17);
            toolStripStatusLabel1.Text = "aduma";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(81, 26);
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(80, 22);
            aToolStripMenuItem.Text = "a";
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            ContextMenuStrip = contextMenuStrip2;
            Controls.Add(statusStrip1);
            Controls.Add(tabControl1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btnReset);
            Controls.Add(btnLogin);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMainForm";
            Text = "Main Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnReset;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem xemPhimLạnhToolStripMenuItem;
        private ToolStripMenuItem xemPhimChấnThànhToolStripMenuItem;
        private ToolStripMenuItem xemPhimTháiBéoToolStripMenuItem;
        private ToolStripMenuItem phimNóngToolStripMenuItem;
        private ToolStripMenuItem phimLạnhToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem aToolStripMenuItem;
    }
}