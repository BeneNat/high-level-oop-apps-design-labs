using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class CityTransportFactory : TransportFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new Bus();
        }

        public override Ticket CreateTicket()
        {
            return new BusTicket();
        }
    }
}
