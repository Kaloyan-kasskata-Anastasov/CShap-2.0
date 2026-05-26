namespace CollectionHierarchy;

public class MyList : AddRemoveCollection, IMyList
{
    public int Used
    {
        get
        {
            return data.Count;
        }
    }

    public override string Remove()
    {
        string item = data[0];
        data.RemoveAt(0);
        return item;
    }
}