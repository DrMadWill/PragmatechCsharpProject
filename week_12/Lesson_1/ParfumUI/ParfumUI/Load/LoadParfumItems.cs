using ParfumUI.SalePriceFolder;
using ParfumUI.SqlModel;
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


namespace ParfumUI.Parfum.Load
{
    public static class LoadParfumItems
    {

        
        // ----------------------------- Load Section

        private static string _connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        public static string connectionString { get { return _connectionString; } }


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



        public static void LoadSearchName(SqlConnection sqlConnection, bool isConnectionOpen, ComboBox combSearchName)
        {
            string commandSearch = "select * from SearchHead order by Header";
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

                // Collection Clear
                parfumHeaders.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        // Collection add
                        parfumHeaders.Add(new ParfumHeader(Convert.ToInt32(sqlDataReader[0]), sqlDataReader[1].ToString().Trim(), comboxIndex));
                        ++comboxIndex;
                    }
                }
                // Data Add
                combSearchName.DataSource = parfumHeaders;
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


        // Loead Procedure in SQL Server
        public static DataTable LoadSalePriceDataTable(SqlConnection sqlConnection, bool isConnectOpen, int Id)
        {
            string commad = "EXECUTE usp_SelectIdSalePirce " + Id;
            //Connect Open
            ConnectionCadditon(sqlConnection, isConnectOpen);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commad, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }


        // Loead Sale Price Table in SQL Server

        public static void LoadSalePrice(SqlConnection sqlConnection, bool isConnectOpen, ComboBox salePrice, int Id)
        {
            string commad = "select * from DeleteSalePirceUI y where y.ParfumId=" + Id;
            using (SqlCommand sqlCommand = new SqlCommand(commad, sqlConnection))
            {
                //Connect Open
                ConnectionCadditon(sqlConnection, isConnectOpen);



                // Data Clear
                salePrice.DataSource = null;


                List<SalePriceData> salePriceDatas = new List<SalePriceData>();
                salePriceDatas.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        salePriceDatas.Add(

                            new SalePriceData(Convert.ToInt32(sqlDataReader[0]), Convert.ToInt32(sqlDataReader[1]), Convert.ToInt32(sqlDataReader[2]), Convert.ToInt32(sqlDataReader[3]))

                            );
                    }
                }

                salePrice.DataSource = salePriceDatas;

                salePrice.DropDownStyle = ComboBoxStyle.DropDownList;
                //salePrice.SelectedIndex = 0;
            }
        }

        public static void ConnectionCadditon(SqlConnection sqlConnection, bool isConnectionOpen)
        {
            if (isConnectionOpen)
            {
                sqlConnection.Open();
            }
        }


        public static void LoadCategory(SqlConnection sqlConnection, bool isConnection, ComboBox combCategory)
        {
            string commandSize = "select * from Catogory";
            using (SqlCommand sqlCommand = new SqlCommand(commandSize, sqlConnection))
            {
                // Connection Candition 
                LoadParfumItems.ConnectionCadditon(sqlConnection, isConnection);

                // Data Clear
                combCategory.Items.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        combCategory.Items.Add(sqlDataReader[1].ToString().Trim());
                    }
                }
                combCategory.DropDownStyle = ComboBoxStyle.DropDownList;
                combCategory.SelectedIndex = 0;
            }
        }


        //--------------------------------- Data Bese
        public static void DataBases(SqlConnection sqlConnection, string command)
        {
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                sqlConnection.Open();

                // -----------------Information Added DataBases
                sqlCommand.ExecuteNonQuery();
            }
        }

        public static void DataBases(SqlConnection sqlConnection, string command,bool isConnect)
        {
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                // Connection Cadition
                ConnectionCadditon(sqlConnection, isConnect);

                // -----------------Information Added DataBases
                sqlCommand.ExecuteNonQuery();
            }
        }

        // ------------------ Messengae Team 

        public static void MessengeWarning(string name)
        {
            MessageBox.Show("Information "+name, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        public static void MessengeCreate()
        {
            MessageBox.Show("Information Created", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void MessengeUpdate()
        {
            MessageBox.Show("Information Update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void MessengeDelete()
        {
            MessageBox.Show("Information Delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        // ------------------ Database Load
        public static DataTable DataBeseRead(SqlConnection sqlConnection,string command,bool isConnection)
        {
            ConnectionCadditon(sqlConnection, isConnection);

            // ----------------Parfum Read Databese

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static void LoadItem(SqlConnection sqlConnection,string command, bool isConnectionOpen, ComboBox combobox)
        {
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                // Connection Open Candition
                ConnectionCadditon(sqlConnection, isConnectionOpen);

                // Data Clear
                combobox.Items.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        combobox.Items.Add(sqlDataReader[0].ToString().Trim());
                    }
                }
            }
            combobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        public static void UpdateLoadSearchName(SqlConnection sqlConnection, bool isConnectionOpen, ComboBox combSearchName)
        {
            string commandSearch = "select * from DeleteHeaders";
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
                        parfumHeaders.Add(new ParfumHeader(Convert.ToInt32(sqlDataReader[0]), sqlDataReader[1].ToString().Trim(), comboxIndex));
                        ++comboxIndex;
                    }
                }

                // Data Add
                combSearchName.DataSource = parfumHeaders.ToList();
                combSearchName.DropDownStyle = ComboBoxStyle.DropDownList;
                combSearchName.SelectedIndex = 0;
            }
        }

        public static bool IsAreYouSure()
        {
            bool isSure = false;
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                isSure = true;
            }
            return isSure;
        }

        public static bool IsAreYouSure(string name)
        {
            bool isSure = false;
            DialogResult result = MessageBox.Show($"Are you sure {name} ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                isSure = true;
            }
            return isSure;
        }
    }
}
