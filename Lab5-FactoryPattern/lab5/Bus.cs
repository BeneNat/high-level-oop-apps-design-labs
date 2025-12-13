using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
     class Bus : Vehicle
    {
        public Bus() : base()
        { 
            
        }

        public Bus(string engine, string velocityLimit) : base(engine, velocityLimit)
        {
            Engine = engine;
            VelocityLimit = velocityLimit;
        }

        public override string GetVehicleType()
        {
            return "bus";
        }

        public override string ToString()
        {
            return $"Vehicle type: {GetVehicleType()}. Engine: {Engine}. Velocity limit: {VelocityLimit} km/h.";
        }
    }
}
