
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using DataAccess.Repository;
using BusinessObject;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private IMemberRepository MemberRepository = new MemberRepository();
        private frmMemberManagement frmMemberManagement;  

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("appsettings.json");

            dynamic config = JsonConvert.DeserializeObject(json);
            string emailAdmin = config.Credentials.Username;
            string passAdmin = config.Credentials.Password;

            String email = txtEmail.Text;
            String pass = txtPass.Text;
            Member member = new Member()
            {
                Email = email,
                Pass = pass,
            };

            if (emailAdmin.Equals(email) && passAdmin.Equals(pass))
            {
                frmMemberManagement = new frmMemberManagement
                {
                    IsAdmin = true
                };
                this.Hide();
                var a = frmMemberManagement.ShowDialog();
                this.Close();               
            }          
            else if (MemberRepository.check(member) != null)
            {
                frmMemberManagement = new frmMemberManagement
                {
                    IsAdmin = false,
                    _Member = (Member)MemberRepository.check(member)

                };
                this.Hide();
                var a = frmMemberManagement.ShowDialog();
                this.Close();
            }
            else
            {
                lblError.Visible = true;
                txtEmail.Text = "";
                txtPass.Text = "";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        => Close();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}