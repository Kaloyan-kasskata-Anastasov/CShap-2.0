/*
a
b
c

%
2
o

1
5
p
*/

class Program
{
    static void Main()
    {
        char char1 = char.Parse(Console.ReadLine());
        char char2 = char.Parse(Console.ReadLine());
        char char3 = char.Parse(Console.ReadLine());

        //Console.WriteLine(char1 + char2 + char3); // int result
        //Console.WriteLine(char1.ToString() + char2 + char3); // string result
        Console.WriteLine($"{char1}{char2}{char3}");
    }
}
