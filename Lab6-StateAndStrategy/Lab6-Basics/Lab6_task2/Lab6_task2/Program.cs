using C6;

namespace Lab6_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sorter mySorter = new Sorter();
            //mySorter.SetAlgorithm(new InsertionSort());
            mySorter.SetAlgorithm(new SelectionSort());
            List<int> myList = new List<int>() { 6, 2, 3, 5, 1 };
            myList = mySorter.Sort(myList);
            foreach (int i in myList) Console.Write(i);
        }
    }
}
