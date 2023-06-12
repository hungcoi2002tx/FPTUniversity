using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        BindingSource source;

        private bool isAdmin;

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        private Member _member;

        public Member _Member
        {
            get { return _member; }
            set { _member = value; }
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            if (!IsAdmin)
            {
                btnDelete.Visible = false;
                btnAdd.Visible = false;
                btnLoad.Visible = false;
                dgvEmployeerList.Visible = false;
                txtTitle.Text = "My Infomation";                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        =>Close();
    }
}
