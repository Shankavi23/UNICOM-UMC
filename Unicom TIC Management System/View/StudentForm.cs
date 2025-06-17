using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Unicom_TIC_Management_System.Controller;
using Unicom_TIC_Management_System.Controllers;
using Unicom_TIC_Management_System.Models;

namespace Unicom_TIC_Management_System.View
{ 
    public partial class StudentForm : Form 

    {
        private Label label1;
        private TextBox txtStudentName;
        private ComboBox cmbCourse;
        private Button deletestudent;
        private Button Updatestudent;
        private Button addstudent;
        private DataGridView dgvstudents;
        private Label Course;
        private Label studentname;

        public StudentForm()
        {
            InitializeComponent();
        }

        

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.studentname = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.deletestudent = new System.Windows.Forms.Button();
            this.Updatestudent = new System.Windows.Forms.Button();
            this.addstudent = new System.Windows.Forms.Button();
            this.dgvstudents = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // studentname
            // 
            this.studentname.AutoSize = true;
            this.studentname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentname.Location = new System.Drawing.Point(156, 67);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(75, 13);
            this.studentname.TabIndex = 1;
            this.studentname.Text = "Student Name";
            this.studentname.Click += new System.EventHandler(this.studentname_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStudentName.Location = new System.Drawing.Point(250, 64);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(239, 20);
            this.txtStudentName.TabIndex = 2;
            // 
            // cmbCourse
            // 
            this.cmbCourse.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(250, 108);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(239, 21);
            this.cmbCourse.TabIndex = 3;
            // 
            // deletestudent
            // 
            this.deletestudent.BackColor = System.Drawing.Color.Tomato;
            this.deletestudent.Location = new System.Drawing.Point(172, 160);
            this.deletestudent.Name = "deletestudent";
            this.deletestudent.Size = new System.Drawing.Size(62, 22);
            this.deletestudent.TabIndex = 4;
            this.deletestudent.Text = "DELETE STUDENT";
            this.deletestudent.UseVisualStyleBackColor = false;
            this.deletestudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // Updatestudent
            // 
            this.Updatestudent.BackColor = System.Drawing.SystemColors.Info;
            this.Updatestudent.Location = new System.Drawing.Point(298, 160);
            this.Updatestudent.Name = "Updatestudent";
            this.Updatestudent.Size = new System.Drawing.Size(62, 22);
            this.Updatestudent.TabIndex = 5;
            this.Updatestudent.Text = "UPDATE";
            this.Updatestudent.UseVisualStyleBackColor = false;
            this.Updatestudent.Click += new System.EventHandler(this.Updatestudent_Click);
            // 
            // addstudent
            // 
            this.addstudent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addstudent.Location = new System.Drawing.Point(415, 160);
            this.addstudent.Name = "addstudent";
            this.addstudent.Size = new System.Drawing.Size(62, 22);
            this.addstudent.TabIndex = 6;
            this.addstudent.Text = "ADD";
            this.addstudent.UseVisualStyleBackColor = false;
            this.addstudent.Click += new System.EventHandler(this.addstudent_Click);
            // 
            // dgvstudents
            // 
            this.dgvstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudents.Location = new System.Drawing.Point(128, 200);
            this.dgvstudents.Name = "dgvstudents";
            this.dgvstudents.RowHeadersWidth = 62;
            this.dgvstudents.Size = new System.Drawing.Size(633, 306);
            this.dgvstudents.TabIndex = 7;
            this.dgvstudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstudents_CellContentClick);
            this.dgvstudents.SelectionChanged += new System.EventHandler(this.dgvstudents_SelectionChanged);
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Course.Location = new System.Drawing.Point(159, 116);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(40, 13);
            this.Course.TabIndex = 8;
            this.Course.Text = "Course";
            // 
            // StudentForm
            // 
            this.ClientSize = new System.Drawing.Size(1043, 552);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.dgvstudents);
            this.Controls.Add(this.addstudent);
            this.Controls.Add(this.Updatestudent);
            this.Controls.Add(this.deletestudent);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.studentname);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedStudentID == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure to delete this user?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                UserController.DeleteUser(selectedStudentID);
                LoadStudents();
                ClearInputs();
            }
        }

        private void addstudent_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                StudentID = selectedStudentID,
                Name = txtStudentName.Text,
            };

            StudentController.AddStudent(student);
            LoadStudents();
            ClearInputs();

        }


        private void studentname_Click(object sender, EventArgs e)
        {

        }

        private void dgvstudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadStudents()
        {
            dgvstudents.DataSource = null;
            dgvstudents.DataSource = StudentController.GetAllStudents();
        }
        private void ClearInputs()
        {
            txtStudentName.Text = "";
           
        }
        private int selectedStudentID = -1;
        private void dgvstudents_SelectionChanged(object sender, EventArgs e)
        {   
            if (dgvstudents.CurrentRow != null && dgvstudents.CurrentRow.Index >= 0)
            {
                selectedStudentID = Convert.ToInt32(dgvstudents.CurrentRow.Cells["StudentID"].Value);
                txtStudentName.Text = dgvstudents.CurrentRow.Cells["Name"].Value?.ToString();
                cmbCourse.Text = dgvstudents.CurrentRow.Cells["courseId"].Value?.ToString();
            }
            else
            {
                selectedStudentID = -1;
                txtStudentName.Clear();

                cmbCourse.SelectedIndex = -1;
            }
        }

        private void Updatestudent_Click(object sender, EventArgs e)
        {
            if (selectedStudentID == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            var student = new Student
            {
                StudentID = selectedStudentID,
                Name = txtStudentName.Text,
                
                
            };

            StudentController.UpdateStudent(student);
            LoadStudents();
            ClearInputs();
        }
    }
}
