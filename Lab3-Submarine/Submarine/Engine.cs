namespace Submarine;

internal class Engine
{
    private FuelTank tank;
    private Waste waste;

    public Engine(FuelTank tank, Waste waste)
    {
        this.tank = tank;
        this.waste = waste;
    }

    public double GetVelocity(double submarineWeight)
    {
        return 10000 / (submarineWeight * 0.01 + 600);
    }

    public bool CheckFuelBeforeTravel(double travelTime)
    {
        if (tank.Weight - travelTime * 2 <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void Travel(double travelTime)
    {
        tank.Volume -= travelTime * 0.2;
        waste.Volume += travelTime * 0.75;
    }
}