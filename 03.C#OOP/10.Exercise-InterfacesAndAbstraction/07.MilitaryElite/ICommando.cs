namespace MilitaryElite;

public interface ICommando : ISpecialisedSoldier
{
    IReadOnlyCollection<IMission> Missions { get; }
}