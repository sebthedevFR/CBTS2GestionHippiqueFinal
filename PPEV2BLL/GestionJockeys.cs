using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using PPEV2DAL;

namespace PPEV2BLL
{
    public class GestionJockeys
    {
        private GestionJockeys uneGestionJockey;

        public GestionJockeys GetGestionJockeys()
        {
            if (uneGestionJockey == null)
            {
                uneGestionJockey = new GestionJockeys();
            }
            return uneGestionJockey;
        }

        public static List<Jockey> GetJockeys()
        {
            return JockeyDAO.GetJockeys();
        }
        public static Jockey GetUnJockey(int id)
        {
            return JockeyDAO.GetUnJockey(id);
        }
        public static int CreerJockey(string nom, string prenom, int age, string civilite)
        {
            Jockey jo = new Jockey(nom, prenom, age, civilite);
            return JockeyDAO.AjoutJockey(jo);
        }
        public static int ModifierJockey(string nom, string prenom, int age, string civilite)
        {
            Jockey jo = new Jockey(nom, prenom, age, civilite);
            return JockeyDAO.UpdateJockey(jo);
        }
        public static int SupprimerJockey(int id)
        {
            return JockeyDAO.DeleteJockey(id);
        }
    }
}
