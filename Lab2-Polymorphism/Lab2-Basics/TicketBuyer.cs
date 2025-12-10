using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    internal class TicketBuyer : IBuyTicket
    {
        public void BuyTicket()
        {
            Console.WriteLine("You just bought a ticket for a ride.");
        }
    }
}
