namespace MilitaryElite;

public interface IEngineer : ISpecialisedSoldier
{
    IReadOnlyCollection<IRepair> Repairs { get; }
}