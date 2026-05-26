namespace Vehicles;

internal class Car : Vehicle
{
    private const double AcConsumptionModifier = 0.9;

    public Car(double fuelQuantity, double fuelConsumption)
        : base(fuelQuantity, fuelConsumption)
    {
    }

    public override double FuelConsumption
    {
        get { return base.FuelConsumption + AcConsumptionModifier; }
    }
}