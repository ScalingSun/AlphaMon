using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaMon
{
    public class Account
    {
        GameRecord record = new GameRecord();
        public int id { get; private set;}
        public string username { get; private set; }
        public string password { get; private set; }
        public int elo { get; private set; }
        public int wins { get; private set; }
        public int losses { get; private set; }
        public Account(int ID, string Username, string Password, int elo, int wins, int losses)
        {
            this.id = ID;
            this.username = Username;
            this.password = Password;
            this.elo = elo;
            this.wins = wins;
            this.losses = losses;
        }
    }
}
