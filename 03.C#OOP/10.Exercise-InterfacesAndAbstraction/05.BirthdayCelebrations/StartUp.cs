namespace BirthdayCelebrations
{
public class StartUp
{
    public static void Main(string[] args)
    {
        List<IBirthable> birthables = new List<IBirthable>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] arguments = input.Split();
            string type = arguments[0];

            if (type == "Citizen")
            {
                Citizen newCitizen = new Citizen(arguments[1], int.Parse(arguments[2]), arguments[3], arguments[4]);
                birthables.Add(newCitizen);
            }
            else if (type == "Pet")
            {
                Pet? newPet = new Pet(arguments[1], arguments[2]);
                birthables.Add(newPet);
            }
        }

        string targetYear = Console.ReadLine();

        foreach (IBirthable birthable in birthables)
        {
            if (birthable.BirthDate.EndsWith(targetYear))
            {
                Console.WriteLine(birthable.BirthDate);
            }
        }
    }
}
}
