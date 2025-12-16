using Lab7_command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_command
{
    internal class StartWiFiCommand : ISmartHomeExecutable
    {
        private WiFi myWifi;
        private string innerPassword;

        public StartWiFiCommand(WiFi wifi, string password)
        {
            myWifi = wifi;
            innerPassword = password;
        }

        public void Execute() 
        {
            myWifi.IsCurrentlyOn = true;
            myWifi.Login(innerPassword);
        }
    }
}
