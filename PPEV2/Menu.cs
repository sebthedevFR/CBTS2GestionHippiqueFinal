using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPEV2BLL;

namespace PPEV2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            labeltime.Text = DateTime.Now.ToShortDateString();


            BindingSource bSource = new BindingSource();
            DataTable table = GestionParticipations.GetDerniereCourse(6);
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            // empecher la modification du datagridview
            dataGridView1.ReadOnly = true;



        }

        private void buttonMenu1_Click(object sender, EventArgs e)
        {
            listeChevaux m = new listeChevaux();
            m.Show();
            this.Hide();
        }

        private void buttonMenu2_Click(object sender, EventArgs e)
        {
            listeEntraineurs m = new listeEntraineurs();
            m.Show();
            this.Hide();
        }

        private void buttonMenu3_Click(object sender, EventArgs e)
        {
            listeCourses m = new listeCourses();
            m.Show();
            this.Hide();
        }

        private void buttonMenu4_Click(object sender, EventArgs e)
        {
            gestioncourses m = new gestioncourses();
            m.Show();
            this.Hide();
        }

        private void buttonMenu5_Click(object sender, EventArgs e)
        {
            listeResultats m = new listeResultats();
            m.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonMenuQuit6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
