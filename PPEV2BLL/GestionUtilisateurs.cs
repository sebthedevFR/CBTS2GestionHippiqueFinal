using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using PPEV2BO;
using PPEV2DAL;

namespace PPEV2BLL
{
    public class GestionUtilisateurs
    {
        private GestionUtilisateurs uneGestionUtilisateurs; // objet BLL

        // Accesseur en lecture
        public GestionUtilisateurs GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new GestionUtilisateurs();
            }
            return uneGestionUtilisateurs;
        }

        // CONNECTION STUFF
        //public static void ConnectionON()
        //{
        //ConnexionDb.InitializeConnection();
        //ConnexionDb.OpenConnection();
        //}
        //public static void ConnectionOff()
        //{
        //ConnexionDb.CloseConnection();
        //}





        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Utilisateur> GetUtilisateurs()
        {
            return UtilisateurDAO.GetUtilisateurs();
        }
        // Méthode qui créer un nouvel objet Utilisateur à partir de son id et de son nom et qui le renvoi en l'ajoutant à la BD avec la méthode AjoutUtilisateur de la DAL
        public static int CreerUtilisateur(string login, string mdp)
        {
            Utilisateur ut = new Utilisateur(login, mdp);
            return UtilisateurDAO.AjoutUtilisateur(ut);
        }
        // Méthode qui modifie un nouvel Utilisateur avec la méthode UpdateUtilisateur de la DAL
        public static int ModifierUtilisateur(int id, string nom, string mdp)
        {
            Utilisateur ut = new Utilisateur(id, nom, mdp);
            return UtilisateurDAO.UpdateUtilisateur(ut);
        }
        public static int SupprimerUtilisateur(int id)
        {
            return UtilisateurDAO.DeleteUtilisateur(id);
        }

    }
}
