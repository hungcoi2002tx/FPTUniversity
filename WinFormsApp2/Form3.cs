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
            if (!btn2.Text.Equals(""))
            {

                if (btn1.Text.Equals(""))
                {
                    btn1.Text = btn2.Text;
                    btn2.Text = "";
                }
                else if (btn4.Text.Equals(""))
                {
                    btn4.Text = btn2.Text;
                    btn2.Text = "";
                }
                
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!btn1.Text.Equals(""))
            {

                if (btn2.Text.Equals(""))
                {
                    btn2.Text = btn1.Text;
                    btn1.Text = "";
                }
                else if (btn3.Text.Equals(""))
                {
                    btn3.Text = btn1.Text;
                    btn1.Text = "";
                }

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!btn3.Text.Equals(""))
            {

                if (btn1.Text.Equals(""))
                {
                    btn1.Text = btn3.Text;
                    btn3.Text = "";
                }
                else if (btn4.Text.Equals(""))
                {
                    btn4.Text = btn3.Text;
                    btn3.Text = "";
                }
                
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!btn4.Text.Equals(""))
            {

                if (btn2.Text.Equals(""))
                {
                    btn2.Text = btn4.Text;
                    btn4.Text = "";
                }
                else if (btn3.Text.Equals(""))
                {
                    btn3.Text = btn4.Text;
                    btn4.Text = "";
                }
                
            }
        }
    }
}
