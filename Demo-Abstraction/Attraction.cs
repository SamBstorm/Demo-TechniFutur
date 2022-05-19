using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstraction
{
    public abstract class Attraction
    {
        private static int _count = 0;

        public static int Count
        {
            get { return _count; }
        }

        private string _name;

        private int _nbSeats;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int NbSeats
        {
            get { return _nbSeats; }
            set { _nbSeats = value; }
        }

        public int NbLaps
        {
            get; set;
        }

        public abstract DateTime TimeLaps {
            get;
        }

        public Attraction(string name, int nbSeats, int nbLaps)
        {
            this._count++;
            this.Name = name;
            this.NbSeats = nbSeats;
            this.NbLaps = nbLaps;
        }

        public abstract void Run();

        public abstract void StopEmergency();
    }
}
