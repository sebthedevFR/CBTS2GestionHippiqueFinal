using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using System.Data.SqlClient;

namespace PPEV2DAL
{
    public class HippodromeDAO
    {
        private HippodromeDAO unHippodromeDAO;

        public HippodromeDAO GetUnHippodromeDAO()
        {
            if (unHippodromeDAO == null)
            {
                unHippodromeDAO = new HippodromeDAO();
            }
            return unHippodromeDAO;
        }
        public static List<Hippodrome> GetHippodromes()
        {
            List<Hippodrome> listHip= new List<Hippodrome>();
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from hippodrome";
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            while (MonLecteur.Read())
            {
                // recuperation de valeurs
                int hipId = (int)MonLecteur["hip_id"];
                string hipNom = (string)MonLecteur["hip_nom"];
                string hipLieu = (string)MonLecteur["hip_lieu"];
                Hippodrome unHip = new Hippodrome(hipId, hipNom, hipLieu);
                listHip.Add(unHip);
            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return listHip;
        }
        // methode qui relie les cables de la DAL avec la BLL
        // C'est VIIIIIINCE qui m'a donné cette méthode. Va falloir la tester (voir CHEVAL DAO création de l'objet cheval a partir de la BDD)
        public static Hippodrome GetUnHippodrome(int id)
        {
            Hippodrome unHip = null;
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from hippodrome where hip_id = " + id;
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            if (MonLecteur.Read())
            {
                int hipId = (int)MonLecteur["hip_id"];
                string hipNom = (string)MonLecteur["hip_nom"];
                string hipLieu = (string)MonLecteur["hip_lieu"];
                unHip = new Hippodrome(hipId, hipNom, hipLieu);
            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return unHip;
        }
        //Cette méthode modifie un utilisateur passé en paramétre dans la BD
        // A VERIFIER ABSOLUMENT (SQL)
        public static int UpdateHippodrome(Hippodrome unHippodrome)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "update hippodrome set hip_nom = '" + unHippodrome.Nom + "', hip_lieu = '" + unHippodrome.Lieu + "' WHERE hip_id = " + unHippodrome.Id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
        //Cette méthode supprime un utilisateur passé en paramétre dans la BD
        // A VERIFIER ABSOLUMENT (SQL)
        public static int DeleteHippodrome(int id)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "delete from hippodrome where hip_id = " + id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
        public static int AjoutHippodrome(Hippodrome unHippodrome)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = " insert into hippodrome (hip_nom, hip_lieu) VALUES ('" + unHippodrome.Nom + "','" + unHippodrome.Lieu + ")";
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
        
    }
}

