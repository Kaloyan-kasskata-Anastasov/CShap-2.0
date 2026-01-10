/*
May
15

June
14
*/

class Program
{
    static void Main()
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        double studioPrice = 0;
        double apartmentPrice = 0;

        if (month == "May" || month == "October")
        {
            studioPrice = 50;
            apartmentPrice = 65;
        }
        else if (month == "June" || month == "September")
        {
            studioPrice = 75.20;
            apartmentPrice = 68.70;
        }
        else if (month == "July" || month == "August")
        {
            studioPrice = 76;
            apartmentPrice = 77;
        }

        double studioTotal = studioPrice * nights;
        double apartmentTotal = apartmentPrice * nights;

        if ((month == "May" || month == "October") && nights > 14)
        {
            studioTotal *= 0.7;
        }
        else if ((month == "May" || month == "October") && nights > 7)
        {
            studioTotal *= 0.95;
        }
        else if ((month == "June" || month == "September") && nights > 14)
        {
            studioTotal *= 0.8;
        }

        if (nights > 14)
        {
            apartmentTotal *= 0.9;
        }

        Console.WriteLine($"Apartment: {apartmentTotal:f2} lv.");
        Console.WriteLine($"Studio: {studioTotal:f2} lv.");
    }
}
