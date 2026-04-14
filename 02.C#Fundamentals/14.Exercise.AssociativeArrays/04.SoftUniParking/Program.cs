class Program
{
    static void Main()
    {
        Dictionary<string, string> users = new Dictionary<string, string>();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] arguments = Console.ReadLine().Split();

            string command = arguments[0];
            string username = arguments[1];

            switch (command)
            {
                case "register":
                {
                    string plate = arguments[2];

                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, plate);
                        Console.WriteLine($"{username} registered {plate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[username]}");
                    }

                    break;
                }
                case "unregister":
                {
                    bool isRemoved = users.Remove(username);
                    if (isRemoved)
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }

                    break;
                }
            }
        }

        foreach (KeyValuePair<string, string> user in users)
        {
            Console.WriteLine($"{user.Key} => {user.Value}");
        }
    }
}
