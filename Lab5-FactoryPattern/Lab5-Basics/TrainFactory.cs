using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
     class TrainFactory : VehicleFactory
    {
        public override Vehicle Create()
        {
            return new Train();
        }
    }
}
