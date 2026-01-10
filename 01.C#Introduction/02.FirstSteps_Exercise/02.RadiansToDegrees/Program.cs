class Program
{
    static void Main()
    {
        double radian = double.Parse(Console.ReadLine());
        double angle = radian * 180 / Math.PI;

        Console.WriteLine(angle);
    }
}
