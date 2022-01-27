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
using ParfumUI.Common;
using ParfumUI.DataModelMsSql;
using ParfumUI.Load;

namespace ParfumUI
{
    public partial class BrendAdd : Form
    {
        public BrendAdd()
        {
            InitializeComponent();
        }

        // Brend Add Click
        private void button1_Click(object sender, EventArgs e)
        {
            string name ="";
            string descript="";

            try
            {
                name = textName.Text.Trim();
                descript = textDescript.Text.Trim();
                if (string.IsNullOrEmpty(name))
                    throw new Exception();
            }
            catch 
            {
                ParfumMessenge.Error("Information Add");
                return;
            }



            if (ParfumMessenge.IsAreYouSure("Are You Sure Create ?"))
            {

                Brend brend = new Brend()
                {
                    Name = name,
                    Decription=descript
                };

                LoadCommonData._db.Brends.Add(brend);
                //Save
                LoadCommonData._db.SaveChanges();

                ParfumMessenge.Warning("Brend Created.");
                textName.Text = "";
                textDescript.Text = "";
            }
        }

        private void BrendAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
