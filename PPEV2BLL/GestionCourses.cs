using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPEV2BO;
using PPEV2DAL;

namespace PPEV2BLL
{
    public class GestionCourses
    {
        private GestionCourses uneGestionCourses;

        public GestionCourses GetGestionCourses()
        {
            if (uneGestionCourses == null)
            {
                uneGestionCourses = new GestionCourses();
            }
            return uneGestionCourses;
        }
        public static List<Course> GetCourses()
        {
            return CoursesDAO.GetCourses();
        }
        public static Course GetUneCourse(int id)
        {
            return CoursesDAO.GetUneCourse(id);
        }
        public static List<Course> GetCourseDunHip(int id)
        {
            return CoursesDAO.GetCourseDunHip(id);
        }
        public static int CreerCourse(string nom, string lieu, int nbrMax, int unPrice, int unFirst, int unSecond, int unThird, int unFourth, int unFifth, int unHip, int ageMin, int ageMax, string sexe, string uneDate)
        {
            Course crs = new Course(nom, lieu, nbrMax, unPrice, unFirst, unSecond, unThird, unFourth, unFifth, unHip, ageMin, ageMax, sexe, uneDate);
            return CoursesDAO.AjoutCourse(crs);
        }
        public static int ModifierCourse(int id, string nom, string lieu, int nbrMax, int unPrice, int unFirst, int unSecond, int unThird, int unFourth, int unFifth, int unHip, int ageMin, int ageMax, string sexe, string uneDate)
        {
            Course crs = new Course(id, nom, lieu, nbrMax, unPrice, unFirst, unSecond, unThird, unFourth, unFifth, unHip, ageMin, ageMax, sexe, uneDate);
            return CoursesDAO.UpdateCourse(crs);
        }
        public static int SupprimerCourse(int id)
        {
            return CoursesDAO.DeleteCourse(id);
        }
    }
}
