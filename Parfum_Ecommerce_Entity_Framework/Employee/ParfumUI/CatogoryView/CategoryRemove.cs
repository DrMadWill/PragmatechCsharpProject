using ParfumUI.Common;
using ParfumUI.DataModelMsSql;
using ParfumUI.Load;
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
            CategoryElementChange();
        }

        public void CategoryElementChange()
        {
            string category = combCategory.SelectedItem.ToString().Trim();
            var categorySelected = LoadCommonData._db.DeleteUpdateCategoryToParfums.Where(dr => dr.Category.ToLower() == category.ToLower()).Select(dr => dr.Header);
            listParfums.Items.Clear();
            foreach (var item in categorySelected)
            {
                listParfums.Items.Add(item);
            }
        }

        private void CategoryRemove_Load(object sender, EventArgs e)
        {
            LoadCommonData.LoadCategory(combCategory);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ParfumMessenge.IsAreYouSure(" Are You Remove?"))
            {
                string name = "";
                foreach (var item in listParfums.SelectedItems)
                {
                    name += (name == "" ? "" : ",") + item.ToString();
                }
                string[] names = name.Replace("ListViewItem: {", "").Replace("}", "").Split(',');

                string category = combCategory.SelectedItem.ToString().Trim();
                StringBuilder info = new StringBuilder();
                for (int i = 0; i < names.Length; i++)
                {
                    // No Selected
                    if (string.IsNullOrEmpty(names[0]))
                    {
                        ParfumMessenge.Error("You Must Be Selecet Some Elemet");
                        return;
                    }

                    //
                    string header = names[i];
                    info.Append(header);
                   if(names.Length!=1)
                        info.Append(",");

                    var categoryToParfumId = LoadCommonData._db.DeleteUpdateCategoryToParfums
                        .FirstOrDefault(dr => dr.Header.ToLower() == header.ToLower() && dr.Category.ToLower() == category.ToLower()).Ids;

                    if (categoryToParfumId != 0)
                    {
                        var categoryToParfums = LoadCommonData._db.CategoryToParfums
                            .Find(categoryToParfumId);
                        if (categoryToParfums != null)
                        {
                            LoadCommonData._db.CategoryToParfums.Remove(categoryToParfums);
                            LoadCommonData._db.SaveChanges();
                        }

                    }

                }

                ParfumMessenge.Warning($"{info} Removed From {category}");
                RefresData.salePriceLists.ChangeData();
                CategoryElementChange();

            }
        }
    }
}
