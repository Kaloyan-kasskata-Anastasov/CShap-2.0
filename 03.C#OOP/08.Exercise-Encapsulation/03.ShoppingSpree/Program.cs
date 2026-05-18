namespace ShoppingSpree
{
public class StartUp
{
    public static void Main(string[] args)
    {
        Dictionary<string, Person> people = new Dictionary<string, Person>();
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        try
        {
            string[] peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in peopleInput)
            {
                string[] arguments = token.Split('=');
                string name = arguments[0];
                decimal money = decimal.Parse(arguments[1]);

                Person person = new Person(name, money);
                people.Add(name, person);
            }

            string[] productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in productsInput)
            {
                string[] arguments = token.Split('=');
                string name = arguments[0];
                decimal cost = decimal.Parse(arguments[1]);

                Product product = new Product(name, cost);
                products.Add(name, product);
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] arguments = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string personName = arguments[0];
                string productName = arguments[1];

                if (people.ContainsKey(personName) && products.ContainsKey(productName))
                {
                    Person person = people[personName];
                    Product product = products[productName];
                    person.BuyProduct(product);
                }
            }

            foreach (Person person in people.Values)
            {
                Console.WriteLine(person);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
}
