using ParfumUI.Parfum.Brend;
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

        
        private bool isUpdate;

        int comboIndex =0;

        string brendName = "";

        public ParfumeUpdate()
        {
            InitializeComponent();
        }

        private void ParfumeUpdate_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadParfumItems.LoadBrend(sqlConnection, true, combBrend);
                LoadParfumItems.LoadDensity(sqlConnection, false, combDensity);
                LoadParfumItems.LoadGender(sqlConnection, false, combGender);
                LoadParfumItems.LoadSearchName(sqlConnection, false, combSearchName);
                ChangeSearchName(sqlConnection, false);
            }

        }


        // Update Click
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
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
                    comboIndex = ((ParfumHeader)combSearchName.SelectedItem).Id;
                    isUpdate = true;

                    // Refres Shearch Name
                    LoadParfumItems.LoadSearchName(sqlConnection, false, combSearchName);

                    //Problem
                    combSearchName.SelectedIndex = SearchNameIndex(comboIndex);

                }

            }
        }

        private int SearchNameIndex(int id)
        {
            int index=0;
            foreach (var item in combSearchName.Items)
            {
                if (((ParfumHeader)item).Id == id)
                {
                     index= ((ParfumHeader)item).ComboIndex;
                    break;
                }
            }
            return index;
        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Problem
            if (isUpdate)
            {
                combSearchName.SelectedIndex = SearchNameIndex(comboIndex);
                isUpdate = false;
            }

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
                LoadParfumItems.LoadBrend(sqlConnection, true, combBrend);
                // New Brend Add .Back To This Parfum Brend Name
                combBrend.SelectedItem = brendName;

            }
        }


        // ----------------------------- Load Section

       

        public void ChangeSearchName(SqlConnection sqlConnection, bool isConnectionOpen)
        {
            int Id =0;
            string command=null;
            try
            {
                    Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
                    command = "select * from MidDetalParfume where Id = " + Id;
            }
            catch (Exception ex)
            {

            }

            if (string.IsNullOrEmpty(command))
            {
                return;
            }

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
                        combBrend.SelectedItem = sqlDataReader[4].ToString().Trim();
                        // Brend Name Save
                        brendName = sqlDataReader[4].ToString().Trim();
                        combGender.SelectedItem = sqlDataReader[5].ToString().Trim();
                        combDensity.SelectedItem = sqlDataReader[6].ToString().Trim();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you  sure delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
                
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {

                    Parfum.Parfum.DeleteParfum(Id, sqlConnection);
                    
                    // Refres Search ComboBox
                    LoadParfumItems.LoadSearchName(sqlConnection, false, combSearchName);

                    // Change DataGridVeiw
                    RefresData.parfum_Function.ChangeParfum();
                }
            }
        }

        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            BrendUpdateDelete brendUpdateDelete = new BrendUpdateDelete(false);
            brendUpdateDelete.ShowDialog();

        }

        public void DataRefres()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
               

                // Brend Refres
                comboIndex = ((ParfumHeader)combSearchName.SelectedItem).Id;
                isUpdate = true;

                // Refres Shearch Name
                LoadParfumItems.LoadSearchName(sqlConnection, true, combSearchName);

                //Problem
                combSearchName.SelectedIndex = SearchNameIndex(comboIndex);

            }
        }
    }
}