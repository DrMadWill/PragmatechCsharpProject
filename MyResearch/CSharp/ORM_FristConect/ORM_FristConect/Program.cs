using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ORM_FristConect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //GetConnect();
            GetMySQLConnect();

        }

        static void GetConnect()
        {
            string connectionString = @"Data Source = .\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security = SSPI;";
          
            using (var connection = new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    Console.WriteLine("Connected");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);

                }
                finally
                {
                    connection.Close();
                }



            }



        }

        static void GetMySQLConnect()
        {
            string connectionString = @"server=localhost;port=3306;database=drmadwill;user =root; password=mypass";

            using (var connection = new MySqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    Console.WriteLine("Connected");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);

                }
                finally
                {
                    connection.Close();
                }



            }



        }

    }
}
