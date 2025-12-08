namespace WorldTour;

public class OceanCruise : GlobalTransport
{
    private string _cruiseShip;
    private double _cruiseDuration;

    public OceanCruise() : base()
    {
        _cruiseShip = "Unknown";
        _cruiseDuration = 0;
    }

    public OceanCruise(string cruiseShip, double cruiseDuration, string transportType, double averageCost,
        double budget, int numberOfCountries, DateTime startDate)
        : base(transportType, averageCost, budget, numberOfCountries, startDate)
    {
        _cruiseShip = cruiseShip;
        _cruiseDuration = cruiseDuration;
    }

    public void DisplayCruise()
    {
        Console.WriteLine($"Cruise ship: {_cruiseShip}.");
        Console.WriteLine($"Cruise duration: {_cruiseDuration}.");
    }

    public string GetCruiseDetails()
    {
        Console.WriteLine("Not implemented yet!");
        return "Not implemented yet!";
    }
}