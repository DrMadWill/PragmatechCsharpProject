using ParfumUI.Load;
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
using System.IO;

namespace ParfumUI
{
    public partial class ParfumeUpdate : Form
    {

        int ParfumId = 0;
        string parfumFulName = "";
        public ParfumeUpdate()
        {
            InitializeComponent();
        }

        private void ParfumeUpdate_Load(object sender, EventArgs e)
        {
            LoadCommonData.LoadBrend(combBrend);
            LoadCommonData.LoadDensity(combDensity);
            LoadCommonData.LoadGender(combGender);
            combBrend.SelectedIndex = 0;
            combDensity.SelectedIndex = 0;
            combGender.SelectedIndex = 0;
            textImage.ReadOnly = true;
            ChangeData();
        }

        public void ChangeData()
        {
            var allparfums = LoadCommonData._db.MidDetalParfumes.ToList();
            dataGridViewUpdate.DataSource = allparfums;
        }

        private void dataGridViewUpdate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewUpdate.SelectedRows.Count > 0)
            {
                textName.Text =  dataGridViewUpdate.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                textDescription.Text = dataGridViewUpdate.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                combBrend.SelectedItem  = dataGridViewUpdate.Rows[e.RowIndex].Cells["Brend"].Value.ToString();
                combGender.SelectedItem = dataGridViewUpdate.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                combDensity.SelectedItem = dataGridViewUpdate.Rows[e.RowIndex].Cells["Density"].Value.ToString();

                int Id = int.Parse(dataGridViewUpdate.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                var img = LoadCommonData._db.Parfumes.Find(Id).Image;
                pictureBox1.Image = null;
                if (null!=img)
                {
                    MemoryStream memory = new MemoryStream(img);
                    Image ret = Image.FromStream(memory);
                    pictureBox1.Image = ret;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                ParfumId =Convert.ToInt32(dataGridViewUpdate.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                parfumFulName = combBrend.SelectedItem.ToString()+"/" + textName.Text;

            }
        }

        private void btnUpfate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parfumFulName) || ParfumId==0)
            {
                ParfumMessenge.Error("You Must Be Seleced Parfum From Parfum List");
                return;
            }
            if (ParfumMessenge.IsAreYouSure($"Are you {parfumFulName} Update"))
            {
                string name = textName.Text.Trim();
                string image = textImage.Text.Trim();
                string decrip = textDescription.Text.Trim();
                string brend = combBrend.SelectedItem.ToString().Trim();
                string gender = combGender.SelectedItem.ToString().Trim();
                string density = combDensity.SelectedItem.ToString().Trim();


                // find BrendId
                int brendId = LoadCommonData._db.Brends
                    .Select(es => new { es.Id, es.Name })
                    .FirstOrDefault(ead => ead.Name.Trim().ToLower() == brend.ToLower()).Id;

                // Find gender
                int gederId = LoadCommonData._db.Genders
                    .Select(es => new { es.Id, es.Name })
                    .FirstOrDefault(ead => ead.Name.Trim().ToLower() == gender.ToLower()).Id;

                // Find gender
                int densityId = LoadCommonData._db.Densities
                    .Select(es => new { es.Id, es.Name })
                    .FirstOrDefault(ead => ead.Name.Trim().ToLower() == density.ToLower()).Id;

                var parfumIsAdd = LoadCommonData._db.Parfumes
                    .FirstOrDefault(es => es.Name.Trim().ToLower() == name.ToLower() && es.BrendId == brendId && es.Id!=ParfumId);

                // Parfum Added Check
                if (parfumIsAdd != null)
                {
                    ParfumMessenge.Error("This Parfum Already Added");
                    return;
                }

                var parfumUpdate = LoadCommonData._db.Parfumes.FirstOrDefault(es => es.Id == ParfumId);
                if (parfumUpdate != null)
                {
                    parfumUpdate.Name = name;
                    parfumUpdate.Description = decrip;
                    parfumUpdate.DensityId = densityId;
                    parfumUpdate.BrendId = brendId;
                    parfumUpdate.GenderId = gederId;
                    if(!string.IsNullOrEmpty(image))
                        parfumUpdate.Image = File.ReadAllBytes(@image);
                    LoadCommonData._db.SaveChanges();
                }
                // Save
               


                // Change DataGridView
                RefresData.parfum_Function.ChangeParfum();

                ClearBoxs();

                ChangeData();

                ParfumMessenge.Warning("Parfum Updated");

                
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ParfumMessenge.IsAreYouSure("Are You Sure Create ?"))
            {
                string name = textName.Text.Trim();
                string image = textImage.Text.Trim();
                string decrip = textDescription.Text.Trim();
                string brend = combBrend.SelectedItem.ToString().Trim();
                string gender = combGender.SelectedItem.ToString().Trim();
                string density = combDensity.SelectedItem.ToString().Trim();


                // find BrendId
                int brendId = LoadCommonData._db.Brends
                    .Select(es => new { es.Id, es.Name })
                    .FirstOrDefault(ead => ead.Name.Trim().ToLower() == brend.ToLower()).Id;

                // Find gender
                int gederId = LoadCommonData._db.Genders
                    .Select(es => new { es.Id, es.Name })
                    .FirstOrDefault(ead => ead.Name.Trim().ToLower() == gender.ToLower()).Id;

                // Find gender
                int densityId = LoadCommonData._db.Densities
                    .Select(es => new { es.Id, es.Name })
                    .FirstOrDefault(ead => ead.Name.Trim().ToLower() == density.ToLower()).Id;

                var parfumIsAdd = LoadCommonData._db.Parfumes
                    .FirstOrDefault(es => es.Name.Trim().ToLower() == name.ToLower() && es.BrendId == brendId);

                // Parfum Added Check
                if (parfumIsAdd != null)
                {
                    ParfumMessenge.Error("This Parfum Already Added");
                    return;
                }

                // Parfum
                Parfume parfume = new Parfume()
                {
                    Name = name,
                    Description = decrip,
                    BrendId = brendId,
                    GenderId = gederId,
                    DensityId = densityId,
                };

                if (!string.IsNullOrEmpty(image))
                    parfume.Image = File.ReadAllBytes(@image);

                LoadCommonData._db.Parfumes.Add(parfume);
                // Save
                LoadCommonData._db.SaveChanges();

                // Change DataGridView
                RefresData.parfum_Function.ChangeParfum();

                ClearBoxs();
                ParfumMessenge.Warning($"{name} Parfum Created");
                
                ChangeData();
            }
        }

        private void ClearBoxs()
        {
            // Clear Boxs
            pictureBox1.Image = null;
            textName.Text = "";
            textImage.Text = "";
            textDescription.Text = "";
            combBrend.SelectedIndex = 0;
            combGender.SelectedIndex = 0;
            combDensity.SelectedIndex = 0;
            ParfumId = 0;
            parfumFulName = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogImage.ShowDialog();
            if(result == DialogResult.OK)
            {
                string imglocation = openFileDialogImage.FileName;
                pictureBox1.Load(imglocation);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                textImage.Text = imglocation.Trim();
            }
        }
    }
}