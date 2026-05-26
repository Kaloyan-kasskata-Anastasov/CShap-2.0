namespace WildFarm;

public class Hen : Bird
{
    public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }

    protected override double WeightMultiplier
    {
        get { return 0.35; }
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Cluck");
    }

    protected override bool DoesEat(Food food)
    {
        return true;
    }
}