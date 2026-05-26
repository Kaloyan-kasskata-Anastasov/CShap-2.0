namespace WildFarm;

public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {
    }

    protected override double WeightMultiplier
    {
        get { return 1.00; }
    }

    public override void ProduceSound()
    {
        Console.WriteLine("ROAR!!!");
    }

    protected override bool DoesEat(Food food)
    {
        return food is Meat;
    }
}