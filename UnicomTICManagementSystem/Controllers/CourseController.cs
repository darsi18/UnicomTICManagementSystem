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
    public class CourseController
    {
            public static void AddCourse(string name)
            {
                var conn = DatabaseManager.GetConnection();
                var cmd = new SQLiteCommand("INSERT INTO Courses (CourseName) VALUES (@name)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
            public static List<Course> GetCourses()
            {
                var list = new List<Course>();
                var conn = DatabaseManager.GetConnection();
                var cmd = new SQLiteCommand("SELECT * FROM Courses", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Course
                    {
                        CourseID = reader.GetInt32(0),
                        CourseName = reader.GetString(1)
                    });
                }
                return list;
            }
            public static void AddSubject(string name, int courseId)
            {
                var conn = DatabaseManager.GetConnection();
                var cmd = new SQLiteCommand("INSERT INTO Subjects (SubjectName, CourseID) VALUES (@name, @cid)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@cid", courseId);
                cmd.ExecuteNonQuery();
            }
            public static List<Subject> GetSubjects()
            {
                var list = new List<Subject>();
                var conn = DatabaseManager.GetConnection();
                var cmd = new SQLiteCommand("SELECT * FROM Subjects", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Subject
                    {
                        SubjectID = reader.GetInt32(0),
                        SubjectName = reader.GetString(1),
                        CourseID = reader.GetInt32(2)
                    });
                }
                return list;
            }
        }
    }



