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
    public partial class DeleteParfum : Form
    {
        public Parfum_Function parfums;
        private Dictionary<string, int> ParfumNameToID;
        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        public DeleteParfum()
        {
            InitializeComponent();
            ParfumNameToID = new Dictionary<string, int>();
        }

        private void DeleteParfum_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "select * from SearchHead";
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            // Parfum Load
                            combSearchName.Items.Add(sqlDataReader[1].ToString().Trim());
                            ParfumNameToID.Add(sqlDataReader[1].ToString().Trim(), Convert.ToInt32(sqlDataReader[0]));
                        }


                    }
                }
            }

            combSearchName.DropDownStyle = ComboBoxStyle.DropDownList;
            combSearchName.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                int Id = ParfumNameToID[combSearchName.SelectedItem.ToString()];
                string command = $"EXECUTE usp_DeleteParfum "+Id;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                    {
                        sqlConnection.Open();

                        // Delete DataBases
                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Information updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Change DataGridVeiw
                        parfums.ChangeParfum();


                    }
                }
            }
        }
    }
}
