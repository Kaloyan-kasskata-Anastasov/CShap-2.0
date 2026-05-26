namespace WildFarm;

public abstract class Animal
{
    protected Animal(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }

    public string Name { get; }
    public double Weight { get; protected set; }
    public int FoodEaten { get; protected set; }
    protected abstract double WeightMultiplier { get; }

    public abstract void ProduceSound();

    protected abstract bool DoesEat(Food food);

    public virtual void Eat(Food food)
    {
        if (!DoesEat(food))
        {
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            return;
        }

        Weight += food.Quantity * WeightMultiplier;
        FoodEaten += food.Quantity;
    }
}