class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> companies =
            new Dictionary<string, List<string>>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] parts = command.Split(" -> ");
            string company = parts[0];
            string employeeId = parts[1];

            if (!companies.ContainsKey(company))
            {
                companies.Add(company, new List<string>());
            }

            if (!companies[company].Contains(employeeId))
            {
                companies[company].Add(employeeId);
            }
        }
        
        foreach (KeyValuePair<string, List<string>> company in companies)
        {
            Console.WriteLine(company.Key);

            foreach (string id in company.Value)
            {
                Console.WriteLine($"-- {id}");
            }
        }
    }
}
