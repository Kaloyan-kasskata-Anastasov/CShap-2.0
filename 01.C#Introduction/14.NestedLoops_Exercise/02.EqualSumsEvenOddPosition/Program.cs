int startNumber = int.Parse(Console.ReadLine());
int endNumber = int.Parse(Console.ReadLine());

for (int currentNumber = startNumber; currentNumber <= endNumber; currentNumber++)
{
    int evenSum = 0;
    int oddSum = 0;
    int extractedNumber = currentNumber;

    for (int position = 1; position <= 6; position++)
    {
        int digit = extractedNumber % 10;

        if (position % 2 == 0)
        {
            evenSum += digit;
        }
        else
        {
            oddSum += digit;
        }

        extractedNumber /= 10;
    }

    if (evenSum == oddSum)
    {
        Console.Write($"{currentNumber} ");
    }
}
