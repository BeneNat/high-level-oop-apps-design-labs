namespace TouristTrip;

public class VisitParkCommand : IVisitTouristAttraction
{
    private Park park;
    private int duration;

    public VisitParkCommand(Park park, int duration)
    {
        this.park = park;
        this.duration = duration;
    }

    public void Visit()
    {
        park.WalkThroughPark(duration);
    }
}