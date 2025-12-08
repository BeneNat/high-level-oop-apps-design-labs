namespace WorldTour;

public class TaxiTransport : RoadTransport
{
    private double _farePerKm;
    private string _driverName;
    private List<string> _rideHistory;

    public TaxiTransport() : base()
    {
        _farePerKm = 0.0;
        _driverName = "Unknown";
        _rideHistory = new List<string>();
    }

    public TaxiTransport(double farePerKm, string driverName, List<string> rideHistory, string roadType, int speedLimit,
        double tollCost, string transportType, int availableSeats, double budget, int numberOfCountries,
        DateTime startDate)
        : base(roadType, speedLimit, tollCost, transportType, availableSeats, budget,
            numberOfCountries, startDate)
    {
        _farePerKm = farePerKm;
        _driverName = driverName;
        _rideHistory = rideHistory;
    }

    public double CalculateFare()
    {
        Console.WriteLine("Not implemented yet!");
        return 0.0;
    }
    
    public string GetLastRideDetails()
    {
        Console.WriteLine("Not implemented yet!");
        return "Not implemented yet!";
    }
}