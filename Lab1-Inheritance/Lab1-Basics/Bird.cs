using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    internal class Bird : Animal
    {
        public int numberOfFeathers = 0;
        public void method()
        {
            name = "birdone";
            weight = 1;
            //age = 1;
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Weight: " + weight);
            //Console.WriteLine("Age: ", age);
        }

        public void LayEggs(int number)
        {
            Console.WriteLine($"{number} eggs were laid.");
        }

        // Wersja long (not to use)
        /*public Bird(string _name, int _weight, int _feathers)
        {
            name = _name;
            weight = _weight;
            int numberOfFeathers = _feathers;
        }*/

        // Wersja short (recommended)

        public Bird()
        {

        }

        public Bird(string _name, int _weight, int _feathers) : base(_name, _weight)
        {
            numberOfFeathers = _feathers;
        }
    }
}
