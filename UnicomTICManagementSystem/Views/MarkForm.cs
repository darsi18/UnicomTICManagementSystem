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
    public partial class MarkForm : Form
    {
        public MarkForm()
        {
            InitializeComponent();
            LoadStudents();
            LoadSubjects();
            LoadMarks();
        }
        private void LoadStudents()
        {
            cmbStudents.DataSource = StudentController.GetStudents();
            cmbStudents.DisplayMember = "FullName";
            cmbStudents.ValueMember = "StudentID";
        }
        private void LoadSubjects()
        {
            cmbSubjects.DataSource = CourseController.GetSubjects();
            cmbSubjects.DisplayMember = "SubjectName";
            cmbSubjects.ValueMember = "SubjectID";
        }
        private void LoadMarks()
        {
            dgvMarks.DataSource = MarkController.GetMarks();
        }
        private void btnAddMark_Click(object sender, EventArgs e)
        {
            int studentId = (int)cmbStudents.SelectedValue;
            int subjectId = (int)cmbSubjects.SelectedValue;
            int mark = int.Parse(txtMarks.Text);
            MarkController.AddMark(studentId, subjectId, mark);
            MessageBox.Show("Mark added!");
            LoadMarks();
            txtMarks.Clear();
        }
        private int selectedMarkId=-1;
        private void dgvMarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMarks.Rows[e.RowIndex];
                selectedMarkId = Convert.ToInt32(row.Cells[0].Value);
                cmbStudents.SelectedValue = row.Cells[1].Value;
                cmbSubjects.SelectedValue = row.Cells[2].Value;
                txtMarks.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMarkId != -1)
            {
                int studentId = (int)cmbStudents.SelectedValue;
                int subjectId = (int)cmbSubjects.SelectedValue;
                int mark = int.Parse(txtMarks.Text);
                MarkController.UpdateMark(selectedMarkId, studentId, subjectId, mark);
                MessageBox.Show("Mark updated!");
                LoadMarks();
                txtMarks.Clear();
                selectedMarkId = -1;
            }
            else
            {
                MessageBox.Show("Please select a mark to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMarkId != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MarkController.DeleteMark(selectedMarkId);
                    MessageBox.Show("Mark deleted!");
                    LoadMarks();
                    txtMarks.Clear();
                    selectedMarkId = -1;
                }
            }
            else
            {
                MessageBox.Show("Please select a mark to delete.");
            }
        }


    }
}




      
