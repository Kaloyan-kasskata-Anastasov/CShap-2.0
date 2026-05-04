using System;
using System.Collections.Generic;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] data = input.Split(' ');
            students.Add(new Student
            {
                FirstName = data[0],
                LastName = data[1],
                Age = int.Parse(data[2]),
                City = data[3]
            });
            input = Console.ReadLine();
        }

        string filterCity = Console.ReadLine();

        foreach (Student student in students)
        {
            if (student.City == filterCity)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
