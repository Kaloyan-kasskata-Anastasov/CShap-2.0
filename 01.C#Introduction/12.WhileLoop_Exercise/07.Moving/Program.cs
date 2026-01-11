/*
10
10
2
20
20
20
20
122

10
1
2
4
6
Done

*/

class Program
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        int freeSpace = width * length * height;

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Done")
            {
                break;
            }

            int boxes = int.Parse(input);
            freeSpace -= boxes;

            if (freeSpace < 0)
            {
                break;
            }
        }

        if (freeSpace >= 0)
        {
            Console.WriteLine($"{freeSpace} Cubic meters left.");
        }
        else
        {
            Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
        }
    }
}
