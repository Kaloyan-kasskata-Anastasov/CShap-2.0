int sumPrimes = 0;
int sumNonPrimes = 0;

while (true)
{
    string input = Console.ReadLine();
    if (input == "stop")
    {
        break;
    }

    int number = int.Parse(input);

    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
        continue;
    }

    bool isPrime = number == 2;

    if (number > 2)
    {
        if (number % 2 != 0) // if is odd number
        {
            isPrime = true;

            int divisor = 3;
            while (divisor * divisor <= number)
            {
                if (number % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
                divisor += 2;
            }
        }
    }

    if (isPrime)
    {
        sumPrimes += number;
    }
    else
    {
        sumNonPrimes += number;
    }
}

Console.WriteLine($"Sum of all prime numbers is: {sumPrimes}");
Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimes}");
