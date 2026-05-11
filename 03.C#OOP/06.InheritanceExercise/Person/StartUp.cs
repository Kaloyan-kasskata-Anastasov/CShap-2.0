using System;
using System.Text;

public class StartUp
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        if (age < 0)
        {
            Console.WriteLine("Age must be positive!");
        }
        else if (age > 15)
        {
            Person person = new Person(name, age);
            Console.WriteLine(person);
        }
        else
        {
            Child child = new Child(name, age);
            Console.WriteLine(child);
        }
    }
}

public class Child : Person
{
    public Child(string name, int age)
        : base(name, age)
    {
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append($"{GetType().Name} -> ");
        stringBuilder.Append($"Name: {Name}, Age: {Age}");

        return stringBuilder.ToString();
    }
}
