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
        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        bool isAdd = true;

        public BrendUpdateDelete(bool isAdd)
        {
            InitializeComponent();
            this.isAdd = isAdd;
        }

        private void BrendUpdateDelete_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadParfumItems.LoadBrend(sqlConnection, true, combBrend);
                combBrend.SelectedIndex = 0;
            }
        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
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
                                    MessageBox.Show("Dont delete this Brend. This Brend Using", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }
                    }

                    string command_delete = $"delete Brend where Name='{brend_name}'";
                    using (SqlCommand sqlCommand = new SqlCommand(command_delete, sqlConnection))
                    {
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Brend Deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        LoadParfumItems.LoadBrend(sqlConnection, false, combBrend);
                        combBrend.SelectedIndex = 0;

                        if (isAdd)
                            RefresData.parfumAdd.ChangeBrend();
                        else
                            RefresData.parfumeUpdate.ChangeBrend();

                    }

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string brend_name = combBrend.SelectedItem.ToString().Trim();
                string new_brend_name = textName.Text.Trim();
                string description = textDescript.Text.Trim();
                string command = $"update Brend set Name='{new_brend_name}',Decription='{description}' where Name='{brend_name}'";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Brend Updated", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        LoadParfumItems.LoadBrend(sqlConnection, false, combBrend);
                        combBrend.SelectedIndex = 0;

                    }

                    if (isAdd)
                        RefresData.parfumAdd.ChangeBrend();
                    else
                    {
                        RefresData.parfumeUpdate.DataRefres();
                        RefresData.parfumeUpdate.ChangeBrend();
                    }
                    RefresData.parfum_Function.ChangeParfum();
                }

            }
        }
    }
}
