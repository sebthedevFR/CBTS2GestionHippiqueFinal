using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using System.Data.SqlClient;

namespace PPEV2DAL
{
    public class JockeyDAO
    {
        private JockeyDAO unJockeyDAO;

        public JockeyDAO GetUnJockeyDAO()
        {
            if (unJockeyDAO == null)
            {
                unJockeyDAO = new JockeyDAO();
            }
            return unJockeyDAO;
        }

        public static List<Jockey> GetJockeys()
        {
            List<Jockey> ListJockey = new List<Jockey>();
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from jockey";
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            while (MonLecteur.Read())
            {
                // recuperation de valeurs
                int jockId = (int)MonLecteur["joc_id"];
                string jockNom = (string)MonLecteur["joc_nom"];
                string jockPrenom = (string)MonLecteur["joc_prenom"];
                int jockAge = (int)MonLecteur["joc_age"];
                string jockCiv = (string)MonLecteur["joc_civilite"];
                Jockey unJockey = new Jockey(jockId,jockNom,jockPrenom,jockAge,jockCiv);
                ListJockey.Add(unJockey);

            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return ListJockey;
        }
        // methode qui relie les cables de la DAL avec la BLL
        // C'est VIIIIIINCE qui m'a donné cette méthode. Va falloir la tester (voir CHEVAL DAO création de l'objet cheval a partir de la BDD)
        public static Jockey GetUnJockey(int id)
        {
            Jockey unJockey = null;
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from jockey where joc_id = " + id;
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            if (MonLecteur.Read())
            {
                int jockId = (int)MonLecteur["joc_id"];
                string jockNom = (string)MonLecteur["joc_nom"];
                string jockPrenom = (string)MonLecteur["joc_prenom"];
                int jockAge = (int)MonLecteur["joc_age"];
                string jockCiv = (string)MonLecteur["joc_civilite"];
                unJockey = new Jockey(jockId, jockNom, jockPrenom, jockAge, jockCiv);
            }

            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return unJockey;
        }
        //Cette méthode modifie un utilisateur passé en paramétre dans la BD
        // A VERIFIER ABSOLUMENT (SQL)
        public static int UpdateJockey(Jockey unJockey)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "update jockey set joc_nom = '" + unJockey.Nom + "', joc_prenom = '" + unJockey.Prenom + "', joc_age = " + unJockey.Age + ", joc_civilite = '" + unJockey.Civilite + "'  WHERE joc_id = " + unJockey.Id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
        public static int DeleteJockey(int id)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "delete from jockey where joc_id = " + id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
        public static int AjoutJockey(Jockey unJockey)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = " insert into jockey (joc_nom, joc_prenom, joc_age, joc_civilite) VALUES ('" + unJockey.Nom + "','" + unJockey.Prenom + "'," + unJockey.Age + ",'" + unJockey.Civilite + "')";
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
    }
}
