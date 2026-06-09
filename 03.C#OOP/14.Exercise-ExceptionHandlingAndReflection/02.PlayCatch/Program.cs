namespace PlayCatch
{
public class Program
{
    public static void Main()
    {
        int[] array = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int exceptionsCount = 0;

        while (exceptionsCount < 3)
        {
            string[] commandArgs = Console.ReadLine().Split();
            string action = commandArgs[0];

            try
            {
                if (action == "Replace")
                {
                    int index = int.Parse(commandArgs[1]);
                    int element = int.Parse(commandArgs[2]);
                    array[index] = element;
                }
                else if (action == "Print")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    List<int> result = new List<int>();
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        result.Add(array[i]);
                    }

                    Console.WriteLine(string.Join(", ", result));
                }
                else if (action == "Show")
                {
                    int index = int.Parse(commandArgs[1]);
                    Console.WriteLine(array[index]);
                }
            }
            catch (Exception exception)
            {
                exceptionsCount++;
                Type exceptionType = exception.GetType();

                if (exceptionType == typeof(FormatException))
                {
                    Console.WriteLine("The variable is not in the correct format!");
                }
                else if (exceptionType == typeof(IndexOutOfRangeException))
                {
                    Console.WriteLine("The index does not exist!");
                }
            }
        }

        Console.WriteLine(string.Join(", ", array));
    }
}
}
