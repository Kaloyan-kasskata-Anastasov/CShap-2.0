using System.Text;

namespace CollectionHierarchy
{
public class StartUp
{
    public static void Main(string[] args)
    {
        IAddCollection addCollection = new AddCollection();
        IAddRemoveCollection addRemoveCollection = new AddRemoveCollection();
        IMyList myList = new MyList();

        string[] items = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int removeCount = int.Parse(Console.ReadLine());

        StringBuilder sbAdd1 = new StringBuilder();
        StringBuilder sbAdd2 = new StringBuilder();
        StringBuilder sbAdd3 = new StringBuilder();

        foreach (string item in items)
        {
            sbAdd1.Append(addCollection.Add(item) + " ");
            sbAdd2.Append(addRemoveCollection.Add(item) + " ");
            sbAdd3.Append(myList.Add(item) + " ");
        }

        StringBuilder sbRemove1 = new StringBuilder();
        StringBuilder sbRemove2 = new StringBuilder();

        for (int i = 0; i < removeCount; i++)
        {
            sbRemove1.Append(addRemoveCollection.Remove() + " ");
            sbRemove2.Append(myList.Remove() + " ");
        }

        Console.WriteLine(sbAdd1.ToString().TrimEnd());
        Console.WriteLine(sbAdd2.ToString().TrimEnd());
        Console.WriteLine(sbAdd3.ToString().TrimEnd());
        Console.WriteLine(sbRemove1.ToString().TrimEnd());
        Console.WriteLine(sbRemove2.ToString().TrimEnd());
    }
}
}
