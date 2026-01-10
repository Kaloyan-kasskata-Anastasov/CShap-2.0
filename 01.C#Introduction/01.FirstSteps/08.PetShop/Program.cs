class Program
{
    static void Main()
    {
        double dogFoodPrice = 2.50;
        double catFoodPrice = 4;

        double dogFoodCount = double.Parse(Console.ReadLine());
        double catFoodCount = double.Parse(Console.ReadLine());

        double total = (dogFoodCount * dogFoodPrice);
        total = total + (catFoodCount * catFoodPrice);

        Console.WriteLine($"{total} lv.");
    }
}
