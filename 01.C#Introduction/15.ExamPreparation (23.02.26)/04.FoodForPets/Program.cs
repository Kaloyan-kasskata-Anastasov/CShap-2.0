/*
3
1000
300
20
100
30
110
40
*/
class Program
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        double totalFood = double.Parse(Console.ReadLine());

        int dogTotal = 0;
        int catTotal = 0;
        double biscuits = 0;

        for (int day = 1; day <= days; day++)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            dogTotal += dogFood;
            catTotal += catFood;

            if (day % 3 == 0)
            {
                biscuits += (dogFood + catFood) * 0.10;
            }
        }

        double total = dogTotal + catTotal;

        double percentEaten = total / totalFood * 100;
        double percentDog = dogTotal / total * 100;
        double percentCat = catTotal / total * 100;

        Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
        Console.WriteLine($"{percentEaten:F2}% of the food has been eaten.");
        Console.WriteLine($"{percentDog:F2}% eaten from the dog.");
        Console.WriteLine($"{percentCat:F2}% eaten from the cat.");
    }
}