namespace UnicomTICManagementSystem.Views
{
    partial class TimetableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.btnAddTimetable = new System.Windows.Forms.Button();
            this.dgvTimetables = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetables)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(579, 110);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(185, 22);
            this.txtTime.TabIndex = 0;
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(317, 108);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(211, 24);
            this.cmbDay.TabIndex = 1;
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(24, 108);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(195, 24);
            this.cmbSubjects.TabIndex = 2;
            // 
            // btnAddTimetable
            // 
            this.btnAddTimetable.Location = new System.Drawing.Point(142, 221);
            this.btnAddTimetable.Name = "btnAddTimetable";
            this.btnAddTimetable.Size = new System.Drawing.Size(110, 23);
            this.btnAddTimetable.TabIndex = 3;
            this.btnAddTimetable.Text = "Add Timetable";
            this.btnAddTimetable.UseVisualStyleBackColor = true;
            this.btnAddTimetable.Click += new System.EventHandler(this.btnAddTimetable_Click);
            // 
            // dgvTimetables
            // 
            this.dgvTimetables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetables.Location = new System.Drawing.Point(121, 270);
            this.dgvTimetables.Name = "dgvTimetables";
            this.dgvTimetables.RowHeadersWidth = 51;
            this.dgvTimetables.RowTemplate.Height = 24;
            this.dgvTimetables.Size = new System.Drawing.Size(558, 150);
            this.dgvTimetables.TabIndex = 4;
            this.dgvTimetables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimetables_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(329, 221);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Timetable";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(532, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Timetable";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvTimetables);
            this.Controls.Add(this.btnAddTimetable);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.txtTime);
            this.Name = "TimetableForm";
            this.Text = "TimetableForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Button btnAddTimetable;
        private System.Windows.Forms.DataGridView dgvTimetables;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}