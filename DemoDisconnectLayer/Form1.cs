using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace DemoDisconnectLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataSet dsData = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Server = (local);" + "uid=sa;pwd=123;database=MyStore;TrustServerCertificate=true;"
                + "Integrated Security = true";
            string query = "Select ProductID, ProductName, UnitInStock from Products;"
                + "Select * from Categories";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
                adapter.Fill(dsData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dsData.Tables[0];
        }

        private void btnViewCategory_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dsData.Tables[1];
        }
    }
}