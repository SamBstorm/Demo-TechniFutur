using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstraction
{
    public class ChuteLibre : Attraction
    {
        public ChuteLibre(string name, int nbSeats, int nbLaps) : base(name, nbSeats, nbLaps)
        {
        }

        public override DateTime TimeLaps { get {
                int milli = NbLaps * 1500;
                return new DateTime(milli);
            } }

        public override void Run()
        {
            Console.WriteLine("Installer passager");
            Console.WriteLine("Vérifier sécurité passager");
            for (int i = 0; i < NbLaps; i++)
            {
                Console.WriteLine("Monter nacelle");
                Console.WriteLine("Lâcher la nacelle");
            }
            Console.WriteLine("Libérer passager");
        }

        public override void StopEmergency()
        {
            Console.WriteLine("Arrêter nacelle");
            Console.WriteLine("Descendre nacelle à petite vitesse");
            Console.WriteLine("Libérer passager");
        }
    }
}
