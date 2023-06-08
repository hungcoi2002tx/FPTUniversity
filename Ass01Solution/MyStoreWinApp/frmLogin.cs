using Newtonsoft.Json;
using System.IO;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("appsettings.json");

            dynamic config = JsonConvert.DeserializeObject(json);
            string emailAdmin = config.Credentials.Username;
            string passAdmin = config.Credentials.Password;

            String email = txtEmail.Text;
            String pass = txtPass.Text; 

        }
 
    }
}