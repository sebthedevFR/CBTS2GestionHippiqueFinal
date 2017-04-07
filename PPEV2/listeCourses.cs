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
    public partial class listeCourses : Form
    {
        public listeCourses()
        {
            InitializeComponent();
            // Création de la liste course
            List<PPEV2BO.Course> uneListe = new List<PPEV2BO.Course>();
            uneListe = GestionCourses.GetCourses();

            HippodromeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // on définit le dataGridView comme étant une liste
            dataGridView1.DataSource = uneListe;


            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            this.dataGridView1.Columns[7].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;
            this.dataGridView1.Columns[11].Visible = false;
            this.dataGridView1.Columns[12].Visible = false;
            this.dataGridView1.Columns[13].Visible = false;

            List<PPEV2BO.Hippodrome> listeHip = new List<PPEV2BO.Hippodrome>();
            listeHip = GestionHippodrome.GetHippodrome();
            foreach (PPEV2BO.Hippodrome Hip in listeHip)
            {
                HippodromeComboBox.Items.Add(Hip.Nom);
                HippodromeComboBox.MaxDropDownItems = listeHip.Count();
            }
            // empecher la modification du datagridview
            dataGridView1.ReadOnly = true;
        }

        private void listeCourses_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                int idSelected = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string nomSelected = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                string lieuSelected = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                string crsNbrMax = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                string crsPrice = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                string crsFirst = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                string crsSecond = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
                string crsThird = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
                string crsFourth = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
                string crsFifth = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
                int crsHipId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[10].Value);
                string crsAgeMin = Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value);
                string crsAgeMax = Convert.ToString(dataGridView1.CurrentRow.Cells[12].Value);
                string crsSexe = Convert.ToString(dataGridView1.CurrentRow.Cells[13].Value);
                string crsDate = Convert.ToString(dataGridView1.CurrentRow.Cells[14].Value);

                DateTime uneDate = Convert.ToDateTime(crsDate);


                NOMTextBox.Text = nomSelected;
                NbrChevauxMaxListBox.Text = crsNbrMax;
                textBox2.Text = crsFirst;
                textBox3.Text = crsSecond;
                textBox4.Text = crsThird;
                textBox5.Text = crsFourth;
                textBox6.Text = crsFifth;
                AGEMINTextBox.Text = crsAgeMin;
                AGEMAXtextboc.Text = crsAgeMax;
                AllocationLabel.Text = crsPrice;
                monthCalendar1.SetDate(uneDate);


                if (crsSexe == "M")
                {
                    HOMMEradio.Checked = true;
                    FEMMERadio.Checked = false;
                    radioButton1.Checked = false;
                }
                else if (crsSexe == "F")
                {
                    HOMMEradio.Checked = false;
                    FEMMERadio.Checked = true;
                    radioButton1.Checked = false;
                }
                else
                {
                    HOMMEradio.Checked = false;
                    FEMMERadio.Checked = false;
                    radioButton1.Checked = true;
                }

                PPEV2BO.Hippodrome unHip = new PPEV2BO.Hippodrome();
                unHip = GestionHippodrome.GetUnHippodrome(crsHipId);
                HippodromeComboBox.Text = unHip.Nom;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir modifier la course selectionné ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idSelected = 0;
                idSelected = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                string sexe = "X";

                if (HOMMEradio.Checked == true)
                {
                    sexe = "M";
                }
                else if (FEMMERadio.Checked == true)
                {
                    sexe = "F";
                }
                else if (radioButton1.Checked == true)
                {
                    sexe = "X";
                }

                int NbrChevauxMax = 0;
                Int32.TryParse(NbrChevauxMaxListBox.Text, out NbrChevauxMax);
                int AllocationComp = 0;
                Int32.TryParse(AllocationLabel.Text, out AllocationComp);
                int CrsFirst = 0;
                Int32.TryParse(textBox2.Text, out CrsFirst);
                int CrsSecond = 0;
                Int32.TryParse(textBox3.Text, out CrsSecond);
                int CrsThird = 0;
                Int32.TryParse(textBox4.Text, out CrsThird);
                int CrsFourth = 0;
                Int32.TryParse(textBox5.Text, out CrsFourth);
                int CrsFifth = 0;
                Int32.TryParse(textBox6.Text, out CrsFifth);
                int AgeMin = 0;
                Int32.TryParse(AGEMINTextBox.Text, out AgeMin);
                int AgeMax = 0;
                Int32.TryParse(AGEMAXtextboc.Text, out AgeMax);
                string uneDate = monthCalendar1.SelectionRange.Start.ToShortDateString();

                int totalPrix = 0;
                totalPrix = CrsFirst + CrsSecond + CrsThird + CrsFourth + CrsFifth;


                // CHOPER ID DE HIPPODROME DEPUIS COURSE 
                int hip = 0;
                string hipSelect = HippodromeComboBox.Text;
                List<PPEV2BO.Hippodrome> listeHippodrome = new List<PPEV2BO.Hippodrome>();
                listeHippodrome = GestionHippodrome.GetHippodrome();
                foreach (PPEV2BO.Hippodrome Hip in listeHippodrome)
                {
                    if (Hip.Nom == hipSelect)
                    {
                        hip = Hip.Id;
                    }
                }


                GestionCourses.ModifierCourse(idSelected, NOMTextBox.Text, HippodromeComboBox.Text, NbrChevauxMax, totalPrix, CrsFirst, CrsSecond, CrsThird, CrsFourth, CrsFifth, hip, AgeMin, AgeMax, sexe, uneDate);
                MessageBox.Show("La Course " + NOMTextBox.Text + "  a bien été modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Update();
                dataGridView1.Refresh();
                // Création de la liste course
                List<PPEV2BO.Course> uneListe = new List<PPEV2BO.Course>();
                uneListe = GestionCourses.GetCourses();
                // on définit le dataGridView comme étant une liste
                dataGridView1.DataSource = uneListe;
                AllocationLabel.Text = Convert.ToString(totalPrix);
                this.dataGridView1.Columns[0].Visible = false;
                this.dataGridView1.Columns[3].Visible = false;
                this.dataGridView1.Columns[4].Visible = false;
                this.dataGridView1.Columns[5].Visible = false;
                this.dataGridView1.Columns[6].Visible = false;
                this.dataGridView1.Columns[7].Visible = false;
                this.dataGridView1.Columns[8].Visible = false;
                this.dataGridView1.Columns[9].Visible = false;
                this.dataGridView1.Columns[10].Visible = false;
                this.dataGridView1.Columns[11].Visible = false;
                this.dataGridView1.Columns[12].Visible = false;
                this.dataGridView1.Columns[13].Visible = false;
            }
        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("êtes vous sur de vouloir ajouter la course selectionné ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idSelected = 0;
                idSelected = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                string sexe = "X";

                if (HOMMEradio.Checked == true)
                {
                    sexe = "M";
                }
                else if (FEMMERadio.Checked == true)
                {
                    sexe = "F";
                }
                else if (radioButton1.Checked == true)
                {
                    sexe = "X";
                }

                int NbrChevauxMax = 0;
                Int32.TryParse(NbrChevauxMaxListBox.Text, out NbrChevauxMax);
                int AllocationComp = 0;
                Int32.TryParse(AllocationLabel.Text, out AllocationComp);
                int CrsFirst = 0;
                Int32.TryParse(textBox2.Text, out CrsFirst);
                int CrsSecond = 0;
                Int32.TryParse(textBox3.Text, out CrsSecond);
                int CrsThird = 0;
                Int32.TryParse(textBox4.Text, out CrsThird);
                int CrsFourth = 0;
                Int32.TryParse(textBox5.Text, out CrsFourth);
                int CrsFifth = 0;
                Int32.TryParse(textBox6.Text, out CrsFifth);
                int AgeMin = 0;
                Int32.TryParse(AGEMINTextBox.Text, out AgeMin);
                int AgeMax = 0;
                Int32.TryParse(AGEMAXtextboc.Text, out AgeMax);
                string uneDate = monthCalendar1.SelectionRange.Start.ToShortDateString();

                int totalPrix = 0;
                totalPrix = CrsFirst + CrsSecond + CrsThird + CrsFourth + CrsFifth;


                // CHOPER ID DE HIPPODROME DEPUIS COURSE 
                int hip = 0;
                string hipSelect = HippodromeComboBox.Text;
                List<PPEV2BO.Hippodrome> listeHippodrome = new List<PPEV2BO.Hippodrome>();
                listeHippodrome = GestionHippodrome.GetHippodrome();
                foreach (PPEV2BO.Hippodrome Hip in listeHippodrome)
                {
                    if (Hip.Nom == hipSelect)
                    {
                        hip = Hip.Id;
                    }
                }


                GestionCourses.CreerCourse(NOMTextBox.Text, HippodromeComboBox.Text, NbrChevauxMax, totalPrix, CrsFirst, CrsSecond, CrsThird, CrsFourth, CrsFifth, hip, AgeMin, AgeMax, sexe, uneDate);
                MessageBox.Show("La Course" + NOMTextBox.Text + " a bien été crée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Update();
                dataGridView1.Refresh();
                // Création de la liste course
                List<PPEV2BO.Course> uneListe = new List<PPEV2BO.Course>();
                uneListe = GestionCourses.GetCourses();
                // on définit le dataGridView comme étant une liste
                dataGridView1.DataSource = uneListe;
                AllocationLabel.Text = Convert.ToString(totalPrix);
                this.dataGridView1.Columns[0].Visible = false;
                this.dataGridView1.Columns[3].Visible = false;
                this.dataGridView1.Columns[4].Visible = false;
                this.dataGridView1.Columns[5].Visible = false;
                this.dataGridView1.Columns[6].Visible = false;
                this.dataGridView1.Columns[7].Visible = false;
                this.dataGridView1.Columns[8].Visible = false;
                this.dataGridView1.Columns[9].Visible = false;
                this.dataGridView1.Columns[10].Visible = false;
                this.dataGridView1.Columns[11].Visible = false;
                this.dataGridView1.Columns[12].Visible = false;
                this.dataGridView1.Columns[13].Visible = false;
            }
        }

        private void btnsuppr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("êtes vous sur de vouloir supprimer la course selectionné ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idSelected = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                GestionCourses.SupprimerCourse(idSelected);
                MessageBox.Show(NOMTextBox.Text + " a bien été supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Update();
                dataGridView1.Refresh();
                // Création de la liste course
                List<PPEV2BO.Course> uneListe = new List<PPEV2BO.Course>();
                uneListe = GestionCourses.GetCourses();
                // on définit le dataGridView comme étant une liste
                dataGridView1.DataSource = uneListe;
                this.dataGridView1.Columns[0].Visible = false;
                this.dataGridView1.Columns[3].Visible = false;
                this.dataGridView1.Columns[4].Visible = false;
                this.dataGridView1.Columns[5].Visible = false;
                this.dataGridView1.Columns[6].Visible = false;
                this.dataGridView1.Columns[7].Visible = false;
                this.dataGridView1.Columns[8].Visible = false;
                this.dataGridView1.Columns[9].Visible = false;
                this.dataGridView1.Columns[10].Visible = false;
                this.dataGridView1.Columns[11].Visible = false;
                this.dataGridView1.Columns[12].Visible = false;
                this.dataGridView1.Columns[13].Visible = false;
            }
        }

        private void NOMTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AGEMINTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void AGEMAXtextboc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void NbrChevauxMaxListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            NOMTextBox.Text = "";
            AGEMINTextBox.Text = "";
            AGEMAXtextboc.Text = "";
            NbrChevauxMaxListBox.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
