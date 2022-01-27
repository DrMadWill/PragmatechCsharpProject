using ParfumUI.Common;
using ParfumUI.DataModelMsSql;
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

namespace ParfumUI.Load
{
    public static class LoadCommonData
    {
        public static ParfumeEntitiesDb _db = new ParfumeEntitiesDb();

        public static void LoadBrend(ComboBox combBrend)
        {
            
            // Clear Item
            combBrend.Items.Clear();

            // Data Base Load
            var parfum_brends = _db.Brends
                .Select(b=>new { b.Name})
                .OrderBy(a => a.Name);
            foreach (var item in parfum_brends)
            {
                combBrend.Items.Add(item.Name);
            }
            combBrend.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        // Density Load
        public static void LoadDensity(ComboBox combDensity)
        {

            // Data Clear
            combDensity.Items.Clear();

            var denstins = _db.Densities.Select(dr => dr.Name);
            foreach (var item in denstins)
            {
                combDensity.Items.Add(item);
            }
            combDensity.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Gender Load
        public static void LoadGender(ComboBox combGender)
        {

            combGender.Items.Clear();

            var genders = _db.Genders.Select(dr => dr.Name);
            foreach (var item in genders)
            {
                combGender.Items.Add(item);
            }
            combGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Search Name Loead
        public static void LoadSearchName(ComboBox combSearchName)
        {
            
            // ComboBox Index
            int comboxIndex = 0;

            // Data Clear
            combSearchName.DataSource = null;

            // Collection Create
            List<ParfumHeader> parfumHeaders = new List<ParfumHeader>();

            // Collection Clear
            parfumHeaders.Clear();


            var searchHeader = _db.SearchHeads.OrderBy(dr => dr.Header).ToList();

            foreach (var item in searchHeader)
            {
                // Collection add
                parfumHeaders.Add(new ParfumHeader(item.Id,item.Header, comboxIndex));
                ++comboxIndex;
            }


            // Data Add
            combSearchName.DataSource = parfumHeaders;
            combSearchName.DropDownStyle = ComboBoxStyle.DropDownList;
            combSearchName.SelectedIndex = 0;

        }

        // Category Load
        public static void LoadCategory(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            var categorys = LoadCommonData._db.Catogories.Select(dr => dr.Name);
            if (categorys != null)
            {
                foreach (var item in categorys)
                {
                    comboBox.Items.Add(item);
                }
            }
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndex = 0;
        }

        // 

        public static void LoadSize(ComboBox comboBox)
        {

            comboBox.Items.Clear();
            var categorys = LoadCommonData._db.Sizes.Select(dr => dr.Size1);
            if (categorys != null)
            {
                foreach (var item in categorys)
                {
                    comboBox.Items.Add(item);
                }
            }
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndex = 0;
        }


        public static bool CheckLogin(string login)
        {

            bool isUsable = false;
            // Login Check
            if (login.Length >= 75 || login.Length <= 10)
            {
                ParfumMessenge.Error("Login So Sort or Long");
                isUsable = true;
            }
            return isUsable;
        }

        public static bool CheckPassword(string password)
        {
            bool isUsable = false;
            // Pasword Check
            if (password.Length >= 75 || password.Length <= 8 || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit))
            {
                ParfumMessenge.Error($"This {password} Not usable. Upper and Lower Letter and Digit add");
                isUsable = true;
            }

            return isUsable;
        }
    }
}
