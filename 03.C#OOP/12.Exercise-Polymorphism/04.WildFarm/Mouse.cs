namespace WildFarm;

public class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    protected override double WeightMultiplier
    {
        get { return 0.10; }
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Squeak");
    }

    protected override bool DoesEat(Food food)
    {
        return food is Vegetable || food is Fruit;
    }
}