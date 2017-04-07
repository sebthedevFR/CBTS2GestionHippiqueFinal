using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEV2BO
{
    public class Hippodrome
    {
        // ATTRIBUTS
        private int id;
        private string nom;
        private string lieu;

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
        public string Lieu
        {
            get { return lieu; }
            set { lieu = value; }
        }

        // CONSTRUCTEUR
        public Hippodrome(int unId, string unNom, string unLieu)
        {
            id = unId;
            nom = unNom;
            lieu = unLieu;
        }
        public Hippodrome(string unNom, string unLieu)
        {
            nom = unNom;
            lieu = unLieu;
        }
        public Hippodrome()
        {
        }
    }
}
