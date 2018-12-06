using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaMon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            frmRegister.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txbUsername.Text;
            string Password = txbPassword.Text;
            DB login = new DB();
            Account Userdata = login.LoginFunction(Username, Password);
            if (Userdata != null)
            {
                MessageBox.Show("banana");
                /*this.Hide();
                ProfileForm frm = new ProfileForm(Userdata);
                frm.Show();*/
            }
            else
            {
                MessageBox.Show("Foutieve login!");
            }
        }
    }
}
