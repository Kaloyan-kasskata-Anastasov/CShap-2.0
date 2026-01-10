/*
85
75
47
17

105
77
89
18.5
*/
class Program
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        double percent = double.Parse(Console.ReadLine());

        double volumeCm3 = length * width * height;
        double volumeLiters = volumeCm3 / 1000.0;

        double usableLiters = volumeLiters * (1 - percent / 100);

        Console.WriteLine(usableLiters);
    }
}
