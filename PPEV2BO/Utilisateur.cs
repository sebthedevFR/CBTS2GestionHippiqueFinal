using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEV2BO
{
    public class Utilisateur
    {
        // ATTRIBUTS
        private int id;
        private string login;
        private string mdp;

        // PROPRIETES
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Mdp
        {
            get { return mdp; }
            set { mdp = value; }
        }

        // CONSTRUCTEUR

        public Utilisateur(int unId,string unLogin, string unMdp)
        {
            id = unId;
            login = unLogin;
            mdp = unMdp;
        }
        public Utilisateur(string unLogin, string unMdp)
        {
            login = unLogin;
            mdp = unMdp;
        }
    }
}
