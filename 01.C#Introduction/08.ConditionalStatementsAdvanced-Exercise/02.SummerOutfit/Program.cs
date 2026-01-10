/*
16
Morning

22
Afternoon
*/

class Program
{
    static void Main()
    {
        int degrees = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();

        string outfit = "";
        string shoes = "";

        // Morning
        if (timeOfDay == "Morning")
        {
            if (degrees >= 10 && degrees <= 18)
            {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (degrees <= 24)
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
        }
        // Afternoon
        else if (timeOfDay == "Afternoon")
        {
            if (degrees >= 10 && degrees <= 18)
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (degrees <= 24)
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else
            {
                outfit = "Swim Suit";
                shoes = "Barefoot";
            }
        }
        // Evening
        else if (timeOfDay == "Evening")
        {
            outfit = "Shirt";
            shoes = "Moccasins";
        }

        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }
}
