using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    internal class Train : Vehicle
    {
        public Train() : base()
        {
            
        }

        public Train(string engine, int velocityLimit) : base(engine, velocityLimit)
        {
            
        }

        //public string GetVehicleType()
        public override string GetVehicleType()
        {
            return "train";
        }

        public override string ToString()
        {
            return $"Vehicle type: {GetVehicleType()}. Engine: {Engine}. Velocity limit: {VelocityLimit} km/h.";
        }
    }
}
