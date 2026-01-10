/*
900
2
1
3

920.45
3
1
1
*/
class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        int videoCards = int.Parse(Console.ReadLine());
        int processors = int.Parse(Console.ReadLine());
        int ramSticks = int.Parse(Console.ReadLine());

        double videoCardPrice = 250;
        double processorsPrice = videoCards * videoCardPrice * 0.35;
        double ramPrice = videoCards * videoCardPrice * 0.10;

        double totalCost = videoCards * videoCardPrice
                           + processors * processorsPrice
                           + ramSticks * ramPrice;

        if (videoCards > processors)
        {
            totalCost *= 0.85; // 15% discount
        }

        if (budget >= totalCost)
        {
            double remaining = budget - totalCost;
            Console.WriteLine($"You have {remaining:F2} leva left!");
        }
        else
        {
            double needed = totalCost - budget;
            Console.WriteLine($"Not enough money! You need {needed:F2} leva more!");
        }
    }
}
