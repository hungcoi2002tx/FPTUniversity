using Microsoft.Data.SqlClient;

namespace DemoConntecdLayer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<dynamic> products = new List<dynamic>();
            string connectionString = "Server = (local) ; uid = sa; pw = 123; database = MyStore; TrustServerCertificate = true" +
                "Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand sql =new  SqlCommand("Select ProductName, UnitPrice from Products",connection);
            SqlDataReader reader = sql.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    products.Add(new
                    {
                        ProductName = reader.GetString("ProductName"),
                        UnitPrice = reader.GetDecimal("UnitPrice")
                    }) ;
                }
                dgv.DataSource = products ;
            }
        }
    }
}