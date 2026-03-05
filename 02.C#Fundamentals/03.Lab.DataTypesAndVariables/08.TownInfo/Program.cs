/*
Sofia
1286383
492

Kaliningrad
437456
223
*/

class Program
{
    static void Main()
    {
        string townName = Console.ReadLine();
        int population = int.Parse(Console.ReadLine());
        int area = int.Parse(Console.ReadLine());

        Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
    }
}
