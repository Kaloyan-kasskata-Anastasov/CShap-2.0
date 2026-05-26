using System;

namespace ExplicitInterfaces
{
public class StartUp
{
    public static void Main(string[] args)
    {
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split();
            string name = tokens[0];
            string country = tokens[1];
            int age = int.Parse(tokens[2]);

            Citizen citizen = new Citizen(name, country, age);

            IPerson person = citizen;
            IResident resident = citizen;

            Console.WriteLine(person.GetName());
            Console.WriteLine(resident.GetName());
        }
    }
}
}
