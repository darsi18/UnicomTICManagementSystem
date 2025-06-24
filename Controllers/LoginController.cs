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
        }
    }





