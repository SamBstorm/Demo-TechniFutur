using System;

namespace Demo_Indexeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Parc parc = new Parc("TechniFutur Planet", 32);
            Attraction[] attracs = { new Attraction("La mine en T", 69, Category.HauntedMansion),
            new Attraction("Le big Splash", 54, Category.Splash),
            new Attraction("Le cas roux seul", 1, Category.Caroussel),
            new Attraction("Les autres...", 20, Category.Caroussel),
            new Attraction("Frittes Fric à delle", 10, Category.FoodTruck),
            new Attraction("La poutine ukrainienne", 47, Category.RollerCoaster),
            new Attraction("Le salle Add()", 12, Category.FoodTruck),
            new Attraction("Le snake 3.0", 32, Category.RollerCoaster) };
            foreach (Attraction attrac in attracs)
            {
                int index = parc.AddAttraction(attrac);
                Console.WriteLine( $"L'attraction {index} est de catégorie : {parc[index].Category}"); 
            }

            Console.WriteLine($"Le cas roux seul est de catégorie : {parc["Le cas roux seul"].Category}");

            foreach (Attraction attrac in parc[Category.Caroussel, 1])
            {
                Console.WriteLine($"L'attraction {attrac.Name} est de catégorie : {attrac.Category}");
            }

            foreach (Attraction attrac in parc[Category.FoodTruck, 11])
            {
                Console.WriteLine($"L'attraction {attrac.Name} est de catégorie : {attrac.Category}");
            }

            foreach (Attraction attrac in parc[Category.Splash, 121])
            {
                Console.WriteLine($"L'attraction {attrac.Name} est de catégorie : {attrac.Category}");
            }
        }
    }
}
