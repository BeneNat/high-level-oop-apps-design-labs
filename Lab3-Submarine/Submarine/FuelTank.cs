namespace Submarine;

internal class FuelTank : IVisitPort
{
    public double MaxCapacity { get; }
    private Fuel fuel;

    public double Weight
    {
        get
        {
            return fuel.Weight;
        }
        set
        {
            fuel.Weight = value;
        }
    }
    
    public double Volume
    {
        get
        {
            return fuel.Volume;
        }
        set
        {
            fuel.Volume = value;
        }
    }

    public FuelTank(double maxCapacity, Fuel fuel)
    {
        MaxCapacity = maxCapacity;
        this.fuel = fuel;
    }

    public string GetFuelType()
    {
        return fuel.GetType();
    }

    public double VisitPort()
    {
        double previousVolume = fuel.Volume;
        fuel.Volume = MaxCapacity;
        return (fuel.Volume - previousVolume) * 1500;
    }
}