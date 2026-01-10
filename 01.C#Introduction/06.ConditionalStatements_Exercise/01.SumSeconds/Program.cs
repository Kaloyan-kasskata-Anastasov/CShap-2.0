/*
35
45
44

22
7
34

50
50
49

14
12
10
*/

class Program
{
    static void Main()
    {
        int firstTime = int.Parse(Console.ReadLine());
        int secondTime = int.Parse(Console.ReadLine());
        int thirdTime = int.Parse(Console.ReadLine());

        int totalSeconds = firstTime + secondTime + thirdTime;

        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        Console.WriteLine($"{minutes}:{seconds:D2}");
    }
}
