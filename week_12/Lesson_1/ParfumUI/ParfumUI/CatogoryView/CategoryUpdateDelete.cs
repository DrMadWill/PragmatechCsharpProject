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
    public partial class CategoryUpdateDelete : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        public CategoryUpdateDelete()
        {
            InitializeComponent();
        }

        private void CategoryUpdateDelete_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                LoadCategoryList(sqlConnection,true);
        }

        private void LoadCategoryList(SqlConnection sqlConnection, bool isConnection)
        {
            string commandSize = "select * from Catogory";
            using (SqlCommand sqlCommand = new SqlCommand(commandSize, sqlConnection))
            {
                // Connection Candition 
                LoadParfumItems.ConnectionCadditon(sqlConnection, isConnection);

                // Data Clear
                combCategory.Items.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        combCategory.Items.Add(sqlDataReader[1].ToString().Trim());
                    }
                }
                combCategory.DropDownStyle = ComboBoxStyle.DropDownList;
                combCategory.SelectedIndex = 0;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = "";
            foreach (var item in listParfums.SelectedItems)
            {
                name += (name == "" ? "" : " ") + item.ToString();
            }
            string[] names = name.Replace("ListViewItem: {", "").Replace("}", "").Split(' ');


        }

        private void combCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = combCategory.SelectedItem.ToString().Trim();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = $"select * from DeleteUpdateCategoryToParfum where Category='{category}'";
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    listParfums.Items.Clear();
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        
                        while (sqlDataReader.Read())
                        {
                            listParfums.Items.Add(sqlDataReader[1].ToString());
                        }
                    }
                }
            }
        }
    }
}
