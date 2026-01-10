/*
365

550

*/

class Program
{
    static void Main()
    {
        int annualFee = int.Parse(Console.ReadLine());

        double sneakers = annualFee * 0.60;
        double outfit = sneakers * 0.80;
        double ball = outfit / 4;
        double accessories = ball / 5;

        double totalCost = annualFee + sneakers + outfit + ball + accessories;

        Console.WriteLine(totalCost);
    }
}
