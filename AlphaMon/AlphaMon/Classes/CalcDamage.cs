using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaMon
{
    public class CalcDamage
    {
        // damage = 2 x level (50) / 5 + 2. (always 22).
        // damage2 = 22 * Power * Attack value / defense value / 50 + 2.
        // modifier = targets * weather * badge * critical * random * STAB * type * burn;
        // which realisticly results into:
        // modifier = 1 * 1 * 1 * 1 * STAB * Type * 1;
        //result = damage2 * modifier;

        UsedAlphaMon alphamonData;
        UsedAlphaMon OpponentAlphamonData;
        bool player1;
        bool player2;
        int player;
        int power;

        public CalcDamage(UsedAlphaMon AlphamonData, UsedAlphaMon OpponentAlphamonData)
        {
            this.alphamonData = AlphamonData;
            this.OpponentAlphamonData = OpponentAlphamonData;
        }
        public void Attack(int power)
        {
            this.power = power;
            player = DecideTurn();
            if (player == 1)
            {
                int secondplayer = 2;
                Calculate(player, secondplayer);
            }
            if (player == 2)
            {
                int secondplayer = 1;
                Calculate(player, secondplayer);
                //p2 goes first
            }
        }
        public int DecideTurn()
        {
            if(alphamonData.AlphamonData.Speed >= OpponentAlphamonData.AlphamonData.Speed)
            {
                player = 1;
                return  player;
            }
            else
            {
                player = 2;
                return player;
            }
        }
        private double Calculate(int player,int secondplayer)
        {
            int P1power = 80; //dummy data
            int p1attack = 100; // dummydata
            int P2Defense = 100; //dummydata
            if (player == 1)
            {
                
                bool IsSTAB = false;
                double STAB = 1;

                if (IsSTAB)
                {
                    //if move == alphamontype
                    STAB = 1.5;
                }
                double type = 1;
                if (type == type)
                {
                    //calc in this if, if the damage value.
                }
                bool isBurn = false;
                double burn = 1;
                if(alphamonData.statusID == 2)
                {
                    burn = 0.5;
                }
                int twentytwo = 2 * 50 / 5 + 2;
                
                int result1 = twentytwo * P1power * p1attack / P2Defense / 50 + 2;
                double modifier = STAB * type * burn;
                double damage = result1 * modifier;
                //twentytwo = twentytwo + alphamonData.AlphamonData.moves.Select(item => item.name).ToArray();
                //OpponentAlphamonData.currentHP - 
                //p1 goes first
                return damage;
            }
            return player;
        }
    }
}
