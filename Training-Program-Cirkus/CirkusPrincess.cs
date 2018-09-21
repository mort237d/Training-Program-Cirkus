using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Program_Cirkus
{
    class CirkusPrincess
    {
        private string Name;
        private int Age;
        private bool Beautiful;

        public CirkusPrincess(string Name, int Age, bool Beautiful)
        {
            this.Name = Name;
            this.Age = Age;
            this.Beautiful = Beautiful;
        }

        public override string ToString()
        {
            return "My name is " + Name + " and i'm " + Beautiful + " princess at the age of " + Age;
        }
    }
}
