using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Views
{
    public partial class MainForm : Form
    {
        private string _role;
        public MainForm(string role)
        {
            InitializeComponent();
            _role = role;
            lblWelcome.Text = "Welcome, " + _role;
            ApplyRolePermissions();
        }
        private void ApplyRolePermissions()
        {
           
            btnCourses.Visible = false;
            btnStudents.Visible = false;
            btnExams.Visible = false;
            btnMarks.Visible = false;
            btnTimetable.Visible = false;
            
            if (_role == "Admin")
            {
                btnCourses.Visible = true;
                btnStudents.Visible = true;
                btnExams.Visible = true;
                btnMarks.Visible = true;
                btnTimetable.Visible = true;
            }
            else if (_role == "Staff")
            {
                btnExams.Visible = true;
                btnMarks.Visible = true;
                btnTimetable.Visible = true;
            }
            else if (_role == "Lecturer")
            {
                btnMarks.Visible = true;
                btnTimetable.Visible = true;
            }
            else if (_role == "Student")
            {
                btnMarks.Visible = true;
                btnTimetable.Visible = true;
            }
        }
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            
            Application.Restart();



        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CourseForm form = new CourseForm();
            form.Show();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            ExamForm examForm = new ExamForm();
            examForm.Show();
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            MarkForm mf = new MarkForm();
            mf.Show();
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            TimetableForm tf = new TimetableForm();
            tf.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

      //  private void pictureBox1_Click(object sender, EventArgs e)
      //  {

       // }
    }
}
