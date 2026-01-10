int studentTickets = 0;
int standardTickets = 0;
int kidTickets = 0;

while (true)
{
    string movieName = Console.ReadLine();
    if (movieName == "Finish")
    {
        break;
    }

    int freeSeats = int.Parse(Console.ReadLine());
    int soldTickets = 0;

    while (soldTickets < freeSeats)
    {
        string ticketType = Console.ReadLine();
        if (ticketType == "End")
        {
            break;
        }

        soldTickets++;

        if (ticketType == "student")
        {
            studentTickets++;
        }
        else if (ticketType == "standard")
        {
            standardTickets++;
        }
        else if (ticketType == "kid")
        {
            kidTickets++;
        }
    }

    double percentFull = soldTickets * 100.0 / freeSeats;
    Console.WriteLine($"{movieName} - {percentFull:F2}% full.");
}

int totalTickets = studentTickets + standardTickets + kidTickets;
Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{studentTickets * 100.0 / totalTickets:F2}% student tickets.");
Console.WriteLine($"{standardTickets * 100.0 / totalTickets:F2}% standard tickets.");
Console.WriteLine($"{kidTickets * 100.0 / totalTickets:F2}% kids tickets.");
