namespace IceCreamStand;

abstract class IceCream
{
    public int Price { get; set; }
    public string Flavor { get; set; }

    public IceCream(int price, string flavor)
    {
        Price = price;
        Flavor = flavor;
    }

    public abstract void DisplayInfo();
}