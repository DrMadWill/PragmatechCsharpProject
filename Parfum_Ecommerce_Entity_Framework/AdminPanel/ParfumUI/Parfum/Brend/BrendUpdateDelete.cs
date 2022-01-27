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
using ParfumUI.Load;
using ParfumUI.Common;

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
            // Load brend
            LoadCommonData.LoadBrend(combBrend);
            combBrend.SelectedIndex = 0;
        }


        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string brend_name = "";
            try
            {
                brend_name = combBrend.SelectedItem.ToString().Trim();
            }
            catch
            {
                return;
            }

            if (string.IsNullOrEmpty(brend_name))
            {
                return;
            }

            var parfumBrend = LoadCommonData._db.Brends.FirstOrDefault(sa => sa.Name.Trim().ToLower() == brend_name.Trim().ToLower());
            if (parfumBrend != null)
            {
                textName.Text = parfumBrend.Name;
                textDescript.Text = parfumBrend.Decription;
            }
        }


        // Delete Brend
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ParfumMessenge.IsAreYouSure("Are You Sure Delete?"))
            {
                string brend_name = combBrend.SelectedItem.ToString().Trim().ToLower();

                if (string.IsNullOrEmpty(brend_name))
                {
                    ParfumMessenge.Error("Plase Information Add");
                    return;
                }

                // Brend Using
                var parfumShearchBrends = LoadCommonData._db.MidDetalParfumes.FirstOrDefault(sa => sa.Brend.Trim().ToLower() == brend_name);
                if (parfumShearchBrends != null)
                {
                    ParfumMessenge.Error("This Parfum Brend Using");
                    return;
                }

                //
                var parfumBrend = LoadCommonData._db.Brends.FirstOrDefault(ea => ea.Name.Trim().ToLower() == brend_name);
                if (parfumBrend != null)
                {
                    LoadCommonData._db.Brends.Remove(parfumBrend);
                }
                else
                {
                    ParfumMessenge.Error($"Not Found This({brend_name})");
                    return;
                }
                // Deleted
                LoadCommonData._db.SaveChanges();

                // Brend Refres
                LoadCommonData.LoadBrend(combBrend);
                combBrend.SelectedIndex = 0;

                // Brend Deleted Databes
                ParfumMessenge.Warning($"{brend_name} Deleted");
            }
        }

        // Brend Updated
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ParfumMessenge.IsAreYouSure("Updated")) 
            {
                string brend_name = combBrend.SelectedItem.ToString().Trim();
                string new_brend_name = textName.Text.Trim();
                string description = textDescript.Text.Trim();

                if (string.IsNullOrEmpty(brend_name) || string.IsNullOrEmpty(new_brend_name) || string.IsNullOrEmpty(description))
                {
                    ParfumMessenge.Error("Plase Information Add");
                    return;
                }

                // Find
                DataModelMsSql.Brend parfum_Brend = LoadCommonData._db.Brends.FirstOrDefault(a => a.Name.Trim() == brend_name);
                if (parfum_Brend != null)
                {
                    parfum_Brend.Name = new_brend_name;
                    parfum_Brend.Decription = description;
                }

                // Updated
                LoadCommonData._db.SaveChanges();

                LoadCommonData.LoadBrend(combBrend);
                combBrend.SelectedIndex = 0;

                // Refers Information Main Menu
                RefresData.salePriceLists.ChangeData();

                ParfumMessenge.Warning("Brend Update");
            }
        }
    }
}
