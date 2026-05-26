namespace Vehicles;

internal class Truck : Vehicle
{
    private const double AcConsumptionModifier = 1.6;
    private const double RefuelEfficiency = 0.95;

    public Truck(double fuelQuantity, double fuelConsumption)
        : base(fuelQuantity, fuelConsumption)
    {
    }

    public override double FuelConsumption
    {
        get { return base.FuelConsumption + AcConsumptionModifier; }
    }

    public override void Refuel(double liters)
    {
        base.Refuel(liters * RefuelEfficiency);
    }
}