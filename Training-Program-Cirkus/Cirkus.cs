﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Program_Cirkus
{
    class Cirkus
    {
        private Clown clown;
        private CirkusPrincess cirkusPrincess;

        public Cirkus()
        {
        }

        public void HireClown(Clown clown)
        {
            this.clown = clown;
        }
        public void HirePrincess(CirkusPrincess cirkusPrincess)
        {
            this.cirkusPrincess = cirkusPrincess;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("+-----------------------+");
            sb.Append("| Brand:");
            sb.Append("\t");
            sb.Append("\t|");
            return sb.ToString();
        }
    }
}
