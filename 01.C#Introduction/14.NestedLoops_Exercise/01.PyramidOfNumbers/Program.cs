int n = int.Parse(Console.ReadLine());
int number = 1;

for (int row = 1; number <= n; row++)
{
    for (int col = 1; col <= row; col++)
    {
        if (number > n)
        {
            break;
        }

        Console.Write(number + " ");
        number++;
    }

    Console.WriteLine();
}
