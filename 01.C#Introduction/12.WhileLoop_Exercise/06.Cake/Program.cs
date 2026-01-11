/*
10
10
20
20
20
20
21

10
2
2
4
6
STOP
*/

class Program
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());

        int piecesLeft = width * length;

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "STOP")
            {
                break;
            }

            int piecesTaken = int.Parse(input);
            piecesLeft -= piecesTaken;

            if (piecesLeft < 0)
            {
                break;
            }
        }

        if (piecesLeft >= 0)
        {
            Console.WriteLine($"{piecesLeft} pieces are left.");
        }
        else
        {
            Console.WriteLine($"No more cake left! You need {Math.Abs(piecesLeft)} pieces more.");
        }
    }
}
