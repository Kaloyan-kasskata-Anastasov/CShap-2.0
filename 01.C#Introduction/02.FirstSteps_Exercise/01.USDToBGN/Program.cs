class Program
{
    static void Main()
    {
        double usd = 1.79549;
        double dollars = double.Parse(Console.ReadLine());

        double bgn = usd * dollars;

        Console.WriteLine(bgn);
    }
}
