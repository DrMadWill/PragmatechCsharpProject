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

        public  ParfumAdd parfumAdd_Location;
        public Parfum_Function parfums;
        public ParfumAdd()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;
        private void ParfumAdd_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
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
                            combBrend.Items.Add(sqlDataReader[0].ToString().Trim()) ;
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
                        }
                    }
                }
                using (SqlCommand sqlCommand = new SqlCommand(commandGender, sqlConnection))
                {
    
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            combGender.Items.Add(sqlDataReader[0].ToString().Trim()) ;
                        }
                    }
                }
            }

            combBrend.DropDownStyle = ComboBoxStyle.DropDownList;
            combBrend.SelectedIndex = 0;

            combDensity.DropDownStyle = ComboBoxStyle.DropDownList;
            combDensity.SelectedIndex = 0;

            combGender.DropDownStyle = ComboBoxStyle.DropDownList;
            combGender.SelectedIndex = 0;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string name = textName.Text.Trim();
                string image = textImage.Text.Trim();
                string decrip = textDescription.Text.Trim();
                string brend = combBrend.SelectedItem.ToString().Trim();
                string gender = combGender.SelectedItem.ToString().Trim();
                string density = combDensity.SelectedItem.ToString().Trim();

                string command = $"EXECUTE usp_AddParfum @Name = '{name}',@Image='{image}',@Descriptio = '{decrip}',@Brend = '{brend}', @Gender = '{gender}',@Density ='{density}'";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                    {
                        sqlConnection.Open();
                        // Add DataBase
                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Information added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Change DataGridView
                        parfums.ChangeParfum();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            BrendAdd brend = new BrendAdd(true);
            brend.parfumAdd = parfumAdd_Location;
            brend.ShowDialog();
        }

        public void ChangeBrend()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string commandBrend = "select Name from Brend";
                using (SqlCommand sqlCommand = new SqlCommand(commandBrend, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            combBrend.Items.Add(sqlDataReader[0].ToString().Trim());
                        }
                    }
                }

                combBrend.SelectedIndex = 0;
            }
        }
    }
}
