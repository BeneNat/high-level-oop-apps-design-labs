using System;

namespace WorldTour
{
    public class WorldTour
    {
        private double _budget;
        private int _numberOfCountries;
        private DateTime _startDate;

        protected WorldTour()
        {
            
        }
        
        public WorldTour(double budget, int numberOfCountries, DateTime startDate)
        {
            _budget = budget;
            _numberOfCountries = numberOfCountries;
            _startDate = startDate;
        }
        
        public void DisplayInfo()
        {
            Console.WriteLine($"Budget: {_budget}$.");
            Console.WriteLine($"Number of countries to visit: {_numberOfCountries}.");
            Console.WriteLine($"Start date: {_startDate}.");
        }

        public double CalculateTotalCost()
        {
            Console.WriteLine("Not implemented yet!");
            return 0;
        }
    }
}