class Program
{
    static void Main()
    {
        Dictionary<string, double> prices = new Dictionary<string, double>();
        Dictionary<string, int> quantities = new Dictionary<string, int>();

        string input;
        while ((input = Console.ReadLine()) != "buy")
        {
            string[] argumens = input.Split();
            string name = argumens[0];
            double price = double.Parse(argumens[1]);
            int quantity = int.Parse(argumens[2]);

            if (!prices.ContainsKey(name))
            {
                prices[name] = price;
                quantities[name] = quantity;
            }
            else
            {
                prices[name] = price;
                quantities[name] += quantity;
            }
        }

        foreach (KeyValuePair<string, double> item in prices)
        {
            string name = item.Key;
            double total = prices[name] * quantities[name];

            Console.WriteLine($"{name} -> {total:F2}");
        }
    }
}
