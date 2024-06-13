using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Come334_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            
            if (ValidateLogin(username, password))
            {
                
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
              
                lblMessage.Text = "Invalid username or password.";
            }
        }
        private bool ValidateLogin(string username, string password)
        {
            string filePath = "admin.csv";
           
            var lines = File.ReadAllLines(filePath);
           
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts[0] == username && parts[1] == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
   
