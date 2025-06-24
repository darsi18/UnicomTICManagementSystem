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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetables)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(579, 110);
            this.txtTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(185, 22);
            this.txtTime.TabIndex = 0;
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(301, 110);
            this.cmbDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(211, 24);
            this.cmbDay.TabIndex = 1;
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(24, 108);
            this.cmbSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(195, 24);
            this.cmbSubjects.TabIndex = 2;
            // 
            // btnAddTimetable
            // 
            this.btnAddTimetable.BackColor = System.Drawing.Color.Salmon;
            this.btnAddTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTimetable.ForeColor = System.Drawing.Color.Black;
            this.btnAddTimetable.Location = new System.Drawing.Point(135, 191);
            this.btnAddTimetable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTimetable.Name = "btnAddTimetable";
            this.btnAddTimetable.Size = new System.Drawing.Size(152, 37);
            this.btnAddTimetable.TabIndex = 3;
            this.btnAddTimetable.Text = "Add Timetable";
            this.btnAddTimetable.UseVisualStyleBackColor = false;
            this.btnAddTimetable.Click += new System.EventHandler(this.btnAddTimetable_Click);
            // 
            // dgvTimetables
            // 
            this.dgvTimetables.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgvTimetables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetables.Location = new System.Drawing.Point(120, 287);
            this.dgvTimetables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTimetables.Name = "dgvTimetables";
            this.dgvTimetables.RowHeadersWidth = 51;
            this.dgvTimetables.RowTemplate.Height = 24;
            this.dgvTimetables.Size = new System.Drawing.Size(557, 150);
            this.dgvTimetables.TabIndex = 4;
            this.dgvTimetables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimetables_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Salmon;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(336, 191);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 37);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Timetable";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(532, 191);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 37);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Timetable";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Day:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "TimeTable";
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvTimetables);
            this.Controls.Add(this.btnAddTimetable);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.txtTime);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}