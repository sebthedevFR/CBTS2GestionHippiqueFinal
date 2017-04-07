using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using System.Data.SqlClient;

namespace PPEV2DAL
{
    public class UtilisateurDAO
    {
        private UtilisateurDAO unUtilisateurDAO;
        public UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }
            return unUtilisateurDAO;
        }

        public static List<Utilisateur> GetUtilisateurs()
        {
            List<Utilisateur> listUtil = new List<Utilisateur>();
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            //Cmd.CommandText = "select count(*) from utilisateur";
            //SqlDataReader MonLecteur = Cmd.ExecuteReader();
            //MonLecteur.Close();

            Cmd.CommandText = "select * from utilisateur";
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            while (MonLecteur.Read())
            {
                // recuperation de valeurs
                int userId = (int)MonLecteur["user_id"];
                string userlogin = (string)MonLecteur["user_login"];
                string usermdp = (string)MonLecteur["user_mdp"];
                Utilisateur newUser = new Utilisateur(userId, userlogin, usermdp);
                listUtil.Add(newUser);
            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return listUtil;
        }
        // Cette méthode insert un nouvel utilisateur passé en paramètre dans la BD
        // A VERIFIER ABSOLUMENT (SQL)
        public static int AjoutUtilisateur(Utilisateur unUtilisateur)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = " insert into utilisateur (user_login, user_mdp) VALUES ('" + unUtilisateur.Login + "','" + unUtilisateur.Mdp + "')";
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }   
        //Cette méthode modifie un utilisateur passé en paramétre dans la BD
        // A VERIFIER ABSOLUMENT (SQL)
        public static int UpdateUtilisateur(Utilisateur unUtilisateur)
        {
            int nbEnr;

            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "update utilisateur set user_login = '" + unUtilisateur.Login + "', user_mdp = '" + unUtilisateur.Mdp + "' WHERE user_id = " + unUtilisateur.Id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }

        //Cette méthode supprime un utilisateur passé en paramétre dans la BD
        // A VERIFIER ABSOLUMENT (SQL)
        public static int DeleteUtilisateur(int id)
        {
            int nbEnr;

            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "delete from utilisateur where user_id = " + id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
    }
}
