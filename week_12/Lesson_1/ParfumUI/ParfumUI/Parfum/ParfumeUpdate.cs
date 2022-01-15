using ParfumUI.Parfum.Load;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ParfumUI
{
    public partial class ParfumeUpdate : Form
    {


        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        private Dictionary<string, int> ParfumNameToID;
        private Dictionary<string, int> BrendId;
        private Dictionary<string, int> GenderId;
        private Dictionary<string, int> DensityId;

        string brendName = "";

        public ParfumeUpdate()
        {
            InitializeComponent();
            ParfumNameToID = new Dictionary<string, int>();
            BrendId = new Dictionary<string, int>();
            GenderId = new Dictionary<string, int>();
            DensityId = new Dictionary<string, int>();
        }

        private void ParfumeUpdate_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadParfumItems.LoadBrend(sqlConnection, true, combBrend, BrendId);
                LoadParfumItems.LoadDensity(sqlConnection, false, combDensity, DensityId);
                LoadParfumItems.LoadGender(sqlConnection, false, combGender, GenderId);
                LoadParfumItems.LoadSearchName(sqlConnection, false, combSearchName, ParfumNameToID);
                ChangeSearchName(sqlConnection, false);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int Id = ParfumNameToID[combSearchName.SelectedItem.ToString()];
                string name = textName.Text.Trim();
                string image = textImage.Text.Trim();
                string decrip = textDescription.Text.Trim();
                string brend = combBrend.SelectedItem.ToString().Trim();
                string gender = combGender.SelectedItem.ToString().Trim();
                string density = combDensity.SelectedItem.ToString().Trim();

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    // Updated Parfum
                    Parfum.Parfum.UpdateParfum(Id, name, image, decrip, brend, gender, density, sqlConnection);

                    // Change DataGridVeiw
                    RefresData.parfum_Function.ChangeParfum();

                    // Brend Refres
                    int id = ParfumNameToID[combSearchName.SelectedItem.ToString().Trim()];
                    LoadParfumItems.LoadSearchName(sqlConnection, false, combSearchName, ParfumNameToID);
                    combSearchName.SelectedItem = SearchName(id);

                }

            }
        }

        private string SearchName(int id)
        {
            string serchname = "";
            foreach (var item in ParfumNameToID)
            {
                if (item.Value == id)
                {
                    serchname = item.Key;
                    break;
                }
            }
            return serchname;
        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                ChangeSearchName(sqlConnection, true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BrendAdd brendAdd = new BrendAdd(false);
            brendAdd.ShowDialog();
        }


        public void ChangeBrend()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadParfumItems.LoadBrend(sqlConnection, true, combBrend, BrendId);
                combBrend.SelectedIndex = BrendId[brendName];

            }
        }


        // ----------------------------- Load Section

        public void LoadSearchName(SqlConnection sqlConnection, bool isConnectionOpen)
        {
            string commandSearch = "select * from SearchHead";
            using (SqlCommand sqlCommand = new SqlCommand(commandSearch, sqlConnection))
            {
                // Connection Open Candition
                LoadParfumItems.ConnectionCadditon(sqlConnection, isConnectionOpen);

                // Data Clear
                combSearchName.Items.Clear();
                ParfumNameToID.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        combSearchName.Items.Add(sqlDataReader[1].ToString().Trim());
                        ParfumNameToID.Add(sqlDataReader[1].ToString().Trim(), Convert.ToInt32(sqlDataReader[0]));
                    }
                }

                combSearchName.DropDownStyle = ComboBoxStyle.DropDownList;
                combSearchName.SelectedIndex = 0;
            }
        }

        public void ChangeSearchName(SqlConnection sqlConnection, bool isConnectionOpen)
        {
            int Id = ParfumNameToID[combSearchName.SelectedItem.ToString()];
            string command = "select * from MidDetalParfume where Id = " + Id;

            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                // Connection Open Candition
                LoadParfumItems.ConnectionCadditon(sqlConnection, isConnectionOpen);
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        textName.Text = sqlDataReader[1].ToString().Trim();
                        textImage.Text = sqlDataReader[2].ToString();
                        textDescription.Text = sqlDataReader[3].ToString().Trim();
                        combBrend.SelectedIndex = BrendId[sqlDataReader[4].ToString().Trim()];
                        // Brend Name Save
                        brendName = sqlDataReader[4].ToString().Trim();
                        combGender.SelectedIndex = GenderId[sqlDataReader[5].ToString().Trim()];
                        combDensity.SelectedIndex = DensityId[sqlDataReader[6].ToString().Trim()];
                    }
                }
            }
        }


        

    }
}