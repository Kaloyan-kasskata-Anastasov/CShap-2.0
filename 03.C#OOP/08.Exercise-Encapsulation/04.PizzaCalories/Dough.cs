namespace PizzaCalories;

using System;

public class Dough
{
    private const double BaseCaloriesPerGram = 2.0;
    private const double MinWeight = 1.0;
    private const double MaxWeight = 200.0;

    private const double WhiteFlourModifier = 1.5;
    private const double WholegrainFlourModifier = 1.0;
    private const double CrispyBakingModifier = 0.9;
    private const double ChewyBakingModifier = 1.1;
    private const double DefaultBakingModifier = 1.0;

    private string flourType;
    private string bakingTechnique;
    private double weight;

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        FlourType = flourType;
        BakingTechnique = bakingTechnique;
        Weight = weight;
    }

    private string FlourType
    {
        get => flourType;
        set
        {
            string lowered = value.ToLower();
            if (lowered != "white" && lowered != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            flourType = value;
        }
    }

    private string BakingTechnique
    {
        get => bakingTechnique;
        set
        {
            string lowered = value.ToLower();
            if (lowered != "crispy" && lowered != "chewy" && lowered != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            bakingTechnique = value;
        }
    }

    private double Weight
    {
        get => weight;
        set
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
            }

            weight = value;
        }
    }

    public double Calories
    {
        get
        {
            double flourModifier = FlourType.ToLower() == "white" ? WhiteFlourModifier : WholegrainFlourModifier;
            double techniqueModifier = DefaultBakingModifier;

            string techLowered = BakingTechnique.ToLower();
            if (techLowered == "crispy")
            {
                techniqueModifier = CrispyBakingModifier;
            }
            else if (techLowered == "chewy")
            {
                techniqueModifier = ChewyBakingModifier;
            }

            return BaseCaloriesPerGram * Weight * flourModifier * techniqueModifier;
        }
    }
}
