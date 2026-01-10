int divisorNumber = int.Parse(Console.ReadLine());

for (int number = 1111; number <= 9999; number++)
{
    int numberCopy = number;
    bool isSpecial = true;

    while (numberCopy > 0)
    {
        int digit = numberCopy % 10;
        if (digit == 0 || divisorNumber % digit != 0)
        {
            isSpecial = false;
            break;
        }

        numberCopy /= 10;
    }

    if (isSpecial)
    {
        Console.Write($"{number} ");
    }
}
