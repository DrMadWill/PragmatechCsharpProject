using System;
using System.Collections.Generic;
using ParfumUI.Parfum.Load;
using ParfumUI.SalePriceFolder.Volume;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParfumUI.SalePriceFolder.Volume
{
    public partial class VolumeAdd : Form
    {
        public VolumeAdd()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;


        private void btnVolumeAdd_Click(object sender, EventArgs e)
        {
            int volume = Convert.ToInt32(textVolume.Text.Trim());
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                VolumeAddItem(sqlConnection, volume);
            }
        }

        private void VolumeAddItem(SqlConnection sqlConnection,int volume)
        {  
            string commad = $"Insert into Size(Size)values({volume})";
            using (SqlCommand sqlCommand = new SqlCommand(commad, sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                RefresData.salePrice.ChangeSize();
                MessageBox.Show("Information added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textVolume.Text = "";
            }
        }
    }
}
