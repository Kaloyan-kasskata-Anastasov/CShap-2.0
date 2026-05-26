namespace VehiclesExtension;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    protected override double AcConsumptionModifier
    {
        get { return 1.6; }
    }

    public override void Refuel(double liters)
    {
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
            return;
        }

        if (FuelQuantity + liters > TankCapacity)
        {
            Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            return;
        }

        FuelQuantity += liters * 0.95;
    }
}