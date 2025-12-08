using System.Runtime.InteropServices.JavaScript;

namespace WorldTour;

public class IntercontinentalFlight : GlobalTransport
{
    private string _airline;
    private double _flightDuration;

    public IntercontinentalFlight() : base()
    {
        _airline = "Unknown";
        _flightDuration = 0;
    }

    public IntercontinentalFlight(string airline, double flightDuration, string transportType, double averageCost,
        double budget, int numberOfCountries, DateTime startDate)
        : base(transportType, averageCost, budget, numberOfCountries, startDate)
    {
        _airline = airline;
        _flightDuration = flightDuration;
    }

    public void DisplayFlight()
    {
        Console.WriteLine($"Airline: {_airline}.");
        Console.WriteLine($"Flight duration: {_flightDuration}");
    }

    public bool IsLongHaul()
    {
        Console.WriteLine("Not implemented yet!");
        return false;
    }
}