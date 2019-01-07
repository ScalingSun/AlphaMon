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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string Username = txtUsernameRegister.Text;
            string Password = txtPasswordRegister.Text;

            DB Register = new DB();
            bool boolean = Register.RegisterQuery(Username, Password);
            if(boolean)
            {
                MessageBox.Show("Register succes!");
                Login frmLogin = new Login();
                frmLogin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Register failed, try again");
                txtUsernameRegister.Text = "";
                txtPasswordRegister.Text = "";
            }
        }
    }
}
