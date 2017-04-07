using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using System.Data.SqlClient;
using PPEV2DAL;

namespace PPEV2DAL
{
    public class ChevalDAO
    {
        private ChevalDAO unChevalDAO;

        public ChevalDAO GetunChevalDAO()
        {
            if (unChevalDAO == null)
            {
                unChevalDAO = new ChevalDAO();
            }
            return unChevalDAO;
        }


        /// <summary>
        /// RETOURNE  LA LISTE DES CHEVAUX DANS LA BDD
        /// </summary>
        /// <returns></returns>
        public static List<Cheval> GetChevaux()
        {
            List<Cheval> listChe = new List<Cheval>();
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from cheval";
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            while (MonLecteur.Read())
            {
                // recuperation de valeurs
                int chevalId = (int)MonLecteur["ch_id"];
                string chevalNom = (string)MonLecteur["ch_nom"];
                string chevalCouleur = (string)MonLecteur["ch_couleur"];
                int chevalAge = (int)MonLecteur["ch_age"];
                string chevalSpecialite = (string)MonLecteur["ch_specialite"];
                string chevalNomPere = (string)MonLecteur["ch_nompere"];
                string chevalNomMere = (string)MonLecteur["ch_nommere"];
                string chevalSexe = (string)MonLecteur["ch_sexe"];
                // c'est ici que ça deviens compliqué, bien lire les deux prochaines lignes plusieurs fois pour comprendre.
                int chevalEnt = (int)MonLecteur["ent_id"];
                int chevalPro = (int)MonLecteur["pro_id"];
                //Entraineur chevalEnt = EntraineurDAO.GetUnEntraineur((int)MaConnectionSql.MonLecteur["ent_id"]);
                //Proprietaire chevalPro = ProprietaireDAO.GetUnProprietaire((int)MaConnectionSql.MonLecteur["pro_id"]);

                // Et la bim, on crée l'objet cheval. ( Et y'a pas d'erreur wow )
                Cheval unCheval = new Cheval(chevalId, chevalNom, chevalCouleur, chevalAge, chevalSpecialite, chevalNomPere, chevalNomMere, chevalSexe, chevalEnt, chevalPro);
                // on ajoute le cheval à la liste
                listChe.Add(unCheval);
            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return listChe;
            // auccune erreur, wow.
        }

        /// <summary>
        /// Cette méthode insert un nouveau cheval passé en paramètre dans la BDD
        /// </summary>
        /// <param name="unCheval"></param>
        /// <returns></returns>
        public static int AjoutCheval(Cheval unCheval)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = " insert into cheval (ch_nom, ch_couleur, ch_age, ch_specialite, ch_nompere, ch_nommere, ch_sexe, ent_id, pro_id) VALUES ('" + unCheval.Nom + "','" + unCheval.Couleur +  "'," + unCheval.Age + ",'" + unCheval.Specialite + "','" + unCheval.Nompere + "','" + unCheval.Nommere + "','" + unCheval.Sexe + "'," + unCheval.Entraineur + "," + unCheval.Proprietaire + ")";
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }

        /// <summary>
        /// Cette méthode met à jour un nouveau cheval passé en paramètre dans la BDD
        /// </summary>
        /// <param name="unCheval"></param>
        /// <returns></returns>
        public static int UpdateCheval(Cheval unCheval)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "update cheval set ch_nom = '" + unCheval.Nom + "', ch_couleur = '" + unCheval.Couleur + "', ch_age = " + unCheval.Age + ", ch_specialite = '" + unCheval.Specialite + "', ch_nompere = '" + unCheval.Nompere + "', ch_nommere = '" + unCheval.Nommere + "', ch_sexe = '" + unCheval.Sexe + "', ent_id = " + unCheval.Entraineur + ", pro_id = " + unCheval.Proprietaire + " WHERE ch_id  =" + unCheval.Id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }

        /// <summary>
        /// Cette méthode supprime un cheval passé en paramètre dans la BDD
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int DeleteCheval(int id)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "delete from cheval where ch_id = " + id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }

        /// <summary>
        /// Cette méthode retourne un cheval en passant son id en paramètre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Cheval GetUnCheval(int id)
        {
            Cheval unCheval = null;
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from cheval where ch_id = " + id;
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            if (MonLecteur.Read())
            {
                // recuperation de valeurs
                int chevalId = (int)MonLecteur["ch_id"];
                string chevalNom = (string)MonLecteur["ch_nom"];
                string chevalCouleur = (string)MonLecteur["ch_couleur"];
                int chevalAge = (int)MonLecteur["ch_age"];
                string chevalSpecialite = (string)MonLecteur["ch_specialite"];
                string chevalNomPere = (string)MonLecteur["ch_nompere"];
                string chevalNomMere = (string)MonLecteur["ch_nommere"];
                string chevalSexe = (string)MonLecteur["ch_sexe"];
                // c'est ici que ça deviens compliqué, bien lire les deux prochaines lignes plusieurs fois pour comprendre.
                int chevalEnt = (int)MonLecteur["ent_id"];
                int chevalPro = (int)MonLecteur["pro_id"];

                // Et la bim, on crée l'objet cheval. ( Et y'a pas d'erreur wow )
                unCheval = new Cheval(chevalId, chevalNom, chevalCouleur, chevalAge, chevalSpecialite, chevalNomPere, chevalNomMere, chevalSexe, chevalEnt, chevalPro);

            }

            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return unCheval;
        }

        /// <summary>
        /// Cette méthode retourne une liste de cheval assigné à une course en passant l'id de la course en paramètre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<Cheval> GetLesChevauxDuneCourse(int id)
        {
            List<Participe> listPart = new List<Participe>();
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from participe where crs_id = " + id;
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            while (MonLecteur.Read())
            {
                // recuperation de valeurs
                int chevalId = (int)MonLecteur["ch_id"];
                int courseId = (int)MonLecteur["crs_id"];
                int jockeyId = (int)MonLecteur["joc_id"];
                int classement = (int)MonLecteur["classement"];
                
                Participe uneParticipation = new Participe(chevalId, courseId, jockeyId, classement);
                // on ajoute le cheval à la liste
                listPart.Add(uneParticipation);
            }
            List<Cheval> listChe = new List<Cheval>();
            foreach (Participe unPar in listPart)
            {
                listChe.Add(GetUnCheval(unPar.Cheval));
            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return listChe;
            // auccune erreur, wow.
        }

        public static List<Participe> GetCourseDuCheval(int idCheval)
        {
            List<Participe> listParticipe = new List<Participe>();
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from participe WHERE ch_id =" + idCheval;
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            while (MonLecteur.Read())
            {
                // recuperation de valeurs
                int partiCheval = (int)MonLecteur["ch_id"];
                int partiCourse = (int)MonLecteur["crs_id"];
                int partiJockey = (int)MonLecteur["joc_id"];
                int partiClass = (int)MonLecteur["classement"];

                Participe uneParti = new Participe(partiCheval, partiCourse, partiJockey, partiClass);
                listParticipe.Add(uneParti);
            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return listParticipe;


        }
        
    }
}
