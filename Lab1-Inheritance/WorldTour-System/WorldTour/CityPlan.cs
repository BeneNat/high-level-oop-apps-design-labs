namespace WorldTour;

public class CityPlan : ContinentalPlan
{
    private string _city;
    private List<string> _landmarks;

    public CityPlan() : base()
    {
        _city = "Unknown";
        _landmarks = new List<string>();
    }

    public CityPlan(string city, List<string> landmarks, string continent, int visitedCountries, List<string> places,
        string travelMode, double budget, int numberOfCountries, DateTime startDate)
        : base(continent, visitedCountries, places, travelMode, budget, numberOfCountries, startDate)
    {
        _city = city;
        _landmarks = landmarks;
    }

    public void DisplayCity()
    {
        Console.WriteLine($"City {_city}.");
        Console.WriteLine($"Landmarks {string.Join(", ", _landmarks)}.");
    }

    public string SuggestedLandmark()
    {
        Console.WriteLine("Not implemented yet!");
        return "Not implemented yet!";
    }
}