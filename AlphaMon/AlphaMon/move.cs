using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaMon
{
    public class Move
    {
        public int id;
        public string name;
        public int power;
        public int type;
        public string description;
        public int statuschance;
        public int status;
        public Move(int id, string name, int power, int type, string description, int statuschance, int status)
        {
            this.id = id;
            this.name = name;
            this.power = power;
            this.type = type;
            this.description = description;
            this.statuschance = statuschance;
            this.status = status;
        }
    }
}
