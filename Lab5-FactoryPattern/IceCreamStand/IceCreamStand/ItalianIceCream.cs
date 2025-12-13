namespace IceCreamStand;

class ItalianIceCream : IceCream
{
    public bool InWaffle { get; set; }
    public bool HasChocolateSprinkles { get; set; }

    public ItalianIceCream(int price, string flavor, bool inWaffle, bool hasChocolateSprinkles)
        : base(price, flavor)
    {
        InWaffle = inWaffle;
        HasChocolateSprinkles = hasChocolateSprinkles;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Lod wloski: {Flavor}, {Price} zl, {(InWaffle ? "w wafelku" : "bez wafelka")}, posypka: {(HasChocolateSprinkles ? "tak" : "nie")}");
    }
}