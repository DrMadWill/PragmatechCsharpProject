using ParfumUI.Parfum.Load;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParfumUI.CatogoryView
{
    public partial class CategoryRemove : Form
    {
        public CategoryRemove()
        {
            InitializeComponent();
        }

        private void combCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = combCategory.SelectedItem.ToString().Trim();
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
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

        private void CategoryRemove_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                LoadParfumItems.LoadCategory(sqlConnection, true, combCategory);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (LoadParfumItems.IsAreYouSure("Remove"))
            {
                string name = "";
                foreach (var item in listParfums.SelectedItems)
                {
                    name += (name == "" ? "" : ",") + item.ToString();
                }
                string[] names = name.Replace("ListViewItem: {", "").Replace("}", "").Split(',');

                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                    // Select iformation

                    string category = combCategory.SelectedItem.ToString().Trim();

                    string command = "";

                    for (int i = 0; i < names.Length; i++)
                    {
                        if (string.IsNullOrEmpty(names[0]))
                        {
                            return;
                        }
                        command = $"Execute usp_RemoveCategoryToParfume @Header='{names[i]}' ,@Category='{category}'";

                        using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                        {
                            if (i == 0)
                                sqlConnection.Open();

                            // -----------------Information Added DataBases
                            sqlCommand.ExecuteNonQuery();
                        }
                    }

                    LoadParfumItems.MessengeWarning("Removed");
                    RefresData.salePriceLists.ChangeData();
                    int index = combCategory.SelectedIndex;
                    if (index == 0)
                    {
                        combCategory.SelectedIndex = index + 1;
                    }
                    else
                    {
                        combCategory.SelectedIndex = index - 1;
                    }
                    combCategory.SelectedIndex = index;
                }

            }
        }
    }
}
