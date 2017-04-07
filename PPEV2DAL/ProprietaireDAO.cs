using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using System.Data.SqlClient;

namespace PPEV2DAL
{
    public class ProprietaireDAO
    {
        private ProprietaireDAO unProprietaireDAO;

        public ProprietaireDAO GetUnProprietaireDAO()
        {
            if (unProprietaireDAO == null)
            {
                unProprietaireDAO = new ProprietaireDAO();
            }
            return unProprietaireDAO;
        }

        public static List<Proprietaire> GetProprietaire()
        {
            List<Proprietaire> listPro = new List<Proprietaire>();
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from proprietaire";
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            while (MonLecteur.Read())
            {
                // recuperation de valeurs
                int proId = (int)MonLecteur["pro_id"];
                string proNom = (string)MonLecteur["pro_nom"];
                string proPrenom = (string)MonLecteur["pro_prenom"];
                string proCivilite = (string)MonLecteur["pro_civilite"];
                Proprietaire unPro = new Proprietaire(proId, proNom, proPrenom, proCivilite);
                listPro.Add(unPro);
            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return listPro;
        }
        // Cette méthode insert un nouvel proprietaire passé en paramètre dans la BD
        // A VERIFIER ABSOLUMENT (SQL)
        public static int AjoutProprietaire(Proprietaire unProprietaire)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = " insert into proprietaire (pro_nom, pro_prenom, pro_civilite) VALUES ('" + unProprietaire.Nom+ "','" + unProprietaire.Prenom + "')";
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
        // methode qui relie les cables de la DAL avec la BLL
        // C'est VIIIIIINCE qui m'a donné cette méthode. Va falloir la tester (voir CHEVAL DAO création de l'objet cheval a partir de la BDD)
        public static Proprietaire GetUnProprietaire(int id)
        {
            Proprietaire unPro = null;
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from proprietaire where pro_id = " + id;
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            if (MonLecteur.Read())
            {
                int proId = (int)MonLecteur["pro_id"];
                string proNom = (string)MonLecteur["pro_nom"];
                string proPrenom = (string)MonLecteur["pro_prenom"];
                string proCivilite = (string)MonLecteur["pro_civilite"];
                unPro = new Proprietaire(proId, proNom, proPrenom, proCivilite);
            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return unPro;
        }
        //Cette méthode modifie un utilisateur passé en paramétre dans la BD
        // A VERIFIER ABSOLUMENT (SQL)
        public static int UpdateProprietaire(Proprietaire unProprietaire)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "update proprietaire set pro_nom = '" + unProprietaire.Nom + "', pro_prenom = '" + unProprietaire.Prenom + "' WHERE pro_id = " + unProprietaire.Id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }

        //Cette méthode supprime un utilisateur passé en paramétre dans la BD
        // A VERIFIER ABSOLUMENT (SQL)
        public static int DeleteProprietaire(int id)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "delete from proprietaire where pro_id = " + id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
    }
}
