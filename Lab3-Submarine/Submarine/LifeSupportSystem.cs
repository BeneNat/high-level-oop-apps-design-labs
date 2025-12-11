namespace Submarine;

internal class LifeSupportSystem
{
    private List<OxygenBottle> oxygenBottles;
    private FoodContainer foodContainer;
    private Waste waste;
    private List<Human> crew;
    public LifeSupportSystem(List<OxygenBottle> oxygenBottles, FoodContainer container, Waste waste, List<Human> crew)
    {
        this.oxygenBottles = oxygenBottles;
        this.foodContainer = container;
        this.waste = waste;
        this.crew = crew;
    }
    public bool CheckSuppliesBeforeTravel(double travelTime) 
    {
        double totalOxygen = 0;
        foreach (OxygenBottle oxygenBottle in oxygenBottles)
        {
            totalOxygen += oxygenBottle.Volume;
        }
        if (foodContainer.Volume - travelTime * 0.01 * crew.Count <= 0 ||
            (totalOxygen - 0.001*travelTime * crew.Count <= 0))
        {
            return false;
        } else return true;
    }
    public void Run(double travelTime)
    {
        foreach(var oxygenBottle in oxygenBottles)
        {
            oxygenBottle.Volume -= travelTime * 0.001 * crew.Count/oxygenBottles.Count;
        }
        foodContainer.Volume -= travelTime * 0.001 * crew.Count;
        waste.Volume += travelTime * 0.007 * crew.Count;
    }
}