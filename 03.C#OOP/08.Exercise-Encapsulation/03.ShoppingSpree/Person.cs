namespace ShoppingSpree;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> bag;

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        bag = new List<Product>();
    }

    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            name = value;
        }
    }

    public decimal Money
    {
        get => money;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            money = value;
        }
    }

    public void BuyProduct(Product product)
    {
        if (Money >= product.Cost)
        {
            Money -= product.Cost;
            bag.Add(product);
            Console.WriteLine($"{Name} bought {product.Name}");
        }
        else
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
        }
    }

    public override string ToString()
    {
        string itemsOutput;
        if (bag.Count > 0)
        {
            itemsOutput = string.Join(", ", bag.Select(p => p.Name));
        }
        else
        {
            itemsOutput = "Nothing bought";
        }

        return $"{Name} - {itemsOutput}";
    }
}
