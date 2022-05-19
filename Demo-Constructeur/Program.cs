using System;

namespace Demo_Constructeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Canard duck_premier = new Canard("Duck","Donald",new DateTime(1934,1,1));
            Canard duck_riche = new Canard(new DateTime(1947,12,1));

            Console.WriteLine($"Nom : {duck_premier.Lastname} {duck_premier.Firstname} - Age : {duck_premier.YearsOld}");
            Console.WriteLine($"Nom : {duck_riche.Lastname} {duck_riche.Firstname} - Age : {duck_riche.YearsOld}");
        }
    }
}
