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
    public partial class ProfileForm : Form
    {
        public ProfileForm(Account userdata)
        {
            InitializeComponent();
            label1.Text = "ID: " + userdata.id.ToString();
            label2.Text = "Voornaam: " + userdata.username;
            label3.Text = "Wachtwoord: " + userdata.password;
            label4.Text = "Elo: " + userdata.elo.ToString();
            label5.Text = "Wins: " + userdata.wins.ToString();
            label6.Text = "Losses: " + userdata.losses.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();


        }
    }
}
