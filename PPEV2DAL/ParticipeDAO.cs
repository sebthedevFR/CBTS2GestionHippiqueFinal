using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using System.Data.SqlClient;
using System.Data;

namespace PPEV2DAL
{
    public class ParticipeDAO
    {
        private ParticipeDAO uneParticipationDAO;

        public ParticipeDAO GetUneParticipationDAO()
        {
            if (uneParticipationDAO == null)
            {
                uneParticipationDAO = new ParticipeDAO();
            }
            return uneParticipationDAO;
        }
        public static List<Participe> GetParticipation()
        {
            List<Participe> listParticipe = new List<Participe>();
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from participe";
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
        public static int AjoutParticipation(Participe uneParticipe)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = " insert into participe (ch_id, crs_id, joc_id, classement) VALUES (" + uneParticipe.Cheval + "," + uneParticipe.Course + "," + uneParticipe.Jockey + "," + uneParticipe.Clas + ")";
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
        // UPDATE 
        public static int UpdateParticipation(Participe uneParticipe)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "update participe set ch_id = '" + uneParticipe.Cheval + "', crs_id = '" + uneParticipe.Course + "', joc_id = " + uneParticipe.Jockey + ", classement = '" + uneParticipe.Clas;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
        public static int AssignerClassementCheval(int idCheval, int idCourse, int classement)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "update participe set classement ='" + classement + "'WHERE ch_id ='" + idCheval + "'AND crs_id=" + idCourse;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;

        }
        public static int DeleteParticipation(int id)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "delete from participe where ch_id = " + id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
        public static DataTable GetResultatDerniereCourse(int id)
        {
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            SqlDataAdapter myDa = new SqlDataAdapter();
          
            string stringSql = "SELECT classement AS 'Classement', ch_nom AS 'Nom Cheval' FROM participe, cheval, course WHERE participe.ch_id = cheval.ch_id AND participe.crs_id = course.crs_id AND course.crs_id ='" + id + "'ORDER BY classement";
            myDa.SelectCommand = new SqlCommand(stringSql, MaConnectionSql);
            Cmd.CommandText = stringSql;
            DataTable table = new DataTable();

            myDa.Fill(table);

            ConnexionDb.CloseConnexion();
            return table;
        }
        public static List<Participe> GetListeDuClassement(int idDeCourse)
        {
            List<Participe> listParticipe = new List<Participe>();
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from participe WHERE classement != 0 AND crs_id =" + idDeCourse;
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
