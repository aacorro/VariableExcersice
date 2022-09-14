using System;

namespace VariablesExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initializing variables 
            string name = "Octupus";
            int species = 289;
            int arms = 8;
            char  hearts = '3';
            bool poisonous = true;
            double weightAve = 14.3;
            decimal sizeAve = 60.4m;

            Console.WriteLine($"With {arms} arms, {hearts} hearts and {species} species, the {name} is one of the most fascinating sea creatures. " +
                $"With {weightAve}lb and {sizeAve}cm average weight and lenght respectively, the only question is: Are they poisonous? The answer is: {poisonous}");
        }
    }
}
