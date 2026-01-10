/*
40.8
20
25
30
50
10

320
8
2
5
5
1
*/
class Program
{
    static void Main()
    {
        double tripPrice = double.Parse(Console.ReadLine());

        int puzzles = int.Parse(Console.ReadLine());
        int dolls = int.Parse(Console.ReadLine());
        int bears = int.Parse(Console.ReadLine());
        int minions = int.Parse(Console.ReadLine());
        int trucks = int.Parse(Console.ReadLine());

        double puzzlePrice = 2.60;
        double dollPrice = 3.00;
        double bearPrice = 4.10;
        double minionPrice = 8.20;
        double truckPrice = 2.00;

        double totalPrice =
            puzzles * puzzlePrice +
            dolls * dollPrice +
            bears * bearPrice +
            minions * minionPrice +
            trucks * truckPrice;

        int totalToys = puzzles + dolls + bears + minions + trucks;

        if (totalToys >= 50)
        {
            totalPrice *= 0.75; 
        }

        totalPrice *= 0.90;

        if (totalPrice >= tripPrice)
        {
            Console.WriteLine($"Yes! {totalPrice - tripPrice:F2} lv left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! {tripPrice - totalPrice:F2} lv needed.");
        }
    }
}
