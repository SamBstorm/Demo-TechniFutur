using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstraction
{
    public class Caroussel : Attraction
    {
        public string musicTitle { get; set; }
        public Caroussel(string name, int nbSeats, int nbLaps, string music) : base(name, nbSeats, nbLaps)

        {
            musicTitle = music;
        }

        public override DateTime TimeLaps { get {
                int milli = this.NbLaps * 90000;
                return new DateTime(milli);
            } }

        public override void Run() {
            Console.WriteLine("Vérifier si enfant bien installé");
            Console.WriteLine("Récupérer ticket");
            Console.WriteLine("Enclenché moteur central");
            Console.WriteLine($"Démarrer musique {musicTitle}");
            for (int i = 0; i < this.NbLaps; i++)
            {
                Console.WriteLine("Fais un tours");
            }
            Console.WriteLine("Arrêter moteur");
            Console.WriteLine("Faire descendre enfant");
        }

        public override void StopEmergency()
        {
            Console.WriteLine("Stop moteur");
            Console.WriteLine("Evacuer attraction");
        }
    }
}
