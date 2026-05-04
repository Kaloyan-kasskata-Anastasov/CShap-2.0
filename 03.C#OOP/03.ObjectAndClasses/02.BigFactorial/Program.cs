using System.Numerics;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (int.TryParse(input, out int n))
        {
            BigInteger factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
