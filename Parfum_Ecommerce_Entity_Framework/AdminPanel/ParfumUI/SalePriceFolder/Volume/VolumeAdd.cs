using System;
using System.Collections.Generic;
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
using ParfumUI.Load;
using ParfumUI.Common;

namespace ParfumUI.SalePriceFolder.Volume
{
    public partial class VolumeAdd : Form
    {
        public VolumeAdd()
        {
            InitializeComponent();
        }
        private void btnVolumeAdd_Click(object sender, EventArgs e)
        {
            int volume;
            try
            {
                volume = Convert.ToInt32(textVolume.Text.Trim());
            }
            catch
            {
                ParfumMessenge.Error("You Must Be Write Number");
                return;
            }
            if(ParfumMessenge.IsAreYouSure($"Are You Sure Add {volume}"))
            {
                if (IsAddedSize(volume))
                {
                    return;
                }
                DataModelMsSql.Size size = new DataModelMsSql.Size()
                {
                    Size1 = volume
                };
                LoadCommonData._db.Sizes.Add(size);
                LoadCommonData._db.SaveChanges();
                textVolume.Text = "";
                LoadCommonData.LoadSize(combSize);
                ParfumMessenge.Warning($"{volume} Added");
                // Sale Price Panel Refers
                RefresData.salePrice.ChangeSize();
            }
        }

        private void VolumeAdd_Load(object sender, EventArgs e)
        {
            LoadCommonData.LoadSize(combSize);
        }

        private void btnSizeUpdate_Click(object sender, EventArgs e)
        {
            int oldsize;
            int newsize;
            try
            {
                oldsize = int.Parse(combSize.SelectedItem.ToString());
                newsize = int.Parse(textVolume.Text);
            }
            catch
            {
                ParfumMessenge.Error("You Must Be Write Number");
                return;
            }
            if (ParfumMessenge.IsAreYouSure($"Are You Sure Update {oldsize}?"))
            {
                if (IsAddedSize(newsize))
                {
                    return;
                }

                var updatesize = LoadCommonData._db.Sizes.FirstOrDefault(dr => dr.Size1 == oldsize);
                if (updatesize != null)
                {
                    updatesize.Size1 = newsize;
                }
                LoadCommonData._db.SaveChanges();
                ParfumMessenge.Warning($"{oldsize} Size Updated");
                LoadCommonData.LoadSize(combSize);
                // Sale Price Panel Refers
                RefresData.salePrice.ChangeSize();

            }
        }

        private bool IsAddedSize(int size)
        {
            bool isadded = false;
            var isAddedSize = LoadCommonData._db.Sizes.FirstOrDefault(dr => dr.Size1 == size);
            if (isAddedSize != null || size==0)
            {
                ParfumMessenge.Error("Is Already Added or You Write Number=> 0");
                isadded = true;
            }
            return isadded;
        }
    }
}
