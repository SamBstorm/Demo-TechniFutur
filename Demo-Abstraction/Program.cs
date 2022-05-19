using System;

namespace Demo_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Attraction attrac1 = new Caroussel("Le gars roux seul", 1, 5, "Le petit bonhome en mousse");
            Attraction attrac2 = new RailCoaster("Snake 3.0", 10, 1);
            Attraction attrac3 = new Caroussel("Le root'or", 15, 10, "Turn around");
            Attraction attrac4 = new RailCoaster("La mine en T", 20, 1);
            Attraction attrac5 = new ChuteLibre("La dernière...", 10, 2);

            attrac1.Run();
            attrac2.Run();
            attrac5.Run();

            attrac3.StopEmergency();
            attrac4.StopEmergency();

            Console.WriteLine(Attraction.Count);
        }
    }
}
