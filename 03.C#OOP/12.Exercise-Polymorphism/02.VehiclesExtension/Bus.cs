namespace VehiclesExtension;

public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    protected override double AcConsumptionModifier
    {
        get { return 1.4; }
    }
}