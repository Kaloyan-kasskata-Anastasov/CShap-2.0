/*
500
7
66
15
*/

class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        int nights = int.Parse(Console.ReadLine());
        double pricePerNight = double.Parse(Console.ReadLine());
        int percentExtra = int.Parse(Console.ReadLine());

        if (nights > 7)
        {
            pricePerNight *= 0.95;
        }

        double totalForNights = nights * pricePerNight;
        double extraExpenses = budget * percentExtra / 100.0;

        double totalNeeded = totalForNights + extraExpenses;

        if (budget >= totalNeeded)
        {
            double remaining = budget - totalNeeded;
            Console.WriteLine($"Ivanovi will be left with {remaining:F2} leva after vacation.");
        }
        else
        {
            double needed = totalNeeded - budget;
            Console.WriteLine($"{needed:F2} leva needed.");
        }
    }
}
