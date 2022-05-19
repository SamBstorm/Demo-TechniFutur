namespace Demo_Indexeur
{
    public class Attraction
    {
        private string _name;
        private int _nbSeats;
        private Category _category;
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
        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public Attraction(string name, int nbSeats, Category category)
        {
            Name = name;
            NbSeats = nbSeats;
            Category = category;
        }
    }
}