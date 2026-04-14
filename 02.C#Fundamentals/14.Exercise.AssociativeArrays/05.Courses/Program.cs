class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] parts = command.Split(" : ");
            string courseName = parts[0];
            string studentName = parts[1];

            if (!courses.ContainsKey(courseName))
            {
                courses.Add(courseName, new List<string>());
            }

            courses[courseName].Add(studentName);
        }

        foreach (KeyValuePair<string, List<string>> course in courses)
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");

            foreach (string student in course.Value)
            {
                Console.WriteLine($"-- {student}");
            }
        }
    }
}
