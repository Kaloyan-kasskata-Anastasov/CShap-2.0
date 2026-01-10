/*
Roses
55
250

Tulips
88
260
*/

class Program

{
    static void Main()
    {
        string flower = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());

        double pricePerFlower = 0;

        if (flower == "Roses")
        {
            pricePerFlower = 5;
        }
        else if (flower == "Dahlias")
        {
            pricePerFlower = 3.8;
        }
        else if (flower == "Tulips")
        {
            pricePerFlower = 2.8;
        }
        else if (flower == "Narcissus")
        {
            pricePerFlower = 3;
        }
        else if (flower == "Gladiolus")
        {
            pricePerFlower = 2.5;
        }

        double total = pricePerFlower * count;

        if (flower == "Roses" && count > 80)
        {
            total *= 0.9;
        }
        else if (flower == "Dahlias" && count > 90)
        {
            total *= 0.85;
        }
        else if (flower == "Tulips" && count > 80)
        {
            total *= 0.85;
        }
        else if (flower == "Narcissus" && count < 120)
        {
            total *= 1.15;
        }
        else if (flower == "Gladiolus" && count < 80)
        {
            total *= 1.2;
        }

        if (budget >= total)
        {
            Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {budget - total:f2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
        }
    }
}
