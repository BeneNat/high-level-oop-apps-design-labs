namespace Submarine;

internal class FoodContainer : IVisitPort
{
    protected double weight, volume;
    private double density = 3;

    public double Weight
    {
        get { return weight; }
        set { 
            weight = value;
            volume = weight / density;    
        }
    }
    public double Volume
    {
        get { return volume; }
        set
        {
            volume = value;
            weight = volume * density;
        }
    }

    public double VisitPort()
    {
        double previousVolume = Volume;
        Volume = MaxCapacity;
        return (Volume - previousVolume) * 2;
    }
    public double MaxCapacity { get; }
    public FoodContainer(double maxCapacity)
    {
        MaxCapacity = maxCapacity;
    }
}