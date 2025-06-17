using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Models;

namespace Unicom_TIC_Management_System.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private User currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            CustomizeUIByRole(user.Role);
        }
        private void LoadFormInPanel(Form form)
        {
            panel2.Controls.Clear();           // Clear previous controls
            form.TopLevel = false;                     // Make it a child form
            form.FormBorderStyle = FormBorderStyle.None; // Remove borders
            form.Dock = DockStyle.Fill;                // Fill the panel
            panel2.Controls.Add(form);         // Add form to panel
            form.Show();                               // Show the form
        }

        private void CustomizeUIByRole(string role)
        {
            if (role == "Admin")
            {
                // all features visible
            }
            else if (role == "Lecturer")
            {
               // btnAddCourse.Visible = false;
             //   btnManageStudents.Visible = false;
            }
            else if (role == "Student")
            {
             //   btnAddCourse.Visible = false;
              //  btnManageStudents.Visible = false;
              //  btnAddMarks.Visible = false;
            }
            // etc.
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new UserForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new StudentForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new courseForm1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ExamForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new MarkForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new RoomForm());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new SubjectForm());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new TimetableForm());
        }
    }
}
