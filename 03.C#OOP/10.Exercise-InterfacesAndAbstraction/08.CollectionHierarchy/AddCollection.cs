namespace CollectionHierarchy;

public class AddCollection : IAddCollection
{
    private readonly List<string> data = new List<string>();

    public int Add(string item)
    {
        data.Add(item);
        return data.Count - 1;
    }
}