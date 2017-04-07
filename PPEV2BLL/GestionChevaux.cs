using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using PPEV2DAL;

namespace PPEV2BLL
{
    public class GestionChevaux
    {
        private GestionChevaux uneGestionChevaux;

        public GestionChevaux GetGestionChevaux()
        {
            if (uneGestionChevaux == null)
            {
                uneGestionChevaux = new GestionChevaux();
            }
            return uneGestionChevaux;
        }

        public static List<Cheval> GetChevaux()
        {
            return ChevalDAO.GetChevaux();
        }
        public static Cheval GetUnChevaux(int id)
        {
            return ChevalDAO.GetUnCheval(id);
        }
        public static int CreerCheval(string nom, string couleur, int age, string specialite, string nompere, string nommere, string sexe, int unEnt, int unPro)
        {
            Cheval ch = new Cheval(nom, couleur, age, specialite, nompere, nommere, sexe, unEnt, unPro);
            return ChevalDAO.AjoutCheval(ch);
        }
        public static int ModifierCheval(int id,string nom, string couleur, int age, string specialite, string nompere, string nommere, string sexe, int unEnt, int unPro)
        {
            Cheval ch = new Cheval(id, nom, couleur, age, specialite, nompere, nommere, sexe, unEnt, unPro);
            return ChevalDAO.UpdateCheval(ch);
        }
        public static int SupprimerCheval(int id)
        {
            return ChevalDAO.DeleteCheval(id);
        }
        public static List<Cheval> GetChevauxDuneCourse(int id)
        {
            return ChevalDAO.GetLesChevauxDuneCourse(id);
        }
        public static List<Participe> GetCourseDunCheval(int IdDuCheval)
        {
            return ChevalDAO.GetCourseDuCheval(IdDuCheval);
        }

    }
}
