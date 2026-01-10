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

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
            if (numbers[i] > max)
            {
                max = numbers[i];
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
