namespace WorldTour;

public class AirTransport : LocalTransport
{
    private string _airportCode;
    private string _flightNumber;
    private double _baggageAllowance;

    public AirTransport() : base()
    {
        _airportCode = "Unknown";
        _flightNumber = "Unknown";
        _baggageAllowance = 0.0;
    }

    public AirTransport(string airportCode, string flightNumber, double baggageAllowance, string transportType,
        int availableSeats, double budget, int numberOfCountries, DateTime startDate)
        : base(transportType, availableSeats, budget, numberOfCountries, startDate)
    {
        _airportCode = airportCode;
        _flightNumber = flightNumber;
        _baggageAllowance = baggageAllowance;
    }

    public void DisplayFlightDetails()
    {
        Console.WriteLine($"Airport code: {_airportCode}");
        Console.WriteLine($"Flight number: {_flightNumber}");
        Console.WriteLine($"Baggage allowance: {_baggageAllowance}");
    }

    public bool CheckBaggageLimit(double weight)
    {
        Console.WriteLine("Not implemented yet!");
        return false;
    }
}