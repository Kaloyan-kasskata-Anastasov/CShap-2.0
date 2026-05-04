class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}

class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}

class Catalog
{
    public List<Car> Cars { get; set; } = new List<Car>();
    public List<Truck> Trucks { get; set; } = new List<Truck>();
}

class Program
{
    static void Main()
    {
        Catalog catalog = new Catalog();
        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] data = input.Split('/');
            string type = data[0];
            string brand = data[1];
            string model = data[2];
            int value = int.Parse(data[3]);

            if (type == "Car")
            {
                catalog.Cars.Add(new Car { Brand = brand, Model = model, HorsePower = value });
            }
            else
            {
                catalog.Trucks.Add(new Truck { Brand = brand, Model = model, Weight = value });
            }

            input = Console.ReadLine();
        }

        if (catalog.Cars.Count > 0)
        {
            Console.WriteLine("Cars:");
            foreach (Car car in catalog.Cars.OrderBy(c => c.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
        }

        if (catalog.Trucks.Count > 0)
        {
            Console.WriteLine("Trucks:");
            foreach (Truck truck in catalog.Trucks.OrderBy(t => t.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
