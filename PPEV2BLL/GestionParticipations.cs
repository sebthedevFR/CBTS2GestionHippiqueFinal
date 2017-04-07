using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using PPEV2DAL;
using System.Data;

namespace PPEV2BLL
{
    public class GestionParticipations
    {
        private GestionParticipations UneGestionParticipations;

        public GestionParticipations GetGestionParticipations()
        {
            if (UneGestionParticipations == null)
            {
                UneGestionParticipations = new GestionParticipations();
            }
            return UneGestionParticipations;
        }
        public static List<Participe> GetParticipations()
        {
            return ParticipeDAO.GetParticipation();
        }
        public static int CreerParticipation(int unChe, int uneCo, int unJo, int unClassement)
        {
            Participe par = new Participe(unChe, uneCo, unJo, unClassement);
            return ParticipeDAO.AjoutParticipation(par);
        }
        public static int ModifierParticipation(int unChe, int uneCo, int unJo, int unClassement)
        {
            Participe par = new Participe(unChe, uneCo, unJo, unClassement);
            return ParticipeDAO.UpdateParticipation(par);
        }
        public static int ModifierParticipation(int id)
        {
            return ParticipeDAO.DeleteParticipation(id);
        }
        public static int AssignerClassementCheval(int unCh,int uneCrs, int unClassement)
        {
            return ParticipeDAO.AssignerClassementCheval(unCh, uneCrs, unClassement);
        }
        public static DataTable GetDerniereCourse(int idCourse)
        {
            return ParticipeDAO.GetResultatDerniereCourse(idCourse);
        }
        public static List<Participe> GetListeDuClassement(int idCourse)
        {
            return ParticipeDAO.GetListeDuClassement(idCourse);
        }
    }
}
