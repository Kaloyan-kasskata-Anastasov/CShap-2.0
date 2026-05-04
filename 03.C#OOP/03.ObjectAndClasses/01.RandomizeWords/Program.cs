class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Random rnd = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            int randomIndex = rnd.Next(0, words.Length);

            string temporary = words[i];
            words[i] = words[randomIndex];
            words[randomIndex] = temporary;
        }

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
