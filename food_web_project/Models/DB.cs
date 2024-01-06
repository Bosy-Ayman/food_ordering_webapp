using System.Collections.Generic; // Add this using statement for List<>
using System.Data.SqlClient;
using System.Data;
using food_web_project.Models.Tables;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace food_web_project.Models
{
    public class DB
    {

        // Set your actual connection string
        static string constring = "Data Source=DESKTOP-O1671VL;Initial Catalog=Final_DB;Integrated Security=True;Encrypt=False";
        SqlConnection con = new SqlConnection(constring);

        /////////////////////////////// GET CURRENT USER ////////////////////
        public int getCurrentUser()
        {
            string result = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM User", con);
                result = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return Int32.Parse(result);
        }
        public bool IsInTable(int id, string Table)
        {
            //return true;
            DataTable table = new DataTable();
            string query = "";
            if (Table == "Administrator")
                query = "select administrator_id from Employee where administrator_id = " + id;
            else if (Table == "Customer")
                query = "select customer_id from Customer where customer_id = " + id;
           
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                table.Load(cmd.ExecuteReader());
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            if (table.Rows.Count == 0)
                return false;
            return true;
        }
        public int GetUserType(int id)
        {
            if (IsInTable(id, "Administrator"))
                return 1;
            if (IsInTable(id, "Customer"))
                return 2;
            else
                return 0;
        }
        ///////////////// Get Max ID /////////////////
        public int GetMaxID(string tablename)
        {
            int maxID = 0;
            string query = "select Max(ID) from " + tablename;
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                maxID = (int)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return maxID;
        }

      
        public DataTable ReadTables(string tablename)
        {
            DataTable table = new DataTable();
            string query = "select * from " + tablename;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                table.Load(cmd.ExecuteReader());
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return table;
        }

       

     public void AddUser(int CustomerId, string CustomerName, string Email, int PhoneNumber, string Password)
        {

            string query = "INSERT INTO Customer VALUES (@customer_id , @customer_name ,@email,@the_Password)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@customer_id", CustomerId);
            cmd.Parameters.AddWithValue("@customer_name", CustomerName);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@phone_number", PhoneNumber);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            ///////////////// Login /////////////////
            public void Sign_In(int id)
            {
                string query = "update User set ID = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

        }



    }
}


