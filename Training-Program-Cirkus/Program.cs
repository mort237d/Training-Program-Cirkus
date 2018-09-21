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
            Clown clown = new Clown("Bobo");
            CirkusPrincess cirkusPrincess = new CirkusPrincess("Sumini", 21, true);

            cirkus.HireClown(clown);
            cirkus.HirePrincess(cirkusPrincess);

            Console.WriteLine(clown);
            Console.WriteLine(cirkusPrincess);

        }
    }
}
