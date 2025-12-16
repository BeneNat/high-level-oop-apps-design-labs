namespace TouristTrip;

public class BuySouvenirCommand : IVisitTouristAttraction
{
    private SouvenirShop shop;
    private decimal price;

    public BuySouvenirCommand(SouvenirShop shop, decimal price)
    {
        this.shop = shop;
        this.price = price;
    }

    public void Visit()
    {
        shop.BuySouvenir(price);
    }
}