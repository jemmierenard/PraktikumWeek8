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
                sqlQuery = "select t.team_name as 'namaTim' , p.player_name , m.manager_name, t.home_stadium, t.capacity from team t, manager m, player p WHERE t.manager_id = m.manager_id and t.captain_id = p.player_id and team_name = '" + cBoxHome.SelectedValue.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTim);
                lblManagHomeIsi.Text = dtTim.Rows[0][2].ToString();
                lblCaptHomeIsi.Text = dtTim.Rows[0][1].ToString();
                lblStadiumIsi.Text = dtTim.Rows[0][3].ToString();
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
                sqlQuery = "select t.team_name as 'namaTim' , p.player_name , m.manager_name, t.home_stadium, t.capacity from team t, manager m, player p WHERE t.manager_id = m.manager_id and t.captain_id = p.player_id and team_name = '" + cBoxLawan.SelectedValue.ToString() + "'";
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dMatch = new DataTable();
                sqlQuery = "select date_format(m.match_date, '%e %M %Y'),concat(m.goal_home,' - ',m.goal_away)  from player p, dmatch d,team t, team t2, `match` m where d.match_id = m.match_id and p.player_id = d.player_id and (((t.team_name = '" + cBoxHome.SelectedValue.ToString() + "'and t2.team_name = '" + cBoxLawan.SelectedValue.ToString() + "')or (t2.team_name = '" + cBoxHome.SelectedValue.ToString() + "' and t.team_name = '" + cBoxLawan.SelectedValue.ToString() + "')) and ((t.team_id = m.team_home and t2.team_id = m.team_away) or (t.team_id = m.team_away and t2.team_id = m.team_home) )); ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dMatch);
                lblIsiTgl.Text = dMatch.Rows[0][0].ToString();
                lblIsiSkor.Text = dMatch.Rows[0][1].ToString();
                
                DataTable dMatch2 = new DataTable();
                sqlQuery = "select d.minute, if(p.team_id = match.team_home,p.player_name,' ') as 'player 1',if(p.team_id = match.team_home,if(d.type = 'CY' ,'Yellow Card',if(d.type = 'CR','Red Card',if(d.type = 'GO','Goal',if(d.type = 'GP','Goal Penalty',if(d.type = 'GW','Own Goal','Penalty Miss'))))),' ') as 'Type 1',if(p.team_id = match.team_away,p.player_name,' ') as 'player 2',if(p.team_id = match.team_away,if(d.type = 'CY' ,'Yellow Card',if(d.type = 'CR','Red Card',if(d.type = 'GO','Goal',if(d.type = 'GP','Goal Penalty',if(d.type = 'GW','Own Goal','Penalty Miss'))))),' ') as 'Type 2' from player p, dmatch d,team t, team t2, `match` where d.match_id = match.match_id and p.player_id = d.player_id and (((t.team_name = '" + cBoxHome.SelectedValue.ToString() + "'and t2.team_name = '" + cBoxLawan.SelectedValue.ToString() + "')or (t2.team_name = '" + cBoxHome.SelectedValue.ToString() + "' and t.team_name = '" + cBoxLawan.SelectedValue.ToString() + "')) and ((t.team_id = match.team_home and t2.team_id = match.team_away) or (t.team_id = match.team_away and t2.team_id = match.team_home) )) group by 1 order by 1; ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dMatch2);
                dgvMatch.DataSource = dMatch2;
            }
            catch (Exception)
            {

                
            }
        }
    }
    //Praktikum Week 10
}
