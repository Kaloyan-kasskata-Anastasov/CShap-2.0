/*
20

175

2703

15875
*/

class Program
{
    static void Main()
    {
        int points = int.Parse(Console.ReadLine());
        double bonusPoints = 0;

        if (points <= 100)
        {
            bonusPoints = 5;
        }
        else if (points <= 1000)
        {
            bonusPoints = points * 0.20;
        }
        else
        {
            bonusPoints = points * 0.10;
        }

        if (points % 2 == 0)
        {
            bonusPoints += 1;
        }

        if (points % 10 == 5)
        {
            bonusPoints += 2;
        }

        Console.WriteLine(bonusPoints);
        Console.WriteLine(points + bonusPoints);
    }
}
