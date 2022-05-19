using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexeur
{
    public class Parc
    {
        private string _name;
        private decimal _price;
        private List<Attraction> _attractions;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public Parc(string name, decimal price)
        {
            Name = name;
            Price = price;
            _attractions = new List<Attraction>();
        }
        public Attraction this[int index]
        {
            get { if (index < 0 || index >= this._attractions.Count) throw new ArgumentOutOfRangeException("L'index est invalide");
                return this._attractions[index];
            }
        }
        public Attraction this[string attracName]
        {
            get
            {
                if (!this._attractions.Select(a => a.Name).Contains(attracName)) throw new ArgumentOutOfRangeException("L'attraction n'existe pas");
                return this._attractions.SingleOrDefault(a => a.Name == attracName);
            }
        }

        public Attraction[] this[Category catIndex, int nbSeatsIndex]
        {
            get {
                List<Attraction> temps = new List<Attraction>();

                temps = this._attractions.Where(a => a.Category == catIndex).Where(a => a.NbSeats > nbSeatsIndex).ToList();

                return temps.ToArray();
            }

        }


        public Parc(string name, decimal price, params Attraction[] attractions): this(name, price)
        {
            _attractions.AddRange(attractions);
        }

        public int AddAttraction(Attraction attrac)
        {
            if (this._attractions.Contains(attrac)) throw new ArgumentException("L'attraction est déjà enregistrée");
            if (this._attractions.Select(a => a.Name).Contains(attrac.Name)) throw new ArgumentException("Une attraction du même nom est déjà enregistrée");
            _attractions.Add(attrac);
            return _attractions.Count - 1;
        }
    }
}
