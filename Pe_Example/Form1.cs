using Microsoft.EntityFrameworkCore;
using Pe_Example.Models;

namespace Pe_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PE_PRN_Sum21Context dbContext = new PE_PRN_Sum21Context();
        BindingSource source;
        private void Form1_Load(object sender, EventArgs e)
        {

            running();

        }

        private void running()
        {
            txtID.Hide();
            var employees = dbContext.Employees.Select(e => new
            {
                e.EmployeeId,
                e.EmployeeName,
                e.Male,
                e.Salary,
                e.Phone
            }).ToList();

            try
            {
                if (employees.Count != 0)
                {
                    radMale.Checked = true;
                }
                source = new BindingSource();
                source.DataSource = employees;


                txtName.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtSalary.DataBindings.Clear();
                txtID.DataBindings.Clear();
                radMale.DataBindings.Clear();
                radFemale.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "EmployeeId");
                txtName.DataBindings.Add("Text", source, "EmployeeName");
                txtPhone.DataBindings.Add("Text", source, "Phone");
                txtSalary.DataBindings.Add("Value", source, "Salary");
                radMale.DataBindings.Add("Checked", source, "Male");


                dgvList.DataSource = null;
                dgvList.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Employee list");
            }
        }

        private void radMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radMale.Checked)
            {
                radFemale.Checked = false;
            }
            else
            {
                radFemale.Checked = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radFemale_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                EmployeeName = txtName.Text,
                Phone = txtPhone.Text,
                Salary = (float)txtSalary.Value,
                Male = radMale.Checked
            };
            dbContext.Add(employee);
            dbContext.SaveChanges();
            running();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            Employee employee = dbContext.Employees.FirstOrDefault(
                    e1 => e1.EmployeeId == id
                );
            employee.EmployeeName = txtName.Text;
            employee.Phone = txtPhone.Text;
            employee.Salary =(float) txtSalary.Value;
            employee.Male = radMale.Checked;
            dbContext.Employees.Update(employee);
            dbContext.SaveChanges();
            running();
        }
    }
}