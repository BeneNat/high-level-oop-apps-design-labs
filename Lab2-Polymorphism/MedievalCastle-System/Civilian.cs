using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedivalCastle
{
    internal class Civilian : Inhabitant
    {
        public override int Eat()
        {
            return 2;
        }

        public override string ToString()
        {
            return "Civilian";
        }
    }
}
