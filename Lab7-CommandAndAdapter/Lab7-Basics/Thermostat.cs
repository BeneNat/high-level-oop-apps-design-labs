using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_command
{
    // receiver class
    class Thermostat
    {
        private int targetTemperature;
        public int TargetTemperature
        {
            get { return targetTemperature; }
            set
            {
                if (value < 18) targetTemperature = 18;
                else if (value > 30) targetTemperature = 30;
                else targetTemperature = value;
                Console.WriteLine("Thermostat set to " + targetTemperature + "C.");
            }
        }
        public Thermostat()
        {
            targetTemperature = 21;
        }
    }
}
