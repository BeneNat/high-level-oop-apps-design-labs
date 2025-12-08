namespace WorldTour;

public class TrainTransport : RoadTransport
{
    private string _trainType;
    private string _railwayCompany;
    private double _trainSpeed;

    public TrainTransport() : base()
    {
        _trainType = "Unknown";
        _railwayCompany = "Unknown";
        _trainSpeed = 0.0;
    }

    public TrainTransport(string trainType, string railwayCompany, double trainSpeed, string roadType, int speedLimit,
        double tollCost, string transportType, int availableSeats, double budget, int numberOfCountries,
        DateTime startDate)
        : base(roadType, speedLimit, tollCost, transportType, availableSeats, budget,
            numberOfCountries, startDate)
    {
        _trainType = trainType;
        _railwayCompany = railwayCompany;
        _trainSpeed = trainSpeed;
    }

    public void DisplayTrainInfo()
    {
        Console.WriteLine($"Train type: {_trainType}");
        Console.WriteLine($"Railway company: {_railwayCompany}");
        Console.WriteLine($"Train speed: {_trainSpeed}");
    }
    
    public DateTime CalculateArrivalTime()
    {
        Console.WriteLine("Not implemented yet!");
        return DateTime.Now;
    }
}