using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalCastle
{
    internal class Pikeman : Defender
    {
        public override int Eat()
        {
            return 4;
        }

        public override string ToString()
        {
            return "Pikeman";
        }

        public override string ReadyToFight()
        {
            return "The Pikeman is ready for battle!";
        }
    }
}
