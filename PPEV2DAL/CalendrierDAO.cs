using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using System.Data.SqlClient;

namespace PPEV2DAL
{
    public class CalendrierDAO
    {
        private CalendrierDAO unCalendrierDAO;

        public CalendrierDAO GetUnCalendrierDAO()
        {
            if (unCalendrierDAO == null)
            {
                unCalendrierDAO = new CalendrierDAO();
            }
            return unCalendrierDAO;
        }
        public static List<Calendrier> GetCalendrier()
        {
            List<Calendrier> ListCalendrier = new List<Calendrier>();
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from calendrier";
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            while (MonLecteur.Read())
            {
                // recuperation de valeurs
                DateTime calDate = (DateTime)MonLecteur["date_course"];
                Calendrier unCal = new Calendrier(calDate);
                ListCalendrier.Add(unCal);
            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return ListCalendrier;
        }
        public static int UpdateCalendrier(Calendrier unCalendrier)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "update calendrier set date_course = " + unCalendrier.DateCourse;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
        public static int DeleteCalendrier(DateTime date)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "delete from jockey where date_course = " + date;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
        public static int AjoutCalendrier(Calendrier unCalendrier)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = " insert into calendrier (date_course) VALUES (" + unCalendrier.DateCourse + ")";
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
    }
}
