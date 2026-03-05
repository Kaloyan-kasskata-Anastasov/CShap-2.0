/*
John
Smith
->

Jan
White
<->

Linda
Terry
=>
*/

class Program
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string delimiter = Console.ReadLine();

        Console.WriteLine($"{firstName}{delimiter}{lastName}");
        //Console.WriteLine(firstName + "" + delimiter + "" + lastName);
    }
}
