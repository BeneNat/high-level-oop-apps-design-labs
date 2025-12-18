using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class BusTicket : Ticket
    {
        public override void DisplayTicket()
        {
            Console.WriteLine("Bus ticket for city transport.");
        }
    }
}
