namespace FootballTeamGenerator;

public class Team
{
    private string name;
    private Dictionary<string, Player> nameToPlayerMap;

    public Team(string name)
    {
        Name = name;
        nameToPlayerMap = new Dictionary<string, Player>();
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

    public int Rating
    {
        get
        {
            double averageSkill = nameToPlayerMap.Values
                .Select(p=>p.SkillLevel)
                .DefaultIfEmpty()
                .Average();
            return (int)Math.Round(averageSkill);
        }
    }

    public void AddPlayer(Player player)
    {
        nameToPlayerMap.Add(player.Name, player);
    }

    public void RemovePlayer(string playerName)
    {
        if (!nameToPlayerMap.ContainsKey(playerName))
        {
            throw new ArgumentException($"Player {playerName} is not in {Name} team.");
        }
        
        nameToPlayerMap.Remove(playerName);
    }
}
