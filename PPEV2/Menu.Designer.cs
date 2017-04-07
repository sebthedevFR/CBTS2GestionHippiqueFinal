namespace PPEV2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.labeltime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonMenuQuit6 = new System.Windows.Forms.Button();
            this.buttonMenu5 = new System.Windows.Forms.Button();
            this.buttonMenu4 = new System.Windows.Forms.Button();
            this.buttonMenu3 = new System.Windows.Forms.Button();
            this.buttonMenu2 = new System.Windows.Forms.Button();
            this.buttonMenu1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labeltime.Location = new System.Drawing.Point(762, 480);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(81, 22);
            this.labeltime.TabIndex = 19;
            this.labeltime.Text = "labeltime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(365, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Résultats de la dérniére course :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(285, 208);
            this.dataGridView1.TabIndex = 17;
            // 
            // buttonMenuQuit6
            // 
            this.buttonMenuQuit6.Location = new System.Drawing.Point(78, 473);
            this.buttonMenuQuit6.Name = "buttonMenuQuit6";
            this.buttonMenuQuit6.Size = new System.Drawing.Size(135, 36);
            this.buttonMenuQuit6.TabIndex = 16;
            this.buttonMenuQuit6.Text = "Quitter";
            this.buttonMenuQuit6.UseVisualStyleBackColor = true;
            this.buttonMenuQuit6.Click += new System.EventHandler(this.buttonMenuQuit6_Click);
            // 
            // buttonMenu5
            // 
            this.buttonMenu5.Location = new System.Drawing.Point(33, 366);
            this.buttonMenu5.Name = "buttonMenu5";
            this.buttonMenu5.Size = new System.Drawing.Size(227, 34);
            this.buttonMenu5.TabIndex = 15;
            this.buttonMenu5.Text = "Gestion des résultats";
            this.buttonMenu5.UseVisualStyleBackColor = true;
            this.buttonMenu5.Click += new System.EventHandler(this.buttonMenu5_Click);
            // 
            // buttonMenu4
            // 
            this.buttonMenu4.Location = new System.Drawing.Point(34, 295);
            this.buttonMenu4.Name = "buttonMenu4";
            this.buttonMenu4.Size = new System.Drawing.Size(226, 34);
            this.buttonMenu4.TabIndex = 14;
            this.buttonMenu4.Text = "Gestion des courses";
            this.buttonMenu4.UseVisualStyleBackColor = true;
            this.buttonMenu4.Click += new System.EventHandler(this.buttonMenu4_Click);
            // 
            // buttonMenu3
            // 
            this.buttonMenu3.Location = new System.Drawing.Point(35, 226);
            this.buttonMenu3.Name = "buttonMenu3";
            this.buttonMenu3.Size = new System.Drawing.Size(227, 34);
            this.buttonMenu3.TabIndex = 13;
            this.buttonMenu3.Text = "Administration des courses";
            this.buttonMenu3.UseVisualStyleBackColor = true;
            this.buttonMenu3.Click += new System.EventHandler(this.buttonMenu3_Click);
            // 
            // buttonMenu2
            // 
            this.buttonMenu2.Location = new System.Drawing.Point(35, 156);
            this.buttonMenu2.Name = "buttonMenu2";
            this.buttonMenu2.Size = new System.Drawing.Size(227, 34);
            this.buttonMenu2.TabIndex = 12;
            this.buttonMenu2.Text = "Administration des entraineurs";
            this.buttonMenu2.UseVisualStyleBackColor = true;
            this.buttonMenu2.Click += new System.EventHandler(this.buttonMenu2_Click);
            // 
            // buttonMenu1
            // 
            this.buttonMenu1.Location = new System.Drawing.Point(35, 90);
            this.buttonMenu1.Name = "buttonMenu1";
            this.buttonMenu1.Size = new System.Drawing.Size(227, 34);
            this.buttonMenu1.TabIndex = 11;
            this.buttonMenu1.Text = "Administration des chevaux";
            this.buttonMenu1.UseVisualStyleBackColor = true;
            this.buttonMenu1.Click += new System.EventHandler(this.buttonMenu1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 534);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonMenuQuit6);
            this.Controls.Add(this.buttonMenu5);
            this.Controls.Add(this.buttonMenu4);
            this.Controls.Add(this.buttonMenu3);
            this.Controls.Add(this.buttonMenu2);
            this.Controls.Add(this.buttonMenu1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonMenuQuit6;
        private System.Windows.Forms.Button buttonMenu5;
        private System.Windows.Forms.Button buttonMenu4;
        private System.Windows.Forms.Button buttonMenu3;
        private System.Windows.Forms.Button buttonMenu2;
        private System.Windows.Forms.Button buttonMenu1;
    }
}