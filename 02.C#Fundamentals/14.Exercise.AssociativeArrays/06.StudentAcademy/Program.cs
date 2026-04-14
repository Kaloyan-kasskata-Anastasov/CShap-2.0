class Program
{
    static void Main()
    {
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            if (!students.ContainsKey(name))
            {
                students.Add(name, new List<double>());
            }

            students[name].Add(grade);
        }

        foreach (KeyValuePair<string, List<double>> student in students)
        {
            double average = student.Value.Average();

            if (average >= 4.50)
            {
                Console.WriteLine($"{student.Key} -> {average:F2}");
            }
        }
    }
}
