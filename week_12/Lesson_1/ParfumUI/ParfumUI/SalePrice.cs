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
    public partial class SalePrice : Form
    {
        private Dictionary<string, int> ParfumNameToID;

        public SalePrice salePrice;

        public SalePrice()
        {
            InitializeComponent();
            ParfumNameToID = new Dictionary<string, int>();
        }


        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        private void SalePrice_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                string commandSearch = "select * from SearchHead";
                using (SqlCommand sqlCommand = new SqlCommand(commandSearch, sqlConnection))
                {
                    sqlConnection.Open();
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

                string commandSize = "select * from Size";
                using (SqlCommand sqlCommand = new SqlCommand(commandSize, sqlConnection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            combSize.Items.Add(sqlDataReader[1].ToString().Trim());
                            
                        }
                    }
                    combSize.DropDownStyle = ComboBoxStyle.DropDownList;
                    combSize.SelectedIndex = 0;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int Id = ParfumNameToID[combSearchName.SelectedItem.ToString()];
                int size = Convert.ToInt32(combSize.SelectedItem.ToString().Trim());
                int price = Convert.ToInt32(textPrice.Text.Trim());
                int number = Convert.ToInt32(textNumber.Text.Trim());

                string command = $"EXECUTE usp_InsertSalePrice @Size={size} ,@Price={price} ,@Number ={number}";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                    {
                        sqlConnection.Open();

                        // Change DataBases
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                string commandMain = $"EXECUTE usp_InsertParfumToSale @ParfumId= {Id}, @Size={size} ,@Price={price} ,@Number ={number}";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(commandMain, sqlConnection))
                    {
                        sqlConnection.Open();

                        // Change DataBases
                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Information Added ", "Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }
                }


            }
        }

        public void ChangeSize()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string commandSize = "select * from Size";
                using (SqlCommand sqlCommand = new SqlCommand(commandSize, sqlConnection))
                {
                    // Clear Combo
                    combSize.Items.Clear();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            // Combo Add
                            combSize.Items.Add(sqlDataReader[1].ToString().Trim());
                        }
                    }
                    combSize.DropDownStyle = ComboBoxStyle.DropDownList;
                    combSize.SelectedIndex = 0;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
