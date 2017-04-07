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
    public partial class listeEntraineurs : Form
    {
        public listeEntraineurs()
        {
            InitializeComponent();
            // Création de la liste entraineur
            List<PPEV2BO.Entraineur> uneListe = new List<PPEV2BO.Entraineur>();
            uneListe = GestionEntraineurs.GetEntraineurs();

            // on définit le dataGridView comme étant une liste
            dataGridView1.DataSource = uneListe;


            this.dataGridView1.Columns[0].Visible = false;
            radioButton1.Checked = true;

            // empecher la modification du datagridview
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                // a = Convert.ToString(selectedRow.Cells["nom"].Value);
                int idSelected = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string nomSelected = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                string prenomSelected = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                string ageSelected = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                string civiliteSelected = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                string localisationSelected = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);



                textBox1.Text = nomSelected;
                textBox2.Text = prenomSelected;
                textBox3.Text = ageSelected;
                textBox4.Text = localisationSelected;

               
                if (civiliteSelected == "H" || civiliteSelected == "M")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else if (civiliteSelected == "F")
                {
                    radioButton2.Checked = true;
                    radioButton1.Checked = false;
                }

                List<PPEV2BO.Cheval> ListeChevaux = new List<PPEV2BO.Cheval>();
                ListeChevaux = GestionEntraineurs.GetChevauxEntraineurs(idSelected);
                dataGridView2.DataSource = ListeChevaux;
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[8].Visible = false;
                dataGridView2.Columns[9].Visible = false;
            }
        }

        private void ModButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir modifier l'entraineur selectionné ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idSelected = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int age = 0;
                Int32.TryParse(textBox3.Text, out age);
                string sexe = "X";

                if (radioButton1.Checked == true)
                {
                    sexe = "H";
                }
                else if (radioButton2.Checked == true)
                {
                    sexe = "F";
                }

                GestionEntraineurs.ModifierEntraineur(idSelected,textBox1.Text, textBox2.Text, age, sexe, textBox4.Text);
                MessageBox.Show(textBox1.Text + " a bien été modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Update();
                dataGridView1.Refresh();
                // Création de la liste entraineur
                List<PPEV2BO.Entraineur> uneListe = new List<PPEV2BO.Entraineur>();
                uneListe = GestionEntraineurs.GetEntraineurs();
                // on définit le dataGridView comme étant une liste
                dataGridView1.DataSource = uneListe;
                this.dataGridView1.Columns[0].Visible = false;
            }
        }

        private void Ajtbutton_Click(object sender, EventArgs e)
        {
            // A REFAIRE
            if (MessageBox.Show("Etes vous sur de vouloir ajouter l'entraineur selectionné ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Merci de remplir un nom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Merci de remplir un prenom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Merci de remplir un age.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("Merci de remplir une localisation.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                int age = 0;
                Int32.TryParse(textBox3.Text, out age);
                string sexe = "X";

                if (radioButton1.Checked == true)
                {
                    sexe = "M";
                }
                else if (radioButton2.Checked == true)
                {
                    sexe = "F";
                }

                GestionEntraineurs.CreerEntraineur(textBox1.Text, textBox2.Text, age, sexe, textBox4.Text);
                MessageBox.Show(textBox1.Text + " a bien été crée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Update();
                dataGridView1.Refresh();
                dataGridView1.DataSource = null;
                // Création de la liste entraineur
                List<PPEV2BO.Entraineur> uneListe = new List<PPEV2BO.Entraineur>();
                uneListe = GestionEntraineurs.GetEntraineurs();
                // on définit le dataGridView comme étant une liste
                dataGridView1.DataSource = uneListe;
                this.dataGridView1.Columns[0].Visible = false;
            }
        }

        private void SuppButton_Click(object sender, EventArgs e)
        {




            if (MessageBox.Show("êtes vous sur de vouloir supprimer l'entraineur selectionné ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idSelected = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string nomSelected = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                string prenomSelected = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);

                List<PPEV2BO.Cheval> ListeChevaux = new List<PPEV2BO.Cheval>();
                ListeChevaux = GestionEntraineurs.GetChevauxEntraineurs(idSelected);


                if (ListeChevaux.Count >= 1)
                {
                    MessageBox.Show(nomSelected + " " + prenomSelected + " entraine actuellement des chevaux, merci de réassigner les chevaux entrainer par " + prenomSelected + " et de réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GestionEntraineurs.SupprimerEntraineur(idSelected);
                MessageBox.Show(textBox1.Text + " a bien été supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Update();
                dataGridView1.Refresh();
                // Création de la liste entraineur
                List<PPEV2BO.Entraineur> uneListe = new List<PPEV2BO.Entraineur>();
                uneListe = GestionEntraineurs.GetEntraineurs();
                // on définit le dataGridView comme étant une liste
                dataGridView1.DataSource = uneListe;
                this.dataGridView1.Columns[0].Visible = false;
            }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
            int idSelected = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            string nomSelected = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value);
            string couleurSelected = Convert.ToString(dataGridView2.CurrentRow.Cells[2].Value);
            string ageSelected = Convert.ToString(dataGridView2.CurrentRow.Cells[3].Value);
            string speSelected = Convert.ToString(dataGridView2.CurrentRow.Cells[4].Value);
            string nomPereSelected = Convert.ToString(dataGridView2.CurrentRow.Cells[5].Value);
            string nomMereSelected = Convert.ToString(dataGridView2.CurrentRow.Cells[6].Value);
            string sexeSelected = Convert.ToString(dataGridView2.CurrentRow.Cells[7].Value);
            int idEntSelected = Convert.ToInt32(dataGridView2.CurrentRow.Cells[8].Value);
            int idProSelected = Convert.ToInt32(dataGridView2.CurrentRow.Cells[9].Value);

            string sexe = "X";

            if (sexeSelected == "H")
            {
                sexe = "Homme";
            }
            else if (sexeSelected == "F")
            {
                sexe = "Femme";
            }

            MessageBox.Show(nomSelected + " " + couleurSelected + " " + ageSelected + " " + speSelected + " " + nomPereSelected + " " + nomMereSelected + " " + sexe, "Recapitulatif", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
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
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
