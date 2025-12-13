namespace IceCreamStand;

class Program
{
    static void Main()
    {
        IceCreamFactory factory = new IceCreamFactory();
        IceCreamVendor vendor = new IceCreamVendor(factory);

        for (int day = 0; day < 7; day++)
        {
            Console.WriteLine($"\nDzien {((ProductionMode)day)}:");
            factory.SetProductionMode(day);

            for (int i = 0; i < 2; i++)
            {
                vendor.OfferSpecialOfTheDay();
            }
        }
        
        Console.WriteLine("\nSymulacja zakonczona!");
    }
}