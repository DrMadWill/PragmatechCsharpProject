﻿using System;
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
    public partial class BrendAdd : Form
    {
        private bool isParfumAdd=true;
        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;
        public BrendAdd(bool isAdd)
        {
            InitializeComponent();
            isParfumAdd = isAdd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string descript = textDescript.Text.Trim();

            string command = $"Insert into dbo.Brend(Name,Decription)values('{name}','{descript}')";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlConnection.Open();

                    // Add DataBases
                    sqlCommand.ExecuteNonQuery();
                    
                    if (isParfumAdd)
                    {
                        // Added Combo Box Change
                        RefresData.parfumAdd.ChangeBrend();

                    }
                    else
                    {
                        // Update Combo Box Change
                        RefresData.parfumeUpdate.ChangeBrend();
                    }




                    MessageBox.Show("Information added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textName.Text = "";
                    textDescript.Text="";
                }
            }
        }

        private void BrendAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
