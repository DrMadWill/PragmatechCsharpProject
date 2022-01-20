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
    public partial class CategoryCreate : Form
    {
        public CategoryCreate()
        {
            InitializeComponent();
        }

        private void CategoryCreate_Load(object sender, EventArgs e)
        {
            CategoryChange();
        }

        private void CategoryChange()
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                LoadParfumItems.LoadCategory(sqlConnection, true, combCategory);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (LoadParfumItems.IsAreYouSure())
            {
                string newname = textNewCategrory.Text.Trim();
                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                    string command =$"insert into Catogory(Name) values('{newname}')";
                    // Create Info
                    LoadParfumItems.DataBases(sqlConnection, command);

                    // Messenge go
                    LoadParfumItems.MessengeCreate();

                    //Refres Data
                    CategoryChange();

                    RefresData.salePriceLists.LoadCatogory();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (LoadParfumItems.IsAreYouSure())
            {
                string oldname = combCategory.SelectedItem.ToString().Trim(); 
                string newname = textNewCategrory.Text.Trim();
                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                    string command = $"Update Catogory set Name='{newname}' where Name='{oldname}'";

                    // Update Info
                    LoadParfumItems.DataBases(sqlConnection, command);

                    LoadParfumItems.MessengeUpdate();

                    //Refres Data
                    CategoryChange();

                    RefresData.salePriceLists.LoadCatogory();
                }
            }
        }
    }
}
