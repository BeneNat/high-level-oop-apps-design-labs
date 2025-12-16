using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_command
{
    internal class SetThermostatCommand : ISmartHomeExecutable
    {
        private Thermostat innerThermostat;
        private int innerTemp;
        public SetThermostatCommand(Thermostat thermostat, int temperautre)
        {
            innerThermostat = thermostat;
            innerTemp = temperautre;
        }

        public void Execute() 
        { 
            innerThermostat.TargetTemperature = innerTemp;
        }
    }
}
