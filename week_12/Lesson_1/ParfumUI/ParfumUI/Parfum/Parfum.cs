using ParfumUI.Parfum.Load;
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

namespace ParfumUI.Parfum
{
    public static class Parfum
    {


        //---------------------------------- Parfum Read
        public static DataTable ReadParfum(SqlConnection sqlConnection)
        {
            // Sql Commad
            string command = "select * from MidDetalParfume";
            sqlConnection.Open();
            // ----------------Parfum Read Databese
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }


        //---------------------------------- Parfum Update
        public static void UpdateParfum(int Id,string name,string image,string decription,string brend,string gender,string density, SqlConnection sqlConnection)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(brend) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(density))
            {
                MessageBox.Show("Name,Brend,Gender and Density is required", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Sql Commad
                string command = $"EXECUTE usp_UpdateParfum @Id={Id},@Name = '{name}',@Image='{image}',@Descriptio = '{decription}',@Brend = '{brend}', @Gender = '{gender}',@Density ='{density}'";
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlConnection.Open();

                    // -----------------Parfum Update DataBases
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Information updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        //---------------------------------- Parfum Add
        public static void CreateParfum(string name,string image,string description,string brend,string gender,string density,SqlConnection sqlConnection)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(brend) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(density))
            {
                MessageBox.Show("Name,Brend,Gender and Density is required", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Sql Commad
                string command = $"EXECUTE usp_AddParfum @Name = '{name}',@Image='{image}',@Descriptio = '{description}',@Brend = '{brend}', @Gender = '{gender}',@Density ='{density}'";
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlConnection.Open();
                    //-------------------Parfum Add DataBase
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Information added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        //---------------------------------- Parfum Delete
        public static void DeleteParfum(int Id,SqlConnection sqlConnection)
        {
            // Sql Commad
            string command = $"EXECUTE usp_DeleteParfum " + Id;
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                sqlConnection.Open();

                //------------------------ Delete Parfum DataBases
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Information deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }


        public static bool IsAdd(SqlConnection sqlConnection, string name,string bend)
        {
            bool isAdd = false;
            string commad = "select * from MidDetalParfume where Name in ('Miss Dior') and Brend in ('asd')";
            using (SqlCommand sqlCommand = new SqlCommand(commad, sqlConnection))
            {
                sqlConnection.Open();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {

                    }
                }
            }



            return isAdd;
        }


    }
}
