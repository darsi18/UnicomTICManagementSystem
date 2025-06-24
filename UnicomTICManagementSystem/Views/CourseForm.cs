using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;

namespace UnicomTICManagementSystem.Views
{
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
            LoadCourses();
            LoadSubjects();
        }
        private void LoadCourses()
        {
            var courses = CourseController.GetCourses();
            dgvCourses.DataSource = courses;
            cmbCourses.DataSource = courses;
            cmbCourses.DisplayMember = "CourseName";
            cmbCourses.ValueMember = "CourseID";
        }
        private void LoadSubjects()
        {
            dgvSubjects.DataSource = CourseController.GetSubjects();
        }
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string name = txtCourseName.Text.Trim();
            if (name != "")
            {
                CourseController.AddCourse(name);
                MessageBox.Show("Course Added!");
                LoadCourses();
                txtCourseName.Clear();
            }
        }
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            string subjectName = txtSubjectName.Text.Trim();
            int courseId = (int)cmbCourses.SelectedValue;
            if (subjectName != "")
            {
                CourseController.AddSubject(subjectName, courseId);
                MessageBox.Show("Subject Added!");
                LoadSubjects();
                txtSubjectName.Clear();
            }
        }

        private void btnAddCourse_Click_1(object sender, EventArgs e)
        {
            string name = txtCourseName.Text;
            MessageBox.Show("Entered:name");
            CourseController.AddCourse(name);
            LoadCourses() ;
        }

        private void btnAddSubject_Click_1(object sender, EventArgs e)
        {
            string SubjectName=txtSubjectName.Text.Trim();
            int courseld = (int) cmbCourses.SelectedValue;
            if(SubjectName !="")
            {
                CourseController.AddSubject(SubjectName,courseld);
                MessageBox.Show("Subject Added!");
                LoadCourses();
                txtSubjectName.Clear();
            }
        }
    }
}

        
