/*
Game of Thrones
60
96

Teen Wolf
48
60
*/

class Program
{
    static void Main()
    {
        string seriesName = Console.ReadLine();
        int episodeDuration = int.Parse(Console.ReadLine());
        int breakDuration = int.Parse(Console.ReadLine());

        double lunchTime = breakDuration / 8.0;
        double restTime = breakDuration / 4.0;

        double freeTime = breakDuration - lunchTime - restTime;

        if (freeTime >= episodeDuration)
        {
            double leftTime = Math.Ceiling(freeTime - episodeDuration);
            Console.WriteLine($"You have enough time to watch {seriesName} and left with {leftTime} minutes free time.");
        }
        else
        {
            double neededTime = Math.Ceiling(episodeDuration - freeTime);
            Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {neededTime} more minutes.");
        }
    }
}
