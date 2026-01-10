class Program
{
    static void Main()
    {
        double pricePerSquare = 7.61;
        double discountPercent = 0.18;

        double squares = double.Parse(Console.ReadLine());

        double finalPrice = pricePerSquare * squares;
        double discount = discountPercent * finalPrice;
        double priceWithDiscount = finalPrice - discount;

        Console.WriteLine($"The final price is: {priceWithDiscount} lv.");
        Console.WriteLine($"The discount is: {discount} lv.");
    }
}
