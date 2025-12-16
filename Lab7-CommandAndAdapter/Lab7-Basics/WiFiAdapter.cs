using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_command
{
    internal class WiFiAdapter : WiFi
    {
        private WiFi2 innerAdaptee;
        private string innerSSID;

        public WiFiAdapter(WiFi2 adaptee, string net)
            : base (net, "blank password")
        {
            innerAdaptee = adaptee;
            innerSSID = net;
            Console.WriteLine("Instancja WiFi Adaptera zostala stworzona");
            Console.WriteLine(net);
        }

        public override void Login(string pwd)
        {
            innerAdaptee.Login(innerSSID, pwd);
        }

        public override bool IsCurrentlyOn 
        { 
            get { return innerAdaptee.IsCurrentlyOn; }
            set { innerAdaptee.IsCurrentlyOn = value; }
            //get => innerAdaptee.IsCurrentlyOn; set => innerAdaptee.IsCurrentlyOn = value; 
        }
    }
}
