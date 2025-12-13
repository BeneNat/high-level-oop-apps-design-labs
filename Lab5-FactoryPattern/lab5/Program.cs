using System;
using System.Collections.Generic;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab 02
            // Train electricTrain = new Train("electric", 120);
            // Console.WriteLine(electricTrain);
            List<Vehicle> myVehicles = new List<Vehicle>();
            myVehicles.Add(new Train("electric", "120"));
            myVehicles.Add(new Bus("electric", "90"));
            myVehicles.Add(new Car("hybrid", "150"));
            foreach (Vehicle v in myVehicles) Console.WriteLine(v);

            // Lab 05 - Task 1
            Console.WriteLine();
            List<VehicleFactory> factories = new List<VehicleFactory>() { new TrainFactory(), 
                new BusFactory(), new CarFactory() };
            foreach (VehicleFactory factory in factories)
            {
                Vehicle v = factory.Create();
                Console.WriteLine(v);
            }

            CarFactory carTest = new CarFactory();
            CarRentalService rentTest = new CarRentalService(carTest);
            rentTest.Rent();
            
            CityTransportFactory cityTransportTest = new CityTransportFactory();
            InterCityTransportFactory interCityTransportTest = new InterCityTransportFactory();
        }
    }
}
