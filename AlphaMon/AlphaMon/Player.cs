using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaMon
{
    class Player
    {
        int userID = 0;
        string Username = "something";
        string UserPassword = "SomethingElse";
        public Player()
        {
            Account account = new Account(userID, Username, UserPassword);
            AlphaMon Alphamon = new AlphaMon();
        }


    }
}
