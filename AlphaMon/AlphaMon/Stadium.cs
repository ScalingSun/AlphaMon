using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaMon
{
    public class Stadium
    {
        public Player player1 = new Player();
        public Player player2 = new Player();
        public GameSession Session = new GameSession();
        public DB DB = new DB();
        public GameForm P1 = new GameForm();
        public GameForm P2 = new GameForm();


        public Stadium()
        {
            P1.Show();
            P2.Show();

            //own AlphaMon Data
            AlphaMon ownAlphaMon = DB.GetAlphamon(5);
            UsedAlphaMon OwnUsedAlphaMon = new UsedAlphaMon(ownAlphaMon);
            


            //opponent AlphaMon Data
            AlphaMon OpponentAlphamon = DB.GetAlphamon(8);
            UsedAlphaMon OpponentUsedAlphaMon = new UsedAlphaMon(OpponentAlphamon);
            

            P1.setAlphamonData(OwnUsedAlphaMon, OpponentUsedAlphaMon);
            P2.setAlphamonData(OpponentUsedAlphaMon, OwnUsedAlphaMon);
            //get data from pokemon


        }
        

    }
}
