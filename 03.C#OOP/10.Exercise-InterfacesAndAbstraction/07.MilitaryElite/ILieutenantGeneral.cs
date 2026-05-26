namespace MilitaryElite;

public interface ILieutenantGeneral : IPrivate
{
    IReadOnlyCollection<IPrivate> Privates { get; }
}