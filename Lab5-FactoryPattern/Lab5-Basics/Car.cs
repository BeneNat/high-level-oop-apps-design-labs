using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
     class Car : Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Year { get; set; }

        public Car(string engine, string velocityLimit, string make, string model, string year) : base(engine, velocityLimit)
        {
            Engine = engine;
            VelocityLimit = velocityLimit;
            Make = make;
            Model = model;
            Year = year;
        }

        public Car() : base()
        {

        }

        public Car(string engine, string velocityLimit) : base(engine, velocityLimit)
        {
            Engine = engine;
            VelocityLimit = velocityLimit;
        }

        public override string GetVehicleType()
        {
            return "car";
        }

        public override string ToString()
        {
            return $"Vehicle type: {GetVehicleType()}. Engine: {Engine}. Velocity limit: {VelocityLimit} km/h. Make: {Make}. Model: {Model}. Year: {Year}";
        }
    }
}
