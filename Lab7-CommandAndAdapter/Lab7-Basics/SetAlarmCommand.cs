using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_command
{
    internal class SetAlarmCommand : ISmartHomeExecutable
    {
        private SecurityAlarm innerAlarm;
        private string innerPassword;

        public SetAlarmCommand(SecurityAlarm alarm, string password)
        {
            innerAlarm = alarm;
            innerPassword = password;
        }

        public void Execute() 
        {
            innerAlarm.Lock(innerPassword);
        }
    }
}
