//class Program
//{
//    // Combined car data: CarName -> { "Distance": value, "Fuel": value }
//    static Dictionary<string, Dictionary<string, int>> carDataMap = new Dictionary<string, Dictionary<string, int>>();

//    static void Main()
//    {
//        int carsCount = int.Parse(Console.ReadLine());

//        for (int i = 0; i < carsCount; i++)
//        {
//            string[] carData = Console.ReadLine().Split('|');
//            string car = carData[0];
//            int mileage = int.Parse(carData[1]);
//            int fuel = int.Parse(carData[2]);

//            carDataMap[car] = new Dictionary<string, int>
//            {
//                { "Distance", mileage },
//                { "Fuel", fuel }
//            };
//        }

//        string command;
//        while ((command = Console.ReadLine()) != "Stop")
//        {
//            string[] arguments = command.Split(" : ");
//            string car = arguments[1];

//            switch (arguments[0])
//            {
//                case "Drive":
//                    int distance = int.Parse(arguments[2]);
//                    int fuelNeeded = int.Parse(arguments[3]);
//                    Drive(car, fuelNeeded, distance);
//                    break;
//                case "Refuel":
//                    int fuelToAdd = int.Parse(arguments[2]);
//                    Refuel(car, fuelToAdd);
//                    break;
//                case "Revert":
//                    int kmToRevert = int.Parse(arguments[2]);
//                    Revert(car, kmToRevert);
//                    break;
//            }
//        }

//        foreach (KeyValuePair<string, Dictionary<string, int>> carData in carDataMap)
//        {
//            string ar = carData.Key;
//            int mileage = carData.Value["Distance"];
//            int fuel = carData.Value["Fuel"];

//            Console.WriteLine($"{ar} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");
//        }
//    }

//    private static void Drive(string car, int fuelNeeded, int distance)
//    {
//        if (carDataMap[car]["Fuel"] < fuelNeeded)
//        {
//            Console.WriteLine("Not enough fuel to make that ride");
//        }
//        else
//        {
//            carDataMap[car]["Fuel"] -= fuelNeeded;
//            carDataMap[car]["Distance"] += distance;
//            Console.WriteLine($"{car} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");

//            if (carDataMap[car]["Distance"] >= 100000)
//            {
//                Console.WriteLine($"Time to sell the {car}!");
//                carDataMap.Remove(car);
//            }
//        }
//    }

//    private static void Refuel(string car, int fuelToAdd)
//    {
//        int currentFuel = carDataMap[car]["Fuel"];
//        int refilledAmount = fuelToAdd;

//        if (currentFuel + fuelToAdd > 75)
//        {
//            refilledAmount = 75 - currentFuel;
//        }

//        carDataMap[car]["Fuel"] += refilledAmount;
//        Console.WriteLine($"{car} refueled with {refilledAmount} liters");
//    }

//    private static void Revert(string car, int kmToRevert)
//    {
//        carDataMap[car]["Distance"] -= kmToRevert;

//        if (carDataMap[car]["Distance"] < 10000)
//        {
//            carDataMap[car]["Distance"] = 10000;
//        }
//        else
//        {
//            Console.WriteLine($"{car} mileage decreased by {kmToRevert} kilometers");
//        }
//    }
//}