namespace BorderControl
{
public class StartUp
{
    public static void Main(string[] args)
    {
        List<IIdentifiable> entities = new List<IIdentifiable>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] arguments = input.Split();

            if (arguments.Length == 3)
            {
                string name = arguments[0];
                int age = int.Parse(arguments[1]);
                string id = arguments[2];
                entities.Add(new Citizen(name, age, id));
            }
            else if (arguments.Length == 2)
            {
                string model = arguments[0];
                string id = arguments[1];
                entities.Add(new Robot(model, id));
            }
        }

        string fakeIdSuffix = Console.ReadLine();

        foreach (IIdentifiable entity in entities)
        {
            if (entity.Id.EndsWith(fakeIdSuffix))
            {
                Console.WriteLine(entity.Id);
            }
        }
    }
}
}
