/*
48
10
3.3
6.5
1.7
*/

class Program
{
    static void Main()
    {
        double strawberryPrice = double.Parse(Console.ReadLine());
        double bananaKg = double.Parse(Console.ReadLine());
        double orangeKg = double.Parse(Console.ReadLine());
        double raspberryKg = double.Parse(Console.ReadLine());
        double strawberryKg = double.Parse(Console.ReadLine());

        double raspberriesPrice = strawberryPrice / 2;
        double orangesPrice = raspberriesPrice - (0.4 * raspberriesPrice);
        double bananasPrice = raspberriesPrice - (0.8 * raspberriesPrice);

        double raspberryTotal = raspberriesPrice * raspberryKg;
        double orangeTotal = orangesPrice * orangeKg;
        double bananaTotal = bananasPrice * bananaKg;
        double strawberryTotal = strawberryKg * strawberryPrice;

        double total = raspberryTotal + 
                       orangeTotal + 
                       bananaTotal + 
                       strawberryTotal;

        Console.WriteLine($"{total:F2}");
    }
}
