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
    public partial class ExamForm : Form
    {
        public ExamForm()
        {
            InitializeComponent();
            LoadSubjects();
            LoadExams();
        }
        private void LoadSubjects()
        {
            cmbSubjects.DataSource = CourseController.GetSubjects();
            cmbSubjects.DisplayMember = "SubjectName";
            cmbSubjects.ValueMember = "SubjectID";
        }
        private void LoadExams()
        {
            dgvExams.DataSource = ExamController.GetExams();
        }
        private void btnAddExam_Click(object sender, EventArgs e)
        {
            string name = txtExamName.Text.Trim();
            string time = txtExamTime.Text.Trim();
            DateTime date = dtpExamDate.Value;
            int subjectId = (int)cmbSubjects.SelectedValue;
            if (name != "" && time != "")
            {
                ExamController.AddExam(name, subjectId, date, time);
                MessageBox.Show("Exam Added!");
                LoadExams();
                txtExamName.Clear();
                txtExamTime.Clear();
            }
           
        }
        private int selectedExamId = -1;
        private void dgvExams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvExams.Rows[e.RowIndex];
                selectedExamId = Convert.ToInt32(row.Cells[0].Value);
                txtExamName.Text = row.Cells[1].Value.ToString();
                cmbSubjects.SelectedValue = row.Cells[2].Value;
                dtpExamDate.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txtExamTime.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedExamId != -1)
            {
                string name = txtExamName.Text.Trim();
                string time = txtExamTime.Text.Trim();
                DateTime date = dtpExamDate.Value;
                int subjectId = (int)cmbSubjects.SelectedValue;
                ExamController.UpdateExam(selectedExamId, name, subjectId, date, time);
                MessageBox.Show("Exam updated!");
                LoadExams();
                selectedExamId = -1;
                txtExamName.Clear();
                txtExamTime.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedExamId != -1)
            {
                DialogResult result = MessageBox.Show("Delete this exam?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExamController.DeleteExam(selectedExamId);
                    MessageBox.Show("Exam deleted!");
                    LoadExams();
                    selectedExamId = -1;
                    txtExamName.Clear();
                    txtExamTime.Clear();
                }
            }
        }

    }
}



        
