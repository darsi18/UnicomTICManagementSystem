using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Repositories
{
    internal class DatabaseManager
    {
            private static SQLiteConnection connection;
        public static void Initialize()
        {
            try
            {
                connection = new SQLiteConnection("Data Source=unicomtic.db;Version=3;");
                connection.Open();
                string createUsersTable = @"CREATE TABLE IF NOT EXISTS Users (
                                            UserID INTEGER PRIMARY KEY,
                                            Username TEXT,
                                            Password TEXT,
                                            Role TEXT
                                        );";
                new SQLiteCommand(createUsersTable, connection).ExecuteNonQuery();

                // Admin 
                string insertAdmin = @"INSERT OR IGNORE INTO Users (UserID, Username, Password, Role)
                                   VALUES (1, 'admin', '1234', 'Admin');";
                new SQLiteCommand(insertAdmin, connection).ExecuteNonQuery();

                //Staff
                string insertStaff = @"INSERT OR IGNORE INTO Users (UserID, Username, Password, Role)
                                   VALUES (2, 'staff', '1234', 'Staff');";
                new SQLiteCommand(insertStaff, connection).ExecuteNonQuery();
                //Lecturer
                string insertLecturer = @"INSERT OR IGNORE INTO Users (UserID, Username, Password, Role)
                                   VALUES (3, 'lecturer', '1234', 'Lecturer');";
                new SQLiteCommand(insertLecturer, connection).ExecuteNonQuery();
                //Students
                string insertStudent = @"INSERT OR IGNORE INTO Users (UserID, Username, Password, Role)
                                   VALUES (4, 'student', '1234', 'Student');";
                new SQLiteCommand(insertStudent, connection).ExecuteNonQuery();
                //Course Table
                string CreateCourses = @"CREATE TABLE IF NOT EXISTS Courses(CourseID INTEGER PRIMARY KEY,CourseName TEXT);";
                new SQLiteCommand(CreateCourses, connection).ExecuteNonQuery();

                //Subject 
                string CreateSubjects = @"CREATE TABLE IF NOT EXISTS Subjects(
                                        SubjectID INTEGER PRIMARY KEY,
                                        SubjectName TEXT,
                                        CourseID INTEGER,
                                        FOREIGN KEY(CourseID)REFERENCES Courses(CourseID)
                                        );";
                new SQLiteCommand(CreateSubjects, connection).ExecuteNonQuery();
                //Subject Table
                string CreateSubjectsTable = @"CREATE TABLE IF NOT EXISTS Subjects(
                                        SubjectID INTEGER PRIMARY KEY,
                                        SubjectName TEXT,
                                        CourseID INTEGER,
                                        FOREIGN KEY(CourseID)REFERENCES Courses(CourseID)
                                        );";
                new SQLiteCommand(CreateSubjectsTable, connection).ExecuteNonQuery();
                //Student Table
                string CreateStudentsTable = @"CREATE TABLE IF NOT EXISTS Students(
                                        StudentID INTEGER PRIMARY KEY,
                                        FullName TEXT,
                                        Email TEXT,
                                        CourseID INTEGER,
                                        FOREIGN KEY(CourseID)REFERENCES Courses(CourseID)
                                        );";
                new SQLiteCommand(CreateStudentsTable, connection).ExecuteNonQuery();
                //Exam Table
                string createExamsTable = @"CREATE TABLE IF NOT EXISTS Exams (
                                          ExamID INTEGER PRIMARY KEY,
                                          ExamName TEXT,
                                          SubjectID INTEGER,
                                          ExamDate TEXT,
                                          ExamTime TEXT,
                                          FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                                          );";
                new SQLiteCommand(createExamsTable, connection).ExecuteNonQuery();
                //Marks Table
                string createMarksTable = @"CREATE TABLE IF NOT EXISTS Marks (
                                          MarkID INTEGER PRIMARY KEY,
                                          StudentID INTEGER,
                                          SubjectID INTEGER,
                                          Marks INTEGER,
                                          FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                                          FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                                          );";
                new SQLiteCommand(createMarksTable, connection).ExecuteNonQuery();
                //TimeTable Table
                string TimetableTable = @"CREATE TABLE IF NOT EXISTS Timetables (
                                          TimetableID INTEGER PRIMARY KEY,
                                          SubjectID INTEGER,
                                          Day TEXT,
                                          Time TEXT,
                                          FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                                          );";
                new SQLiteCommand(TimetableTable, connection).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DBError:" + ex.Message);
            }
            }
            public static SQLiteConnection GetConnection()
            {
                return connection;
            }
        }
    }


