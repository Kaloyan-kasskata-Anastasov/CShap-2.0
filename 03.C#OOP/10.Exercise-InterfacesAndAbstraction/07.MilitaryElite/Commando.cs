using System.Text;

namespace MilitaryElite;

public class Commando : SpecialisedSoldier, ICommando
{
    private readonly List<IMission> missions;

    public Commando(int id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        missions = new List<IMission>();
    }

    public IReadOnlyCollection<IMission> Missions
    {
        get { return missions.AsReadOnly(); }
    }

    public void AddMission(IMission mission)
    {
        missions.Add(mission);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine("Missions:");
        foreach (IMission mission in missions)
        {
            sb.AppendLine($"{IndentStr}{mission.ToString()}");
        }

        return sb.ToString().TrimEnd();
    }
}