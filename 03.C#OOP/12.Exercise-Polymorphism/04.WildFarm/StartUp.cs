namespace WildFarm
{
public class StartUp
{
    public static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] animalData = input.Split();
            Animal animal = CreateAnimal(animalData);
            animals.Add(animal);

            string[] foodData = Console.ReadLine().Split();
            Food food = CreateFood(foodData);

            animal.ProduceSound();
            animal.Eat(food);
        }

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.ToString());
        }
    }

    private static Animal CreateAnimal(string[] data)
    {
        string type = data[0];
        string name = data[1];
        double weight = double.Parse(data[2]);

        switch (type)
        {
            case "Hen":
                return new Hen(name, weight, double.Parse(data[3]));
            case "Owl":
                return new Owl(name, weight, double.Parse(data[3]));
            case "Mouse":
                return new Mouse(name, weight, data[3]);
            case "Dog":
                return new Dog(name, weight, data[3]);
            case "Cat":
                return new Cat(name, weight, data[3], data[4]);
            case "Tiger":
                return new Tiger(name, weight, data[3], data[4]);
            default:
                return null;
        }
    }

    private static Food CreateFood(string[] data)
    {
        string type = data[0];
        int quantity = int.Parse(data[1]);

        if (type == "Vegetable")
            return new Vegetable(quantity);
        if (type == "Fruit")
            return new Fruit(quantity);
        if (type == "Meat")
            return new Meat(quantity);
        if (type == "Seeds")
            return new Seeds(quantity);
        return null;
    }
}
}
