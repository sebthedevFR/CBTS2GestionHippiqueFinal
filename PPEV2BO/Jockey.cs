using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEV2BO
{
    public class Jockey
    {
        // ATTRIBUTS
        private int id;
        private string nom;
        private string prenom;
        private int age;
        private string civilite;

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

        // CONSTRUCTEUR
        public Jockey(int unId, string unNom, string unPrenom, int unAge, string uneCivilite)
        {
            id = unId;
            nom = unNom;
            prenom = unPrenom;
            age = unAge;
            civilite = uneCivilite;
        }
        public Jockey(string unNom, string unPrenom, int unAge, string uneCivilite)
        {
            nom = unNom;
            prenom = unPrenom;
            age = unAge;
            civilite = uneCivilite;
        }
    }
}
