namespace WorldTour;

public class DomesticFlight : AirTransport
{
    private string _planeType;
    private string _airline;
    private string _flightGate;

    public DomesticFlight() : base()
    {
        _planeType = "Unknown";
        _airline = "Unknown";
        _flightGate = "Unknown";
    }

    public DomesticFlight(string planeType, string airline, string flightGate, string airportCode, string flightNumber,
        double baggageAllowance, string transportType, int availableSeats, double budget, int numberOfCountries,
        DateTime startDate)
        : base(airportCode, flightNumber, baggageAllowance, transportType, availableSeats, budget,
        numberOfCountries, startDate)
    {
        _planeType = planeType;
        _airline = airline;
        _flightGate = flightGate;
    }

    public void DisplayFlightInfo()
    {
        Console.WriteLine($"Plane type: {_planeType}");
        Console.WriteLine($"Airline: {_airline}");
        Console.WriteLine($"Flight gate: {_flightGate}");
    }

    public string GetBoardingInfo()
    {
        Console.WriteLine("Not implemented yet!");
        return "Not implemented yet!";
    }
}