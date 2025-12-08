namespace WorldTour;

public class GlobalTransport : WorldTour
{
    private string _transportType;
    private double _averageCost;

    public GlobalTransport() : base(0, 0, DateTime.Now)
    {
        _transportType = "Unknown";
        _averageCost = 0;
    }

    public GlobalTransport(string transportType, double averageCost, double budget, int numberOfCountries,
        DateTime startDate)
        : base(budget, numberOfCountries, startDate)
    {
        _transportType = transportType;
        _averageCost = averageCost;
    }

    public void DisplayTransport()
    {
        Console.WriteLine($"Transport type: {_transportType}.");
        Console.WriteLine($"Average cost: {_averageCost}.");
    }

    public string CompareCost(GlobalTransport other)
    {
        Console.WriteLine("Not implemented yet!");
        return "Not implemented yet!";
    }
}