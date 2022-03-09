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

namespace PROJET_PPE2._1_KARATE
{
    public partial class Suppr : Form
    {
        public Suppr()
        {
            InitializeComponent();
            /*MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();

            string sqlInscription = "SELECT NUM_COMPETITION, NUM_LICENCE, NOTE_GLOBALE FROM inscription";
            MySqlCommand cmdInscription = new MySqlCommand(sqlInscription, conn);
            MySqlDataReader readerInscription = cmdInscription.ExecuteReader();

            while (readerInscription.Read())
            {
                string NUM_COMPETITION = (readerInscription["NUM_COMPETITION"].ToString());
                string NUM_LICENCE = (readerInscription["NUM_LICENCE"].ToString());
                string NOTE_GLOBALE = (readerInscription["NOTE_GLOBALE"].ToString());

                GridInscription.Rows.Add(NUM_COMPETITION, NUM_LICENCE, NOTE_GLOBALE);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();

            string sqlSupprimer = "DELETE FROM inscription WHERE NUM_COMPETITION=@NUM_COMPETITION AND NUM_LICENCE=@NUM_LICENCE";
            MySqlCommand cmdSupprimer = new MySqlCommand(sqlSupprimer, conn);
            string numLicence = GridInscription.SelectedRows[0].Cells[0].Value.ToString();
            cmdSupprimer.Parameters.AddWithValue("NUM_COMPETITION", NUM_COMPETITION);
            string numCompetition = GridInscription.SelectedRows[0].Cells[1].Value.ToString();
            cmdSupprimer.Parameters.AddWithValue("NUM_LICENCE", numLicence);
            cmdSupprimer.ExecuteNonQuery();*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
