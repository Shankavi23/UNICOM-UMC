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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtAddress;
        private ComboBox cmbGender;
        private Label label6;
        private DateTimePicker dtpDOB;
        private Label label7;
        private Label studentname;

        public StudentForm()
        {
            InitializeComponent();
            LoadCourses();
        }



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.studentname = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.deletestudent = new System.Windows.Forms.Button();
            this.Updatestudent = new System.Windows.Forms.Button();
            this.addstudent = new System.Windows.Forms.Button();
            this.dgvstudents = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // studentname
            // 
            this.studentname.AutoSize = true;
            this.studentname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentname.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentname.Location = new System.Drawing.Point(251, 51);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(117, 18);
            this.studentname.TabIndex = 1;
            this.studentname.Text = "Student Name";
            this.studentname.Click += new System.EventHandler(this.studentname_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.White;
            this.txtStudentName.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.txtStudentName.Location = new System.Drawing.Point(247, 85);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(264, 30);
            this.txtStudentName.TabIndex = 2;
            // 
            // cmbCourse
            // 
            this.cmbCourse.BackColor = System.Drawing.Color.White;
            this.cmbCourse.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(571, 85);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(264, 30);
            this.cmbCourse.TabIndex = 3;
            // 
            // deletestudent
            // 
            this.deletestudent.BackColor = System.Drawing.Color.DarkRed;
            this.deletestudent.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.deletestudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletestudent.Location = new System.Drawing.Point(1063, 262);
            this.deletestudent.Name = "deletestudent";
            this.deletestudent.Size = new System.Drawing.Size(84, 39);
            this.deletestudent.TabIndex = 4;
            this.deletestudent.Text = "DELETE ";
            this.deletestudent.UseVisualStyleBackColor = false;
            this.deletestudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // Updatestudent
            // 
            this.Updatestudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Updatestudent.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.Updatestudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Updatestudent.Location = new System.Drawing.Point(863, 259);
            this.Updatestudent.Name = "Updatestudent";
            this.Updatestudent.Size = new System.Drawing.Size(108, 39);
            this.Updatestudent.TabIndex = 5;
            this.Updatestudent.Text = "UPDATE";
            this.Updatestudent.UseVisualStyleBackColor = false;
            this.Updatestudent.Click += new System.EventHandler(this.Updatestudent_Click);
            // 
            // addstudent
            // 
            this.addstudent.BackColor = System.Drawing.Color.Teal;
            this.addstudent.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.addstudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addstudent.Location = new System.Drawing.Point(698, 259);
            this.addstudent.Name = "addstudent";
            this.addstudent.Size = new System.Drawing.Size(90, 39);
            this.addstudent.TabIndex = 6;
            this.addstudent.Text = "ADD";
            this.addstudent.UseVisualStyleBackColor = false;
            this.addstudent.Click += new System.EventHandler(this.addstudent_Click);
            // 
            // dgvstudents
            // 
            this.dgvstudents.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudents.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvstudents.Location = new System.Drawing.Point(106, 324);
            this.dgvstudents.Name = "dgvstudents";
            this.dgvstudents.RowHeadersWidth = 62;
            this.dgvstudents.Size = new System.Drawing.Size(1153, 368);
            this.dgvstudents.TabIndex = 7;
            this.dgvstudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstudents_CellContentClick);
            this.dgvstudents.SelectionChanged += new System.EventHandler(this.dgvstudents_SelectionChanged);
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Course.Font = new System.Drawing.Font("Stencil", 11.25F);
            this.Course.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Course.Location = new System.Drawing.Point(569, 51);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(64, 18);
            this.Course.TabIndex = 8;
            this.Course.Text = "Course";
            this.Course.Click += new System.EventHandler(this.Course_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(8, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student Detials";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 11.25F);
            this.label3.Location = new System.Drawing.Point(568, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "phone no:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.txtPhone.Location = new System.Drawing.Point(571, 182);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(264, 30);
            this.txtPhone.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 11.25F);
            this.label4.Location = new System.Drawing.Point(244, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.txtEmail.Location = new System.Drawing.Point(247, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(264, 30);
            this.txtEmail.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 11.25F);
            this.label5.Location = new System.Drawing.Point(896, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.txtAddress.Location = new System.Drawing.Point(898, 85);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(264, 30);
            this.txtAddress.TabIndex = 20;
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(898, 182);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(264, 30);
            this.cmbGender.TabIndex = 21;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 11.25F);
            this.label6.Location = new System.Drawing.Point(894, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "gender";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Stencil", 11.25F);
            this.dtpDOB.Location = new System.Drawing.Point(240, 268);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(380, 25);
            this.dtpDOB.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 11.25F);
            this.label7.Location = new System.Drawing.Point(243, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "dob";
            // 
            // StudentForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1494, 676);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.dgvstudents);
            this.Controls.Add(this.addstudent);
            this.Controls.Add(this.Updatestudent);
            this.Controls.Add(this.deletestudent);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.studentname);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
            LoadCourses(); // 🔄 Make sure it's called here too, just in case
            LoadStudents(); // load all student data
            string[] genders = { "Male", "Female" };
            cmbGender.Items.AddRange(genders);
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
                StudentController.DeleteStudent(selectedStudentID);
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
                CourseID = (int)cmbCourse.SelectedValue,
                DateOfBirth = dtpDOB.Value, 
                Email = txtEmail.Text,
                PhoneNumber = int.Parse(txtPhone.Text),
                Address = txtAddress.Text,
                Gender = cmbGender.SelectedItem?.ToString()

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
            if (e.RowIndex >= 0)
            {
                var row = dgvstudents.Rows[e.RowIndex];
                txtStudentName.Text = row.Cells["Name"].Value.ToString();
                cmbCourse.SelectedValue = Convert.ToInt32(row.Cells["CourseID"].Value);
            }
        }
        private void LoadStudents()
        {
            dgvstudents.DataSource = null;
            dgvstudents.DataSource = StudentController.GetAllStudents();
        }
        private CourseController courseController = new CourseController();
        private void LoadCourses()
        {
            var courses = courseController.GetAllCourses();
            cmbCourse.DataSource = courses;
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseID";
        }
        private void ClearInputs()
        {
            txtStudentName.Text = "";
            txtStudentName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            cmbGender.SelectedIndex = -1; 
            txtAddress.Clear();
            dtpDOB.Value = DateTime.Today;
            cmbCourse.SelectedIndex = -1;

        }
        private int selectedStudentID = -1;

        private void dgvstudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvstudents.CurrentRow != null && dgvstudents.CurrentRow.Index >= 0)
            {
                selectedStudentID = Convert.ToInt32(dgvstudents.CurrentRow.Cells["StudentID"].Value);
                txtStudentName.Text = dgvstudents.CurrentRow.Cells["Name"].Value?.ToString();
                
                txtStudentName.Text = dgvstudents.CurrentRow.Cells["Name"].Value?.ToString();
                cmbCourse.SelectedValue = Convert.ToInt32(dgvstudents.CurrentRow.Cells["CourseID"].Value);
                txtEmail.Text = dgvstudents.CurrentRow.Cells["Email"].Value?.ToString();
                txtPhone.Text = dgvstudents.CurrentRow.Cells["PhoneNumber"].Value?.ToString();
                cmbGender.Text = dgvstudents.CurrentRow.Cells["Gender"].Value?.ToString();
                txtAddress.Text = dgvstudents.CurrentRow.Cells["Address"].Value?.ToString();
                dtpDOB.Value = Convert.ToDateTime(dgvstudents.CurrentRow.Cells["DateOfBirth"].Value);
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
                CourseID = (int)cmbCourse.SelectedValue,
                DateOfBirth = dtpDOB.Value,
                Email = txtEmail.Text,
                PhoneNumber = int.TryParse(txtPhone.Text, out int phone) ? phone : 0, // safer parsing
                Address = txtAddress.Text,
                Gender = cmbGender.SelectedItem?.ToString()


            };

            StudentController.UpdateStudent(student);
            LoadStudents();
            ClearInputs();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Course_Click(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
