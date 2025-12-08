namespace WorldTour;

public class BusTransport : RoadTransport
{
    private int _capacity;
    private List<string> _schedule;
    private double _ticketPrice;

    public BusTransport() : base()
    {
        _capacity = 0;
        _schedule = new List<string>();
        _ticketPrice = 0.0;
    }

    public BusTransport(int capacity, List<string> schedule, double ticketPrice, string roadType, int speedLimit,
        double tollCost, string transportType, int availableSeats, double budget, int numberOfCountries,
        DateTime startDate)
        : base(roadType, speedLimit, tollCost, transportType, availableSeats, budget,
        numberOfCountries, startDate)
    {
        _capacity = capacity;
        _schedule = schedule;
        _ticketPrice = ticketPrice;
    }

    public string GetNextBus()
    {
        Console.WriteLine("Not implemented yet!");
        return "Not implemented yet!";
    }
    
    public string GetNextStop()
    {
        Console.WriteLine("Not implemented yet!");
        return "Not implemented yet!";
    }
}