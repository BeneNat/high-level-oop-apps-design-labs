using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class CarRentalService
    {
        protected CarFactory carFactory;

        public CarRentalService(CarFactory _carFactory)
        {
            carFactory = _carFactory;
        }

        public void Rent()
        {
            Vehicle v = carFactory.Create();
            Console.WriteLine("Our service can offer you the following car today: ");
            Console.WriteLine(v);
        }
    }
}
