using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstraction
{
    public class RailCoaster : Attraction
    {
        public RailCoaster(string name, int nbSeats, int nbLaps) : base(name, nbSeats, nbLaps)
        {
        }

        public override DateTime TimeLaps
        {
            get
            {
                int milli = NbLaps * 150000;
                return new DateTime(milli);
            }
        }

        public override void Run()
        {
            Console.WriteLine("Ouvrir wagon");
            Console.WriteLine("installer passager");
            Console.WriteLine("Vérifier voie");
            Console.WriteLine("Démarrer premier wagon");
            for (int i = 0; i < this.NbLaps; i++)
            {
                Console.WriteLine("Faire un tour");
            }
            Console.WriteLine("Ralentir");
            Console.WriteLine("Libérer passager");
        }

        public override void StopEmergency()
        {
            Console.WriteLine("Arrêter wagon à la prochaine halte");
            Console.WriteLine("Faire descendre passager");
        }
    }
}
