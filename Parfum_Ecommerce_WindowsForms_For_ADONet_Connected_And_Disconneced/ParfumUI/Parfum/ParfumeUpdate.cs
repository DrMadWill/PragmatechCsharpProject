using ParfumUI.Parfum.Brend;
using ParfumUI.Parfum.Load;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ParfumUI
{
    public partial class ParfumeUpdate : Form
    {
        
        private bool isUpdate;

        int comboIndex =0;

        string brendName = "";

        public ParfumeUpdate()
        {
            InitializeComponent();
        }

        private void ParfumeUpdate_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
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
            if (LoadParfumItems.IsAreYouSure("Update"))
            {
                int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
                string name = textName.Text.Trim();
                string image = textImage.Text.Trim();
                string decrip = textDescription.Text.Trim();
                string brend = combBrend.SelectedItem.ToString().Trim();
                string gender = combGender.SelectedItem.ToString().Trim();
                string density = combDensity.SelectedItem.ToString().Trim();

                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                    // Updated Parfum
                    Parfum.Parfum.UpdateParfum(Id, name,image, decrip, brend, gender, density, sqlConnection);

                    // Change DataGridVeiw
                    RefresData.parfum_Function.ChangeParfum();

                    // Brend Refres
                    comboIndex = ((ParfumHeader)combSearchName.SelectedItem).Id;
                    isUpdate = true;

                    // Refres Shearch Name
                    LoadParfumItems.LoadSearchName(sqlConnection, false, combSearchName);

                    // Refres Data
                    RefresData.salePriceLists.ChangeData();

                    //Problem
                    combSearchName.SelectedIndex = SearchNameIndex(comboIndex);
                    LoadParfumItems.MessengeWarning("Parfum Updated");
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

            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                ChangeSearchName(sqlConnection, true);
            }

            
        }

       

        public void ChangeBrend()
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                LoadParfumItems.LoadBrend(sqlConnection, true, combBrend);
                combBrend.SelectedItem = brendName;

            }
        }



        public void ChangeSearchName(SqlConnection sqlConnection, bool isConnectionOpen)
        {
            int Id =0;
            string command=null;
            try
            {
                    Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
                    command = "select * from MidDetalParfumeForUpdate where Id = " + Id;
            }
            catch (Exception ex)
            {

            }

            if (string.IsNullOrEmpty(command))
            {
                return;
            }
            byte[] img;
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                // Connection Open Candition
                LoadParfumItems.ConnectionCadditon(sqlConnection, isConnectionOpen);
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {

                        pictureBox1.Image = null;
                        textName.Text = sqlDataReader[1].ToString().Trim();
                        textImage.Text = "----";
                        
                        textDescription.Text = sqlDataReader[3].ToString().Trim();
                        combBrend.SelectedItem = sqlDataReader[4].ToString().Trim();
                        // Brend Name Save
                        brendName = sqlDataReader[4].ToString().Trim();
                        combGender.SelectedItem = sqlDataReader[5].ToString().Trim();
                        combDensity.SelectedItem = sqlDataReader[6].ToString().Trim();
                        if (!string.IsNullOrEmpty(sqlDataReader[2].ToString()))
                        {
                            img = (byte[])sqlDataReader[2];
                            MemoryStream memory = new MemoryStream(img);
                            Image ret = Image.FromStream(memory);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Image = ret;
                        }
                       

                    }
                }
            }
           
           
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LoadParfumItems.IsAreYouSure("Delete? if this parfum deleted connectid sales deleted!"))
            {

                int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
                
                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {

                    Parfum.Parfum.DeleteParfum(Id, sqlConnection);

                    // Refres Search ComboBox
                    LoadParfumItems.LoadSearchName(sqlConnection, false, combSearchName);

                    // Change DataGridVeiw
                    RefresData.parfum_Function.ChangeParfum();
                    RefresData.salePriceLists.ChangeData();
                }
                LoadParfumItems.MessengeWarning("Deleted");
            }
        }

        

        

        public void DataRefres()
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
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

        private void btnImg_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFileDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                string image = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Load(image);
                textImage.Text = image;
            }
        }
    }
}