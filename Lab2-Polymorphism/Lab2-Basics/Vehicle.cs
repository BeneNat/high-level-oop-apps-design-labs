using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    //internal class Vehicle
    internal abstract class Vehicle
    {
        //public string _engine;
        //public int _velocityLimit;
        private string engine;
        private int velocityLimit;
        //public string engine { get; set; }
        //public string velocityLimit { get; set; }

        protected string Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        protected int VelocityLimit
        {
            get { return velocityLimit; }
            set { velocityLimit = value; }
        }

        public Vehicle()
        {
            
        }

        public Vehicle(string engine, int velocityLimit)
        {
            Engine = engine;
            VelocityLimit = velocityLimit;
        }

        //public string GetVehicleType()
        /*public virtual string GetVehicleType()
        {
            return "unspecified vehicle";
        }*/

        public abstract string GetVehicleType();
    }
}
