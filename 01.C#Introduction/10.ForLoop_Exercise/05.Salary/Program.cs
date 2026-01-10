/*
10
750
Facebook
Dev.bg
Instagram
Facebook
Reddit
Facebook
Facebook

3
500
Github.com
Stackoverflow.com
softuni.bg
*/

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int salary = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string site = Console.ReadLine();

            if (site == "Facebook")
            {
                salary -= 150;
            }
            else if (site == "Instagram")
            {
                salary -= 100;
            }
            else if (site == "Reddit")
            {
                salary -= 50;
            }

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
                break;
            }
        }

        if (salary > 0)
        {
            Console.WriteLine(salary);
        }
    }
}
