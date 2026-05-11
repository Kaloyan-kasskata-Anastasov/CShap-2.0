public class StartUp
{
    public static void Main(string[] args)
    {
    }
}

public class Animal
{
    public Animal(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}

public class Reptile : Animal
{
    public Reptile(string name) : base(name)
    {
    }
}

public class Mammal : Animal
{
    public Mammal(string name) : base(name)
    {
    }
}

public class Lizard : Reptile
{
    public Lizard(string name) : base(name)
    {
    }
}

public class Snake : Reptile
{
    public Snake(string name) : base(name)
    {
    }
}

public class Gorilla : Mammal
{
    public Gorilla(string name) : base(name)
    {
    }
}

public class Bear : Mammal
{
    public Bear(string name) : base(name)
    {
    }
}
