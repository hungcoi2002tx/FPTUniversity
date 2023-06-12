using Newtonsoft.Json;
using System;

using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string json = File.ReadAllText("appsettings.json");

        dynamic config = JsonConvert.DeserializeObject(json);
            string username = config.Credentials.Username;
        string password = config.Credentials.Password;

        Console.WriteLine("Username: " + username);
        Console.WriteLine("Password: " + password);
        }
    }
}