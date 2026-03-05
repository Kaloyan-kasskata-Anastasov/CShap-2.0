class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int currentNum = 1; currentNum <= n; currentNum++)
        {
            int sum = 0;
            int number = currentNum;

            while (number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }

            bool isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine($"{currentNum} -> {isSpecialNum}");
        }
    }
}
