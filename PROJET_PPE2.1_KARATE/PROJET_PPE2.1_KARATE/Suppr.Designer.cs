namespace PROJET_PPE2._1_KARATE
{
    partial class Suppr
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
            this.GridInscription = new System.Windows.Forms.DataGridView();
            this.btnsupr = new System.Windows.Forms.Button();
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_LICENCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_GLOBALE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridInscription)).BeginInit();
            this.SuspendLayout();
            // 
            // GridInscription
            // 
            this.GridInscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInscription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION,
            this.NUM_LICENCE,
            this.NOTE_GLOBALE});
            this.GridInscription.Location = new System.Drawing.Point(94, 12);
            this.GridInscription.Name = "GridInscription";
            this.GridInscription.RowHeadersWidth = 51;
            this.GridInscription.RowTemplate.Height = 24;
            this.GridInscription.Size = new System.Drawing.Size(602, 316);
            this.GridInscription.TabIndex = 0;
            this.GridInscription.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnsupr
            // 
            this.btnsupr.Location = new System.Drawing.Point(285, 343);
            this.btnsupr.Name = "btnsupr";
            this.btnsupr.Size = new System.Drawing.Size(188, 63);
            this.btnsupr.TabIndex = 1;
            this.btnsupr.Text = "Supprimer";
            this.btnsupr.UseVisualStyleBackColor = true;
            this.btnsupr.Click += new System.EventHandler(this.button1_Click);
            // 
            // NUM_COMPETITION
            // 
            this.NUM_COMPETITION.HeaderText = "NUM_COMPETITION";
            this.NUM_COMPETITION.MinimumWidth = 6;
            this.NUM_COMPETITION.Name = "NUM_COMPETITION";
            this.NUM_COMPETITION.Width = 125;
            // 
            // NUM_LICENCE
            // 
            this.NUM_LICENCE.HeaderText = "NUM_LICENCE";
            this.NUM_LICENCE.MinimumWidth = 6;
            this.NUM_LICENCE.Name = "NUM_LICENCE";
            this.NUM_LICENCE.Width = 125;
            // 
            // NOTE_GLOBALE
            // 
            this.NOTE_GLOBALE.HeaderText = "NOTE_GLOBALE";
            this.NOTE_GLOBALE.MinimumWidth = 6;
            this.NOTE_GLOBALE.Name = "NOTE_GLOBALE";
            this.NOTE_GLOBALE.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsupr);
            this.Controls.Add(this.GridInscription);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.GridInscription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridInscription;
        private System.Windows.Forms.Button btnsupr;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_LICENCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_GLOBALE;
    }
}