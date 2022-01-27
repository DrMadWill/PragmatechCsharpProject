using ParfumUI.Common;
using ParfumUI.DataModelMsSql;
using ParfumUI.Load;
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
            LoadCommonData.LoadCategory(combCategory);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string newname = textNewCategrory.Text.Trim();
            if (string.IsNullOrEmpty(newname))
            {
                ParfumMessenge.Error("You Must Write New Name!");
                return;
            }
            if (ParfumMessenge.IsAreYouSure($"Are Sure Create Category {newname}"))
            {
                if (IsAddedCategory(newname))
                {
                    return;
                }
                

                Catogory catogory = new Catogory()
                {
                    Name = newname
                };
                // Add
                LoadCommonData._db.Catogories.Add(catogory);
                // Save
                LoadCommonData._db.SaveChanges();

                ParfumMessenge.Warning($"Category {newname} Created");

                //Refres Data
                CategoryChange();
                // Refres Main Menu
                RefresData.salePriceLists.LoadCatogory();
            }
        }


        public bool IsAddedCategory(string newname)
        {

            // Check Category Name Added
            bool isadded = false;
            var categoryAdded = LoadCommonData._db.Catogories.FirstOrDefault(dr => dr.Name.Trim().ToLower() == newname.ToLower());
            if (categoryAdded != null)
            {
                ParfumMessenge.Error("This Category Already Added");
            }

            return isadded;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string oldname = combCategory.SelectedItem.ToString().Trim();
            if (ParfumMessenge.IsAreYouSure($"Are Sure Update {oldname}"))
            {
                
                string newname = textNewCategrory.Text.Trim();
                if (string.IsNullOrEmpty(newname))
                {
                    ParfumMessenge.Error("Information Must be Added!");
                    return;
                }

                var updatecategory = LoadCommonData._db.Catogories.FirstOrDefault(dr => dr.Name.ToLower() == oldname.ToLower());
                if (updatecategory != null)
                {
                    updatecategory.Name = newname;
                }
                else
                    ParfumMessenge.Error("Not Found This Category");


                LoadCommonData._db.SaveChanges();
                ParfumMessenge.Warning($"{newname} Updated.");

                //Refres Data
                CategoryChange();
                RefresData.salePriceLists.LoadCatogory();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string oldname = combCategory.SelectedItem.ToString().Trim();
            if (string.IsNullOrEmpty(oldname))
            {
                ParfumMessenge.Error("You Must Write New Name ");
                return;
            }

            if(ParfumMessenge.IsAreYouSure($"Are You Sure Delete {oldname}"))
            {
                var usingCategory = LoadCommonData._db.CategoryToParfums.FirstOrDefault(dr => dr.Catogory.Name.Trim().ToLower() == oldname.ToLower());
                if (usingCategory != null)
                {
                    ParfumMessenge.Error("This Category Are Using");
                    return;
                }

                var category = LoadCommonData._db.Catogories.FirstOrDefault(dr => dr.Name.ToLower() == oldname.ToLower());
                if (category != null)
                {
                    // Delete Elemenent
                    LoadCommonData._db.Catogories.Remove(category);
                    LoadCommonData._db.SaveChanges();
                    ParfumMessenge.Warning($"{oldname} Deleted");
                    RefresData.salePriceLists.ChangeData();

                    // Refres Main Menu Category
                    RefresData.salePriceLists.LoadCatogory();


                    CategoryChange();
                }
                else
                    ParfumMessenge.Error("Not Found This Category");
            }


        }
    }
}
