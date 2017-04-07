using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEV2BO
{
    public class Participe
    {
        // ATTRIBUTS
        private int chvl;
        private int crs;
        private int jck;
        private int classement;
        

        // PROPRIETES
        public int Cheval
        {
            get { return chvl; }
            set { chvl = value; }
        }
        public int Course
        {
            get { return crs; }
            set { crs = value; }
        }
        public int Jockey
        {
            get { return jck; }
            set { jck = value; }
        }

        public int Clas
        {
            get { return classement; }
            set { classement = value; }
        }


        // CONSTRUCTEUR
        public Participe(int idCheval, int idCourse, int idJockey, int unClassement)
        {
            chvl = idCheval;
            crs = idCourse;
            jck = idJockey;
            classement = unClassement;
        }
    }
}
