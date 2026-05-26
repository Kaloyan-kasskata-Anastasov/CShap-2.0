namespace WildFarm;

public class Owl : Bird
{
    public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }

    protected override double WeightMultiplier
    {
        get { return 0.25; }
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Hoot Hoot");
    }

    protected override bool DoesEat(Food food)
    {
        return food is Meat;
    }
}