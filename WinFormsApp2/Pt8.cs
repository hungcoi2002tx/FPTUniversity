using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Pt8 : Form
    {
        public Pt8()
        {
            InitializeComponent();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox groupBox = (GroupBox)sender;
            Rectangle borderRect = new Rectangle(0, 0, groupBox.Width - 1, groupBox.Height - 1);

            // Đặt màu và độ dày cho viền trong
            Color innerBorderColor = Color.Black;
            int innerBorderWidth = 2;

            // Vẽ viền trong
            using (Pen pen = new Pen(innerBorderColor, innerBorderWidth))
            {
                e.Graphics.DrawRectangle(pen, borderRect);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void Pt8_Load(object sender, EventArgs e)
        {

        }
    }
}
