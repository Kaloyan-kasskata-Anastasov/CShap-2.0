namespace FootballTeamGenerator
{
/*
Team;Arsenal
Rating;Arsenal
END
*/
public class StartUp
{
    public static void Main(string[] args)
    {
        Dictionary<string, Team> teams = new Dictionary<string, Team>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] arguments = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
            try
            {
                switch (arguments[0])
                {
                    case "Team":
                        string teamName = arguments[1];
                        Team newTeam = new Team(teamName);
                        teams.Add(teamName, newTeam);
                        break;

                    case "Add":
                        string targetTeam = arguments[1];
                        if (!teams.ContainsKey(targetTeam))
                        {
                            throw new ArgumentException($"Team {targetTeam} does not exist.");
                        }

                        string playerName = arguments[2];
                        int endurance = int.Parse(arguments[3]);
                        int sprint = int.Parse(arguments[4]);
                        int dribble = int.Parse(arguments[5]);
                        int passing = int.Parse(arguments[6]);
                        int shooting = int.Parse(arguments[7]);

                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        teams[targetTeam].AddPlayer(player);
                        break;

                    case "Remove":
                        string fromTeam = arguments[1];
                        string playerToRemove = arguments[2];

                        if (!teams.ContainsKey(fromTeam))
                        {
                            throw new ArgumentException($"Team {fromTeam} does not exist.");
                        }

                        teams[fromTeam].RemovePlayer(playerToRemove);
                        break;

                    case "Rating":
                        string rateTeam = arguments[1];
                        if (!teams.ContainsKey(rateTeam))
                        {
                            throw new ArgumentException($"Team {rateTeam} does not exist.");
                        }

                        Console.WriteLine($"{rateTeam} - {teams[rateTeam].Rating}");
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
}
