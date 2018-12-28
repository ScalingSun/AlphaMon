using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaMon
{
    public class Player
    {
        int userID = 0;
        string Username = "something";
        string UserPassword = "SomethingElse";
        int elo = 50;
        int wins = 0;
        int losses = 0;
        public Player()
        {
            Account account = new Account(userID, Username, UserPassword,elo,wins,losses);
            //AlphaMon Alphamon = new AlphaMon();
        }


    }
}
