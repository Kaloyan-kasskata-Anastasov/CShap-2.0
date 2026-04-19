using System.Text;

class Program
{
    static void Main()
    {
        string inputMessage = Console.ReadLine();
        StringBuilder message = new StringBuilder(inputMessage);

        string input;
        while ((input = Console.ReadLine()) != "Decode")
        {
            string[] arguments = input.Split('|');

            switch (arguments[0])
            {
                case "Move":
                    int count = int.Parse(arguments[1]);
                    MoveLetters(message, count);
                    break;

                case "Insert":
                    int index = int.Parse(arguments[1]);
                    string value = arguments[2];
                    InsertValue(message, index, value);
                    break;

                case "ChangeAll":
                    string subString = arguments[1];
                    string replacement = arguments[2];
                    ChangeAllOccurrences(message, subString, replacement);
                    break;
            }
        }

        Console.WriteLine($"The decrypted message is: {message}");
    }

    static void MoveLetters(StringBuilder message, int count)
    {
        if (count > 0 && count <= message.Length)
        {
            string firstPart = message.ToString().Substring(0, count);
            message.Remove(0, count);
            message.Append(firstPart);
        }
    }

    static void InsertValue(StringBuilder message, int index, string value)
    {
        message.Insert(index, value);
    }


    static void ChangeAllOccurrences(StringBuilder message, string subString, string replacement)
    {
        message.Replace(subString, replacement);
    }
}
