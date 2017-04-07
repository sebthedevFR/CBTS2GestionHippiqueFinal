using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
// using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace PPEV2DAL
{
    public class ConnexionDb
    {
        // ATTRIBUTS
        //private MySqlConnection con;
        private static SqlConnection con;
        private static ConnexionDb uneConnexionBD;
        //private MySqlCommand cmd;
        //private MySqlDataReader monLecteur;
        private string chaineConnection;

        // accesseur en lecture de la chaine de connexion
        public string GetChaineConnexion()
        {
            return chaineConnection;
        }
        // Accesseur en écriture de la chaîne de connexion
        public void SetchaineConnexion(string ch)
        {
            chaineConnection = ch;
        }
        // Accesseur en lecture, renvoi une instance de connexion
        //public MySqlConnection GetConnexionBD()
        //{
        //    if (con == null)
        //    {
        //        con = new MySqlConnection();
        //    }
        //    return con;
        //}
        // Constructeur privé
        private ConnexionDb()
        {

        }

        public static SqlConnection GetSqlConnexion()
        {

            if (con == null)
            {

                con = new SqlConnection();
                con.ConnectionString = "Data Source=mssql5.gear.host;Initial Catalog=gestionHippique;Persist Security Info=True; User ID=gestionhippique;Password=Xv8Ko_ce8!Eu";

            }
            // Si la connexion est fermée, on l’ouvre

            if (con.State == System.Data.ConnectionState.Closed)
            {

                con.Open();

            }

            return con;

        }
        public static void  CloseConnexion()
        {

            // Si la connexion est ouverte, on la ferme
            if (con != null && con.State != System.Data.ConnectionState.Closed)
            {
                con.Close();
            }

        }

        //public MySqlConnection Con
        //{
        //    get { return con; }
        //    set { con = value; }
        //}
        //public MySqlCommand Cmd
        //{
        //    get { return cmd; }
        //    set { cmd = value; }
        //}
        //public MySqlDataReader MonLecteur
        //{
        //    get { return monLecteur; }
        //    set { monLecteur = value; }
        //}
        //public string ChaineConnection
        //{
        //    get { return chaineConnection; }
        //    set { chaineConnection = value; }
        //}


        //// CONSTRUCTEUR
        //public ConnexionDb()
        //{
        //}
        // METHODES
        //public void InitializeConnection()
        //{
        //    con = new MySqlConnection("server = localhost; user id = root; persistsecurityinfo = True; database = testppe;");
        //    cmd = new MySqlCommand("", con);
        //}

    }
}
