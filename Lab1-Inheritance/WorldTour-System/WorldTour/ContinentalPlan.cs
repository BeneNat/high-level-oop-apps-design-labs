namespace WorldTour;

public class ContinentalPlan : Itinerary
{
    private string _continent;
    private int _visitedCountries;

    public ContinentalPlan() : base()
    {
        _continent = "Unknown";
        _visitedCountries = 0;
    }

    public ContinentalPlan(string continent, int visitedCountries, List<string> places, string travelMode,
        double budget, int numberOfCountries, DateTime startDate)
        : base(places, travelMode, budget, numberOfCountries, startDate)
    {
        _continent = continent;
        _visitedCountries = visitedCountries;
    }

    public void DisplayContinent()
    {
        Console.WriteLine($"Continental plan: {_continent}.");
        Console.WriteLine($"Number of visited countries: {_visitedCountries}.");
    }

    public int GetRemainingCountries()
    {
        Console.WriteLine("Not implemented yet!");
        return 0;
    }
}