namespace WorldTour;

public class HelicopterTransport : AirTransport
{
    private string _heliType;

    public HelicopterTransport() : base()
    {
        _heliType = "Unknown";
    }

    public HelicopterTransport(string heliType, string airportCode, string flightNumber, double bagageAllowance,
        string transportType, int availableSeats, double budget, int numberOfCountries, DateTime startDate)
        : base(airportCode, flightNumber, bagageAllowance, transportType, availableSeats, budget,
            numberOfCountries, startDate)
    {
        _heliType = heliType;
    }

    public bool IsAvailableForEmergency()
    {
        Console.WriteLine("Not implemented yet!");
        return false;
    }
}