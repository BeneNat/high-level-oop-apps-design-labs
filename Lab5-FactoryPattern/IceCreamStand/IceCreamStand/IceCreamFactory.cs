namespace IceCreamStand;

class IceCreamFactory
{
    private ProductionMode currentMode;

    public void SetProductionMode(int i)
    {
        currentMode = (ProductionMode)(i % 7);
    }

    public IceCream SpecialOfToday()
    {
        return currentMode switch
        {
            ProductionMode.Monday => new CreamyIceCream(10, "Waniliowy", true, "Karmel", true),
            ProductionMode.Tuesday => new FruityIceCream(9, "Truskawkowy", false, "Malina"),
            ProductionMode.Wednesday => new Sorbet(8, "Cytrynowy"),
            ProductionMode.Thursday => new ItalianIceCream(11, "Czekoladowy", true, false),
            ProductionMode.Friday => new CreamyIceCream(10, "Kokosowy", false, "Czekolada", false),
            ProductionMode.Saturday => new FruityIceCream(9, "Mango", true, "Biala czekolada"),
            ProductionMode.Sunday => new ItalianIceCream(12, "Orzechowy", false, false),
            _ => throw new Exception("Nieznany tryb produkcji")
        };
    }
}