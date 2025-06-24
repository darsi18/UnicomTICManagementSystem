using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    public class TimetableController
    {
        public static void AddTimetable(int subjectId, string day, string time)
        {
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("INSERT INTO Timetables (SubjectID, Day, Time) VALUES (@s, @d, @t)", conn);
            cmd.Parameters.AddWithValue("@s", subjectId);
            cmd.Parameters.AddWithValue("@d", day);
            cmd.Parameters.AddWithValue("@t", time);
            cmd.ExecuteNonQuery();
        }
        public static void UpdateTimetable(int timetableId, int subjectId, string day, string time)
        {
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("UPDATE Timetables SET SubjectID = @s, Day = @d, Time = @t WHERE TimetableID = @id", conn);
            cmd.Parameters.AddWithValue("@s", subjectId);
            cmd.Parameters.AddWithValue("@d", day);
            cmd.Parameters.AddWithValue("@t", time);
            cmd.Parameters.AddWithValue("@id", timetableId);
            cmd.ExecuteNonQuery();
        }
        public static void DeleteTimetable(int timetableId)
        {
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("DELETE FROM Timetables WHERE TimetableID = @id", conn);
            cmd.Parameters.AddWithValue("@id", timetableId);
            cmd.ExecuteNonQuery();
        }


        public static List<Timetable> GetTimetables()
        {
            var list = new List<Timetable>();
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("SELECT * FROM Timetables", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Timetable
                {
                    TimetableID = reader.GetInt32(0),
                    SubjectID = reader.GetInt32(1),
                    Day = reader.GetString(2),
                    Time = reader.GetString(3)
                });
            }
            return list;
        }
    }
}


    
