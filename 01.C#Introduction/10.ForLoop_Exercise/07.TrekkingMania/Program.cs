/*
10
10
5
1
100
12
26
17
37
40
78
*/
class Program
{
    static void Main()
    {
        int groups = int.Parse(Console.ReadLine());

        int musala = 0;
        int montBlanc = 0;
        int kilimanjaro = 0;
        int k2 = 0;
        int everest = 0;

        int totalPeople = 0;

        for (int i = 0; i < groups; i++)
        {
            int people = int.Parse(Console.ReadLine());
            totalPeople += people;

            if (people <= 5)
            {
                musala += people;
            }
            else if (people <= 12)
            {
                montBlanc += people;
            }
            else if (people <= 25)
            {
                kilimanjaro += people;
            }
            else if (people <= 40)
            {
                k2 += people;
            }
            else
            {
                everest += people;
            }
        }

        Console.WriteLine($"{musala * 100.0 / totalPeople:f2}%");
        Console.WriteLine($"{montBlanc * 100.0 / totalPeople:f2}%");
        Console.WriteLine($"{kilimanjaro * 100.0 / totalPeople:f2}%");
        Console.WriteLine($"{k2 * 100.0 / totalPeople:f2}%");
        Console.WriteLine($"{everest * 100.0 / totalPeople:f2}%");

    }
}
