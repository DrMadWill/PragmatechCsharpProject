using ParfumUI.DataModelMsSql;
using ParfumUI.Load;
using ParfumUI.Users;
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
    public partial class SalePriceLists : Form
    {

        private string _username;
        public string UserName { get { return _username; } }
        List<FullDetailParfum> fulls = new List<FullDetailParfum>();

        List<FullDetailParfum> detailParfums = new List<FullDetailParfum>();
        public SalePriceLists(string admin_name)
        {
            InitializeComponent();
            _username = admin_name;

        }

        private void SalePriceLists_Load(object sender, EventArgs e)
        {
            textUser.Text = UserName;
            LoadCatogory();
            ChangeData();
            
        }


        public void ChangeData()
        {
            dataGridView1.DataSource = null;
            dataGridShearch.DataSource = null;

            fulls = LoadCommonData._db.FullDetailParfums.ToList();
            dataGridView1.DataSource = fulls;
            textcatogory.Text = "All Parfums";
            
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {

            dataGridShearch.DataSource=null; ;
            string name = textSearchName.Text.Trim();

            if (string.IsNullOrEmpty(name))
                return;

            detailParfums.Clear();
            foreach (var item in fulls)
            {
                if(item.Name.Trim().ToLower().Contains(name.ToLower()))
                    detailParfums.Add(item);

            }
            dataGridShearch.DataSource = detailParfums;

        }


        private void btn_allparfums_Click(object sender, EventArgs e)
        {
            ChangeData();
        }


        public void LoadCatogory()
        {
            combCatogory.Items.Clear();
            var categorys = LoadCommonData._db.Catogories.Select(dr => dr.Name);
            foreach (var item in categorys)
            {
                combCatogory.Items.Add(item);
            }

            combCatogory.DropDownStyle = ComboBoxStyle.DropDownList;
            combCatogory.SelectedIndex = 0;
        }

        private void combCatogory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCatogory();
        }



        public void ChangeCatogory()
        {

            string catogory = combCatogory.SelectedItem.ToString().Trim();
            var parfumIds = LoadCommonData._db.CategoryToParfums.Where(dr => dr.Catogory.Name == catogory).Select(sd=>sd.ParfumId);
            dataGridView1.DataSource = null;
            dataGridShearch.DataSource = null; ;

            fulls.Clear();

            foreach (var item in parfumIds)
            {
                fulls.AddRange(LoadCommonData._db.FullDetailParfums.Where(dr=>dr.Id==item).ToList());
            }
            dataGridView1.DataSource = fulls;
            textcatogory.Text = catogory;

        }

          
        private void acivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserActivityMonitor userActivityMonitor = new UserActivityMonitor();
            userActivityMonitor.ShowDialog();
        }

        private void saleAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSaleMonitor userSaleMonitor = new UserSaleMonitor();
            userSaleMonitor.ShowDialog();
        }
       

        private void parfumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parfum_Function parfum_Function = new Parfum_Function();
            RefresData.parfum_Function = parfum_Function;
            parfum_Function.ShowDialog();
        }
    }
}
