using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using PPEV2DAL;

namespace PPEV2BLL
{
    class GestionCalendriers
    {
        private GestionCalendriers UneGestionCalendriers;

        public GestionCalendriers GetGestionCalendriers()
        {
            if (UneGestionCalendriers == null)
            {
                UneGestionCalendriers = new GestionCalendriers();
            }
            return UneGestionCalendriers;
        }
        public static List<Calendrier> GetCalendriers()
        {
            return CalendrierDAO.GetCalendrier();
        }
        public static int CreerCalendrier(DateTime date)
        {
            Calendrier cal = new Calendrier(date);
            return CalendrierDAO.AjoutCalendrier(cal);
        }
        public static int ModifierCalendrier(DateTime date)
        {
            Calendrier cal = new Calendrier(date);
            return CalendrierDAO.UpdateCalendrier(cal);
        }
        public static int SupprimerCalendrier(DateTime date)
        {
            return CalendrierDAO.DeleteCalendrier(date);
        }
    }
}
