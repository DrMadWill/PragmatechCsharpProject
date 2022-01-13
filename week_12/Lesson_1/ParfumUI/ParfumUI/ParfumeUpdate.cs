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

        public Parfum_Function parfums;
        public ParfumeUpdate ParfumeUpdate_Location;

        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        private Dictionary<string, int> ParfumNameToID;
        private Dictionary<string, int> BrendId;
        private Dictionary<string, int> GenderId;
        private Dictionary<string, int> DensityId;


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
                int brendId = 0;
                int genderId = 0;
                int densityId = 0;
                string commandSearch = "select * from SearchHead";
                string commandBrend = "select Name from Brend";
                string commandDensity = "select Name from Density";
                string commandGender = "select Name from Gender";
                using (SqlCommand sqlCommand = new SqlCommand(commandBrend, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            combBrend.Items.Add(sqlDataReader[0].ToString().Trim());
                            BrendId.Add(sqlDataReader[0].ToString().Trim(), brendId);
                            ++brendId;
                        }
                    }
                }
                using (SqlCommand sqlCommand = new SqlCommand(commandDensity, sqlConnection))
                {

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            combDensity.Items.Add(sqlDataReader[0].ToString().Trim());
                            DensityId.Add(sqlDataReader[0].ToString().Trim(), densityId);
                            ++densityId;
                        }
                    }
                }
                using (SqlCommand sqlCommand = new SqlCommand(commandGender, sqlConnection))
                {

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            combGender.Items.Add(sqlDataReader[0].ToString().Trim());
                            GenderId.Add(sqlDataReader[0].ToString().Trim(), genderId);
                            ++genderId;
                        }
                    }
                }

                using (SqlCommand sqlCommand = new SqlCommand(commandSearch, sqlConnection))
                {

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            combSearchName.Items.Add(sqlDataReader[1].ToString().Trim());
                            ParfumNameToID.Add(sqlDataReader[1].ToString().Trim(), Convert.ToInt32(sqlDataReader[0]));
                        }
                    }
                }

                combSearchName.DropDownStyle = ComboBoxStyle.DropDownList;
                combSearchName.SelectedIndex = 0;

                combBrend.DropDownStyle = ComboBoxStyle.DropDownList;

                combDensity.DropDownStyle = ComboBoxStyle.DropDownList;

                combGender.DropDownStyle = ComboBoxStyle.DropDownList;

                int Id = ParfumNameToID[combSearchName.SelectedItem.ToString()];
                string command = "select * from MidDetalParfume where Id = " + Id;

                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            textName.Text = sqlDataReader[1].ToString().Trim();
                            textImage.Text = sqlDataReader[2].ToString();
                            textDescription.Text = sqlDataReader[3].ToString().Trim();
                            combBrend.SelectedIndex = BrendId[sqlDataReader[4].ToString().Trim()];
                            combGender.SelectedIndex = GenderId[sqlDataReader[5].ToString().Trim()];
                            combDensity.SelectedIndex = DensityId[sqlDataReader[6].ToString().Trim()];
                        }
                    }
                }

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

                string command = $"EXECUTE usp_UpdateParfum @Id={Id},@Name = '{name}',@Image='{image}',@Descriptio = '{decrip}',@Brend = '{brend}', @Gender = '{gender}',@Density ='{density}'";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                    {
                        sqlConnection.Open();

                        // Change DataBases
                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Information updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Change DataGridVeiw
                        parfums.ChangeParfum();


                    }
                    int indexsd = combSearchName.SelectedIndex;
                    string commandSearch = "select * from SearchHead";
                    using (SqlCommand sqlCommand = new SqlCommand(commandSearch, sqlConnection))
                    {
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

                        combSearchName.SelectedIndex = indexsd;
                    }
                }
            }
        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = ParfumNameToID[combSearchName.SelectedItem.ToString()];
            string command = "select * from MidDetalParfume where Id = " + Id;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            textName.Text = sqlDataReader[1].ToString().Trim();
                            textImage.Text = sqlDataReader[2].ToString();
                            textDescription.Text = sqlDataReader[3].ToString().Trim();
                            combBrend.SelectedIndex = BrendId[sqlDataReader[4].ToString().Trim()];
                            combGender.SelectedIndex = GenderId[sqlDataReader[5].ToString().Trim()];
                            combDensity.SelectedIndex = DensityId[sqlDataReader[6].ToString().Trim()];
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BrendAdd brendAdd = new BrendAdd(false);
            brendAdd.parfumeUpdate = ParfumeUpdate_Location;
            brendAdd.ShowDialog();
        }


        public void ChangeBrend()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string commandBrend = "select Name from Brend";
                
                using (SqlCommand sqlCommand = new SqlCommand(commandBrend, sqlConnection))
                {

                    sqlConnection.Open();
                    combBrend.Items.Clear();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {

                        while (sqlDataReader.Read())
                        {
                            
                            combBrend.Items.Add(sqlDataReader[0].ToString().Trim());
                            
                        }
                    }

                }
                

            }
        }
    }
}
