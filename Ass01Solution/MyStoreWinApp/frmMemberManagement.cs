using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private IMemberRepository memberRepository = new MemberRepository();

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

        private void Loading()
        {
            var members = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPass.DataBindings.Clear();
                txtCountry.DataBindings.Clear();



                txtMemberID.DataBindings.Add("Text", source, "ID");
                txtMemberName.DataBindings.Add("Text", source, "Name");
                txtCity.DataBindings.Add("Text", source, "City");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPass.DataBindings.Add("Text", source, "Pass");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvEmployeerList.DataSource = null;
                dgvEmployeerList.DataSource = source;

                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member List");
            }
        }

        private void ClearText()
        {
            txtMemberID.Text = "";
            txtMemberName.Text = "";
            txtCity.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            txtCountry.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        => Close();

        private void btnLoad_Click(object sender, EventArgs e) => Loading();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemberDetail memberDetail = new MemberDetail
            {
                InsertOrUpdate = true
            };

            if (memberDetail.ShowDialog() == DialogResult.OK)
            {
                Loading();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            memberRepository.DeleteMember(int.Parse(txtMemberID.Text));
            Loading();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void dgvEmployeerList_DoubleClick(object sender, EventArgs e)
        {
            MemberDetail memberDetail = new MemberDetail
            {
                InsertOrUpdate = false,
                member = memberRepository.GetMemberByID(int.Parse(txtMemberID.Text))
            };
            if (memberDetail.ShowDialog() == DialogResult.OK)
            {
                Loading();               
            }
        }
    }
}
