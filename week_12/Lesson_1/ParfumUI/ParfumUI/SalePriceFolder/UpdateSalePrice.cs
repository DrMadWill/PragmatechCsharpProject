﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using ParfumUI.Parfum.Load;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParfumUI.SqlModel;

namespace ParfumUI.SalePriceFolder
{

    public partial class UpdateSalePrice : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        public UpdateSalePrice()
        {
            InitializeComponent();
        }

        private void UpdateSalePrice_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadSearchName(sqlConnection, true, combSearchName);

                LoadParfumItems.LoadSize(sqlConnection, false, combSize);
                SelectedChange();
            }
        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string name = string.Empty;
                bool isException = false;
                try
                {
                    name = ((ParfumHeader)combSearchName.SelectedItem).Id.ToString();
                }
                catch (Exception ex)
                {
                    isException = true;
                }

                if (isException)
                {
                    isException = false;
                    return;
                }
                int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;

                LoadParfumItems.LoadSalePrice(sqlConnection, true, comb, Id);
            }

        }

        private void SelectedChange()
        {
            try
            {
                string size = ((SalePriceData)comb.SelectedItem).Size.ToString();
                string price = ((SalePriceData)comb.SelectedItem).Price.ToString();
                string count = ((SalePriceData)comb.SelectedItem).Count.ToString();
                combSize.SelectedItem = size;
                textPrice.Text = price;
                textNumber.Text = count;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void comb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedChange();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int Id = ((SalePriceData)comb.SelectedItem).Id;
                string newsize = combSize.SelectedItem.ToString().Trim();
                string price = textPrice.Text.Trim();
                string count = textNumber.Text.Trim();
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    foreach (var item in comb.Items)
                    {
                        if (((SalePriceData)item).Size == int.Parse(newsize) && ((SalePriceData)comb.SelectedItem).Id != ((SalePriceData)item).Id)
                        {
                            MessageBox.Show("Got this Size", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string commad = $"UPDATE SalePrice set SizeId=(select Id from Size where Size={newsize}),Price={price},number={count} where Id = {Id} ";
                    using (SqlCommand sqlCommand = new SqlCommand(commad, sqlConnection))
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Information update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // SalePriceList Refres 
                        RefresData.salePriceLists.ChangeData();
                    }


                    int index = combSearchName.SelectedIndex;
                    if (index == 0)
                    {
                        combSearchName.SelectedIndex = index+1;

                    }
                    else
                    {
                        combSearchName.SelectedIndex = index-1;
                    }
                    combSearchName.SelectedIndex = index;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                int saleId = ((SalePriceData)comb.SelectedItem).Id;
                string commad = "Delete SalePrice where Id =" + saleId;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(commad, sqlConnection))
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Information deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        int index = combSearchName.SelectedIndex;
                        if (index == 0)
                        {
                            combSearchName.SelectedIndex = index + 1;
                        }
                        else
                        {
                            combSearchName.SelectedIndex = index - 1;
                        }
                        combSearchName.SelectedIndex = index;

                        RefresData.salePriceLists.ChangeData();
                        
                    }
                    LoadSearchName(sqlConnection, false, combSearchName);
                }
            }
        }


        private void LoadSearchName(SqlConnection sqlConnection, bool isConnectionOpen, ComboBox combSearchName)
        {
            string commandSearch = "SELECT DISTINCT Id,Header FROM DeleteUpdateHeader";
            using (SqlCommand sqlCommand = new SqlCommand(commandSearch, sqlConnection))
            {
                // ComboBox Index
                int comboxIndex = 0;

                // Connection Open Candition
                LoadParfumItems.ConnectionCadditon(sqlConnection, isConnectionOpen);

                // Data Clear
                combSearchName.DataSource = null;

                // Collection Create
                List<ParfumHeader> parfumHeaders = new List<ParfumHeader>();

                bool dubilcateinfo = false;

                // Collection Clear
                parfumHeaders.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        //// Collection add
                        //foreach (var item in parfumHeaders)
                        //{
                        //    if (item.Id == Convert.ToInt32(sqlDataReader[0]))
                        //    {
                        //        dubilcateinfo = true;
                        //        break;
                        //    }
                        //}

                        //if (dubilcateinfo)
                        //{
                        //    dubilcateinfo = false;
                        //    continue;
                        //}

                        parfumHeaders.Add(new ParfumHeader(Convert.ToInt32(sqlDataReader[0]), sqlDataReader[1].ToString().Trim(), comboxIndex));
                        ++comboxIndex;
                    }
                }

                // Data Add
                combSearchName.DataSource = parfumHeaders.Distinct().ToList();
                combSearchName.DropDownStyle = ComboBoxStyle.DropDownList;
                combSearchName.SelectedIndex = 0;
            }
        }
    }
}
