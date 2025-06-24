using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Repositories;
namespace UnicomTICManagementSystem.Controllers
{
    public class LoginController
    {
         public static string CheckLogin(string username, string password)
         {
             var conn =DatabaseManager.GetConnection();
             var cmd = new SQLiteCommand("SELECT Role FROM Users WHERE Username=@u AND Password=@p", conn);
             cmd.Parameters.AddWithValue("@u", username);
             cmd.Parameters.AddWithValue("@p", password);
             var reader = cmd.ExecuteReader();
             if (reader.Read())
         {
             return reader.GetString(0);
         }
             return null;
         }
        /*public static string CheckLogin(string username, string password)
        {
            using (var conn = Repositories.DatabaseManager.GetConnection())
            {
                conn.Open();
                string sql = "SELECT Role FROM Users WHERE Username=@u AND Password=@p";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        return result.ToString();
                    else
                        return null;
                }
            }
        }*/

    }
}





