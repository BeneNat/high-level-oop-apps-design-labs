namespace WorldTour;

public class LocalTransport : WorldTour
{
    private string _transportType;
    private int _availableSeats;

    public LocalTransport() : base(0, 0, DateTime.Now)
    {
        _transportType = "Unknown";
        _availableSeats = 0;
    }

    public LocalTransport(string transportType, int availableSeats, double budget, int numberOfCountries,
        DateTime startDate)
        : base(budget, numberOfCountries, startDate)
    {
        _transportType = transportType;
        _availableSeats = availableSeats;
    }

    public void DisplayLocalTransport()
    {
        Console.WriteLine($"Transport type: {_transportType}");
        Console.WriteLine($"Available seats: {_availableSeats}");
    }

    public bool CheckAvailability()
    {
        Console.WriteLine("Not implemented yet!");
        return false;
    }
}