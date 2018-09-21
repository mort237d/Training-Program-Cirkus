using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Program_Cirkus
{
    class Program
    {
        static void Main(string[] args)
        {
            Cirkus cirkus = new Cirkus();
            Clown clown = new Clown();
            CirkusPrincess cirkusPrincess = new CirkusPrincess();

            cirkus.HireClown(clown);
            cirkus.HirePrincess(cirkusPrincess);

        }
    }
}
