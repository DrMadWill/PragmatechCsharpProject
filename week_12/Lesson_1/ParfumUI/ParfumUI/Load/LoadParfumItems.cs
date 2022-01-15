﻿using System;
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


namespace ParfumUI.Parfum.Load
{
    public static class LoadParfumItems
    {

        
        // ----------------------------- Load Section

        public static void LoadBrend(SqlConnection sqlConnection, bool isConnectionOpen,ComboBox combBrend, Dictionary<string, int> BrendId)
        {
            string commandBrend = "select Name from Brend group by (Name)";
            int brendIndex = 0;
            using (SqlCommand sqlCommand = new SqlCommand(commandBrend, sqlConnection))
            {
                // Connection Open Candition
                ConnectionCadditon(sqlConnection, isConnectionOpen);

                // Clear Item
                combBrend.Items.Clear();
                BrendId.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {

                    while (sqlDataReader.Read())
                    {

                        combBrend.Items.Add(sqlDataReader[0].ToString().Trim());
                        BrendId.Add(sqlDataReader[0].ToString().Trim(), brendIndex);
                        ++brendIndex;

                    }
                }
                combBrend.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }

        public static void LoadBrend(SqlConnection sqlConnection, bool isConnectionOpen, ComboBox combBrend)
        {
            string commandBrend = "select Name from Brend group by (Name)";
            using (SqlCommand sqlCommand = new SqlCommand(commandBrend, sqlConnection))
            {
                // Connection Open Candition
                ConnectionCadditon(sqlConnection, isConnectionOpen);

                // Clear Item
                combBrend.Items.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {

                    while (sqlDataReader.Read())
                    {
                        combBrend.Items.Add(sqlDataReader[0].ToString().Trim());
                    }
                }
                combBrend.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }



        public static void LoadDensity(SqlConnection sqlConnection, bool isConnectionOpen, ComboBox combDensity, Dictionary<string, int> DensityId)
        {
            string commandDensity = "select Name from Density";
            int densityIndex = 0;
            using (SqlCommand sqlCommand = new SqlCommand(commandDensity, sqlConnection))
            {
                // Connection Open Candition
                ConnectionCadditon(sqlConnection, isConnectionOpen);

                // Data Clear
                combDensity.Items.Clear();
                DensityId.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        combDensity.Items.Add(sqlDataReader[0].ToString().Trim());
                        DensityId.Add(sqlDataReader[0].ToString().Trim(), densityIndex);
                        ++densityIndex;
                    }
                }
                combDensity.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }

        public static void LoadDensity(SqlConnection sqlConnection, bool isConnectionOpen, ComboBox combDensity)
        {
            string commandDensity = "select Name from Density";
            using (SqlCommand sqlCommand = new SqlCommand(commandDensity, sqlConnection))
            {
                // Connection Open Candition
                ConnectionCadditon(sqlConnection, isConnectionOpen);

                // Data Clear
                combDensity.Items.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        combDensity.Items.Add(sqlDataReader[0].ToString().Trim());
                    }
                }
                combDensity.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }


        public static void LoadGender(SqlConnection sqlConnection, bool isConnectionOpen, ComboBox combGender, Dictionary<string, int> GenderId)
        {
            string commandGender = "select Name from Gender";
            int selectIndex = 0;
            using (SqlCommand sqlCommand = new SqlCommand(commandGender, sqlConnection))
            {
                // Connection Open Candition
                ConnectionCadditon(sqlConnection, isConnectionOpen);

                // Data Clear
                combGender.Items.Clear();
                GenderId.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        combGender.Items.Add(sqlDataReader[0].ToString().Trim());
                        GenderId.Add(sqlDataReader[0].ToString().Trim(), selectIndex);
                        ++selectIndex;
                    }
                }
            }
            combGender.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public static void LoadGender(SqlConnection sqlConnection, bool isConnectionOpen, ComboBox combGender)
        {
            string commandGender = "select Name from Gender";
            using (SqlCommand sqlCommand = new SqlCommand(commandGender, sqlConnection))
            {
                // Connection Open Candition
                ConnectionCadditon(sqlConnection, isConnectionOpen);

                // Data Clear
                combGender.Items.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        combGender.Items.Add(sqlDataReader[0].ToString().Trim());
                    }
                }
            }
            combGender.DropDownStyle = ComboBoxStyle.DropDownList;

        }


        public static void LoadSearchName(SqlConnection sqlConnection, bool isConnectionOpen,ComboBox combSearchName, Dictionary<string, int> ParfumNameToID)
        {
            string commandSearch = "select * from SearchHead order by Header";
            using (SqlCommand sqlCommand = new SqlCommand(commandSearch, sqlConnection))
            {
                // Connection Open Candition
                ConnectionCadditon(sqlConnection, isConnectionOpen);

                // Data Clear
                combSearchName.Items.Clear();
                ParfumNameToID.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        combSearchName.Items.Add(sqlDataReader[1].ToString().Trim());
                        ParfumNameToID.Add(sqlDataReader[1].ToString().Trim(), Convert.ToInt32(sqlDataReader[0]));
                    }
                }

                combSearchName.DropDownStyle = ComboBoxStyle.DropDownList;
                combSearchName.SelectedIndex = 0;
            }
        }


        public static void LoadSize(SqlConnection sqlConnection, bool isConnectionOpen, ComboBox combSize)
        {
            string commandSize = "select * from Size";
            using (SqlCommand sqlCommand = new SqlCommand(commandSize, sqlConnection))
            {
                // Connection Open Candition
                ConnectionCadditon(sqlConnection, isConnectionOpen);

                // Data Clear
                combSize.Items.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        combSize.Items.Add(sqlDataReader[1].ToString().Trim());
                    }
                }

                combSize.DropDownStyle = ComboBoxStyle.DropDownList;
                combSize.SelectedIndex = 0;
            }
        }

        public static DataTable LoadSalePrice(SqlConnection sqlConnection, bool isConnectOpen, int Id)
        {
            string commad = "EXECUTE usp_SelectIdSalePirce " + Id;
            //Connect Open
            ConnectionCadditon(sqlConnection, isConnectOpen);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commad, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static void LoadSalePrice(SqlConnection sqlConnection, bool isConnectOpen,ComboBox salePrice,int Id, Dictionary<string, int> SalePriceId)
        {
            string commad = "select * from DeleteSalePirceUI y where y.ParfumId=" + Id;
            using (SqlCommand sqlCommand = new SqlCommand(commad, sqlConnection))
            {
                //Connect Open
                ConnectionCadditon(sqlConnection, isConnectOpen);

                // Data Clear
                salePrice.Items.Clear();
                SalePriceId.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Clear();
                    while (sqlDataReader.Read())
                    {
                        stringBuilder.Append(sqlDataReader[1].ToString().Trim() + "ML / " + sqlDataReader[2].ToString().Trim() + "AZN / " + sqlDataReader[3].ToString().Trim());
                        salePrice.Items.Add(stringBuilder.ToString());
                        SalePriceId.Add(stringBuilder.ToString(),Convert.ToInt32(sqlDataReader[0]));
                        stringBuilder.Clear();
                        
                    }
                }

                salePrice.DropDownStyle = ComboBoxStyle.DropDownList;
                salePrice.SelectedIndex = 0;
            }
        }


        public static void ConnectionCadditon(SqlConnection sqlConnection, bool isConnectionOpen)
        {
            if (isConnectionOpen)
            {
                sqlConnection.Open();
            }
        }

    }
}
