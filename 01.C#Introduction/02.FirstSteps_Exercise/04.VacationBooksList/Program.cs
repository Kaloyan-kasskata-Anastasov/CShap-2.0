class Program
{
    static void Main()
    {
        int pagesCount = int.Parse(Console.ReadLine());
        int pagesPerHour = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());

        int totalHours = pagesCount / pagesPerHour;
        int hoursPerDay = totalHours / days;

        Console.WriteLine(hoursPerDay);
    }
}
