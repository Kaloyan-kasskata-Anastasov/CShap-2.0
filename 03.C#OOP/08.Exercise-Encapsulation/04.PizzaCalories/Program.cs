namespace PizzaCalories
{
/*
Pizza Meatless
Dough Wholegrain Crispy 100
Topping Veggies 50
Topping Cheese 50
END
*/
public class StartUp
{
    public static void Main(string[] args)
    {
        try
        {
            string[] pizzaArgs = Console.ReadLine().Split();
            string pizzaName = pizzaArgs[1];

            string[] doughArgs = Console.ReadLine().Split();
            string flourType = doughArgs[1];
            string bakingTechnique = doughArgs[2];
            double doughWeight = double.Parse(doughArgs[3]);

            Dough dough = new Dough(flourType, bakingTechnique, doughWeight);
            Pizza pizza = new Pizza(pizzaName, dough);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] toppingArgs = command.Split();
                string toppingType = toppingArgs[1];
                double toppingWeight = double.Parse(toppingArgs[2]);

                Topping topping = new Topping(toppingType, toppingWeight);
                pizza.AddTopping(topping);
            }

            Console.WriteLine(pizza);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
}
