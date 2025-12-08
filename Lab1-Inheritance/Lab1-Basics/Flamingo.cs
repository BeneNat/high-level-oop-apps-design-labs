using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    internal class Flamingo : Bird
    {
        public void method_flamingo()
        {
            name = "Flaming";
            weight = 45;
            Console.WriteLine($"Name:  {name}");
            Console.WriteLine($"Weight: {weight}");
            //Console.WriteLine("Age: ", age);
        }


        public void Incubation(int number, int days)
        {
            LayEggs(number);
            Console.WriteLine($"Sitting at the eggs for {days} days.");
        }

        public Flamingo()
        {

        }

        public Flamingo(string _name, int _weight, int _feathers) : base(_name, _weight, _feathers) 
        {
            //numberOfFeathers = _feathers;
        }
    }
}
