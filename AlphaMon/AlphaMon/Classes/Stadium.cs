using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public CalcDamage Calc;
        

        public Stadium()
        {
             
            P1.Show(); //the form for player1.
            P2.Show(); //the form for player2.

            //own AlphaMon Data
            AlphaMon ownAlphaMon = DB.GetAlphamon(10);//5 is a random number, this should be changed based on the arduino input.
            UsedAlphaMon OwnUsedAlphaMon = new UsedAlphaMon(ownAlphaMon);


            //opponent AlphaMon Data
            AlphaMon OpponentAlphamon = DB.GetAlphamon(11);//8 is a random number, this should be changed based on the arduino input.
            UsedAlphaMon OpponentUsedAlphaMon = new UsedAlphaMon(OpponentAlphamon);

            //get data from pokemon
            P1.setAlphamonData(OwnUsedAlphaMon, OpponentUsedAlphaMon);
            P2.setAlphamonData(OpponentUsedAlphaMon, OwnUsedAlphaMon);
            while (true) {
                if (P1.isClicked() && P2.isClicked())
                {
                    MessageBox.Show("both players clicked");
                }
            }



            Calc = new CalcDamage(OwnUsedAlphaMon, OpponentUsedAlphaMon);
        }
        public void InitiateAttack()
        {

        }

    }
}
