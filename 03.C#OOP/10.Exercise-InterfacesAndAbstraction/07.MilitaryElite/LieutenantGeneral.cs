using System.Text;

namespace MilitaryElite;

public class LieutenantGeneral : RegularSoldier, ILieutenantGeneral
{
    private readonly List<IPrivate> privates;

    public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
        : base(id, firstName, lastName, salary)
    {
        privates = new List<IPrivate>();
    }

    public IReadOnlyCollection<IPrivate> Privates
    {
        get { return privates.AsReadOnly(); }
    }

    public void AddPrivate(IPrivate newPrivate)
    {
        privates.Add(newPrivate);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine("Privates:");
        foreach (ISoldier soldier in privates)
        {
            sb.AppendLine($"{IndentStr}{soldier.ToString()}");
        }

        return sb.ToString().TrimEnd();
    }
}