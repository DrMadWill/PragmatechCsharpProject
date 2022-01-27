using ParfumUI.Load;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ParfumUI
{
    public partial class Parfum_Function : Form
    {

        public Parfum_Function()
        {
            InitializeComponent();
        }

        private void Parfum_Function_Load(object sender, EventArgs e)
        {
            // Parfum Load 
            ChangeParfum();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            ParfumeUpdate parfumeUpdate = new ParfumeUpdate();
            parfumeUpdate.ShowDialog();
        }


        public void ChangeParfum()
        {
            var parfumDetial = LoadCommonData._db.MidDetalParfumes.ToList();
            dataGridView1.DataSource = parfumDetial;
        }

        private void btnRefres_Click(object sender, EventArgs e)
        {
            labelDataGridStatus.Text = "All Parfums";
            ChangeParfum();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string shearch = textSearchName.Text.Trim().ToLower();
            dataGridView1.DataSource = LoadCommonData._db.MidDetalParfumes.Where(dr => dr.Name.Trim().ToLower().Contains(shearch)).ToList();
            labelDataGridStatus.Text = "Search Parfum Resault";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                pictureBox1.Image = null;
                var image = LoadCommonData._db.Parfumes.Find(Id).Image;
                if (null!=image)
                {
                    MemoryStream memory = new MemoryStream(image);
                    Image ret = Image.FromStream(memory);
                    pictureBox1.Image = ret;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
