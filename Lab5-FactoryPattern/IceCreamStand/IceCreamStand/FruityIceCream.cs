namespace IceCreamStand;

class FruityIceCream : IceCream
{
    public bool InWaffle;
    public string Topping;

    public FruityIceCream(int price, string flavor, bool inWaffle, string topping)
        : base(price, flavor)
    {
        InWaffle = inWaffle;
        Topping = topping;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Lod owocowy: {Flavor}, {Price} zl, {(InWaffle ? "w wafelku" : "bez wafelka")}, polewa: {Topping}");
    }
}