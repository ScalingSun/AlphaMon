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
    public partial class Menu : Form
    {
        Button loginP1 = new Button();
        Button loginP2 = new Button();
        Account userdataP1;
        Account userdataP2;
        int toplocation = 120;
        int leftlocation = 80;
        int buttonwidth = 85;
        int buttonheight = 23;
        int leftlocation2 = 640;
        public Menu()
        {
            InitializeComponent();

            loginP1 = CreateButton(toplocation, leftlocation,buttonwidth,buttonheight, "btnPlayer1login", "Login speler 1");
            loginP1.Click += loginP1_Click;
            loginP2 = CreateButton(toplocation, leftlocation2, buttonwidth, buttonheight, "btnPlayer2login", "Login speler 2");
            loginP2.Click += LoginP2_Click;
        }


        private void loginP1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginP1form = new Login();
            loginP1form.Show();
            loginP1form.test += GetData;
        }
        private void LoginP2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginP2form = new Login();
            loginP2form.Show();
            loginP2form.test += GetData2;
        }
        /// <summary>
        /// gets and sets the data for player 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="Userdata"></param>
        public void GetData(object sender, Account Userdata)
        {
            this.userdataP1 = Userdata;
            lblP1.Text = "gebruikersnaam: " + Userdata.username;
            lblP1Elo.Text = "elo: " + Userdata.elo.ToString();
            lblP1Wins.Text = "wins: " + Userdata.wins.ToString();
            lblP1Losses.Text = "losses: " + Userdata.losses.ToString();
            this.Show();
            this.Controls.Remove(loginP1);
            Button ProfileP1 = new Button();
            ProfileP1 = CreateButton(toplocation, leftlocation, buttonwidth, buttonheight, "btnProfileP1", "Profiel P1");
            ProfileP1.Click += ProfileP1_Click;
        }
        /// <summary>
        /// gets and sets the data for player 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="Userdata"></param>
        public void GetData2(object sender, Account Userdata)
        {
            this.userdataP2 = Userdata;
            label2.Text = "gebruikersnaam: " + Userdata.username;
            lblP2elo.Text = "elo: " + Userdata.elo.ToString();
            lblP2wins.Text = "wins: " + Userdata.wins.ToString();
            lblP2losses.Text = "losses: " + Userdata.losses.ToString();
            this.Show();
            this.Controls.Remove(loginP2);
            Button ProfileP2 = new Button();
            ProfileP2 = CreateButton(toplocation, leftlocation2, buttonwidth, buttonheight, "btnProfileP2", "Profiel P2");
            ProfileP2.Click += ProfileP2_Click;
        }
        private void ProfileP1_Click(object sender, EventArgs e)
        {
            ProfileForm ProfileP1 = new ProfileForm(userdataP1);
            ProfileP1.Show();
        }

        private void ProfileP2_Click(object sender, EventArgs e)
        {
            ProfileForm ProfileP2 = new ProfileForm(userdataP2);
            ProfileP2.Show();
        }
        public Button CreateButton(int top, int left, int width, int height, string name, string text)
        {
            Button createdbutton = new Button();
            createdbutton.Name = name;
            createdbutton.Text = text;
            createdbutton.Left = left;
            createdbutton.Top = top;
            createdbutton.Width = width;
            createdbutton.Height = height;
            this.Controls.Add(createdbutton);
            return createdbutton;
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (userdataP1 != null && userdataP2 != null)
            {
                Stadium StartGame = new Stadium();
            }
            else
            {
                MessageBox.Show("Please Log into both account first!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userdataP1 != null)
            {
                Stadium StartGame = new Stadium();
            }
            else
            {
                MessageBox.Show("Please Log into Player 1 first!");
            }
        }
    }
}
