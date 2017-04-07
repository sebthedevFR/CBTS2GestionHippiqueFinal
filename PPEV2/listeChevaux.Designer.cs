namespace PPEV2
{
    partial class listeChevaux
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listeChevaux));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FEMMERadio = new System.Windows.Forms.RadioButton();
            this.HOMMEradio = new System.Windows.Forms.RadioButton();
            this.NOMMereTextBox = new System.Windows.Forms.TextBox();
            this.NOMPereTextBox = new System.Windows.Forms.TextBox();
            this.AGETextBox = new System.Windows.Forms.TextBox();
            this.NOMTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnsuppr = new System.Windows.Forms.Button();
            this.btnajout = new System.Windows.Forms.Button();
            this.CouleurTextBox = new System.Windows.Forms.TextBox();
            this.SpeListBox = new System.Windows.Forms.TextBox();
            this.NomEntComboBox = new System.Windows.Forms.ComboBox();
            this.NomProComboBox = new System.Windows.Forms.ComboBox();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(597, 334);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, -17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // FEMMERadio
            // 
            this.FEMMERadio.AutoSize = true;
            this.FEMMERadio.Location = new System.Drawing.Point(840, 215);
            this.FEMMERadio.Name = "FEMMERadio";
            this.FEMMERadio.Size = new System.Drawing.Size(61, 17);
            this.FEMMERadio.TabIndex = 38;
            this.FEMMERadio.TabStop = true;
            this.FEMMERadio.Text = "Feminin";
            this.FEMMERadio.UseVisualStyleBackColor = true;
            // 
            // HOMMEradio
            // 
            this.HOMMEradio.AutoSize = true;
            this.HOMMEradio.Location = new System.Drawing.Point(756, 217);
            this.HOMMEradio.Name = "HOMMEradio";
            this.HOMMEradio.Size = new System.Drawing.Size(67, 17);
            this.HOMMEradio.TabIndex = 37;
            this.HOMMEradio.TabStop = true;
            this.HOMMEradio.Text = "Masculin";
            this.HOMMEradio.UseVisualStyleBackColor = true;
            // 
            // NOMMereTextBox
            // 
            this.NOMMereTextBox.Location = new System.Drawing.Point(799, 181);
            this.NOMMereTextBox.Name = "NOMMereTextBox";
            this.NOMMereTextBox.Size = new System.Drawing.Size(100, 20);
            this.NOMMereTextBox.TabIndex = 36;
            this.NOMMereTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NOMMereTextBox_KeyPress);
            // 
            // NOMPereTextBox
            // 
            this.NOMPereTextBox.Location = new System.Drawing.Point(799, 152);
            this.NOMPereTextBox.Name = "NOMPereTextBox";
            this.NOMPereTextBox.Size = new System.Drawing.Size(100, 20);
            this.NOMPereTextBox.TabIndex = 35;
            this.NOMPereTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NOMPereTextBox_KeyPress);
            // 
            // AGETextBox
            // 
            this.AGETextBox.Location = new System.Drawing.Point(840, 93);
            this.AGETextBox.Name = "AGETextBox";
            this.AGETextBox.Size = new System.Drawing.Size(59, 20);
            this.AGETextBox.TabIndex = 34;
            this.AGETextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AGETextBox_KeyPress);
            // 
            // NOMTextBox
            // 
            this.NOMTextBox.Location = new System.Drawing.Point(799, 29);
            this.NOMTextBox.Name = "NOMTextBox";
            this.NOMTextBox.Size = new System.Drawing.Size(100, 20);
            this.NOMTextBox.TabIndex = 33;
            this.NOMTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NOMTextBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(660, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nom proprietaire";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(660, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Nom de l\'entraineur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Sexe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nom de la mere du cheval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nom du pere du cheval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Specialité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Couleur";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(657, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Nom";
            // 
            // btnsuppr
            // 
            this.btnsuppr.Location = new System.Drawing.Point(837, 316);
            this.btnsuppr.Name = "btnsuppr";
            this.btnsuppr.Size = new System.Drawing.Size(75, 32);
            this.btnsuppr.TabIndex = 43;
            this.btnsuppr.Text = "Supprimer";
            this.btnsuppr.UseVisualStyleBackColor = true;
            this.btnsuppr.Click += new System.EventHandler(this.btnsuppr_Click);
            // 
            // btnajout
            // 
            this.btnajout.Location = new System.Drawing.Point(675, 316);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(75, 32);
            this.btnajout.TabIndex = 44;
            this.btnajout.Text = "Ajouter";
            this.btnajout.UseVisualStyleBackColor = true;
            this.btnajout.Click += new System.EventHandler(this.btnajout_Click);
            // 
            // CouleurTextBox
            // 
            this.CouleurTextBox.Location = new System.Drawing.Point(799, 60);
            this.CouleurTextBox.Name = "CouleurTextBox";
            this.CouleurTextBox.Size = new System.Drawing.Size(100, 20);
            this.CouleurTextBox.TabIndex = 45;
            this.CouleurTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CouleurTextBox_KeyPress);
            // 
            // SpeListBox
            // 
            this.SpeListBox.Location = new System.Drawing.Point(799, 123);
            this.SpeListBox.Name = "SpeListBox";
            this.SpeListBox.Size = new System.Drawing.Size(100, 20);
            this.SpeListBox.TabIndex = 46;
            this.SpeListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpeListBox_KeyPress);
            // 
            // NomEntComboBox
            // 
            this.NomEntComboBox.FormattingEnabled = true;
            this.NomEntComboBox.Location = new System.Drawing.Point(779, 247);
            this.NomEntComboBox.Name = "NomEntComboBox";
            this.NomEntComboBox.Size = new System.Drawing.Size(121, 21);
            this.NomEntComboBox.TabIndex = 47;
            this.NomEntComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NomEntComboBox_KeyPress);
            // 
            // NomProComboBox
            // 
            this.NomProComboBox.FormattingEnabled = true;
            this.NomProComboBox.Location = new System.Drawing.Point(778, 280);
            this.NomProComboBox.Name = "NomProComboBox";
            this.NomProComboBox.Size = new System.Drawing.Size(121, 21);
            this.NomProComboBox.TabIndex = 48;
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(837, 354);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(75, 23);
            this.btn_quitter.TabIndex = 70;
            this.btn_quitter.Text = "Retour";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(756, 354);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 71;
            this.reset.Text = "Réinitialiser";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // listeChevaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 387);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.NomProComboBox);
            this.Controls.Add(this.NomEntComboBox);
            this.Controls.Add(this.SpeListBox);
            this.Controls.Add(this.CouleurTextBox);
            this.Controls.Add(this.btnajout);
            this.Controls.Add(this.btnsuppr);
            this.Controls.Add(this.FEMMERadio);
            this.Controls.Add(this.HOMMEradio);
            this.Controls.Add(this.NOMMereTextBox);
            this.Controls.Add(this.NOMPereTextBox);
            this.Controls.Add(this.AGETextBox);
            this.Controls.Add(this.NOMTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "listeChevaux";
            this.Text = "Gestion des Chevaux";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton FEMMERadio;
        private System.Windows.Forms.RadioButton HOMMEradio;
        private System.Windows.Forms.TextBox NOMMereTextBox;
        private System.Windows.Forms.TextBox NOMPereTextBox;
        private System.Windows.Forms.TextBox AGETextBox;
        private System.Windows.Forms.TextBox NOMTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnsuppr;
        private System.Windows.Forms.Button btnajout;
        private System.Windows.Forms.TextBox CouleurTextBox;
        private System.Windows.Forms.TextBox SpeListBox;
        private System.Windows.Forms.ComboBox NomEntComboBox;
        private System.Windows.Forms.ComboBox NomProComboBox;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Button reset;
    }
}