/*
10
170.00
6

21
1570.98
3
*/

class Program
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double washingMachinePrice = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        int toysCount = 0;
        double money = 0;
        double evenBirthdayMoney = 10;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                money += evenBirthdayMoney - 1;
                evenBirthdayMoney += 10;
            }
            else

            {
                toysCount++;
            }
        }

        money += toysCount * toyPrice;

        if (money >= washingMachinePrice)
        {
            Console.WriteLine($"Yes! {money - washingMachinePrice:f2}");
        }
        else
        {
            Console.WriteLine($"No! {washingMachinePrice - money:f2}");
        }
    }
}
