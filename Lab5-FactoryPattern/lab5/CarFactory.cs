using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class CarFactory : VehicleFactory
    {
        private static readonly string[] Makes = { "Toyota", "Ford", "BMW", "Honda", "Audi" };
        private static readonly string[] Models = { "Corolla", "Focus", "X5", "Civic", "A4" };
        private static readonly string[] Engines = { "1.8L", "2.0L", "3.0L", "2.5L" };
        private static readonly string[] Years = { "2018", "2019", "2020", "2021", "2022" };
        private static readonly string[] VelocityLimits = { "180", "260", "140", "198", "175" };

        private Random _random = new Random();

        public override Vehicle Create()
        {
            string make = Makes[_random.Next(Makes.Length)];
            string model = Models[_random.Next(Models.Length)];
            string engine = Engines[_random.Next(Engines.Length)];
            string year = Years[_random.Next(Years.Length)];
            string velocityLimit = VelocityLimits[_random.Next(VelocityLimits.Length)];

            return new Car(engine, velocityLimit, make, model, year);
        }
    }
}
