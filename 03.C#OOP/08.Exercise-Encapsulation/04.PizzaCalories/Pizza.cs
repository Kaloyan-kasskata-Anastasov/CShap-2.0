namespace PizzaCalories;

using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    public const int MinNameLength = 1;
    public const int MaxNameLength = 15;
    public const int MaxToppingsCount = 10;

    private string name;
    private List<Topping> toppings;

    public Pizza(string name, Dough dough)
    {
        Name = name;
        Dough = dough;
        toppings = new List<Topping>();
    }

    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > MaxNameLength)
            {
                throw new ArgumentException($"Pizza name should be between {MinNameLength} and {MaxNameLength} symbols.");
            }

            name = value;
        }
    }

    public Dough Dough { get; }

    public double TotalCalories
    {
        get { return Dough.Calories + toppings.Sum(t => t.Calories); }
    }

    public void AddTopping(Topping topping)
    {
        if (toppings.Count >= MaxToppingsCount)
        {
            throw new ArgumentException($"Number of toppings should be in range [0..{MaxToppingsCount}].");
        }

        toppings.Add(topping);
    }

    public override string ToString()
    {
        return $"{Name} - {TotalCalories:F2} Calories.";
    }
}
