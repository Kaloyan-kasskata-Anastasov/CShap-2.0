/*
10
12
+

10
1
-

7
3
*
*/

class Program
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        string operation = Console.ReadLine();

        if (operation == "+" || operation == "-" || operation == "*")
        {
            int result = 0;
            if (operation == "+")
            {
                result = n1 + n2;
            }
            else if (operation == "-")
            {
                result = n1 - n2;
            }
            else
            {
                result = n1 * n2;
            }

            string evenOdd;
            if (result % 2 == 0)
            {
                evenOdd = "even";
            }
            else
            {
                evenOdd = "odd";
            }

            Console.WriteLine($"{n1} {operation} {n2} = {result} - {evenOdd}");
        }
        else if (operation == "/")
        {
            if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else
            {
                double result = (double)n1 / n2;
                Console.WriteLine($"{n1} / {n2} = {result:f2}");
            }
        }
        else if (operation == "%")
        {
            if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else
            {
                int result = n1 % n2;
                Console.WriteLine($"{n1} % {n2} = {result}");
            }
        }
    }
}
