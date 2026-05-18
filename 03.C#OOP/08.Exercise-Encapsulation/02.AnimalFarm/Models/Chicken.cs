using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        public const int MinAge = 0;
        public const int MaxAge = 15;

       // Step 1: All fields must be private to prevent unintended modifications from the outside
        private string name;
        private int age;

       // Step 2: The constructor uses the public properties (setters) instead of modifying fields directly
        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get => name;
            // Step 3: Validate name so it cannot be null, empty, or whitespace
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }
        }

        public int Age
        {
            get => age;
            // Step 3: Validate age based on MinAge and MaxAge constants
            private set
            {
                if (value < MinAge || value > MaxAge)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }
                age = value;
            }
        }

        public double ProductPerDay => CalculateProductPerDay();

        // Step 4: Hide internal logic by changing the access modifier from public to private
        private double CalculateProductPerDay()
        {
            switch (Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}