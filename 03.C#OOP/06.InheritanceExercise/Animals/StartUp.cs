using System.Text;

namespace Animals
{
public class StartUp
{
    public static void Main(string[] args)
    {
    }
}

public class Animal
{
    public Animal(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public string Name { get; set; }

    public int Age { get; set; }

    public string Gender { get; set; }

    public virtual string ProduceSound()
    {
        return string.Empty;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(GetType().Name);
        sb.AppendLine($"{Name} {Age} {Gender}");
        sb.Append(ProduceSound());
        return sb.ToString();
    }
}

public class Dog : Animal
{
    public Dog(string name, int age, string gender)
        : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
        return "Woof!";
    }
}

public class Frog : Animal
{
    public Frog(string name, int age, string gender)
        : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
        return "Ribbit";
    }
}

public class Cat : Animal
{
    public Cat(string name, int age, string gender)
        : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
        return "Meow meow";
    }
}

public class Kitten : Cat
{
    public Kitten(string name, int age)
        : base(name, age, "Female")
    {
    }

    public override string ProduceSound()
    {
        return "Meow";
    }
}

public class Tomcat : Cat
{
    public Tomcat(string name, int age)
        : base(name, age, "Male")
    {
    }

    public override string ProduceSound()
    {
        return "MEOW";
    }
}
}
