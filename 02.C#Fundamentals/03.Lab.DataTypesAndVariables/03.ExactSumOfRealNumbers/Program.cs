/*
3
1000000000000000000
5
10

2
0.00000000003
333333333333.3
*/

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal exactSum = 0m;

        for (int i = 0; i < n; i++)
        {
            exactSum += decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine(exactSum);
    }
}
