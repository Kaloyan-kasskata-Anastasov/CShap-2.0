/*
9
30
9
50

9
00
8
30

16
00
15
00
*/

class Program
{
    static void Main()
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinute = int.Parse(Console.ReadLine());
        int arriveHour = int.Parse(Console.ReadLine());
        int arriveMinute = int.Parse(Console.ReadLine());

        int examTime = examHour * 60 + examMinute;
        int arriveTime = arriveHour * 60 + arriveMinute;

        int difference = arriveTime - examTime;

        if (difference > 0)
        {
            Console.WriteLine("Late");
            if (difference < 60)
            {
                Console.WriteLine($"{difference} minutes after the start");
            }
            else
            {
                Console.WriteLine($"{difference / 60}:{difference % 60:D2} hours after the start");
            }
        }
        else if (difference >= -30)
        {
            Console.WriteLine("On time");
            if (difference != 0)
            {
                Console.WriteLine($"{-difference} minutes before the start");
            }
        }
        else
        {
            Console.WriteLine("Early");
            int earlyHours = -difference / 60;
            int earlyMinutes = -difference % 60;

            if (earlyHours > 0)
            {
                Console.WriteLine($"{earlyHours}:{earlyMinutes:D2} hours before the start");
            }
            else
            {
                Console.WriteLine($"{earlyMinutes} minutes before the start");
            }
        }
    }
}
