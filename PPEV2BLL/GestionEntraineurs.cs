using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using PPEV2DAL;

namespace PPEV2BLL
{
    public class GestionEntraineurs
    {
        private GestionEntraineurs uneGestionEntraineurs;

        public GestionEntraineurs GetGestionEntraineurs()
        {
            if (uneGestionEntraineurs == null)
            {
                uneGestionEntraineurs = new GestionEntraineurs();
            }
            return uneGestionEntraineurs;
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Entraineur> GetEntraineurs()
        {
            return EntraineurDAO.GetEntraineurs();
        }
        public static List<Cheval> GetChevauxEntraineurs(int id)
        {
            return EntraineurDAO.GetChevauxEntrainer(id);
        }
        public static Entraineur GetUnEntraineurs(int id)
        {
            return EntraineurDAO.GetUnEntraineur(id);
        }
        public static int CreerEntraineur(string nom, string prenom, int age, string civilite, string localisation)
        {
            Entraineur et = new Entraineur(nom, prenom, age, civilite, localisation);
            return EntraineurDAO.AjoutEntraineur(et);
        }
        public static int ModifierEntraineur(int id,string nom, string prenom, int age, string civilite, string localisation)
        {
            Entraineur et = new Entraineur(id, nom, prenom, age, civilite, localisation);
            return EntraineurDAO.UpdateEntraineur(et);
        }
        public static int SupprimerEntraineur(int id)
        {
            return EntraineurDAO.DeleteEntraineur(id);
        }
    }
}
