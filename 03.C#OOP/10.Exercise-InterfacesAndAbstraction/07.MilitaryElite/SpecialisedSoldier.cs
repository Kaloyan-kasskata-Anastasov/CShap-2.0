namespace MilitaryElite;

public abstract class SpecialisedSoldier : RegularSoldier, ISpecialisedSoldier
{
    protected SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary)
    {
        Corps = corps;
    }

    public string corps;


    public string Corps
    {
        get { return corps; }
        set
        {
            if (value != "Airforces" && value != "Marines")
            {
                throw new ArgumentException("Invalid corps");
            }

            corps = value;
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()}{Environment.NewLine}Corps: {Corps}";
    }
}