using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
     class BusFactory : VehicleFactory
    {
        public override Vehicle Create()
        {
            return new Bus();
        }
    }
}
