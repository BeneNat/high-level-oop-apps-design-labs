namespace IceCreamStand;

class Sorbet : IceCream
{
    public Sorbet(int price, string flavor) : base(price, flavor){}

    public override void DisplayInfo()
    {
        Console.WriteLine($"Sorbet: {Flavor}, {Price} zl");
    }
}