using System.Data.SqlClient;
using System.Data;
using food_web_project.Models.Tables;
namespace food_web_project.Models
{
    public class DB
    {
        public SqlConnection con { get; set; }

        public DB()
        {
            // Set your actual connection string
            string conStr = "YourConnectionString";
            con = new SqlConnection(conStr);
        }

       /* public Users AuthenticateUser(string username, string password)
        {
            // Authentication logic here...

            // If authentication is successful, return the user object
            // Otherwise, return null
            if (authenticationSuccessful)
            {
                Users authenticatedUser = // Retrieve the authenticated user from the database
        return authenticatedUser;
            }
            else
            {
                return null; // Authentication failed
            }
        }*/

    }
}
