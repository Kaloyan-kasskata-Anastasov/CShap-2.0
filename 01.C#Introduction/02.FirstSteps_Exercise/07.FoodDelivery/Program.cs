/*
2
4
3

9
2
6

*/

class Program
{
    static void Main()
    {
        int chickenMenus = int.Parse(Console.ReadLine());
        int fishMenus = int.Parse(Console.ReadLine());
        int vegetarianMenus = int.Parse(Console.ReadLine());

        double chickenPrice = 10.35;
        double fishPrice = 12.40;
        double vegetarianPrice = 8.15;
        double deliveryPrice = 2.50;

        double menusTotal =
            chickenMenus * chickenPrice +
            fishMenus * fishPrice +
            vegetarianMenus * vegetarianPrice;

        double dessertPrice = menusTotal * 0.20;

        double totalPrice = menusTotal + dessertPrice + deliveryPrice;

        Console.WriteLine(totalPrice);
    }
}
