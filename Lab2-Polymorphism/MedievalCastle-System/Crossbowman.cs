using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedivalCastle
{
    internal class Crossbowman : Defender
    {
        public override int Eat()
        {
            return 3;
        }

        public override string ToString()
        {
            return "Crossbowman";
        }

        public override string ReadyToFight()
        {
            return "The crossbowman is ready for battle!";
        }
    }
}
