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
        static string constring = "Data Source=DESKTOP-O1671VL;Initial Catalog=Final_DB;Integrated Security=True";
        SqlConnection con = new SqlConnection(constring);

        /////////////////////////////// GET CURRENT USER ////////////////////
        public int getCurrentUser()
        {
            string result = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", con);
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
                query = "select administrator_id from Administrator where administrator_id = " + id;
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


        /////////////////////////////// Add USER///////////////////////////////////////////
        public void AddUser(string CustomerName, string Email, string PhoneNumber, string Password)
        {
            string query = "INSERT INTO Customer (customer_id, customer_name, email, phone_number, the_Password) " +
                           "VALUES (@customer_id, @customer_name, @email, @phone_number, @the_Password)";
            SqlCommand cmd = new SqlCommand(query, con);

            int nextCustomerId = GetMaxID("Customer") + 1;

            cmd.Parameters.AddWithValue("@customer_id", nextCustomerId);
            cmd.Parameters.AddWithValue("@customer_name", CustomerName);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@phone_number", PhoneNumber);
            cmd.Parameters.AddWithValue("@the_Password", Password);

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


        ///////////////// Login /////////////////
        public void Login(int CustomerId)
        {
            string query = "UPDATE Customer SET ID = @CustomerId WHERE customer_id = @CustomerId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
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

        ///////////////// Get User ID /////////////////
        public int GetUserID(string Email)
        {
            if (Email == null)
            {
                throw new ArgumentNullException(nameof(Email), "Email cannot be null.");
            }

            string query = "SELECT customer_id FROM Customer WHERE email = @Email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Email", Email);

            int ID = 0;

            try
            {
                con.Open();
                var result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    ID = Convert.ToInt32(result);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return ID;
        }

        ///////////////// Get Current User /////////////////
        public int GetCurrentUserID()
        {
            string query = "select * from Customer";
            SqlCommand cmd = new SqlCommand(query, con);
            int ID = 0;
            try
            {
                con.Open();
                ID = (int)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return ID;
        }

        ///////////////// Get Current User Name /////////////////
        public string GetCurrentUserName(int id)
        {
            string query = "select customer_name from Customer where ID = " + id;
            SqlCommand cmd = new SqlCommand(query, con);
            string name = " ";
            try
            {
                con.Open();
                name = (string)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return name;
        }
        ///////////////// Get Password /////////////////
        public string GetPassword(int id)
        {
            string query = "select the_password from Customer where id = " + id;
            SqlCommand cmd = new SqlCommand(query, con);
            string password = "";
            try
            {
                con.Open();
                password = (string)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return password;
        }
        //////////////////////////// Edit Password ////////////////////////////
        public string Alterpassword(int Password)
        {
            string UpdatePassword = "";

            string query = "UPDATE Customer SET the_password = @Password WHERE customer_id = @CustomerId;";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.Parameters.AddWithValue("@the_password", Password);


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return UpdatePassword;
        }
       /* public string Alterpassword(int Password)
        {
            string UpdatePassword = "";

            string query = "UPDATE Customer SET the_Password = @Password WHERE customer_id = @CustomerId;";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                table.Load(cmd.ExecuteReader());
                cmd.Parameters.AddWithValue("@NewPassword", Password);


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return UpdatePassword;
        }
*/


        /*    }
            public string applycoupon(int promotion)
            {
                string res = string.Empty;
                string query = "DECLARE coupon_id INT = @coupon_id;  SELECT discount_Percentage FROM promotion WHERE coupon_id = @coupon_id;";
                try
                {
                    con.Open();
                    query.Load(cmd.ExecuteReader());

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return res;
            }

            public string Getcoupon(int promotion)
            {
                string res = string.Empty;
                string query = "DECLARE coupon_id INT = @coupon_id;  IF EXISTS (SELECT 1 FROM promotion WHERE coupon_id = @coupon_id)   PRINT 'Coupon ID exists.'; ELSE    PRINT 'Coupon ID does not exist.';";
                try
                {
                    con.Open();
                    query.Load(cmd.ExecuteReader());

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return res;
            }*/

        ///////////////////////////////// Update Password ///////////////////////////////////
        public void UpdatePassword(string connectionString, int CustomerId, string newPassword)
        {
            string updateQuery = "UPDATE Users SET the_password = @NewPassword WHERE customer_id = @CustomerId";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@the_password", newPassword);
                        command.Parameters.AddWithValue("@customer_id", CustomerId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Password updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("User not found or password update failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        ////////////////calculate total o=price//////////
       /* public decimal CalculateTotalPrice(int OrderID)
        {
            decimal totalPrice = 0 ;

            string query = "SELECT    Order_id,   SUM(Quantity * ProductPrice) AS TotalPrice FROM   OrderItems WHERE  OrderId = @order_id GROUP BY  order_id;";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                foreach (var item in OrderID)
                {
                    totalPrice += item.Quantity * item.Price;
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return totalPrice;
        }*/
    }
    /////////////////////// Apply Coupon ///////////////////////////
/*    public int ApplyCoupon(string connectionString, int couponId)
    {
        int discountPercentage = -1;
        string query = "SELECT discount_Percentage FROM promotion WHERE coupon_id = @coupon_id";
        try
        {
            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@coupon_id", couponId);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    discountPercentage = Convert.ToInt32(result);
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            con.Close();
        }
        return discountPercentage;
    }

    public bool GetCouponExistence(string connectionString, int couponId)
    {
        bool couponExists = false;

        string query = "IF EXISTS (SELECT 1 FROM promotion WHERE coupon_id = @coupon_id) SELECT 1 ELSE SELECT 0";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@coupon_id", couponId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            couponExists = Convert.ToBoolean(reader[0]);
                        }
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            con.Close();
        }
        return couponExists;
    }
*/


}








