namespace Laboratorium2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Vehicle vehicle = new Vehicle();
            Train train = new Train();
            Vehicle trainAsVehicle = new Train();

            //Console.WriteLine(vehicle.GetVehicleType());
            Console.WriteLine(train.GetVehicleType());
            // Zwroci to jakiego typu zostalo stworzone u nas na
            // poczatku obiekt Train typu Vehicle
            // Po dodaniu virtual do Vehicle a override do Train sytuacja sie zmienia
            Console.WriteLine(trainAsVehicle.GetVehicleType());

            Train electricTrain = new Train("electric", 120);
            Console.WriteLine(electricTrain);

            List<Vehicle> myVehicles = new List<Vehicle>();
            myVehicles.Add(new Train("electric", 120));
            myVehicles.Add(new Bus("electric", 90));
            myVehicles.Add(new Car("hybrid", 150));
            myVehicles.Add(new Car("petrol", 250));

            foreach(Vehicle v in myVehicles) Console.WriteLine(v);

            TicketBuyer ticketBuyer = new TicketBuyer();
            ticketBuyer.BuyTicket();
        }
    }
}
