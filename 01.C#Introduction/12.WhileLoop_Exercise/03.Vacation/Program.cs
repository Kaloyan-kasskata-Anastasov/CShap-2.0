/*
2000
1000
spend
1200
save
2000
*/

class Program
{
    static void Main()
    {
        double neededMoney = double.Parse(Console.ReadLine());
        double currentMoney = double.Parse(Console.ReadLine());

        int days = 0;
        int spendDays = 0;

        while (true)
        {
            string action = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            days++;

            if (action == "spend")
            {
                spendDays++;

                currentMoney -= amount;

                if (currentMoney < 0)
                {
                    currentMoney = 0;
                }
            }
            else if (action == "save")
            {
                spendDays = 0;
                currentMoney += amount;
            }

            if (spendDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
                break;
            }

            if (currentMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
                break;
            }
        }
    }
}
