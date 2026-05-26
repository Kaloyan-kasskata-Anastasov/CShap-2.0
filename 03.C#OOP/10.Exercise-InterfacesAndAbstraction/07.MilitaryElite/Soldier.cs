namespace MilitaryElite;

public abstract class Soldier : ISoldier
{
    public const string IndentStr = "  ";

    protected Soldier(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public int Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
}