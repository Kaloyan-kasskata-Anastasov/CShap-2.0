/*
80

39
*/

class Program
{
    static void Main()
    {
        decimal pounds = decimal.Parse(Console.ReadLine());
        decimal dollars = pounds * 1.31m;
        Console.WriteLine($"{dollars:f3}");
    }
}
