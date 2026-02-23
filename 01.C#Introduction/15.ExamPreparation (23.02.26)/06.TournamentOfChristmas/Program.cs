/*
2
volleyball
win
football
lose
basketball
win
Finish
golf
win
tennis
win
badminton
win
Finish
*/

class Program
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());

        double totalMoney = 0;
        int totalWinDays = 0;
        int totalLoseDays = 0;

        for (int day = 1; day <= days; day++)
        {
            string sport = Console.ReadLine();

            int wins = 0;
            int loses = 0;
            double dailyMoney = 0;

            while (sport != "Finish")
            {
                string result = Console.ReadLine();

                if (result == "win")
                {
                    wins++;
                    dailyMoney += 20;
                }
                else if (result == "lose")
                {
                    loses++;
                }

                sport = Console.ReadLine();
            }

            if (wins > loses)
            {
                dailyMoney *= 1.10;
                totalWinDays++;
            }
            else
            {
                totalLoseDays++;
            }

            totalMoney += dailyMoney;
        }

        if (totalWinDays > totalLoseDays)
        {
            totalMoney *= 1.20;
            Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:F2}");
        }
        else
        {
            Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:F2}");
        }
    }
}
