namespace UnicomTICManagementSystem.Views
{
    partial class ExamForm
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
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.txtExamTime = new System.Windows.Forms.TextBox();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.dtpExamDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExamName
            // 
            this.txtExamName.Location = new System.Drawing.Point(349, 75);
            this.txtExamName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(263, 22);
            this.txtExamName.TabIndex = 0;
            // 
            // txtExamTime
            // 
            this.txtExamTime.Location = new System.Drawing.Point(40, 146);
            this.txtExamTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExamTime.Name = "txtExamTime";
            this.txtExamTime.Size = new System.Drawing.Size(191, 22);
            this.txtExamTime.TabIndex = 1;
            // 
            // btnAddExam
            // 
            this.btnAddExam.BackColor = System.Drawing.Color.Salmon;
            this.btnAddExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExam.Location = new System.Drawing.Point(471, 240);
            this.btnAddExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(109, 38);
            this.btnAddExam.TabIndex = 2;
            this.btnAddExam.Text = "Add Exam";
            this.btnAddExam.UseVisualStyleBackColor = false;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // dgvExams
            // 
            this.dgvExams.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Location = new System.Drawing.Point(40, 240);
            this.dgvExams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.RowHeadersWidth = 51;
            this.dgvExams.RowTemplate.Height = 24;
            this.dgvExams.Size = new System.Drawing.Size(325, 158);
            this.dgvExams.TabIndex = 3;
            this.dgvExams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExams_CellContentClick);
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(40, 74);
            this.cmbSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(195, 24);
            this.cmbSubjects.TabIndex = 5;
            // 
            // dtpExamDate
            // 
            this.dtpExamDate.CalendarMonthBackground = System.Drawing.Color.Snow;
            this.dtpExamDate.Location = new System.Drawing.Point(353, 146);
            this.dtpExamDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.Size = new System.Drawing.Size(259, 22);
            this.dtpExamDate.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Salmon;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(471, 305);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 36);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update Exam";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(471, 365);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 33);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Exam";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Exam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Exams Table";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(657, 411);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpExamDate);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.dgvExams);
            this.Controls.Add(this.btnAddExam);
            this.Controls.Add(this.txtExamTime);
            this.Controls.Add(this.txtExamName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.TextBox txtExamTime;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.DateTimePicker dtpExamDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}