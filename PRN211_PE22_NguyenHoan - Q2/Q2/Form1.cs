using Microsoft.EntityFrameworkCore;
using Q2.Models;

namespace Q2
{
    public partial class Form1 : Form
    {
        private readonly PRN_Sum22_B1Context _context = new PRN_Sum22_B1Context();
        private List<Employee> _employees = new List<Employee>();
        BindingSource source;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCourtesy.SelectedIndex = 0;
            cboDepartment.DataSource = _context.Departments.ToList();
            LoadEmployeesList();
        }
        private void LoadEmployeesList()
        {
            var employees = _context.Employees.Select(e => new
            {
                e.EmployeeId,
                e.FirstName,
                e.LastName,
                e.TitleOfCourtesy,
                Department = e.Department.DepartmentName,
                e.BirthDate
            }).ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = employees;


                txtFirstName.DataBindings.Clear();
                txtLastName.DataBindings.Clear();
                cboCourtesy.DataBindings.Clear();
                cboDepartment.DataBindings.Clear();
                dtpDOB.DataBindings.Clear();
                txtID.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "EmployeeId");
                txtFirstName.DataBindings.Add("Text", source, "FirstName");
                txtLastName.DataBindings.Add("Text", source, "LastName");
                cboCourtesy.DataBindings.Add("Text", source, "TitleOfCourtesy");
                cboDepartment.DataBindings.Add("Text", source, "Department");
                dtpDOB.DataBindings.Add("Value", source, "BirthDate");

                dgvList.DataSource = null;
                dgvList.DataSource = source;
                dgvList.Columns["EmployeeId"].Visible = false;
                dgvList.Columns["BirthDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Employee list");
            }
        }
        private Employee GetEmployeeObject()
        {
            Employee employee = new Employee()
            {
                EmployeeId = int.Parse(txtID.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                TitleOfCourtesy = cboCourtesy.Text,
                Department = cboDepartment.SelectedItem as Department,
                BirthDate = dtpDOB.Value
            };
            return employee;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                TitleOfCourtesy = cboCourtesy.Text,
                Department = cboDepartment.SelectedItem as Department,
                BirthDate = dtpDOB.Value
            };
            _employees.Add(employee);
            dgvEmployees.DataSource = _employees.Select(e => new
            {
                e.FirstName,
                e.LastName,
                e.TitleOfCourtesy,
                DepartmentName = e.Department.DepartmentName,
                e.BirthDate
            }).ToList();
            dgvEmployees.Columns["BirthDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnInsertAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (_employees != null)
                {
                    _context.Employees.AddRange(_employees);
                    _context.SaveChanges();
                    LoadEmployeesList();
                    MessageBox.Show($"Inserted {_employees.Count} Employees succcessful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Employeess");
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee employee = GetEmployeeObject();
            _context.Employees.Update(employee);
            _context.SaveChanges();
            LoadEmployeesList();
            MessageBox.Show($"Update Employee with ID: {employee.EmployeeId}  succcessful");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Employee employee = GetEmployeeObject();
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            LoadEmployeesList();
            MessageBox.Show($"Removed Employee with ID: {employee.EmployeeId}  succcessful");
        }
    }
}