namespace WorldTour;

public class RoadTransport : LocalTransport
{
    private string _roadType;
    private int _speedLimit;
    private double _tollCost;

    public RoadTransport() : base()
    {
        _roadType = "Unknown";
        _speedLimit = 0;
        _tollCost = 0;
    }

    public RoadTransport(string roadType, int speedLimit, double tollCost, string transportType, int availableSeats,
        double budget, int numberOfCountries, DateTime startDate)
        : base(transportType, availableSeats, budget, numberOfCountries, startDate)
    {
        _roadType = roadType;
        _speedLimit = speedLimit;
        _tollCost = tollCost;
    }

    public double GetTravelTime(double distance)
    {
        Console.WriteLine("Not implemented yet!");
        return 0.0;
    }

    public double CalculateTollFee()
    {
        Console.WriteLine("Not implemented yet!");
        return 0.0;
    }
}