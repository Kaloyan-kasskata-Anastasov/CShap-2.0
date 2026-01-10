class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        int projectCount = int.Parse(Console.ReadLine());
        int oneProjectHours = 3;

        int spendTime = projectCount * oneProjectHours;

        Console.WriteLine($"The architect {name} will need {spendTime} hours to complete {projectCount} project/s.");
    }
}
