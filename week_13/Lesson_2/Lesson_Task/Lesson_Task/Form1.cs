
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
namespace Lesson_Task
{
    public partial class Form1 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Lesson_Task.Properties.Settings.Setting"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeData();

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            textStudentId.Text = "";
            textStName.Text = "";
            textCourse.Text = "";
            textAge.Text = "";
        }

        private void btnSeve_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure save?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {


                int rull = Convert.ToInt32(textStudentId.Text);
                string stname = textStName.Text;
                string coruse = textCourse.Text;
                int age = Convert.ToInt32(textAge.Text);

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {

                    string command = $"Insert into Person(Name,StudentId,Age,Course)values('{stname}',{rull},{age},'{coruse}')";
                    using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Information added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ChangeData();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure update?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                int rull = Convert.ToInt32(textStudentId.Text);
                string stname = textStName.Text;
                string coruse = textCourse.Text;
                int age = Convert.ToInt32(textAge.Text);

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {

                    string command = $"Update Person set Name='{stname}',Course='{coruse}',Age={age} where Person.StudentId={rull}";
                    using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Information updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ChangeData();
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "select * from Person where Person.StudentId=" + textStudentId.Text;
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            textStName.Text = sqlDataReader[1].ToString();
                            textAge.Text = sqlDataReader[3].ToString();
                            textCourse.Text = sqlDataReader[4].ToString();
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int rull = Convert.ToInt32(textStudentId.Text);
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {

                    string command = $"delete Person where StudentId={rull}";
                    using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Information Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ChangeData();
                    }
                }
            }
        }


        private void ChangeData()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                // Sql Commad
                string commad = "select * from People order by StudentId";
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commad, sqlConnection))
                {
                    // SQL Connection Open
                    sqlConnection.Open();
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                }
            }
        }
    }
}
