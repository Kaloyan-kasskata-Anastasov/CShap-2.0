/*
10
11
4
8

5
10
10
1

*/

class Program
{
    static void Main()
    {
        int nylon = int.Parse(Console.ReadLine());
        int paint = int.Parse(Console.ReadLine());
        int thinner = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());

        double nylonPrice = 1.50;
        double paintPrice = 14.50;
        double thinnerPrice = 5.00;
        double bagsPrice = 0.40;

        double totalNylonCost = (nylon + 2) * nylonPrice;
        double totalPaintCost = (paint * 1.10) * paintPrice;
        double totalThinnerCost = thinner * thinnerPrice;

        double materialsCost = totalNylonCost + totalPaintCost + totalThinnerCost + bagsPrice;

        double laborCost = materialsCost * 0.30 * hours;

        double totalCost = materialsCost + laborCost;

        Console.WriteLine($"{totalCost:F2}");
    }
}
