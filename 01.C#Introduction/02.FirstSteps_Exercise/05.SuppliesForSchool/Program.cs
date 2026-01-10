/*
2
3
4
25

*/
class Program
{
    static void Main()
    {
        int penPacks = int.Parse(Console.ReadLine());
        int markersPacks = int.Parse(Console.ReadLine());
        int litersBoardCleaner = int.Parse(Console.ReadLine());
        int discountPercent = int.Parse(Console.ReadLine());
        double discountDouble = discountPercent / 100.0;

        double penPackPrice = 5.80;
        double markersPackPrice = 7.20;
        double literCleanerPrice = 1.20;

        double total = penPacks * penPackPrice;
        total = total + markersPacks * markersPackPrice;
        total = total + litersBoardCleaner * literCleanerPrice;
        total = total - total * discountDouble;

        Console.WriteLine(total);
    }
}
