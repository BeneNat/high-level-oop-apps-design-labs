namespace TouristTrip;

public class VisitMuseumCommand : IVisitTouristAttraction
{
    private Museum museum;
    private int hour;

    public VisitMuseumCommand(Museum museum, int hour)
    {
        this.museum = museum;
        this.hour = hour;
    }

    public void Visit()
    {
        museum.EnterMuseum(hour);
    }
}