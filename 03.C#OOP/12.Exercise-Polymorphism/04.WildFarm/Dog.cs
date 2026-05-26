namespace WildFarm;

public class Dog : Mammal
{
    public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    protected override double WeightMultiplier
    {
        get { return 0.40; }
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Woof!");
    }

    protected override bool DoesEat(Food food)
    {
        return food is Meat;
    }
}