/*
5
4
one
two
one
two
two
End
*/

class Program
{
    static void Main()
    {
        int playerOne = int.Parse(Console.ReadLine());
        int playerTwo = int.Parse(Console.ReadLine());

        string command = "";
        while ((command = Console.ReadLine()) != "End")
        {
            if (command == "one")
            {
                playerTwo -= 1;
            }
            else if (command == "two")
            {
                playerOne -= 1;
            }

            if (playerOne == 0 || playerTwo == 0)
            {
                break;
            }
        }

        if (playerOne == 0)
        {
            Console.WriteLine($"Player one is out of eggs. Player two has {playerTwo} eggs left.");
        }
        else if (playerTwo == 0)
        {
            Console.WriteLine($"Player two is out of eggs. Player one has {playerOne} eggs left.");
        }
        else
        {
            Console.WriteLine($"Player one has {playerOne} eggs left.");
            Console.WriteLine($"Player two has {playerTwo} eggs left.");
        }
    }
}
