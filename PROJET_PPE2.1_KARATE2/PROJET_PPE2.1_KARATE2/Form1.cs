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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();

            string sqlMembre = "SELECT NUM_LICENCE,NUM_CLUB, NOM_MEMBRE, PRENOM_MEMBRE FROM membre";
            MySqlCommand cmdMembre = new MySqlCommand(sqlMembre, conn);
            MySqlDataReader readerMembre = cmdMembre.ExecuteReader();

            while (readerMembre.Read())
            {
                string NUM_LICENCE = (readerMembre["NUM_LICENCE"].ToString());
                string NUM_CLUB = (readerMembre["NUM_CLUB"].ToString());
                string NOM_MEMBRE = (readerMembre["NOM_MEMBRE"].ToString());
                string PRENOM_MEMBRE = (readerMembre["PRENOM_MEMBRE"].ToString());

                Grid_Membre.Rows.Add(NUM_LICENCE, NUM_CLUB, NOM_MEMBRE, PRENOM_MEMBRE);
            }
            conn.Close();
            conn.Open();

            string sqlComp = "SELECT NUM_COMPETITION,NUM_CLUB FROM competition";
            MySqlCommand cmdComp = new MySqlCommand(sqlComp, conn);
            MySqlDataReader readerComp = cmdComp.ExecuteReader();

            while (readerComp.Read())
            {
                string NUM_COMPETITION = (readerComp["NUM_COMPETITION"].ToString());
                string NUM_CLUB = (readerComp["NUM_CLUB"].ToString());

                Grid_Comp.Rows.Add(NUM_COMPETITION, NUM_CLUB);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();

            string sqlInscription = "INSERT INTO inscription (NUM_LICENCE, NUM_COMPETITION) VALUES (@NUM_LICENCE, @NUM_COMPETITION)";
            MySqlCommand cmdInscription = new MySqlCommand(sqlInscription, conn);
            string numLicence = Grid_Membre.SelectedRows[0].Cells[0].Value.ToString();
            cmdInscription.Parameters.AddWithValue("NUM_LICENCE", numLicence);
            string numCompetition = Grid_Comp.SelectedRows[0].Cells[0].Value.ToString();
            cmdInscription.Parameters.AddWithValue("NUM_COMPETITION", numCompetition);
            cmdInscription.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Suppr frm = new Suppr();
            frm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modif_Click(object sender, EventArgs e)
        {
            Modif frm = new Modif();
            frm.Show();
        }
    }




}
