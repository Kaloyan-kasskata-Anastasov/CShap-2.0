namespace FoodShortage
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] arguments = Console.ReadLine().Split();

                if (arguments.Length == 4)
                {
                    buyers[arguments[0]] = new Citizen(arguments[0], int.Parse(arguments[1]), arguments[2], arguments[3]);
                }
                else if (arguments.Length == 3)
                {
                    buyers[arguments[0]] = new Rebel(arguments[0], int.Parse(arguments[1]), arguments[2]);
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (buyers.ContainsKey(input))
                {
                    IBuyer buyer = buyers[input];
                    buyer.BuyFood();
                }
            }

            int totalFood = 0;
            foreach (IBuyer? buyer in buyers.Values)
            {
                totalFood += buyer.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
    }