using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedivalCastle
{
    internal abstract class Defender : Inhabitant, IDefender
    {
        public abstract string ReadyToFight();
    }
}
