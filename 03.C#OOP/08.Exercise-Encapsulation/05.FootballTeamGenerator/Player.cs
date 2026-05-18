namespace FootballTeamGenerator;

public class Player
{
    private const int MinStatValue = 0;
    private const int MaxStatValue = 100;
    private const double TotalStatsCount = 5.0;

    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        Name = name;
        Endurance = endurance;
        Sprint = sprint;
        Dribble = dribble;
        Passing = passing;
        Shooting = shooting;
    }

    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }

            name = value;
        }
    }

    public int Endurance
    {
        get => endurance;
        private set
        {
            ValidateStat(value, "Endurance");
            endurance = value;
        }
    }

    public int Sprint
    {
        get => sprint;
        private set
        {
            ValidateStat(value, "Sprint");
            sprint = value;
        }
    }

    public int Dribble
    {
        get => dribble;
        private set
        {
            ValidateStat(value, "Dribble");
            dribble = value;
        }
    }

    public int Passing
    {
        get => passing;
        private set
        {
            ValidateStat(value, "Passing");
            passing = value;
        }
    }

    public int Shooting
    {
        get => shooting;
        private set
        {
            ValidateStat(value, "Shooting");
            shooting = value;
        }
    }

    public double SkillLevel => (Endurance + Sprint + Dribble + Passing + Shooting) / TotalStatsCount;

    private void ValidateStat(int value, string statName)
    {
        if (value < MinStatValue || value > MaxStatValue)
        {
            throw new ArgumentException($"{statName} should be between {MinStatValue} and {MaxStatValue}.");
        }
    }
}