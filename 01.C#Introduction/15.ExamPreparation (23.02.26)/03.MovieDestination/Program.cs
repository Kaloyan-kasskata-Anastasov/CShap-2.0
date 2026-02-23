/*
400000
Sofia
Winter
20
*/
class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string destination = Console.ReadLine();
        string season = Console.ReadLine();
        int days = int.Parse(Console.ReadLine());

        double pricePerDay = 0;
        if (destination == "Dubai")
        {
            if (season == "Winter")
            {
                pricePerDay = 45000;
            }
            else
            {
                pricePerDay = 40000;
            }
        }
        else if (destination == "Sofia")
        {
            if (season == "Winter")
            {
                pricePerDay = 17000;
            }
            else
            {
                pricePerDay = 12500;
            }
        }
        else if (destination == "London")
        {
            if (season == "Winter")
            {
                pricePerDay = 24000;
            }
            else
            {
                pricePerDay = 20250;
            }
        }

        double totalPrice = pricePerDay * days;

        if (destination == "Dubai")
        {
            totalPrice *= 0.70;
        }
        else if (destination == "Sofia")
        {
            totalPrice *= 1.25;
        }

        if (budget >= totalPrice)
        {
            double remaining = budget - totalPrice;
            Console.WriteLine($"The budget for the movie is enough! We have {remaining:F2} leva left!");
        }
        else
        {
            double needed = totalPrice - budget;
            Console.WriteLine($"The director needs {needed:F2} leva more!");
        }
    }
}
