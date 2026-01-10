class Program
{
    static void Main()
    {
        double inches = double.Parse(Console.ReadLine());
        double centimeters = inches * 2.54d;
        
        Console.WriteLine(centimeters);
    }
}
