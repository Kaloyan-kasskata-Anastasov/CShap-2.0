namespace CollectionHierarchy;

public class AddRemoveCollection : IAddRemoveCollection
{
    protected readonly List<string> data = new List<string>();

    public virtual int Add(string item)
    {
        data.Insert(0, item);
        return 0;
    }

    public virtual string Remove()
    {
        int lastIndex = data.Count - 1;
        string item = data[lastIndex];
        data.RemoveAt(lastIndex);
        return item;
    }
}