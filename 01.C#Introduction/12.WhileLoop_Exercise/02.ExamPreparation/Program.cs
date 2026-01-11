/*
3
Money
6
Story
4
Spring Time
5
Bus
6
Enough
*/

class Program
{
    static void Main()
    {
        int maxPoorGrades = int.Parse(Console.ReadLine());

        int poorGrades = 0;
        int solvedProblems = 0;
        double sumGrades = 0;
        string lastProblem = "";

        while (true)
        {
            string problemName = Console.ReadLine();

            if (problemName == "Enough")
            {
                double average = sumGrades / solvedProblems;

                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
                break;
            }

            int grade = int.Parse(Console.ReadLine());

            solvedProblems++;
            sumGrades += grade;
            lastProblem = problemName;

            if (grade <= 4)
            {
                poorGrades++;
            }

            if (poorGrades == maxPoorGrades)
            {
                Console.WriteLine($"You need a break, {poorGrades} poor grades.");
                break;
            }
        }
    }
}
