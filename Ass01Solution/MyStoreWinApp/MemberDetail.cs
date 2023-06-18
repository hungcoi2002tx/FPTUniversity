using BusinessObject;
using DataAccess.Repository;
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
    public partial class MemberDetail : Form
    {

        public MemberDetail()
        {
            InitializeComponent();
        }
        public Member member;

        private bool insertOrUpdate;

        private IMemberRepository memberRepository = new MemberRepository();
        public bool InsertOrUpdate
        {
            get { return insertOrUpdate; }
            set { insertOrUpdate = value; }
        }

        private void MemberDetail_Load(object sender, EventArgs e) => Loading();

        private void Loading()
        {
            if (!insertOrUpdate)
            {
                txtCity.Text = member.City;
                txtID.Text = member.Id.ToString();
                txtCountry.Text = member.Country;
                txtEmail.Text = member.Email;
                txtName.Text = member.Name;
                txtPass.Text = member.Pass;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Id = int.Parse(txtID.Text);
            member.Name = txtName.Text;
            member.Pass = txtPass.Text;
            member.City = txtCity.Text;
            member.Country = txtCountry.Text;
            member.Email = txtEmail.Text;
            if (!InsertOrUpdate)
            {
                MessageBox.Show("ID is exit", "Warming", MessageBoxButtons.OK);
            }
            else
            {
                if (memberRepository.GetMemberByID(member.Id) != null)
                {
                    memberRepository.UpdateMember(member);
                    MessageBox.Show("Update Succesfull", "Annotation", MessageBoxButtons.OK);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    memberRepository.AddMember(member);
                    MessageBox.Show("Insert Succesfull", "Annotation", MessageBoxButtons.OK);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
    }
}
