namespace Submarine;

abstract class Fuel : ITransportable
{
    public abstract string Type { get; }
    protected abstract double density { get; }
    protected double weight;
    protected double volume;

    public new abstract string GetType();

    public double Volume {
        get
        {
            return volume;
        }
        set {
            volume = value;
            weight = density * volume;
        }
    }

    public double Weight
    {
        get
        {
            return weight;
        }
        set {  
            weight = value;
            volume = weight / density;
        }
    }       
}