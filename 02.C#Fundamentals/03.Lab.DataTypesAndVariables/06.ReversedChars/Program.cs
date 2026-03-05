/*
A
B
C

1
L
&
*/

class Program
{
    static void Main()
    {
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = Console.ReadLine()[0];
        char thirdChar = Convert.ToChar(Console.ReadLine());

        Console.WriteLine($"{thirdChar} {secondChar} {firstChar}");
    }
}
