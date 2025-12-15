using C6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_task2
{
    internal class Sorter
    {
        private SortingAlgorithm algorithm { get; set; }

        public void SetAlgorithm(SortingAlgorithm sortingAlgorithm)
        {
            algorithm = sortingAlgorithm;
        }

        public List<int> Sort(List<int> lista) 
        {
            return algorithm.Sort(lista);
        }
    }
}
