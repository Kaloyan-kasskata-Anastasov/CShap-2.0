/*
Troy
Stronger
Life Style
Troy
*/

class Program
{
    static void Main()
    {
        string bookToSearch = Console.ReadLine();

        int booksCount = 0;
        bool bookFound = false;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "No More Books")
            {
                break;
            }

            if (input == bookToSearch)
            {
                bookFound = true;
                break;
            }

            booksCount++; // lastly count the books 
        }

        if (bookFound)
        {
            Console.WriteLine($"You checked {booksCount} books and found it.");
        }
        else
        {
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {booksCount} books.");
        }
    }
}
