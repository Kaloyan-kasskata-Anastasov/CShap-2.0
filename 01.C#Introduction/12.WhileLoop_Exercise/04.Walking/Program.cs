/*
1000
1500
2000
6500

1500
3000
250
1548
2000
Going home
2000
*/

class Program
{
    static void Main()
    {
        int goal = 10000;
        int totalSteps = 0;

        string input;
        while (true)
        {
            input = Console.ReadLine();

            if (input == "Going home")
            {
                break;
            }
            else
            {
                int steps = int.Parse(input);
                totalSteps += steps;
            }

            if (totalSteps >= goal)
            {
                break;
            }
        }

        if(input == "Going home")
        {
            int stepsToHome = int.Parse(Console.ReadLine());
            totalSteps += stepsToHome;
        }

        if (totalSteps >= goal)
        {
            Console.WriteLine("Goal reached! Good job!");
            Console.WriteLine($"{totalSteps - goal} steps over the goal!");
        }
        else
        {
            Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
        }
    }
}
