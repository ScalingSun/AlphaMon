using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaMon
{
    public class UsedAlphaMon
    {
        public AlphaMon AlphamonData;
        public int currentHP;
        public int statusID;
        
        public UsedAlphaMon(AlphaMon AlphamonData)
        {
            this.AlphamonData = AlphamonData;
            this.currentHP = AlphamonData.HP;
        }
    }
}
