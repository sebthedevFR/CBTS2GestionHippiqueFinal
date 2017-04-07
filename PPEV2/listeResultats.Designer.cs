namespace PPEV2
{
    partial class listeResultats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listeResultats));
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.comboBoxch1 = new System.Windows.Forms.ComboBox();
            this.comboBoxch2 = new System.Windows.Forms.ComboBox();
            this.comboBoxch3 = new System.Windows.Forms.ComboBox();
            this.comboBoxch4 = new System.Windows.Forms.ComboBox();
            this.comboBoxch5 = new System.Windows.Forms.ComboBox();
            this.dataGridViewResultat = new System.Windows.Forms.DataGridView();
            this.comboBoxCou = new System.Windows.Forms.ComboBox();
            this.comboBoxHipp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultat)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(647, 434);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(155, 23);
            this.buttonRetour.TabIndex = 25;
            this.buttonRetour.Text = "retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(355, 434);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(155, 23);
            this.buttonValider.TabIndex = 24;
            this.buttonValider.Text = "Valider l\'arrivée de la course";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // comboBoxch1
            // 
            this.comboBoxch1.FormattingEnabled = true;
            this.comboBoxch1.Location = new System.Drawing.Point(50, 391);
            this.comboBoxch1.Name = "comboBoxch1";
            this.comboBoxch1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxch1.TabIndex = 23;
            // 
            // comboBoxch2
            // 
            this.comboBoxch2.FormattingEnabled = true;
            this.comboBoxch2.Location = new System.Drawing.Point(212, 391);
            this.comboBoxch2.Name = "comboBoxch2";
            this.comboBoxch2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxch2.TabIndex = 22;
            // 
            // comboBoxch3
            // 
            this.comboBoxch3.FormattingEnabled = true;
            this.comboBoxch3.Location = new System.Drawing.Point(377, 391);
            this.comboBoxch3.Name = "comboBoxch3";
            this.comboBoxch3.Size = new System.Drawing.Size(121, 21);
            this.comboBoxch3.TabIndex = 21;
            // 
            // comboBoxch4
            // 
            this.comboBoxch4.FormattingEnabled = true;
            this.comboBoxch4.Location = new System.Drawing.Point(527, 391);
            this.comboBoxch4.Name = "comboBoxch4";
            this.comboBoxch4.Size = new System.Drawing.Size(121, 21);
            this.comboBoxch4.TabIndex = 20;
            // 
            // comboBoxch5
            // 
            this.comboBoxch5.FormattingEnabled = true;
            this.comboBoxch5.Location = new System.Drawing.Point(681, 391);
            this.comboBoxch5.Name = "comboBoxch5";
            this.comboBoxch5.Size = new System.Drawing.Size(121, 21);
            this.comboBoxch5.TabIndex = 19;
            // 
            // dataGridViewResultat
            // 
            this.dataGridViewResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultat.Location = new System.Drawing.Point(50, 189);
            this.dataGridViewResultat.Name = "dataGridViewResultat";
            this.dataGridViewResultat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResultat.Size = new System.Drawing.Size(722, 150);
            this.dataGridViewResultat.TabIndex = 17;
            // 
            // comboBoxCou
            // 
            this.comboBoxCou.FormattingEnabled = true;
            this.comboBoxCou.Location = new System.Drawing.Point(227, 90);
            this.comboBoxCou.Name = "comboBoxCou";
            this.comboBoxCou.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCou.TabIndex = 14;
            this.comboBoxCou.SelectedIndexChanged += new System.EventHandler(this.comboBoxCou_SelectedIndexChanged);
            // 
            // comboBoxHipp
            // 
            this.comboBoxHipp.FormattingEnabled = true;
            this.comboBoxHipp.Location = new System.Drawing.Point(227, 51);
            this.comboBoxHipp.Name = "comboBoxHipp";
            this.comboBoxHipp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHipp.TabIndex = 13;
            this.comboBoxHipp.SelectedIndexChanged += new System.EventHandler(this.comboBoxHipp_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Course";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Hippodrome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Liste des chevaux engagés dans la course :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "1er";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "2nd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "3eme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "4eme";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(678, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "5eme";
            // 
            // listeResultats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 509);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.comboBoxch1);
            this.Controls.Add(this.comboBoxch2);
            this.Controls.Add(this.comboBoxch3);
            this.Controls.Add(this.comboBoxch4);
            this.Controls.Add(this.comboBoxch5);
            this.Controls.Add(this.dataGridViewResultat);
            this.Controls.Add(this.comboBoxCou);
            this.Controls.Add(this.comboBoxHipp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "listeResultats";
            this.Text = "listeResultats";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.ComboBox comboBoxch1;
        private System.Windows.Forms.ComboBox comboBoxch2;
        private System.Windows.Forms.ComboBox comboBoxch3;
        private System.Windows.Forms.ComboBox comboBoxch4;
        private System.Windows.Forms.ComboBox comboBoxch5;
        private System.Windows.Forms.DataGridView dataGridViewResultat;
        private System.Windows.Forms.ComboBox comboBoxCou;
        private System.Windows.Forms.ComboBox comboBoxHipp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}