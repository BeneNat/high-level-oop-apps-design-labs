namespace Submarine;

internal class Waste : IVisitPort
{
    protected double weight, volume;
    public double Volume
    {
        get
        {
            return volume;
        }
        set
        {
            volume = value;
            weight = volume * 5; 
        }
    }
    public double Weight
    {
        get
        {
            return weight;
        }
        set
        {
            weight = value;
            volume = weight / 5;
        }
    }
    public double VisitPort()
    {
        Volume = 0;
        return 2000;
    }
}