using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class InterCityTransportFactory : TransportFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new Train();
        }

        public override Ticket CreateTicket()
        {
            return new TrainTicket();
        }
    }
}
