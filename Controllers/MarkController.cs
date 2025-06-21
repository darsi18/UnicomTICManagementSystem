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
    public class MarkController
    {
        public static void AddMark(int studentId, int subjectId, int mark)
        {
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("INSERT INTO Marks (StudentID, SubjectID, Marks) VALUES (@s, @sub, @m)", conn);
            cmd.Parameters.AddWithValue("@s", studentId);
            cmd.Parameters.AddWithValue("@sub", subjectId);
            cmd.Parameters.AddWithValue("@m", mark);
            cmd.ExecuteNonQuery();
        }
        public static void UpdateMark(int markId, int studentId, int subjectId, int mark)
        {
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("UPDATE Marks SET StudentID = @s, SubjectID = @sub, Marks = @m WHERE MarkID = @id", conn);
            cmd.Parameters.AddWithValue("@s", studentId);
            cmd.Parameters.AddWithValue("@sub", subjectId);
            cmd.Parameters.AddWithValue("@m", mark);
            cmd.Parameters.AddWithValue("@id", markId);
            cmd.ExecuteNonQuery();
        }
        public static void DeleteMark(int markId)
        {
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("DELETE FROM Marks WHERE MarkID = @id", conn);
            cmd.Parameters.AddWithValue("@id", markId);
            cmd.ExecuteNonQuery();
        }

        public static List<Mark> GetMarks()
        {
            var list = new List<Mark>();
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("SELECT * FROM Marks", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Mark
                {
                    MarkID = reader.GetInt32(0),
                    StudentID = reader.GetInt32(1),
                    SubjectID = reader.GetInt32(2),
                    Marks = reader.GetInt32(3)
                });
            }
            return list;
        }
    }
}


    
