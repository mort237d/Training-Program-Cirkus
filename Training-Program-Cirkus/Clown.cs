using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Program_Cirkus
{
    class Clown
    {
        public string FirstName = "The Clown";
        public string SecondName;

        public Clown(string SecondName)
        {
            this.SecondName = SecondName;
        }

        public override string ToString()
        {
            return this.SecondName + ", " + this.FirstName;
        }
    }
}
