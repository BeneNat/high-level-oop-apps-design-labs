namespace TouristTrip;

// invoker class
public class TripScheduler
{
    private List<IVisitTouristAttraction> commands = new List<IVisitTouristAttraction>();

    public void AddCommand(IVisitTouristAttraction command)
    {
        commands.Add(command);
    }

    public void Trip()
    {
        foreach (var command in commands)
        {
            command.Visit();
        }
    }
}