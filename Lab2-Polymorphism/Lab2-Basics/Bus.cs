using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    internal class Bus : Vehicle
    {
        public Bus() : base()
        { 
            
        }

        public Bus(string engine, int velocityLimit) : base(engine, velocityLimit)
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
