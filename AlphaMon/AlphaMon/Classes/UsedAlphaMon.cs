using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphamon
{
    public class UsedAlphamon
    {
        public Alphamon AlphamonData;
        public int currentHP;
        public int statusID;
        
        public UsedAlphamon(Alphamon AlphamonData)
        {
            this.AlphamonData = AlphamonData;
            this.currentHP = AlphamonData.HP;
        }
    }
}
