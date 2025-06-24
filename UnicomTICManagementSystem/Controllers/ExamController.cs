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
    public class ExamController
    {
        public static void AddExam(string name, int subjectId, DateTime date, string time)
        {
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("INSERT INTO Exams (ExamName, SubjectID, ExamDate, ExamTime) VALUES (@n, @s, @d, @t)", conn);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@s", subjectId);
            cmd.Parameters.AddWithValue("@d", date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@t", time);
            cmd.ExecuteNonQuery();
        }
        public static void UpdateExam(int examId, string name, int subjectId, DateTime date, string time)
        {
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("UPDATE Exams SET ExamName = @n, SubjectID = @s, ExamDate = @d, ExamTime = @t WHERE ExamID = @id", conn);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@s", subjectId);
            cmd.Parameters.AddWithValue("@d", date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@t", time);
            cmd.Parameters.AddWithValue("@id", examId);
            cmd.ExecuteNonQuery();
        }
        public static void DeleteExam(int examId)
        {
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("DELETE FROM Exams WHERE ExamID = @id", conn);
            cmd.Parameters.AddWithValue("@id", examId);
            cmd.ExecuteNonQuery();
        }


        public static List<Exam> GetExams()
        {
            var list = new List<Exam>();
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("SELECT * FROM Exams", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Exam
                {
                    ExamID = reader.GetInt32(0),
                    ExamName = reader.GetString(1),
                    SubjectID = reader.GetInt32(2),
                    ExamDate = DateTime.Parse(reader.GetString(3)),
                    ExamTime = reader.GetString(4)
                });
            }
            return list;
        }
    }
}

    
