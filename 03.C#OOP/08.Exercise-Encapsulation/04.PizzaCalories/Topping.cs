namespace PizzaCalories;

using System;

public class Topping
{
    private const double BaseCaloriesPerGram = 2.0;
    private const double MinWeight = 1.0;
    private const double MaxWeight = 50.0;

    private const double MeatModifier = 1.2;
    private const double VeggiesModifier = 0.8;
    private const double CheeseModifier = 1.1;
    private const double SauceModifier = 0.9;
    private const double DefaultModifier = 1.0;

    private string type;
    private double weight;

    public Topping(string type, double weight)
    {
        Type = type;
        Weight = weight;
    }

    private string Type
    {
        get => type;
        set
        {
            string lowered = value.ToLower();
            if (lowered != "meat" && lowered != "veggies" && lowered != "cheese" && lowered != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            type = value;
        }
    }

    private double Weight
    {
        get => weight;
        set
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException($"{Type} weight should be in the range [{MinWeight}..{MaxWeight}].");
            }

            weight = value;
        }
    }

    public double Calories
    {
        get
        {
            double modifier = DefaultModifier;
            switch (Type.ToLower())
            {
                case "meat": modifier = MeatModifier; break;
                case "veggies": modifier = VeggiesModifier; break;
                case "cheese": modifier = CheeseModifier; break;
                case "sauce": modifier = SauceModifier; break;
            }

            return BaseCaloriesPerGram * Weight * modifier;
        }
    }
}
