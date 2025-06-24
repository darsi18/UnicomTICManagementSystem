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
    public class StudentController
    {
        public static void AddStudent(string name, string email, int courseId)
        {
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("INSERT INTO Students (FullName, Email, CourseID) VALUES (@n, @e, @c)", conn);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@c", courseId);
            cmd.ExecuteNonQuery();
        }
        public static void DeleteStudent(int StudentId)
        {
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("DELETE FROM Students WHERE StudentID=@id", conn);
            cmd.Parameters.AddWithValue("@id", StudentId);
            cmd.ExecuteNonQuery();
        }
        public static void UpdateStudent(int studentId, string name, string email, int courseId)
        {
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("UPDATE Students SET FullName = @n, Email = @e, CourseID = @c WHERE StudentID = @id", conn);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@c", courseId);
            cmd.Parameters.AddWithValue("@id", studentId);
            cmd.ExecuteNonQuery();
        }

        public static List<Student> GetStudents()
        {
            var list = new List<Student>();
            var conn = DatabaseManager.GetConnection();
            var cmd = new SQLiteCommand("SELECT * FROM Students", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Student
                {
                    StudentID = reader.GetInt32(0),
                    FullName = reader.GetString(1),
                    Email = reader.GetString(2),
                    CourseID = reader.GetInt32(3)
                });
            }
            return list;
        }
    }
}

    
