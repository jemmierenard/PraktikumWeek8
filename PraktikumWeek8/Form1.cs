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

namespace PraktikumWeek8
{
    public partial class FormHasilPertandingan : System.Windows.Forms.Form
    {
        public FormHasilPertandingan()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //sebagai data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; //memindahkan query ke database, query terjadi di dbmsnya
        public static MySqlDataAdapter sqlAdapter; //hasil dari query akan disimpan di mysqldata
        public string sqlQuery;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            { 
                DataTable dtTeamHome = new DataTable();
                DataTable dtTeamLawan = new DataTable();
                sqlQuery = "SELECT team_id as `ID TEAM`, team_name as `Nama Tim` from team";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeamHome);
                sqlQuery = "SELECT team_name as `Nama Tim`, team_id as `ID TEAM` FROM team";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeamLawan);
                cBoxHome.DataSource = dtTeamHome;
                cBoxHome.DisplayMember = "Nama Tim";
                cBoxHome.ValueMember = "Nama Tim";
                cBoxLawan.DataSource = dtTeamLawan;
                cBoxLawan.DisplayMember = "Nama Tim";
                cBoxLawan.ValueMember = "Nama Tim";
            }
            catch (Exception)
            {

               
            }
        }

        private void cBoxHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTim = new DataTable();
                ////mulai dari sini
                sqlQuery = "select t.team_name as 'namaTim' , p.player_name , m.manager_name, t.home_stadium, t.capacity from team t, manager m, player p WHERE t.manager_id = m.manager_id and t.captain_id = p.player_id and team_name = '" + cBoxHome.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTim);
                lblManagHomeIsi.Text = dtTim.Rows[0][2].ToString();
                lblCaptHomeIsi.Text = dtTim.Rows[0][1].ToString();
                lblStadiumIsi.Text = dtTim.Rows[0]["home_stadium"].ToString();
                lblCapacityIsi.Text = dtTim.Rows[0]["capacity"].ToString();
                ////sampai sini
                
            }
            catch (Exception)
            {

                
            }
          
        }

        private void cBoxLawan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTim = new DataTable();
                ////mulai dari sini
                sqlQuery = "select t.team_name as 'namaTim' , p.player_name , m.manager_name, t.home_stadium, t.capacity from team t, manager m, player p WHERE t.manager_id = m.manager_id and t.captain_id = p.player_id and team_name = '" + cBoxLawan.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTim);
                lblManagLawanIsi.Text = dtTim.Rows[0][2].ToString();
                lblCaptLawanIsi.Text = dtTim.Rows[0][1].ToString();
            }
            catch (Exception)
            {

                
            }
        }
    }
}
