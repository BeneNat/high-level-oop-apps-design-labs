namespace Submarine;

abstract class Human : ITransportable
{
    protected double weight, volume;
    protected double density = 1;

    public double Weight
    {
        get
        {
            return weight;
        }
        set
        {
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
            weight = density + volume;
        }
    }
}