/*
7
3
4
1
1
2
12
1

4
6
1
2
3

3
1
1
10
*/

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int max = int.MinValue;

        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum = sum + number;

            if (number > max)
            {
                max = number;
            }
        }

        int sumWithoutMax = sum - max;

        if (max == sumWithoutMax)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {max}");
        }
        else
        {
            int diff = Math.Abs(max - sumWithoutMax);
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {diff}");
        }
    }
}
