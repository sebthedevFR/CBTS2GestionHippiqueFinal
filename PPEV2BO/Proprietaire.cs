using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEV2BO
{
    public class Proprietaire
    {
        // ATTRIBUTS
        private int id;
        private string nom;
        private string prenom;
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
        public string Civilite
        {
            get { return civilite; }
            set { civilite = value; }
        }

        // CONSTRUCTEUR
        public Proprietaire(int unId, string unNom, string unPrenom, string uneCivilite)
        {
            id = unId;
            nom = unNom;
            prenom = unPrenom;
            civilite = uneCivilite;
        }
        public Proprietaire(string unNom, string unPrenom, string uneCivilite)
        {
            nom = unNom;
            prenom = unPrenom;
            civilite = uneCivilite;
        }
        public Proprietaire()
        {

        }
    }
}
