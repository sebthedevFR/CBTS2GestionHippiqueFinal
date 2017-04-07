using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using PPEV2BLL;
using PPEV2BO;
using MySql.Data.MySqlClient;

namespace PPEV2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // Initialisation du password char
            PasswordBox.UseSystemPasswordChar = true;
            // GestionUtilisateurs.ConnectionON();
            // ConnexionDb uneCo = new ConnexionDb();
            // uneCo.InitializeConnection();
            // uneCo.OpenConnection();
            // uneCo.CloseConnection();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            bool found = false;

            foreach (Utilisateur lesUtils in GestionUtilisateurs.GetUtilisateurs())
            {
                if (UsernameBox.Text == lesUtils.Login && PasswordBox.Text == lesUtils.Mdp)
                {
                    Menu m = new Menu();
                    m.Show();
                    this.Hide();
                    MessageBox.Show("Bienvenue " + lesUtils.Login, "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                MessageBox.Show("Erreur ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordBox_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
