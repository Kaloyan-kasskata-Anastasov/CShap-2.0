using NUnit.Framework;
using System;

namespace CarManager.Tests
{
[TestFixture]
public class CarTests
{
    private Car car;

    [SetUp]
    public void Setup()
    {
        this.car = new Car("Toyota", "Corolla", 5.0, 50.0);
    }

    [Test]
    public void Constructor_WithValidData_ShouldInitializeProperties()
    {
        Assert.AreEqual("Toyota", this.car.Make);
        Assert.AreEqual("Corolla", this.car.Model);
        Assert.AreEqual(5.0, this.car.FuelConsumption);
        Assert.AreEqual(50.0, this.car.FuelCapacity);
        Assert.AreEqual(0, this.car.FuelAmount);
    }

    [TestCase(null)]
    [TestCase("")]
    public void Constructor_NullOrEmptyMake_ShouldThrowArgumentException(string make)
    {
        Assert.Throws<ArgumentException>(() => new Car(make, "Corolla", 5.0, 50.0));
    }

    [TestCase(null)]
    [TestCase("")]
    public void Constructor_NullOrEmptyModel_ShouldThrowArgumentException(string model)
    {
        Assert.Throws<ArgumentException>(() => new Car("Toyota", model, 5.0, 50.0));
    }

    [TestCase(0)]
    [TestCase(-5.0)]
    public void Constructor_ZeroOrNegativeFuelConsumption_ShouldThrowArgumentException(double consumption)
    {
        Assert.Throws<ArgumentException>(() => new Car("Toyota", "Corolla", consumption, 50.0));
    }

    [TestCase(0)]
    [TestCase(-10.0)]
    public void Constructor_ZeroOrNegativeFuelCapacity_ShouldThrowArgumentException(double capacity)
    {
        Assert.Throws<ArgumentException>(() => new Car("Toyota", "Corolla", 5.0, capacity));
    }

    [TestCase(0)]
    [TestCase(-20.0)]
    public void Refuel_ZeroOrNegativeAmount_ShouldThrowArgumentException(double amount)
    {
        Assert.Throws<ArgumentException>(() => this.car.Refuel(amount));
    }

    [Test]
    public void Refuel_ValidAmount_ShouldIncreaseFuelAmount()
    {
        this.car.Refuel(20);
        Assert.AreEqual(20, this.car.FuelAmount);
    }

    [Test]
    public void Refuel_ExceedingCapacity_ShouldSetToCapacity()
    {
        this.car.Refuel(60);
        Assert.AreEqual(50, this.car.FuelAmount);
    }

    [Test]
    public void Drive_WithoutEnoughFuel_ShouldThrowInvalidOperationException()
    {
        this.car.Refuel(1);
        Assert.Throws<InvalidOperationException>(() => this.car.Drive(100));
    }

    [Test]
    public void Drive_WithEnoughFuel_ShouldDecreaseFuelAmount()
    {
        this.car.Refuel(20);
        this.car.Drive(100);
        Assert.AreEqual(15, this.car.FuelAmount);
    }
}
}
