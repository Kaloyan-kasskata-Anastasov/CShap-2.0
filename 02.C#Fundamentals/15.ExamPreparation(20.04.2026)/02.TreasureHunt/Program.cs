/*
Gold|Silver|Bronze|Medallion|Cup
Loot Wood Gold Coins
Loot Silver Pistol
Drop 3
Steal 3
Yohoho!

 */

class Program
{
    static void Main()
    {
        List<string> treasures = Console.ReadLine().Split('|').ToList();

        string commands;
        while ((commands = Console.ReadLine()) != "Yohoho!")
        {
            List<string> arguments = commands.Split().ToList();

            switch (arguments[0])
            {
                case "Loot":
                    LootItems(treasures, arguments.GetRange(1, arguments.Count - 1));
                    break;
                case "Drop":
                    DropItem(treasures, int.Parse(arguments[1]));
                    break;
                case "Steal":
                    StealItems(treasures, int.Parse(arguments[1]));
                    break;
            }
        }

        PrintResults(treasures);
    }

    static void LootItems(List<string> treasures, List<string> items)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (!treasures.Contains(items[i]))
            {
                treasures.Insert(0, items[i]);
            }
        }
    }

    static void DropItem(List<string> treasures, int index)
    {
        if (index >= 0 && index <= treasures.Count - 1)
        {
            string itemToMove = treasures[index];
            treasures.RemoveAt(index);
            treasures.Add(itemToMove);
        }
    }

    static void StealItems(List<string> treasures, int count)
    {
        int actualCount = Math.Min(count, treasures.Count);
        int startIndex = treasures.Count - actualCount;

        List<string> stolenItems = treasures.GetRange(startIndex, actualCount);
        treasures.RemoveRange(startIndex, actualCount);

        Console.WriteLine(string.Join(", ", stolenItems));
    }

    static void PrintResults(List<string> chest)
    {
        if (chest.Count == 0)
        {
            Console.WriteLine("Failed treasure hunt.");
        }
        else
        {
            double sumOfLengths = chest.Sum(item => item.Length);
            double averageGain = sumOfLengths / chest.Count;
            Console.WriteLine($"Average treasure gain: {averageGain:F2} pirate credits.");
        }
    }
}
