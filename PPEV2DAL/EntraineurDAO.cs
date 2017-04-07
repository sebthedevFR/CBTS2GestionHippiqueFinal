    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using System.Data.SqlClient;

namespace PPEV2DAL
{
    public class EntraineurDAO
    {
        private EntraineurDAO unEntraineurDAO;

        public EntraineurDAO GetUnEntraineurDAO()
        {
            if (unEntraineurDAO == null)
            {
                unEntraineurDAO = new EntraineurDAO();
            }
            return unEntraineurDAO;
        }

        /// <summary>
        /// Cette méthode retourne une liste de cheval qui sont entrainés par un entraineur en passant l'id de l'entraineur en paramètre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<Cheval> GetChevauxEntrainer(int id)
        {
            List<Cheval> ListeChevaux = new List<Cheval>();
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from cheval where ent_id = " + id;
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
                ListeChevaux.Add(unCheval);
            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return ListeChevaux;
        }

        /// <summary>
        /// Cette méthode retourne les entraineurs de la BDD sous forme de liste
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public static List<Entraineur> GetEntraineurs()
        {
            List<Entraineur> listEntr = new List<Entraineur>();
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from entraineur";
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            while (MonLecteur.Read())
            {
                // recuperation de valeurs
                int entId = (int)MonLecteur["ent_id"];
                string entNom = (string)MonLecteur["ent_nom"];
                string entPrenom = (string)MonLecteur["ent_prenom"];
                int entAge = (int)MonLecteur["ent_age"];
                string entCivilite = (string)MonLecteur["ent_civilite"];
                string entLocalisation = (string)MonLecteur["ent_localisation"];
                Entraineur unEnt = new Entraineur(entId, entNom, entPrenom, entAge, entCivilite, entLocalisation);
                listEntr.Add(unEnt);
            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return listEntr;
        }


        /// <summary>
        /// Cette méthode ajoute un entraineur en BDD
        /// </summary>
        /// <param name="unEntraineur"></param>
        /// <returns></returns>
        public static int AjoutEntraineur(Entraineur unEntraineur)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = " insert into entraineur (ent_nom, ent_prenom, ent_age, ent_civilite, ent_localisation) VALUES ('" + unEntraineur.Nom + "','" + unEntraineur.Prenom + "'," + unEntraineur.Age + ",'" + unEntraineur.Civilite + "','" + unEntraineur.Localisation + "')";
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }


        /// <summary>
        /// Cette méthode retourne un entraineur quand on passe son id en paramètre
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public static Entraineur GetUnEntraineur(int id)
        {
            Entraineur unEntraineur = null;
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from entraineur where ent_id = " + id;
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            if (MonLecteur.Read())
            {
                int entId = (int)MonLecteur["ent_id"];
                string entNom = (string)MonLecteur["ent_nom"];
                string entPrenom = (string)MonLecteur["ent_prenom"];
                int entAge = (int)MonLecteur["ent_age"];
                string entCivilite = (string)MonLecteur["ent_civilite"];
                string entLocalisation = (string)MonLecteur["ent_localisation"];
                unEntraineur = new Entraineur(entId, entNom, entPrenom, entAge, entCivilite, entLocalisation);
            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return unEntraineur;
        }
        /// <summary>
        /// Cette méthode modifie un entraineur
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public static int UpdateEntraineur(Entraineur unEntraineur)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "update entraineur set ent_nom = '" + unEntraineur.Nom + "', ent_prenom = '" + unEntraineur.Prenom + "', ent_age = " + unEntraineur.Age + ", ent_civilite = '" + unEntraineur.Civilite + "', ent_localisation = '" + unEntraineur.Localisation + "' WHERE ent_id =" + unEntraineur.Id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }

        /// <summary>
        /// Cette méthode supprime un entraineur
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public static int DeleteEntraineur(int id)
        {
            int nbEnr = 0;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "delete from entraineur where ent_id = " + id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
    }
}
