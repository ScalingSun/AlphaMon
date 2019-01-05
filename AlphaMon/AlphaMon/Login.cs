using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alphamon
{
    public partial class Login : Form
    {
        public event EventHandler<Account> test;
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string Username = txbUsername.Text;
            string Password = txbPassword.Text;
            DB register = new DB();
            bool IsRegistered = register.RegisterQuery(Username, Password);
            if (IsRegistered) {
                MessageBox.Show("je bent succesvol geregistreerd!");
            }
            else
            {
                MessageBox.Show("Registreren gefaald!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txbUsername.Text;
            string Password = txbPassword.Text;
            DB login = new DB();
            Account Userdata = login.LoginFunction(Username, Password);
            if (Userdata != null)
            {
                test.Invoke(this, Userdata);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Foutieve login!");
            }
        }
    }
}
