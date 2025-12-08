namespace WorldTour;

public class Itinerary : WorldTour
{
    private List<string> _places;
    private string _travelMode;

    protected Itinerary() : base(0, 0, DateTime.Now)
    {
        _places = new List<string>();
        _travelMode = "Unknown";
    }

    public Itinerary(List<string> places, string travelMode, double budget, int numberOfCountries, DateTime startDate)
        : base(budget, numberOfCountries, startDate)
    {
        _places = places ?? new List<string>(); // Maybe it will be null who knnows
        _travelMode = travelMode;
    }

    public void AddPlace(string place)
    {
        Console.WriteLine("Not implemented yet!");
    }
    
    public void RemovePlace(string place)
    {
        Console.WriteLine("Not implemented yet!");
    }

    public string GetNextDestination()
    {
        Console.WriteLine("Not implemented yet!");
        return "Not implemented yet!";
    }
}