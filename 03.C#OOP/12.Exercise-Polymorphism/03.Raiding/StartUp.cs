namespace Raiding
{
public class StartUp
{
    public static void Main(string[] args)
    {
        List<BaseHero> raidGroup = new List<BaseHero>();
        int n = int.Parse(Console.ReadLine());

        while (raidGroup.Count < n)
        {
            string heroName = Console.ReadLine();
            string heroType = Console.ReadLine();

            BaseHero hero = HeroFactory.CreateHero(heroName, heroType);

            if (hero != null)
            {
                raidGroup.Add(hero);
            }
            else
            {
                Console.WriteLine("Invalid hero!");
            }
        }

        int bossPower = int.Parse(Console.ReadLine());

        foreach (BaseHero hero in raidGroup)
        {
            Console.WriteLine(hero.CastAbility());
        }

        int totalPower = raidGroup.Sum(h => h.Power);

        if (totalPower >= bossPower)
        {
            Console.WriteLine("Victory!");
        }
        else
        {
            Console.WriteLine("Defeat...");
        }
    }
}
}
