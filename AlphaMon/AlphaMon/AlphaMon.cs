using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaMon
{
    public class AlphaMon
    {
        public int id;
        public string name;
        public int type;
        public int SpDefense;
        public int SpAttack;
        public int Attack;
        public int Defense;
        public int Speed;
        public int HP;
        DB DB = new DB();
        public List<Move> moves = new List<Move>();
        public AlphaMon(int id,string name,int type, int SpDefense, int SpAttack, int Attack, int Defense, int Speed,int HP)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.SpDefense = SpDefense;
            this.SpAttack = SpAttack;
            this.Attack = Attack;
            this.Defense = Defense;
            this.Speed = Speed;
            this.HP = HP;
            moves = DB.GetMoves(id);
        }
        
        
    }
}
