using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.Common;

namespace DemoDataProviderFactory
{
    static String GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
        var strConnection = config["ConnectionStirngs:MyStoreDB"];
            return strConnection;

    }
    static void ViewProducts()
    {
        DbProviderFactory factory = SqlClientFactory.Instance;
        using DbConnection connection = factory.CreateConnection();
        if(connection == null)
        {
            Console.WriteLine($"Unable create the connection object");
            return;
        }
        connection.ConnectionString = GetConnectionString();
        connection.Open();
        DbCommand command = factory.CreateCommand();
        if(command == null)
        {
            Console.WriteLine("Unable create the command object!");
        }
        command.CommandText = "Select ProductID, ProductName from Products";
        using DbDataReader dbDataReader = command.ExecuteReader();
        while (dbDataReader != null) {
            Console.WriteLine($"ProductID: {}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}