namespace Restaurant
{
public class StartUp
{
    public static void Main(string[] args)
    {
    }
}

public class Product
{
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Beverage : Product
{
    public Beverage(string name, decimal price, double milliliters)
        : base(name, price)
    {
        Milliliters = milliliters;
    }

    public double Milliliters { get; set; }
}

public class HotBeverage : Beverage
{
    public HotBeverage(string name, decimal price, double milliliters)
        : base(name, price, milliliters)
    {
    }
}

public class ColdBeverage : Beverage
{
    public ColdBeverage(string name, decimal price, double milliliters)
        : base(name, price, milliliters)
    {
    }
}

public class Tea : HotBeverage
{
    public Tea(string name, decimal price, double milliliters)
        : base(name, price, milliliters)
    {
    }
}

public class Coffee : HotBeverage
{
    public Coffee(string name, double caffeine)
        : base(name, 3.50m, 50)
    {
        Caffeine = caffeine;
    }

    public double Caffeine { get; set; }
}

public class Food : Product
{
    public Food(string name, decimal price, double grams)
        : base(name, price)
    {
        Grams = grams;
    }

    public double Grams { get; set; }
}

public class MainDish : Food
{
    public MainDish(string name, decimal price, double grams)
        : base(name, price, grams)
    {
    }
}

public class Starter : Food
{
    public Starter(string name, decimal price, double grams)
        : base(name, price, grams)
    {
    }
}

public class Dessert : Food
{
    public Dessert(string name, decimal price, double grams, double calories)
        : base(name, price, grams)
    {
        Calories = calories;
    }

    public double Calories { get; set; }
}

public class Fish : MainDish
{
    public Fish(string name, decimal price)
        : base(name, price, 22)
    {
    }
}

public class Soup : Starter
{
    public Soup(string name, decimal price, double grams)
        : base(name, price, grams)
    {
    }
}

public class Cake : Dessert
{
    public Cake(string name)
        : base(name, 5m, 250, 1000)
    {
    }
}
}
