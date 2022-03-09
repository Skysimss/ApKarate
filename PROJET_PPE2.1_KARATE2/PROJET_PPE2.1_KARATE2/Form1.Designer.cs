namespace PROJET_PPE2._1_KARATE2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grid_Membre = new System.Windows.Forms.DataGridView();
            this.NUM_LICENCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENOM_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Comp = new System.Windows.Forms.DataGridView();
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.modif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Membre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Comp)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Membre
            // 
            this.Grid_Membre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Membre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_LICENCE,
            this.NUM_CLUB,
            this.NOM_MEMBRE,
            this.PRENOM_MEMBRE});
            this.Grid_Membre.Location = new System.Drawing.Point(12, 125);
            this.Grid_Membre.Name = "Grid_Membre";
            this.Grid_Membre.RowHeadersWidth = 51;
            this.Grid_Membre.RowTemplate.Height = 24;
            this.Grid_Membre.Size = new System.Drawing.Size(554, 292);
            this.Grid_Membre.TabIndex = 11;
            // 
            // NUM_LICENCE
            // 
            this.NUM_LICENCE.HeaderText = "NUM_LICENCE";
            this.NUM_LICENCE.MinimumWidth = 6;
            this.NUM_LICENCE.Name = "NUM_LICENCE";
            this.NUM_LICENCE.Width = 125;
            // 
            // NUM_CLUB
            // 
            this.NUM_CLUB.HeaderText = "NUM_CLUB";
            this.NUM_CLUB.MinimumWidth = 6;
            this.NUM_CLUB.Name = "NUM_CLUB";
            this.NUM_CLUB.Width = 125;
            // 
            // NOM_MEMBRE
            // 
            this.NOM_MEMBRE.HeaderText = "NOM_MEMBRE";
            this.NOM_MEMBRE.MinimumWidth = 6;
            this.NOM_MEMBRE.Name = "NOM_MEMBRE";
            this.NOM_MEMBRE.Width = 125;
            // 
            // PRENOM_MEMBRE
            // 
            this.PRENOM_MEMBRE.HeaderText = "PRENOM_MEMBRE";
            this.PRENOM_MEMBRE.MinimumWidth = 6;
            this.PRENOM_MEMBRE.Name = "PRENOM_MEMBRE";
            this.PRENOM_MEMBRE.Width = 125;
            // 
            // Grid_Comp
            // 
            this.Grid_Comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Comp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION,
            this.Column1});
            this.Grid_Comp.Location = new System.Drawing.Point(841, 138);
            this.Grid_Comp.Name = "Grid_Comp";
            this.Grid_Comp.RowHeadersWidth = 51;
            this.Grid_Comp.RowTemplate.Height = 24;
            this.Grid_Comp.Size = new System.Drawing.Size(358, 292);
            this.Grid_Comp.TabIndex = 12;
            // 
            // NUM_COMPETITION
            // 
            this.NUM_COMPETITION.HeaderText = "NUM_COMPETITION";
            this.NUM_COMPETITION.MinimumWidth = 6;
            this.NUM_COMPETITION.Name = "NUM_COMPETITION";
            this.NUM_COMPETITION.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NUM_CLUB";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 117);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 122);
            this.button2.TabIndex = 14;
            this.button2.Text = "Retirer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ajouter une inscription";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // modif
            // 
            this.modif.Location = new System.Drawing.Point(604, 459);
            this.modif.Name = "modif";
            this.modif.Size = new System.Drawing.Size(193, 125);
            this.modif.TabIndex = 16;
            this.modif.Text = "Modifier";
            this.modif.UseVisualStyleBackColor = true;
            this.modif.Click += new System.EventHandler(this.modif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 708);
            this.Controls.Add(this.modif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Grid_Comp);
            this.Controls.Add(this.Grid_Membre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Membre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Comp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Membre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_LICENCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_MEMBRE;
        private System.Windows.Forms.DataGridView Grid_Comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modif;
    }
}

