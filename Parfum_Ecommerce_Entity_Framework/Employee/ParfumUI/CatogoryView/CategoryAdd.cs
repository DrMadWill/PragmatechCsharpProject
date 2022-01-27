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
    public partial class CategoryAdd : Form
    {

        public CategoryAdd()
        {
            InitializeComponent();
        }


        private void CategoryAdd_Load(object sender, EventArgs e)
        {
            LoadCommonData.LoadSearchName(combSearchName);
            LoadCategoryList();
        }

        private void LoadCategoryList()
        {
            listCategory.Items.Clear();
            var categorys = LoadCommonData._db.Catogories.Select(dr => dr.Name);
            if (categorys != null)
            {
                foreach (var item in categorys)
                {
                    listCategory.Items.Add(item);
                }
            }
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ParfumMessenge.IsAreYouSure("Are Sure Add"))
            {
                string name = "";
                foreach (var item in listCategory.SelectedItems)
                {
                    name += (name == "" ? "" : " ") + item.ToString();
                }
                string[] names = name.Replace("ListViewItem: {", "").Replace("}", "").Split(' ');
                int parfumId = ((ParfumHeader)combSearchName.SelectedItem).Id;

                int categoryId = 0;
                string categoryName = "";

               

                CategoryToParfum toParfum = new CategoryToParfum();
                for (int i = 0; i < names.Length; i++)
                {
                    // Null Empty Check
                    if (string.IsNullOrEmpty(names[0]))
                    {
                        return;
                    }
                    categoryName = names[i].Trim();

                    // 
                    var categoryIdes = LoadCommonData._db.CategoryToParfums
                        .Where(dr => dr.ParfumId == parfumId)
                        .Select(ds => ds.Catogory.Name).ToList();
                    bool isAdded = false;
                    foreach (var item in categoryIdes)
                    {
                        if (categoryName == item)
                        {
                            isAdded = true;
                            break;
                        }
                    }

                    if (isAdded)
                        continue;

                    // Save
                    categoryId = LoadCommonData._db.Catogories.FirstOrDefault(dr => dr.Name.Trim().ToLower() == categoryName).Id;
                    if (categoryId != 0)
                    {
                        
                         

                        toParfum.CategoryId = categoryId;
                        toParfum.ParfumId = parfumId;
                        LoadCommonData._db.CategoryToParfums.Add(toParfum);
                        LoadCommonData._db.SaveChanges();
                        ChangeData();
                    }

                }

                ParfumMessenge.Warning("Informations Added.");
                RefresData.salePriceLists.ChangeData();

            }
        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void ChangeData()
        {
            dataGridListCategory.Rows.Clear();
            int parfumId = ((ParfumHeader)combSearchName.SelectedItem).Id;
            var categoyrs = LoadCommonData._db.CategoryToParfums.Where(dr => dr.ParfumId == parfumId)
                .Select(sd => sd.Catogory.Name).ToList();//Distinct Sil
            foreach (var item in categoyrs)
            {
                dataGridListCategory.Rows.Add(item);
            }
        }

    }
}
