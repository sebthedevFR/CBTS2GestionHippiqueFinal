using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEV2BO
{
    public class Calendrier
    {
        // ATTRIBUTS
        private DateTime dateCourse;

        // PROPRIETES
        public DateTime DateCourse
        {
            get { return dateCourse; }
            set { dateCourse = value; }
        }
        // CONSTRUCTEUR
        public Calendrier(DateTime uneDate)
        {
            dateCourse = uneDate;
        }
    }
}
