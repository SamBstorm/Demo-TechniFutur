using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Constructeur
{
    public class Canard // (UpperPascalCase)
    {
        #region Champs (pascalCase)
        private string _firstname;
        private DateTime _birthdate;

        #endregion
        #region Propriétés/Indexeurs (UpperPascalCase)
        public string Lastname { get; set;}
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public int YearsOld { get {
                return DateTime.Now.Year - this._birthdate.Year;
            } }

        public DateTime BirthDate { set { this._birthdate = value; } }


        #endregion
        #region Constructeurs (UpperPascalCase)
        /// <summary>
        /// Permet de générer un canard de Disney...    
        /// </summary>
        /// <param name="lastname">Donnez le nom de famille</param>
        /// <param name="firstname">Donnez le prénom</param>
        /// <param name="birthDate">Donnez la date de naissance</param>
        public Canard(string lastname, string firstname, DateTime birthDate)
        {
            Lastname = lastname;
            Firstname = firstname;
            BirthDate = birthDate;
        }
        public Canard(DateTime birthDate, string firstname = "Donald") : this("Duck",firstname, birthDate)
        {
            Console.WriteLine("Astucieux ce constructeur!");
        }

        #endregion
        #region Methodes (UpperPascalCase - paramètres sont en pascalCase)

        #endregion
    }
}

/*
 Différent type de nomenclature :

snake_case : full minuscule, séparation des termes par un underscore => langage Web 
khebab-case : full minuscule, séparation des termes par un tiret => langage Web (nommination ficher)

pascalCase : full minuscule, séparation des termes par une Majuscule : langage avancé (instance ou variable ou paramètre)
UpperPascalCase : full minuscule, sauf premier caractère, et séparation des termes par une Majuscule : langage avancé (nommination des class, structures, propriétés, méthodes)

 */
