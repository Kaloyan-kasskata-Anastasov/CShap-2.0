/*
10464
1500
20

55555.67
3017
5.03
*/
class Program
{
    static void Main()
    {
        double worldRecord = double.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        double timePerMeter = double.Parse(Console.ReadLine());

        double totalTime = distance * timePerMeter;

        double slowDownIntervals = (int)distance / 15; // loss of fraction by purpose
        double resistanceTime = slowDownIntervals * 12.5;

        totalTime += resistanceTime;

        if (totalTime < worldRecord)
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
        }
        else
        {
            double difference = totalTime - worldRecord;
            Console.WriteLine($"No, he failed! He was {difference:F2} seconds slower.");
        }
    }
}
