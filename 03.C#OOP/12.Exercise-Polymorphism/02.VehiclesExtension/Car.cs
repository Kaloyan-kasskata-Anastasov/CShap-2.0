namespace VehiclesExtension;

public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    protected override double AcConsumptionModifier
    {
        get { return 0.9; }
    }
}