using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEV2BO
{
    public class Cheval
    {
        // ATTRIBUTS
        private int id;
        private string nom;
        private string couleur;
        private int age;
        private string specialite;
        private string nompere;
        private string nommere;
        private string sexe;
        private int ent;
        private int pro;
        //private Entraineur ent;
        //private Proprietaire pro;

        // NE PAS OUBLIER D'ASSIGNER ID PROPRIETAIRE et ID ENTRAINEUR

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
        public string Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Specialite
        {
            get { return specialite; }
            set { specialite = value; }
        }
        public string Nompere
        {
            get { return nompere; }
            set { nompere = value; }
        }
        public string Nommere
        {
            get { return nommere; }
            set { nommere = value; }
        }
        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
        public int Entraineur
        {
            get { return ent; }
            set { ent = value; }
        }
        public int Proprietaire
        {
            get { return pro; }
            set { pro = value; }
        }


        // CONSTRUCTEUR
        public Cheval(int unId, string unNom, string uneCouleur, int unAge, string uneSpe, string unNomPere, string unNomMere, string unSexe, int unEnt, int unPro)
        {
            id = unId;
            nom = unNom;
            couleur = uneCouleur;
            age = unAge;
            specialite = uneSpe;
            nompere = unNomPere;
            nommere = unNomMere;
            sexe = unSexe;
            ent = unEnt;
            pro = unPro;
        }
        public Cheval(string unNom, string uneCouleur, int unAge, string uneSpe, string unNomPere, string unNomMere, string unSexe, int unEnt, int unPro)
        {
            nom = unNom;
            couleur = uneCouleur;
            age = unAge;
            specialite = uneSpe;
            nompere = unNomPere;
            nommere = unNomMere;
            sexe = unSexe;
            ent = unEnt;
            pro = unPro;
        }
    }
}
