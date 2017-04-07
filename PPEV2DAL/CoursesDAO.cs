using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using System.Data.SqlClient;

namespace PPEV2DAL
{
    public class CoursesDAO
    {
        private CoursesDAO uneCourseDAO;

        public CoursesDAO GetUneCourseDAO()
        {
            if (uneCourseDAO == null)
            {
                uneCourseDAO = new CoursesDAO();
            }
            return uneCourseDAO;
        }

        public static List<Course> GetCourses()
        {
            List<Course> ListCourse = new List<Course>();
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from course";
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            while (MonLecteur.Read())
            {
                // recuperation de valeurs
                int crsId = (int)MonLecteur["crs_id"];
                string crsNom = (string)MonLecteur["crs_nom"];
                string crsLieu = (string)MonLecteur["crs_lieu"];
                int crsnbrsMax = (int)MonLecteur["crs_nbrmax"];
                int crsPrice = (int)MonLecteur["crs_price"];
                int crsFirst = (int)MonLecteur["crs_first"];
                int crsSecond = (int)MonLecteur["crs_second"];
                int crsThird = (int)MonLecteur["crs_third"];
                int crsFourth = (int)MonLecteur["crs_fourth"];
                int crsFifth = (int)MonLecteur["crs_fifth"];
                int courseHip = (int)MonLecteur["hip_id"];
                int crsAgeMin = (int)MonLecteur["crs_agemin"];
                int crsAgeMax = (int)MonLecteur["crs_agemax"];
                string crsSexe = (string)MonLecteur["crs_sexe"];
                string crsDate = (string)MonLecteur["crs_date"];

                Course uneCourse = new Course(crsId, crsNom, crsLieu, crsnbrsMax, crsPrice, crsFirst, crsSecond, crsThird, crsFourth, crsFifth, courseHip, crsAgeMin, crsAgeMax, crsSexe, crsDate);

                ListCourse.Add(uneCourse);

            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return ListCourse;
        }
        public static int AjoutCourse(Course uneCourse)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            // ok, la ligne suivante en sql fait un peu mal à la tête
            // merci de bien la vérifié au niveau de cheval.ent.id et cheval.pro.Id
            Cmd.CommandText = " insert into course (crs_nom, crs_lieu, crs_nbrmax, crs_price, crs_first, crs_second, crs_third, crs_fourth, crs_fifth, hip_id, crs_agemin, crs_agemax, crs_sexe, crs_date) VALUES ('" + uneCourse.Nom + "','" + uneCourse.Lieu + "'," + uneCourse.NbrMax + "," + uneCourse.Price + "," + uneCourse.First + "," + uneCourse.Second + "," + uneCourse.Third + "," + uneCourse.Fourth + "," + uneCourse.Fifth + "," + uneCourse.Hip + "," + uneCourse.AgeMin + "," + uneCourse.AgeMax + ",'" + uneCourse.Sexe + "','" + uneCourse.Date + "')";
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
        public static int UpdateCourse(Course uneCourse)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "update course set crs_nom = '" + uneCourse.Nom + "', crs_lieu = '" + uneCourse.Lieu + "', crs_nbrmax = " + uneCourse.NbrMax + ", crs_price =" + uneCourse.Price + ", crs_first = " + uneCourse.First + ", crs_second = " + uneCourse.Second + ", crs_third = " + uneCourse.Third + ", crs_fourth = " + uneCourse.Fourth + ", crs_fifth = " + uneCourse.Fifth + ", hip_id = " + uneCourse.Hip + ", crs_agemin = " + uneCourse.AgeMin + ", crs_agemax = " + uneCourse.AgeMax + ", crs_sexe = '" + uneCourse.Sexe + "', crs_date = '" + uneCourse.Date + "' WHERE crs_id = " + uneCourse.Id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
        public static int DeleteCourse(int id)
        {
            int nbEnr;
            // connexion à la BD
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "delete from course where crs_id = " + id;
            nbEnr = Cmd.ExecuteNonQuery();
            ConnexionDb.CloseConnexion();
            return nbEnr;
        }
        public static Course GetUneCourse(int id)
        {
            Course uneAutreCourse = null;

            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from course where crs_id = " + id;
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            // recuperation de valeurs
            if (MonLecteur.Read())
            {
                int crsId = (int)MonLecteur["crs_id"];
                string crsNom = (string)MonLecteur["crs_nom"];
                string crsLieu = (string)MonLecteur["crs_lieu"];
                int crsnbrsMax = (int)MonLecteur["crs_nbrmax"];
                int crsPrice = (int)MonLecteur["crs_price"];
                int crsFirst = (int)MonLecteur["crs_first"];
                int crsSecond = (int)MonLecteur["crs_second"];
                int crsThird = (int)MonLecteur["crs_third"];
                int crsFourth = (int)MonLecteur["crs_fourth"];
                int crsFifth = (int)MonLecteur["crs_fifth"];
                int courseHip = (int)MonLecteur["hip_id"];
                int crsAgeMin = (int)MonLecteur["crs_agemin"];
                int crsAgeMax = (int)MonLecteur["crs_agemax"];
                string crsSexe = (string)MonLecteur["crs_sexe"];
                string crsDate = (string)MonLecteur["crs_date"];


                uneAutreCourse = new Course(crsId, crsNom, crsLieu, crsnbrsMax, crsPrice, crsFirst, crsSecond, crsThird, crsFourth, crsFifth, courseHip, crsAgeMin, crsAgeMax, crsSexe, crsDate);

            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return uneAutreCourse;


        }
        public static List<Course> GetCourseDunHip(int id)
        {
            List<Course> ListCourse = new List<Course>();
            SqlConnection MaConnectionSql = ConnexionDb.GetSqlConnexion();
            SqlCommand Cmd = MaConnectionSql.CreateCommand();
            Cmd.CommandText = "select * from course where hip_id = " + id;
            SqlDataReader MonLecteur = Cmd.ExecuteReader();
            // recuperation de valeurs
            while (MonLecteur.Read())
            {
                // recuperation de valeurs
                int crsId = (int)MonLecteur["crs_id"];
                string crsNom = (string)MonLecteur["crs_nom"];
                string crsLieu = (string)MonLecteur["crs_lieu"];
                int crsnbrsMax = (int)MonLecteur["crs_nbrmax"];
                int crsPrice = (int)MonLecteur["crs_price"];
                int crsFirst = (int)MonLecteur["crs_first"];
                int crsSecond = (int)MonLecteur["crs_second"];
                int crsThird = (int)MonLecteur["crs_third"];
                int crsFourth = (int)MonLecteur["crs_fourth"];
                int crsFifth = (int)MonLecteur["crs_fifth"];
                int courseHip = (int)MonLecteur["hip_id"];
                int crsAgeMin = (int)MonLecteur["crs_agemin"];
                int crsAgeMax = (int)MonLecteur["crs_agemax"];
                string crsSexe = (string)MonLecteur["crs_sexe"];
                string crsDate = (string)MonLecteur["crs_date"];

                Course uneCourse = new Course(crsId, crsNom, crsLieu, crsnbrsMax, crsPrice, crsFirst, crsSecond, crsThird, crsFourth, crsFifth, courseHip, crsAgeMin, crsAgeMax, crsSexe, crsDate);

                ListCourse.Add(uneCourse);

            }
            MonLecteur.Close();
            ConnexionDb.CloseConnexion();
            return ListCourse;
        }
    }
}
