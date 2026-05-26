

/*
Private 1 Peter Johnson 22.22
Commando 13 Sam Peterson 13.1 Airforces
Private 222 Tony Samthon 80.08
LieutenantGeneral 3 George Stevenson 100 222 1
End

Engineer 7 Peter Johnson 12.23 Marines Boat 2 Crane 17
Commando 19 George Stevenson 150.15 Airforces HairyFoot Finished Freedom InProgress
End
*/
namespace MilitaryElite
{
public class StartUp
{
    public static void Main(string[] args)
    {
        List<ISoldier> soldiers = new List<ISoldier>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] arguments = input.Split();
            string type = arguments[0];
            int id = int.Parse(arguments[1]);
            string firstName = arguments[2];
            string lastName = arguments[3];

            if (soldiers.Any(soldier => soldier.Id == id))
            {
                continue;
            }

            switch (type)
            {
                case "Private":
                {
                    decimal salary = decimal.Parse(arguments[4]);
                    Private newPrivate = new Private(id, firstName, lastName, salary);
                    soldiers.Add(newPrivate);
                    break;
                }
                case "LieutenantGeneral":
                {
                    decimal salary = decimal.Parse(arguments[4]);
                    LieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < arguments.Length; i++)
                    {
                        int privateId = int.Parse(arguments[i]);

                        ISoldier soldier = soldiers.FirstOrDefault(s => s.Id == privateId);
                        if (soldier != null && soldier is IPrivate newPrivate)
                        {
                            general.AddPrivate(newPrivate);
                        }
                    }

                    soldiers.Add(general);
                    break;
                }
                case "Engineer":
                {
                    decimal salary = decimal.Parse(arguments[4]);
                    string corps = arguments[5];

                    try
                    {
                        Engineer engineer = new Engineer(id, firstName, lastName, salary, corps);

                        for (int i = 6; i < arguments.Length; i += 2)
                        {
                            string partName = arguments[i];
                            int hours = int.Parse(arguments[i + 1]);
                            engineer.AddRepair(new Repair(partName, hours));
                        }

                        soldiers.Add(engineer);
                    }
                    catch (ArgumentException)
                    {
                        continue;
                    }

                    break;
                }
                case "Commando":
                {
                    decimal salary = decimal.Parse(arguments[4]);
                    string corps = arguments[5];

                    try
                    {
                        Commando commando = new Commando(id, firstName, lastName, salary, corps);

                        for (int i = 6; i < arguments.Length; i += 2)
                        {
                            string codeName = arguments[i];
                            string state = arguments[i + 1];

                            try
                            {
                                commando.AddMission(new Mission(codeName, state));
                            }
                            catch (ArgumentException)
                            {
                                continue;
                            }
                        }

                        soldiers.Add(commando);
                    }
                    catch (ArgumentException)
                    {
                        continue;
                    }

                    break;
                }
                case "Spy":
                {
                    int codeNumber = int.Parse(arguments[4]);
                    Spy spy = new Spy(id, firstName, lastName, codeNumber);
                    soldiers.Add(spy);
                    break;
                }
            }
        }

        foreach (ISoldier soldier in soldiers)
        {
            Console.WriteLine(soldier.ToString());
        }
    }
}
}
