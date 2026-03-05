/*
L

f
*/

class Program
{
    static void Main()
    {
        char inputChar = char.Parse(Console.ReadLine());

        if (char.IsUpper(inputChar))
        {
            Console.WriteLine("upper-case");
        }
        else
        {
            Console.WriteLine("lower-case");
        }

        // ternary operator -> `?:`
        //Console.WriteLine(char.IsUpper(inputChar) ? "upper-case" : "lower-case");
    }
}
