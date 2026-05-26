namespace Telephony
{
public class StartUp
{
    public static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split();
        string[] urls = Console.ReadLine().Split();

        Smartphone smartphone = new Smartphone();
        StationaryPhone stationaryPhone = new StationaryPhone();

        foreach (string number in numbers)
        {
            if (!number.All(char.IsDigit))
            {
                Console.WriteLine("Invalid number!");
            }
            else if (number.Length == 10)
            {
                Console.WriteLine(smartphone.Call(number));
            }
            else if (number.Length == 7)
            {
                Console.WriteLine(stationaryPhone.Call(number));
            }
        }

        foreach (string url in urls)
        {
            if (url.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine(smartphone.Browse(url));
            }
        }
    }
}
}
