namespace PROJET_PPE2._1_KARATE2
{
    partial class Modif
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
            this.GridModifier = new System.Windows.Forms.DataGridView();
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_LICENCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_GLOBALE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.Button();
            this.textModif = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridModifier)).BeginInit();
            this.SuspendLayout();
            // 
            // GridModifier
            // 
            this.GridModifier.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridModifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridModifier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION,
            this.NUM_LICENCE,
            this.NOTE_GLOBALE});
            this.GridModifier.Location = new System.Drawing.Point(72, 33);
            this.GridModifier.Name = "GridModifier";
            this.GridModifier.RowHeadersWidth = 51;
            this.GridModifier.RowTemplate.Height = 24;
            this.GridModifier.Size = new System.Drawing.Size(602, 316);
            this.GridModifier.TabIndex = 2;
            this.GridModifier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridModifier_CellContentClick_1);
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
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(393, 369);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(166, 43);
            this.Modifier.TabIndex = 3;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // textModif
            // 
            this.textModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textModif.Location = new System.Drawing.Point(160, 376);
            this.textModif.Name = "textModif";
            this.textModif.Size = new System.Drawing.Size(166, 30);
            this.textModif.TabIndex = 4;
            // 
            // Modif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textModif);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.GridModifier);
            this.Name = "Modif";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.GridModifier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridModifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_LICENCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_GLOBALE;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.TextBox textModif;
    }
}