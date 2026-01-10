/*
Zahari Baharov
205
4
Johnny Depp
45
Will Smith
29
Jet Lee
10
Matthew Mcconaughey
39
*/

class Program
{
    static void Main()
    {
        string actorName = Console.ReadLine();
        double points = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        bool isNominated = false;

        for (int i = 0; i < n; i++)
        {
            string judgeName = Console.ReadLine();
            double judgePoints = double.Parse(Console.ReadLine());

            points += (judgeName.Length * judgePoints) / 2;

            if (points > 1250.5)
            {
                isNominated = true;
                break;
            }
        }

        if (isNominated)
        {
            Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
        }
        else
        {
            double needed = 1250.5 - points;

            Console.WriteLine($"Sorry, {actorName} you need {needed:f1} more!");
        }

    }
}
