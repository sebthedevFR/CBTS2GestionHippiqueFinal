using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEV2BO
{
    public class Entraineur
    {
        // ATTRIBUTS
        private int id;
        private string nom;
        private string prenom;
        private int age;
        private string civilite;
        private string localisation;

        // PROPRIETES
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Civilite
        {
            get { return civilite; }
            set { civilite = value; }
        }
        public string Localisation
        {
            get { return localisation; }
            set { localisation = value; }
        }

        // CONSTRUCTEUR
        public Entraineur(int unId, string unNom, string unPrenom, int unAge, string uneCivilite, string uneLocalisation)
        {
            id = unId;
            nom = unNom;
            prenom = unPrenom;
            age = unAge;
            civilite = uneCivilite;
            localisation = uneLocalisation;
        }
        public Entraineur(string unNom, string unPrenom, int unAge, string uneCivilite, string uneLocalisation)
        {
            nom = unNom;
            prenom = unPrenom;
            age = unAge;
            civilite = uneCivilite;
            localisation = uneLocalisation;
        }
        public Entraineur()
        {
        }
    }
}
