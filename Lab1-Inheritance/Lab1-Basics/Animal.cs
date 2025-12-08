using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    internal class Animal
    {
        public string name = "BirdOne";
        protected int weight = 123;
        private int age = 23;

        public Animal()
        {
            name = "AnimalTest";
            weight = 1;
        }

        public Animal(string _name, int _weight)
        {
            name = _name;
            weight = _weight;
        }
    }
}
