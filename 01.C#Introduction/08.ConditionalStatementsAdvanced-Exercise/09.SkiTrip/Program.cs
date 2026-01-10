/*

*/

class Program
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        string roomType = Console.ReadLine();
        string rating = Console.ReadLine();

        int nights = days - 1;

        double pricePerNight = 0;

        if (roomType == "room for one person")
        {
            pricePerNight = 18;
        }
        else if (roomType == "apartment")
        {
            pricePerNight = 25;
        }
        else if (roomType == "president apartment")
        {
            pricePerNight = 35;
        }

        double total = pricePerNight * nights;

        if (roomType == "apartment")
        {
            if (nights < 10)
            {
                total *= 0.7;
            }
            else if (nights <= 15)
            {
                total *= 0.65;
            }
            else
            {
                total *= 0.5;
            }
        }
        else if (roomType == "president apartment")
        {
            if (nights < 10)
            {
                total *= 0.9;
            }
            else if (nights <= 15)
            {
                total *= 0.85;
            }
            else
            {
                total *= 0.8;
            }
        }

        if (rating == "positive")
        {
            total *= 1.25;
        }
        else if (rating == "negative")
        {
            total *= 0.9;
        }

        Console.WriteLine($"{total:f2}");
    }
}
