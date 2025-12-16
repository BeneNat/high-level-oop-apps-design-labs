namespace TouristTrip;

public class EatAtRestaurantCommand : IVisitTouristAttraction
{
    private Restaurant restaurant;
    private string dish;

    public EatAtRestaurantCommand(Restaurant restaurant, string dish)
    {
        this.restaurant = restaurant;
        this.dish = dish;
    }

    public void Visit()
    {
        restaurant.EatMeal(dish);
    }
}