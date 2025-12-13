namespace IceCreamStand;

class IceCreamVendor
{
    private IceCreamFactory factory;

    public IceCreamVendor(IceCreamFactory factory)
    {
        this.factory = factory;
    }

    public void OfferSpecialOfTheDay()
    {
        IceCream iceCream = factory.SpecialOfToday();
        iceCream.DisplayInfo();
    }
}