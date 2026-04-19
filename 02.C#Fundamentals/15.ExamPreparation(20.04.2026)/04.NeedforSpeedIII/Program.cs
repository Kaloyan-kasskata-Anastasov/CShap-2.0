class Program
{
    static Dictionary<string, int> carMileage = new Dictionary<string, int>();
    static Dictionary<string, int> carFuel = new Dictionary<string, int>();

    // In one combines car data.
    //static Dictionary<string, Dictionary<int, int>> carToMilesFuelMap = new Dictionary<string, Dictionary<int,int>>();

    static void Main()
    {
        int carsCount = int.Parse(Console.ReadLine());


        for (int i = 0; i < carsCount; i++)
        {
            string[] carData = Console.ReadLine().Split('|');
            string name = carData[0];
            int mileage = int.Parse(carData[1]);
            int fuel = int.Parse(carData[2]);

            carMileage[name] = mileage;
            carFuel[name] = fuel;
        }

        string command;
        while ((command = Console.ReadLine()) != "Stop")
        {
            string[] arguments = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            string carName = arguments[1];

            switch (arguments[0])
            {
                case "Drive":
                    {
                        int distance = int.Parse(arguments[2]);
                        int fuelNeeded = int.Parse(arguments[3]);
                        Drive(carName, fuelNeeded, distance);
                        break;
                    }
                case "Refuel":
                    {
                        int fuelToAdd = int.Parse(arguments[2]);
                        int currentFuel = carFuel[carName];
                        int refilledAmount = fuelToAdd;
                        Refuel(currentFuel, fuelToAdd, refilledAmount, carName);
                        break;
                    }
                case "Revert":
                    {
                        int kmToRevert = int.Parse(arguments[2]);
                        Revert(carName, kmToRevert);
                        break;
                    }
            }
        }

        foreach (string carName in carMileage.Keys)
        {
            int mileage = carMileage[carName];
            int fuel = carFuel[carName];

            Console.WriteLine($"{carName} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");
        }
    }

    private static void Drive(string carName, int fuelNeeded, int distance)
    {
        if (carFuel[carName] < fuelNeeded)
        {
            Console.WriteLine("Not enough fuel to make that ride");
        }
        else
        {
            carFuel[carName] -= fuelNeeded;
            carMileage[carName] += distance;
            Console.WriteLine($"{carName} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");

            if (carMileage[carName] >= 100000)
            {
                Console.WriteLine($"Time to sell the {carName}!");
                carMileage.Remove(carName);
                carFuel.Remove(carName);
            }
        }
    }

    private static void Refuel(int currentFuel, int fuelToAdd, int refilledAmount, string carName)
    {
        if (currentFuel + fuelToAdd > 75)
        {
            refilledAmount = 75 - currentFuel;
        }

        carFuel[carName] += refilledAmount;
        Console.WriteLine($"{carName} refueled with {refilledAmount} liters");
    }

    private static void Revert(string carName, int kmToRevert)
    {
        carMileage[carName] -= kmToRevert;

        if (carMileage[carName] < 10000)
        {
            carMileage[carName] = 10000;
        }
        else
        {
            Console.WriteLine($"{carName} mileage decreased by {kmToRevert} kilometers");
        }
    }
}
