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
            string firstName = data[0];
            string lastName = data[1];
            int age = int.Parse(data[2]);
            string city = data[3];

            Student existingStudent = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            if (existingStudent != null)
            {
                existingStudent.Age = age;
                existingStudent.City = city;
            }
            else
            {
                students.Add(new Student { FirstName = firstName, LastName = lastName, Age = age, City = city });
            }

            input = Console.ReadLine();
        }

        string filterCity = Console.ReadLine();

        foreach (Student student in students.Where(s => s.City == filterCity))
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
        }
    }
}
