namespace Vehicles
{
public class StartUp
{
    public static void Main(string[] args)
    {
        string[] carData = Console.ReadLine().Split();
        Vehicle car = new Car(double.Parse(carData[1]), double.Parse(carData[2]));

        string[] truckData = Console.ReadLine().Split();
        Vehicle truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]));

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split();
            string action = command[0];
            string vehicleType = command[1];
            double parameter = double.Parse(command[2]);

            if (action == "Drive")
            {
                if (vehicleType == "Car") car.Drive(parameter);
                else if (vehicleType == "Truck") truck.Drive(parameter);
            }
            else if (action == "Refuel")
            {
                if (vehicleType == "Car") car.Refuel(parameter);
                else if (vehicleType == "Truck") truck.Refuel(parameter);
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
    }
}
}
