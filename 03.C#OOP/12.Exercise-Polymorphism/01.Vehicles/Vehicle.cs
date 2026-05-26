namespace Vehicles;

internal abstract class Vehicle
{
    protected Vehicle(double fuelQuantity, double fuelConsumption)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
    }

    public double FuelQuantity { get; protected set; }
    public virtual double FuelConsumption { get; protected set; }

    public void Drive(double distance)
    {
        double neededFuel = distance * FuelConsumption;

        if (FuelQuantity >= neededFuel)
        {
            FuelQuantity -= neededFuel;
            Console.WriteLine($"{GetType().Name} travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"{GetType().Name} needs refueling");
        }
    }

    public virtual void Refuel(double liters)
    {
        FuelQuantity += liters;
    }

    public override string ToString()
    {
        return $"{GetType().Name}: {FuelQuantity:F2}";
    }
}