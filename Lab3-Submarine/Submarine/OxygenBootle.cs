namespace Submarine;

internal class OxygenBottle : IVisitPort
{
    protected double weight,volume;
    protected double density = 5;

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
        get
        {
            return volume;
        }
        set
        {
            volume = value;
            weight = volume * density;
        }
    }

    public double MaxCapacity
    {
        get;
    }
    public OxygenBottle(double maxCapacity)
    {
        MaxCapacity = maxCapacity;
    }
    
    public double VisitPort()
    {
        double previousVolume = volume;
        Volume = MaxCapacity;
        return (Volume - volume)*5;
    }
}