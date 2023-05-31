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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text.Equals("1"))
            {
                btn2.Text = "";
                btn1.Text = "1";
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text.Equals("1"))
            {
                btn1.Text = "";
                btn2.Text = "1";
            }
        }
    }
}
