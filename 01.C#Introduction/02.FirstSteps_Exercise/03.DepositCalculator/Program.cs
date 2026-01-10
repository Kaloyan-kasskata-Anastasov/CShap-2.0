/*
200
3
5.7
*/

class Program
{
    static void Main()
    {
        double amount = double.Parse(Console.ReadLine());
        int time = int.Parse(Console.ReadLine());
        double percent = double.Parse(Console.ReadLine());
        percent = percent / 100;

        double product = amount * percent;
        product = product / 12;
        product = product * time;
        product = product + amount;

        Console.WriteLine(product);
    }
}
