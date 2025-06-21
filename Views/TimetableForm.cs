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
    public partial class TimetableForm : Form
    {
        public TimetableForm()
        {
            InitializeComponent();
            LoadSubjects();
            LoadTimetables();
            LoadDays();
        }
        private void LoadSubjects()
        {
            cmbSubjects.DataSource = CourseController.GetSubjects();
            cmbSubjects.DisplayMember = "SubjectName";
            cmbSubjects.ValueMember = "SubjectID";
        }
        private void LoadDays()
        {
            cmbDay.Items.Clear();
            cmbDay.Items.AddRange(new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
        }
        private void LoadTimetables()
        {
            dgvTimetables.DataSource = TimetableController.GetTimetables();
        }
        private void btnAddTimetable_Click(object sender, EventArgs e)
        {
            int subjectId = (int)cmbSubjects.SelectedValue;
            string day = cmbDay.Text;
            string time = txtTime.Text.Trim();
            if (day != "" && time != "")
            {
                TimetableController.AddTimetable(subjectId, day, time);
                MessageBox.Show("Timetable added!");
                LoadTimetables();
                txtTime.Clear();
            }
        }
        private int selectedTimetableId = -1;
        private void dgvTimetables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTimetables.Rows[e.RowIndex];
                selectedTimetableId = Convert.ToInt32(row.Cells[0].Value); // TimetableID
                cmbSubjects.SelectedValue = row.Cells[1].Value;
                cmbDay.Text = row.Cells[2].Value.ToString();
                txtTime.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId != -1)
            {
                int subjectId = (int)cmbSubjects.SelectedValue;
                string day = cmbDay.Text;
                string time = txtTime.Text.Trim();
                TimetableController.UpdateTimetable(selectedTimetableId, subjectId, day, time);
                MessageBox.Show("Timetable updated!");
                LoadTimetables();
                selectedTimetableId = -1;
                txtTime.Clear();
            }
            else
            {
                MessageBox.Show("Please select a timetable to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    TimetableController.DeleteTimetable(selectedTimetableId);
                    MessageBox.Show("Timetable deleted!");
                    LoadTimetables();
                    selectedTimetableId = -1;
                    txtTime.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please select a timetable to delete.");
            }
        }

    }
}




        
