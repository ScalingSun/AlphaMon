using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Alphamon
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
        public List<GameForm> CalcData;
        
        public Stadium()
        { 
            P1.Show(); //the form for player1.
            P1.Name = "P1";
            P2.Show(); //the form for player2.
            P2.Name = "P2";

            //own AlphaMon Data
            Alphamon ownAlphaMon = DB.GetAlphamon("04d0611a4c5880");//5 is a random number, this should be changed based on the arduino input.
            UsedAlphamon OwnUsedAlphaMon = new UsedAlphamon(ownAlphaMon);


            //opponent AlphaMon Data
            Alphamon OpponentAlphamon = DB.GetAlphamon("04d5621a4c5880");//8 is a random number, this should be changed based on the arduino input.
            UsedAlphamon OpponentUsedAlphaMon = new UsedAlphamon(OpponentAlphamon);

            //get data from alphamon
            P1.setAlphamonData(this, OwnUsedAlphaMon, OpponentUsedAlphaMon);
            P2.setAlphamonData(this, OpponentUsedAlphaMon, OwnUsedAlphaMon);
        }

        public bool CheckPlayers()
        {
            bool clicked = false;
           
            if(P1.isClicked() == false && P2.isClicked() == false)
            {
                clicked = false;
            }
            else if(P1.isClicked() == true && P2.isClicked() == false)
            {
                clicked = false;
            }
            else if(P1.isClicked() == false && P2.isClicked() == true)
            {
                clicked = false;
            }
            else
            {
                clicked = true;
            }
            
            return clicked;
        }

        public void Attack(List<GameForm> Data)
        {
            this.CalcData = Data;
            foreach (GameForm test in CalcData)
            {
                Console.WriteLine(test.);
            }

        }
    }
}
