namespace WildFarm;

public class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {
    }

    protected override double WeightMultiplier
    {
        get { return 0.30; }
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Meow");
    }

    protected override bool DoesEat(Food food)
    {
        return food is Vegetable || food is Meat;
    }
}