/*
1
46

0
01

23
59

11
08

12
49
*/

class Program
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 15;

        if (minutes >= 60)
        {
            minutes -= 60;
            hours += 1;
        }

        if (hours == 24)
        {
            hours = 0;
        }

        if (minutes < 10)
        {
            Console.WriteLine($"{hours}:0{minutes}");
        }
        else
        {
            Console.WriteLine($"{hours}:{minutes}");
        }
    }
}
