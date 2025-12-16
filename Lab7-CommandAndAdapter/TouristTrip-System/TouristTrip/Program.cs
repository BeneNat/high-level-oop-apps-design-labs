using System;
using TouristTrip;

class Program
{
    static void Main(string[] args)
    {
        var musem = new Museum();
        var park = new Park();
        var restaurant = new Restaurant();
        var shop = new SouvenirShop();

        var trip1 = new TripScheduler();
        trip1.AddCommand(new VisitMuseumCommand(musem, 10));
        trip1.AddCommand(new EatAtRestaurantCommand(restaurant, "Pizza"));
        trip1.AddCommand(new VisitParkCommand(park, 30));
        trip1.AddCommand(new BuySouvenirCommand(shop, 22.75m));
        
        Console.WriteLine("===Trip 1===");
        trip1.Trip();
        
        var trip2 = new TripScheduler();
        trip2.AddCommand(new VisitParkCommand(park, 120));
        trip2.AddCommand(new VisitMuseumCommand(musem, 16));
        trip2.AddCommand(new EatAtRestaurantCommand(restaurant, "Pasta"));
        trip2.AddCommand(new BuySouvenirCommand(shop, 12.25m));
        
        Console.WriteLine("===Trip 2===");
        trip2.Trip();
        
        var trip3 = new TripScheduler();
        trip3.AddCommand(new EatAtRestaurantCommand(restaurant, "Sushi"));
        trip3.AddCommand(new VisitParkCommand(park, 60));
        trip3.AddCommand(new BuySouvenirCommand(shop, 4.00m));
        trip3.AddCommand(new VisitMuseumCommand(musem, 9));
        
        Console.WriteLine("===Trip 3===");
        trip3.Trip();
    }
}