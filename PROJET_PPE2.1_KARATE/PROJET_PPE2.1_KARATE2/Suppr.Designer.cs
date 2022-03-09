namespace PROJET_PPE2._1_KARATE2
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
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_LICENCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_GLOBALE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsupr = new System.Windows.Forms.Button();
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
            this.GridInscription.Location = new System.Drawing.Point(163, 65);
            this.GridInscription.Name = "GridInscription";
            this.GridInscription.RowHeadersWidth = 51;
            this.GridInscription.RowTemplate.Height = 24;
            this.GridInscription.Size = new System.Drawing.Size(602, 316);
            this.GridInscription.TabIndex = 1;
            this.GridInscription.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInscription_CellContentClick);
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
            // btnsupr
            // 
            this.btnsupr.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupr.Location = new System.Drawing.Point(230, 437);
            this.btnsupr.Name = "btnsupr";
            this.btnsupr.Size = new System.Drawing.Size(188, 63);
            this.btnsupr.TabIndex = 2;
            this.btnsupr.Text = "Supprimer";
            this.btnsupr.UseVisualStyleBackColor = true;
            this.btnsupr.Click += new System.EventHandler(this.btnsupr_Click);
            // 
            // Suppr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 724);
            this.Controls.Add(this.btnsupr);
            this.Controls.Add(this.GridInscription);
            this.Name = "Suppr";
            this.Text = "Suppr";
            ((System.ComponentModel.ISupportInitialize)(this.GridInscription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridInscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_LICENCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_GLOBALE;
        private System.Windows.Forms.Button btnsupr;
    }
}