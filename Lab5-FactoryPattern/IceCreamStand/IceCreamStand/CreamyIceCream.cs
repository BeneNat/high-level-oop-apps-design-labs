namespace IceCreamStand;

class CreamyIceCream : IceCream
{
    public bool InWaffle { get; set; }
    public string Topping { get; set; }
    public bool HasChocolateSprinkles { get; set; }

    public CreamyIceCream(int price, string flavor, bool inWaffle, string topping, bool hasChocolateSprinkles)
        : base(price, flavor)
    {
        InWaffle = inWaffle;
        Topping = topping;
        HasChocolateSprinkles = hasChocolateSprinkles;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Lod smietankowy: {Flavor}, {Price} zl, {(InWaffle ? "w wafelku" : "bez wafelka")}, polewa: {Topping}, posypka: {(HasChocolateSprinkles ? "tak" : "nie")}");
    }
}