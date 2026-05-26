namespace VehiclesExtension
{
public class StartUp
{
    public static void Main(string[] args)
    {
        Vehicle car = CreateVehicle(Console.ReadLine().Split());
        Vehicle truck = CreateVehicle(Console.ReadLine().Split());
        Vehicle bus = CreateVehicle(Console.ReadLine().Split());

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] arguments = Console.ReadLine().Split();
            string action = arguments[0];
            string vehicleType = arguments[1];
            double parameter = double.Parse(arguments[2]);

            Vehicle currentVehicle;
            if (vehicleType == "Car") currentVehicle = car;
            else if (vehicleType == "Truck") currentVehicle = truck;
            else if (vehicleType == "Bus") currentVehicle = bus;
            else currentVehicle = null;

            if (currentVehicle == null)
            {
                continue;
            }

            if (action == "Drive")
            {
                currentVehicle.IsAirConditionerOn = true;
                currentVehicle.Drive(parameter);
            }
            else if (action == "DriveEmpty" && currentVehicle is Bus)
            {
                currentVehicle.IsAirConditionerOn = false;
                currentVehicle.Drive(parameter);
            }
            else if (action == "Refuel")
            {
                currentVehicle.Refuel(parameter);
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }

    private static Vehicle CreateVehicle(string[] data)
    {
        string type = data[0];
        double fuelQuantity = double.Parse(data[1]);
        double fuelConsumption = double.Parse(data[2]);
        double tankCapacity = double.Parse(data[3]);

        if (type == "Car")
        {
            return new Car(fuelQuantity, fuelConsumption, tankCapacity);
        }

        if (type == "Truck")
        {
            return new Truck(fuelQuantity, fuelConsumption, tankCapacity);
        }

        if (type == "Bus")
        {
            return new Bus(fuelQuantity, fuelConsumption, tankCapacity);
        }

        return null;
    }
}
}
