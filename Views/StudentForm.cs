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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            LoadCourses();
            LoadStudents();
        }
        private void LoadCourses()
        {
            cmbCourses.DataSource = CourseController.GetCourses();
            cmbCourses.DisplayMember = "CourseName";
            cmbCourses.ValueMember = "CourseID";
        }
        private void LoadStudents()
        {
            dgvStudents.DataSource = StudentController.GetStudents();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            int courseId = (int)cmbCourses.SelectedValue;
            if (name != "" && email != "")
            {
                StudentController.AddStudent(name, email, courseId);
                MessageBox.Show("Student added!");
                LoadStudents();
                txtName.Clear();
                txtEmail.Clear();
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells[0].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    StudentController.DeleteStudent(studentId);
                    MessageBox.Show("Student deleted!");
                    LoadStudents();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }
        private int selectedStudentId = -1;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentId != -1)
            {
                string name = txtName.Text.Trim();
                string email = txtEmail.Text.Trim();
                int courseId = (int)cmbCourses.SelectedValue;
                StudentController.UpdateStudent(selectedStudentId, name, email, courseId);
                MessageBox.Show("Student updated!");
                LoadStudents();
                txtName.Clear();
                txtEmail.Clear();
                selectedStudentId = -1;
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }
        }
        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                selectedStudentId = Convert.ToInt32(row.Cells[0].Value);
                txtName.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                cmbCourses.SelectedValue = row.Cells[3].Value;
            }
        }

    }
}




        
