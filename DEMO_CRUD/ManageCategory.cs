using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_CRUD
{
    public record Category
    {
        private int categoryID;

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        private String categoryName;

        public String CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }


    }
    internal class ManageCategory
    {

        SqlConnection connection;

        SqlCommand command;
        string connectionString = "Server=(local)" +
            ";uid=sa;pwd=123;database=MyStore;" +
            "TrustServerCertificate=true;"+
            "Integrated Security= true";
        public List<Category> GetCategories() {
            List<Category> categories = new List<Category>();
            connection = new SqlConnection(connectionString);
            String query = "Select * from Categories";
            command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (sqlDataReader.Read())
                {
                    categories.Add(new Category
                    {
                        CategoryID = sqlDataReader.GetInt32(0),
                        CategoryName = sqlDataReader.GetString(1)
                    });
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close(); 
            }
            return categories;
        }

        public void InsertCategories(Category category)
        {
            connection = new SqlConnection(connectionString);
            string query = "Insert Categories values(@CategoryID,@CategoryName)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryID", category.CategoryID);
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }

        }
        public void UpdateCategories(Category category)
        {
            connection = new SqlConnection(connectionString);
            string query = "Update Categories set CategoryName=@CategoryName where CategoryID = @CategoryID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryID", category.CategoryID);
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); } 
        }

        public void DeleteCategories(Category category)
        {
            connection = new SqlConnection(connectionString);
            string query = "Delete Case Categories where CategoryID = @CategoryID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryID", category.CategoryID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }
        }
    }
}
