﻿using ParfumUI.Parfum.Load;
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
    public partial class ParfumAdd : Form
    {
        private Dictionary<string, int> BrendId;
        private Dictionary<string, int> GenderId;
        private Dictionary<string, int> DensityId;

        public ParfumAdd()
        {
            InitializeComponent();
            BrendId = new Dictionary<string, int>();
            GenderId = new Dictionary<string, int>();
            DensityId = new Dictionary<string, int>();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;
        private void ParfumAdd_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                // Load Parfum Items
                LoadParfumItems.LoadBrend(sqlConnection, true, combBrend, BrendId);
                LoadParfumItems.LoadDensity(sqlConnection, false, combDensity, DensityId);
                LoadParfumItems.LoadGender(sqlConnection, false, combGender, GenderId);

                
            }
            combBrend.SelectedIndex = 0;
            combDensity.SelectedIndex = 0;
            combGender.SelectedIndex = 0;



        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Save Click
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string name = textName.Text.Trim();
                string image = textImage.Text.Trim();
                string decrip = textDescription.Text.Trim();
                string brend = combBrend.SelectedItem.ToString().Trim();
                string gender = combGender.SelectedItem.ToString().Trim();
                string density = combDensity.SelectedItem.ToString().Trim();

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    Parfum.Parfum.CreateParfum(name, image, decrip, brend, gender, density, sqlConnection);
                }

                // Change DataGridView
                RefresData.parfum_Function.ChangeParfum();

                // Clear Boxs
                textName.Text = "";
                textImage.Text ="";
                textDescription.Text ="";
                combBrend.SelectedIndex =0;
                combGender.SelectedIndex = 0;
                combDensity.SelectedIndex = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Brend Add Panel Show
            BrendAdd brend = new BrendAdd(true);
            RefresData.brendAdd = brend;
            brend.ShowDialog();
        }

        public void ChangeBrend()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                // Refres Brend 
                LoadParfumItems.LoadBrend(sqlConnection, true, combBrend, BrendId);
                combBrend.SelectedIndex = 0;
            }
        }
    }
}
