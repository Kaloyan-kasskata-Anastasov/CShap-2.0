namespace NeedForSpeed
{
public class Vehicle
{
    public const double DefaultFuelConsumption = 1.25;

    public Vehicle(int horsePower, double fuel)
    {
        HorsePower = horsePower;
        Fuel = fuel;
    }

    public virtual double FuelConsumption => DefaultFuelConsumption;
    public double Fuel { get; set; }
    public int HorsePower { get; set; }

    public virtual void Drive(double kilometers)
    {
        double fuelNeeded = kilometers * FuelConsumption;
        if (Fuel >= fuelNeeded)
        {
            Fuel -= fuelNeeded;
        }
    }
}

public class Motorcycle : Vehicle
{
    public Motorcycle(int horsePower, double fuel)
        : base(horsePower, fuel)
    {
    }
}

public class Car : Vehicle
{
    public new const double DefaultFuelConsumption = 3;

    public Car(int horsePower, double fuel)
        : base(horsePower, fuel)
    {
    }

    public override double FuelConsumption => DefaultFuelConsumption;
}

public class RaceMotorcycle : Motorcycle
{
    public new const double DefaultFuelConsumption = 8;

    public RaceMotorcycle(int horsePower, double fuel)
        : base(horsePower, fuel)
    {
    }

    public override double FuelConsumption => DefaultFuelConsumption;
}

public class CrossMotorcycle : Motorcycle
{
    public CrossMotorcycle(int horsePower, double fuel)
        : base(horsePower, fuel)
    {
    }
}

public class FamilyCar : Car
{
    public FamilyCar(int horsePower, double fuel)
        : base(horsePower, fuel)
    {
    }
}

public class SportCar : Car
{
    public new const double DefaultFuelConsumption = 10;

    public SportCar(int horsePower, double fuel)
        : base(horsePower, fuel)
    {
    }

    public override double FuelConsumption => DefaultFuelConsumption;
}

public class StartUp
{
    public static void Main(string[] args)
    {
    }
}
}
