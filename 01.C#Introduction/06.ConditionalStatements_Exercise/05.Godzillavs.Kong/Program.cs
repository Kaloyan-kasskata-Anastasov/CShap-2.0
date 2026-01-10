/*
20000 
120
55.5

15437.62
186
57.99

9587.88
222
55.68
*/
class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        int extrasCount = int.Parse(Console.ReadLine());
        double clothingPrice = double.Parse(Console.ReadLine());

        double decorPrice = budget * 0.10;
        double clothesTotal = extrasCount * clothingPrice;

        if (extrasCount > 150)
        {
            clothesTotal *= 0.90; // 10% discount
        }

        double totalCost = decorPrice + clothesTotal;

        if (totalCost > budget)
        {
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {totalCost - budget:F2} leva more.");
        }
        else
        {
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {budget - totalCost:F2} leva left.");
        }
    }
}
