namespace VehiclesExtension;

public abstract class Vehicle
{
    private double fuelQuantity;

    protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        TankCapacity = tankCapacity;
        FuelConsumption = fuelConsumption;

        if (fuelQuantity > tankCapacity)
        {
            FuelQuantity = 0;
        }
        else
        {
            FuelQuantity = fuelQuantity;
        }
    }

    public double TankCapacity { get; }

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        protected set { fuelQuantity = value; }
    }

    public double FuelConsumption { get; }

    public bool IsAirConditionerOn { get; set; } = true;

    protected abstract double AcConsumptionModifier { get; }

    public void Drive(double distance)
    {
        double consumption = IsAirConditionerOn ? FuelConsumption + AcConsumptionModifier : FuelConsumption;
        double neededFuel = distance * consumption;

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

        FuelQuantity += liters;
    }

    public override string ToString()
    {
        return $"{GetType().Name}: {FuelQuantity:F2}";
    }
}