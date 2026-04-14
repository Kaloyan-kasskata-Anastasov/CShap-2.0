class Program
{
    static void Main()
    {
        Dictionary<string, long> resources = new Dictionary<string, long>();

        string command;
        while ((command = Console.ReadLine()) != "stop")
        {
            string[] arguments = command.Split(" -> ");
            string resource = arguments[0];
            long quantity = long.Parse(Console.ReadLine());

            if (!resources.ContainsKey(resource))
            {
                resources.Add(resource, 0);
            }

            resources[resource] += quantity;
        }

        foreach (KeyValuePair<string, long> pair in resources)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}
