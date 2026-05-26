using System.Text;

namespace MilitaryElite;

public class Engineer : SpecialisedSoldier, IEngineer
{
    private readonly List<IRepair> repairs;

    public Engineer(int id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        repairs = new List<IRepair>();
    }

    public IReadOnlyCollection<IRepair> Repairs
    {
        get { return repairs.AsReadOnly(); }
    }

    public void AddRepair(IRepair repair)
    {
        repairs.Add(repair);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine("Repairs:");
        foreach (IRepair repair in repairs)
        {
            sb.AppendLine($"{IndentStr}{repair.ToString()}");
        }

        return sb.ToString().TrimEnd();
    }
}