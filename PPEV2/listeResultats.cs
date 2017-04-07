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
    public partial class listeResultats : Form
    {
        public listeResultats()
        {
            InitializeComponent();
            List<PPEV2BO.Hippodrome> listeHippodrome = new List<PPEV2BO.Hippodrome>();
            listeHippodrome = GestionHippodrome.GetHippodrome();
            comboBoxHipp.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxch1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxch2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxch3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxch4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxch5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCou.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (PPEV2BO.Hippodrome Hip in listeHippodrome)
            {
                comboBoxHipp.Items.Add(Hip.Nom);
                comboBoxHipp.MaxDropDownItems = listeHippodrome.Count();
                
            }
            // empecher la modification du datagridview
            dataGridViewResultat.ReadOnly = true;
        }

        private void comboBoxHipp_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCou.Items.Clear();
            int hip = 0;
            string hipSelect = comboBoxHipp.Text;
            List<PPEV2BO.Hippodrome> listeHippodrome = new List<PPEV2BO.Hippodrome>();
            listeHippodrome = GestionHippodrome.GetHippodrome();
            foreach (PPEV2BO.Hippodrome Hip in listeHippodrome)
            {
                if (Hip.Nom == hipSelect)
                {
                    hip = Hip.Id;
                }
            }

            List<PPEV2BO.Course> listeCou = new List<PPEV2BO.Course>();
            listeCou = GestionCourses.GetCourseDunHip(hip);
            foreach (PPEV2BO.Course Cou in listeCou)
            {
                comboBoxCou.Items.Add(Cou.Nom);
                comboBoxCou.MaxDropDownItems = listeCou.Count();
            }
        }

        private void comboBoxCou_SelectedIndexChanged(object sender, EventArgs e)
        {
            int crs = 0;
            string crsSelect = comboBoxCou.Text;
            List<PPEV2BO.Course> listeCourse = new List<PPEV2BO.Course>();
            listeCourse = GestionCourses.GetCourses();
            foreach (PPEV2BO.Course Cou in listeCourse)
            {
                if (Cou.Nom == crsSelect)
                {
                    crs = Cou.Id;
                }
            }
            List<PPEV2BO.Cheval> uneListe = new List<PPEV2BO.Cheval>();
            uneListe = GestionChevaux.GetChevauxDuneCourse(crs);
            dataGridViewResultat.DataSource = uneListe;
            comboBoxch1.Items.Clear();
            comboBoxch2.Items.Clear();
            comboBoxch3.Items.Clear();
            comboBoxch4.Items.Clear();
            comboBoxch5.Items.Clear();
            foreach (PPEV2BO.Cheval Ch in uneListe)
            {
                comboBoxch1.Items.Add(Ch.Nom);
                comboBoxch1.MaxDropDownItems = uneListe.Count();
                comboBoxch2.Items.Add(Ch.Nom);
                comboBoxch2.MaxDropDownItems = uneListe.Count();
                comboBoxch3.Items.Add(Ch.Nom);
                comboBoxch3.MaxDropDownItems = uneListe.Count();
                comboBoxch4.Items.Add(Ch.Nom);
                comboBoxch4.MaxDropDownItems = uneListe.Count();
                comboBoxch5.Items.Add(Ch.Nom);
                comboBoxch5.MaxDropDownItems = uneListe.Count();
            }


            this.dataGridViewResultat.Columns[0].Visible = false;
            this.dataGridViewResultat.Columns[8].Visible = false;
            this.dataGridViewResultat.Columns[9].Visible = false;

            List<PPEV2BO.Participe> uneListeParticipation = new List<PPEV2BO.Participe>();
            uneListeParticipation = GestionParticipations.GetListeDuClassement(crs);

            foreach (PPEV2BO.Participe Participant in uneListeParticipation)
            {
                if (Participant.Clas == 1)
                {
                    comboBoxch1.SelectedIndex = comboBoxch1.FindStringExact(GestionChevaux.GetUnChevaux(Participant.Cheval).Nom);
                }
                else if (Participant.Clas == 2)
                {
                    comboBoxch2.SelectedIndex = comboBoxch2.FindStringExact(GestionChevaux.GetUnChevaux(Participant.Cheval).Nom);
                }
                else if (Participant.Clas == 3)
                {
                    comboBoxch3.SelectedIndex = comboBoxch3.FindStringExact(GestionChevaux.GetUnChevaux(Participant.Cheval).Nom);
                }
                else if (Participant.Clas == 4)
                {
                    comboBoxch4.SelectedIndex = comboBoxch4.FindStringExact(GestionChevaux.GetUnChevaux(Participant.Cheval).Nom);
                }
                else if (Participant.Clas == 5)
                {
                    comboBoxch5.SelectedIndex = comboBoxch5.FindStringExact(GestionChevaux.GetUnChevaux(Participant.Cheval).Nom);
                }
            }


        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("êtes vous sur de vouloir ajouter le cheval selectionné ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // RECUPERATION DE LID DE LA COURSE
                int crs = 0;
                string crsSelect = comboBoxCou.Text;
                List<PPEV2BO.Course> listeCourse = new List<PPEV2BO.Course>();
                listeCourse = GestionCourses.GetCourses();
                foreach (PPEV2BO.Course Cou in listeCourse)
                {
                    if (Cou.Nom == crsSelect)
                    {
                        crs = Cou.Id;
                    }
                }

                // RECUPERATION DE L'ID DES CHEVAUX
                int chv1 = 0;
                int chv2 = 0;
                int chv3 = 0;
                int chv4 = 0;
                int chv5 = 0;
                string chvSelect1 = comboBoxch1.Text;
                string chvSelect2 = comboBoxch2.Text;
                string chvSelect3 = comboBoxch3.Text;
                string chvSelect4 = comboBoxch4.Text;
                string chvSelect5 = comboBoxch5.Text;
                List<PPEV2BO.Cheval> listeChevaux = new List<PPEV2BO.Cheval>();
                listeChevaux = GestionChevaux.GetChevaux();
                foreach (PPEV2BO.Cheval Chv in listeChevaux)
                {
                    if (Chv.Nom == chvSelect1)
                    {
                        chv1 = Chv.Id;
                    }
                    else if (Chv.Nom == chvSelect2)
                    {
                        chv2 = Chv.Id;
                    }
                    else if (Chv.Nom == chvSelect3)
                    {
                        chv3 = Chv.Id;
                    }
                    else if (Chv.Nom == chvSelect4)
                    {
                        chv4 = Chv.Id;
                    }
                    else if (Chv.Nom == chvSelect5)
                    {
                        chv5 = Chv.Id;
                    }
                    
                }
                GestionParticipations.AssignerClassementCheval(chv1, crs, 1);
                GestionParticipations.AssignerClassementCheval(chv2, crs, 2);
                GestionParticipations.AssignerClassementCheval(chv3, crs, 3);
                GestionParticipations.AssignerClassementCheval(chv4, crs, 4);
                GestionParticipations.AssignerClassementCheval(chv5, crs, 5);

                MessageBox.Show("Le classement a bien été appliqué", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            


        }
    }
}
