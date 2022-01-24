using ParfumUI.Parfum.Load;
using ParfumUI.SalePriceFolder;
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

namespace ParfumUI.CatogoryView
{
    public partial class CategoryAdd : Form
    {
        public CategoryAdd()
        {
            InitializeComponent();
        }


        private void CategoryAdd_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                LoadParfumItems.LoadSearchName(sqlConnection, true, combSearchName);
                LoadCategoryList(sqlConnection,false);
            }
        }

        private void LoadCategoryList(SqlConnection sqlConnection,bool isConnection)
        {
            string commandSize = "select * from Catogory";
            using (SqlCommand sqlCommand = new SqlCommand(commandSize, sqlConnection))
            {
                // Connection Candition 
                LoadParfumItems.ConnectionCadditon(sqlConnection, isConnection);

                // Data Clear
                listCategory.Items.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        listCategory.Items.Add(sqlDataReader[1].ToString().Trim());
                    }
                }
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (LoadParfumItems.IsAreYouSure("Add"))
            {
                string name = "";
                foreach (var item in listCategory.SelectedItems)
                {
                    name += (name == "" ? "" : " ") + item.ToString();
                }
                string[] names = name.Replace("ListViewItem: {", "").Replace("}", "").Split(' ');
                bool isFrist = true;
                bool isAdded = false;

                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                    // Select iformation

                    int parfumId = ((ParfumHeader)combSearchName.SelectedItem).Id;


                    string command = "";

                    for (int i = 0; i < names.Length; i++)
                    {
                        if (string.IsNullOrEmpty(names[0]))
                        {
                            return;
                        }

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["Category"].Value.ToString().Trim() == names[i])
                            {
                                isAdded = true;
                                break;
                            }
                        }

                        if (isAdded)
                        {
                            isAdded = false;
                            continue;
                        }

                        command = $"EXECUTE usp_InsertCategoryToParfum @ParfumId={parfumId},@Category='{names[i]}'";

                        using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                        {
                            if (isFrist)
                            {
                                isFrist = false;
                                sqlConnection.Open();

                            }

                            //-----------------Information Added DataBases
                            sqlCommand.ExecuteNonQuery();

                        }
                    }

                    LoadParfumItems.MessengeWarning("Added.");
                    RefresData.salePriceLists.ChangeData();
                }
            }
        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
            string command = "select Name from CategoryListParfum where ParfumId=" + Id;
            using (SqlConnection sql = new SqlConnection(LoadParfumItems.connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(command, sql))
                {
                    // Connection Open Candition
                    sql.Open();
                    // Data Clear
                    dataGridView1.Rows.Clear();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            dataGridView1.Rows.Add(sqlDataReader[0].ToString().Trim());
                        }
                    }
                }
            }


        }
    }
}
