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
    public partial class Suppr : Form
    {
        public Suppr()
        {
            InitializeComponent();
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();

            string sqlInscription = "SELECT NUM_COMPETITION, NUM_LICENCE, NOTE_GLOBALE FROM inscription WHERE NOTE_GLOBALE is NULL";
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


        private void GridInscription_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsupr_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();

            int ligne = GridInscription.CurrentCell.RowIndex;

            int numcomp = Convert.ToInt16(GridInscription[0, ligne].Value);

            string sqlSupprimer = "DELETE FROM inscription WHERE NUM_COMPETITION=@NUM_COMPETITION AND NUM_LICENCE=@NUM_LICENCE";
            MySqlCommand cmdSupprimer = new MySqlCommand(sqlSupprimer, conn);
            
            
            cmdSupprimer.Parameters.AddWithValue("@NUM_COMPETITION", numcomp);
            
           


            string numlicence = GridInscription[1, ligne].Value.ToString();

            
            cmdSupprimer.Parameters.AddWithValue("@NUM_LICENCE", numlicence);
            MessageBox.Show(numlicence);
            cmdSupprimer.ExecuteNonQuery();

            conn.Close();
        }

       
    }
}
