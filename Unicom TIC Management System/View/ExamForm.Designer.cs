namespace Unicom_TIC_Management_System.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamForm));
            this.lblExamName = new System.Windows.Forms.Label();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.btnUpdateExam = new System.Windows.Forms.Button();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExamName.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExamName.Location = new System.Drawing.Point(147, 52);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(68, 13);
            this.lblExamName.TabIndex = 0;
            this.lblExamName.Text = "Exam Name";
            // 
            // txtExamName
            // 
            this.txtExamName.Location = new System.Drawing.Point(280, 43);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(247, 20);
            this.txtExamName.TabIndex = 1;
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(280, 82);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(247, 21);
            this.cmbSubjects.TabIndex = 2;
            this.cmbSubjects.Text = "SubjectID + SubjectName";
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteExam.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteExam.Location = new System.Drawing.Point(280, 126);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(70, 25);
            this.btnDeleteExam.TabIndex = 3;
            this.btnDeleteExam.Text = "Delete";
            this.btnDeleteExam.UseVisualStyleBackColor = false;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteExam_Click);
            // 
            // btnUpdateExam
            // 
            this.btnUpdateExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdateExam.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateExam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateExam.Location = new System.Drawing.Point(372, 126);
            this.btnUpdateExam.Name = "btnUpdateExam";
            this.btnUpdateExam.Size = new System.Drawing.Size(70, 25);
            this.btnUpdateExam.TabIndex = 4;
            this.btnUpdateExam.Text = "Update";
            this.btnUpdateExam.UseVisualStyleBackColor = false;
            this.btnUpdateExam.Click += new System.EventHandler(this.btnUpdateExam_Click);
            // 
            // btnAddExam
            // 
            this.btnAddExam.BackColor = System.Drawing.Color.Teal;
            this.btnAddExam.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddExam.Location = new System.Drawing.Point(457, 126);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(70, 25);
            this.btnAddExam.TabIndex = 5;
            this.btnAddExam.Text = "Add";
            this.btnAddExam.UseVisualStyleBackColor = false;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // dgvExams
            // 
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Location = new System.Drawing.Point(117, 177);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.RowHeadersWidth = 62;
            this.dgvExams.Size = new System.Drawing.Size(459, 164);
            this.dgvExams.TabIndex = 6;
            this.dgvExams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvExams.SelectionChanged += new System.EventHandler(this.dgvExams_SelectionChanged);
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSubjectID.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSubjectID.Location = new System.Drawing.Point(147, 90);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(66, 13);
            this.lblSubjectID.TabIndex = 7;
            this.lblSubjectID.Text = "Subject ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Exam Detiles";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSubjectID);
            this.Controls.Add(this.dgvExams);
            this.Controls.Add(this.btnAddExam);
            this.Controls.Add(this.btnUpdateExam);
            this.Controls.Add(this.btnDeleteExam);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.txtExamName);
            this.Controls.Add(this.lblExamName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.Button btnUpdateExam;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}