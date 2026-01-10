/*
50
summer

 75
winter

312
summer

678.53
winter

1500
summer
 */

class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string destination = "";
        string stay = "";
        double spent = 0;

        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season == "summer")
            {
                stay = "Camp";
                spent = budget * 0.3;
            }
            else
            {
                stay = "Hotel";
                spent = budget * 0.7;
            }
        }
        else if (budget <= 1000)
        {
            destination = "Balkans";
            if (season == "summer")
            {
                stay = "Camp";
                spent = budget * 0.4;
            }
            else
            {
                stay = "Hotel";
                spent = budget * 0.8;
            }
        }
        else
        {
            destination = "Europe";
            stay = "Hotel";
            spent = budget * 0.9;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{stay} - {spent:f2}");
    }
}
