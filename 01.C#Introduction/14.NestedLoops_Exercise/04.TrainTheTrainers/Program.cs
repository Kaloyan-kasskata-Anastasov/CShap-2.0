int juryCount = int.Parse(Console.ReadLine());

double totalSum = 0.0;
int totalGradesCount = 0;

while (true)
{
    string inputLine = Console.ReadLine();
    if (inputLine == "Finish")
    {
        break;
    }

    string presentationName = inputLine;
    double gradesSum = 0.0;

    for (int i = 0; i < juryCount; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        gradesSum += grade;
        totalSum += grade;
        totalGradesCount += 1;
    }

    double average = gradesSum / juryCount;
    Console.WriteLine($"{presentationName} - {average:F2}.");
}

Console.WriteLine($"Student's final assessment is {totalSum / totalGradesCount:F2}.");
