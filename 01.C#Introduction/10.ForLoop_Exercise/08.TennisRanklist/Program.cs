/*
5
1400
F
SF
W
W
SF
*/

class Program
{
    static void Main()
    {
        int tournaments = int.Parse(Console.ReadLine());
        int startPoints = int.Parse(Console.ReadLine());

        int totalPoints = startPoints;
        int earnedPoints = 0;
        int wins = 0;

        for (int i = 0; i < tournaments; i++)
        {
            string result = Console.ReadLine();

            if (result == "W")
            {
                earnedPoints += 2000;
                wins++;
            }
            else if (result == "F")
            {
                earnedPoints += 1200;
            }
            else if (result == "SF")
            {
                earnedPoints += 720;
            }
        }

        totalPoints += earnedPoints;
        int averagePoints = earnedPoints / tournaments;
        double winPercent = wins * 100.0 / tournaments;

        Console.WriteLine($"Final points: {totalPoints}");
        Console.WriteLine($"Average points: {averagePoints}");
        Console.WriteLine($"{winPercent:f2}%");
    }
}
