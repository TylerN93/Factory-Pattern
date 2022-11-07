using System;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfTires;
            bool input = false;

            do
            {
                Console.WriteLine($"How many tires would you like for your vehicle to have?");

                input = int.TryParse(Console.ReadLine(), out numberOfTires);
            }
            while (!input);

            var vehicle = VehicleFactory.GetVehicle(numberOfTires);

            vehicle.Drive();

            
        }
    }
}
