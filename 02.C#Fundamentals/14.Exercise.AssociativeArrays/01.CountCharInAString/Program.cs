class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<char, int> counts = new Dictionary<char, int>();

        foreach (char ch in input)
        {
            if (ch == ' ')
            {
                continue;
            }

            if (!counts.ContainsKey(ch))
            {
                counts[ch] = 0;
            }

            counts[ch]++;
        }

        foreach (KeyValuePair<char, int> pair in counts)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}
