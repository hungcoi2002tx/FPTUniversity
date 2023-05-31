using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1HoanDt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPass.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "hung" &&  txtPass.Text == "123")
            {
                frmMainForm frmMainForm = new frmMainForm();
                frmMainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("login fail", "sai roi ",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                BtnLogOut_Click(null, null);
            }
        }
    }
}
