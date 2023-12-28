using System.Data.SqlClient;
using System.Data;
namespace food_web_project.Models
{
    public class DB
    {

        public SqlConnection con { get; set; }
        public DB(){
            string conStr = "";
            con = new SqlConnection(conStr);
            }
        //read specific table
      /*  public DataTable ReadTable(string TableName)
        {

        }
*/
    }
}
