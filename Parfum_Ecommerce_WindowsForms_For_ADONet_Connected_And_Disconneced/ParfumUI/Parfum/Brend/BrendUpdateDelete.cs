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

namespace ParfumUI.Parfum.Brend
{
    public partial class BrendUpdateDelete : Form
    {

        public BrendUpdateDelete()
        {
            InitializeComponent();
        }

        private void BrendUpdateDelete_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                LoadParfumItems.LoadBrend(sqlConnection, true, combBrend);
                combBrend.SelectedIndex = 0;
            }
        }


        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                string brend_name = null;
                try
                {
                    brend_name = combBrend.SelectedItem.ToString().Trim();
                }
                catch (Exception ex)
                {

                }

                if (string.IsNullOrEmpty(brend_name))
                {
                    return;
                }

                string command = $"select * from Brend where Name='{brend_name}'";
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            textName.Text = sqlDataReader[1].ToString().Trim();
                            textDescript.Text = sqlDataReader[2].ToString().Trim();
                        }
                    }
                }
            }
        }


        // Delete Brend
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LoadParfumItems.IsAreYouSure("Delete"))
            {
                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                    string brend_name = combBrend.SelectedItem.ToString().Trim();
                    string command = "select Brend from MidDetalParfume group by Brend";
                    using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                    {
                        sqlConnection.Open();
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                if (sqlDataReader[0].ToString().Trim() == brend_name)
                                {
                                    // Brend Delete Databes Cadition
                                    MessageBox.Show("Dont delete this Brend. This Brend Using", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }
                    }

                    string command_delete = $"delete Brend where Name='{brend_name}'";
                    LoadParfumItems.DataBases(sqlConnection, command_delete, false);

                    // Brend Deleted Databes
                    LoadParfumItems.MessengeWarning(": Brend Deleted");

                    // Brend Refres
                    LoadParfumItems.LoadBrend(sqlConnection, false, combBrend);
                    combBrend.SelectedIndex = 0;
                }
            }
        }

        // Brend Updated
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (LoadParfumItems.IsAreYouSure("Updated")) 
            {
                string brend_name = combBrend.SelectedItem.ToString().Trim();
                string new_brend_name = textName.Text.Trim();
                string description = textDescript.Text.Trim();
                string command = $"update Brend set Name='{new_brend_name}',Decription='{description}' where Name='{brend_name}'";
                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                    LoadParfumItems.DataBases(sqlConnection, command);
                    LoadParfumItems.MessengeWarning(":Brend Update");

                    // Brend Update
                    LoadParfumItems.LoadBrend(sqlConnection, false, combBrend);
                    combBrend.SelectedIndex = 0;
                    
                }

            }
        }
    }
}
