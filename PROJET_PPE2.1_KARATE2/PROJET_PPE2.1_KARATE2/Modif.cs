using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJET_PPE2._1_KARATE2
{
    public partial class Modif : Form
    {
        public Modif()
        {
            InitializeComponent();
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();

            string sqlModifier = "SELECT NUM_COMPETITION, NUM_LICENCE, NOTE_GLOBALE FROM inscription WHERE NOTE_GLOBALE is NULL";
            MySqlCommand cmdModifier = new MySqlCommand(sqlModifier, conn);
            MySqlDataReader readerModifier = cmdModifier.ExecuteReader();

            while (readerModifier.Read())
            {
                string NUM_COMPETITION = (readerModifier["NUM_COMPETITION"].ToString());
                string NUM_LICENCE = (readerModifier["NUM_LICENCE"].ToString());
                string NOTE_GLOBALE = (readerModifier["NOTE_GLOBALE"].ToString());

                GridModifier.Rows.Add(NUM_COMPETITION, NUM_LICENCE, NOTE_GLOBALE);
            }
            conn.Close();
        }

        private void GridModifier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();


            int ligne = GridModifier.CurrentCell.RowIndex;
            int NUM_COMPETITION = Convert.ToInt16(GridModifier[0, ligne].Value);
            string NUM_LICENCE = GridModifier[1, ligne].Value.ToString();
            string sqlUpdate = "UPDATE inscription SET NUM_COMPETITION=@numCompet WHERE NUM_COMPETITION = @numCompetition AND NUM_LICENCE = @numLicence";

            MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);

            cmdUpdate.Parameters.AddWithValue("numCompetition", NUM_COMPETITION);
            cmdUpdate.Parameters.AddWithValue("numLicence", NUM_LICENCE);
            cmdUpdate.Parameters.AddWithValue("numCompet", int.Parse(textModif.Text));

            MessageBox.Show(NUM_COMPETITION.ToString());
            MessageBox.Show(NUM_LICENCE.ToString());
            cmdUpdate.ExecuteNonQuery();

            GridModifier.Rows.Clear();

            string sqlSelect = "SELECT NUM_COMPETITION,NUM_LICENCE,NOTE_GLOBALE FROM inscription";
            MySqlCommand cmdSelect = new MySqlCommand(sqlSelect, conn);
            MySqlDataReader readerSelect = cmdSelect.ExecuteReader();
            while (readerSelect.Read())
            {
                string NUM_COMP = readerSelect["NUM_COMPETITION"].ToString();
                string NUM_LIC = (readerSelect["NUM_LICENCE"].ToString());
                string NOTE_GLOBALE = (readerSelect["NOTE_GLOBALE"].ToString());

                GridModifier.Rows.Add(NUM_COMP, NUM_LIC, NOTE_GLOBALE);
            }
            conn.Close();
        }

        private void GridModifier_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
