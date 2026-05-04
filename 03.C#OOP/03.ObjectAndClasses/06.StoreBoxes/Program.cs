class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int Quantity { get; set; }
    public decimal PriceBox { get; set; }
}

class Program
{
    static void Main()
    {
        List<Box> boxes = new List<Box>();
        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] data = input.Split(' ');
            string serialNumber = data[0];
            string itemName = data[1];
            int quantity = int.Parse(data[2]);
            decimal itemPrice = decimal.Parse(data[3]);

            boxes.Add(new Box
            {
                SerialNumber = serialNumber,
                Item = new Item { Name = itemName, Price = itemPrice },
                Quantity = quantity,
                PriceBox = quantity * itemPrice
            });

            input = Console.ReadLine();
        }

        foreach (Box box in boxes.OrderByDescending(b => b.PriceBox))
        {
            Console.WriteLine(box.SerialNumber);
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
            Console.WriteLine($"-- ${box.PriceBox:F2}");
        }
    }
}
