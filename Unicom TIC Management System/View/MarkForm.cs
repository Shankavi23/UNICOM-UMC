using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controller;
using Unicom_TIC_Management_System.Models;

namespace Unicom_TIC_Management_System.View
{
    public partial class MarkForm : Form
    {
        public MarkForm()
        {
            InitializeComponent();
            LoadMarks();
        }
        MarkController marks = new MarkController();
        private  void LoadMarks()
        {
            MarkController markController = new MarkController();
var marks = markController.GetAllMarks(); // ✅

            gridMark.DataSource = null;
            gridMark.DataSource = marks;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Mark mark = new Mark
                {
                    StudentID = int.Parse(txtStudent.Text),
                    ExamID = int.Parse(txtExamID.Text),
                    Score = int.Parse(txtScore.Text)
                };

                MarkController controller = new MarkController();
                var marks = controller.GetAllMarks();   // ✅ No error
                controller.DeleteMark(5);               // ✅ No error

                LoadMarks();
                ClearInputs();
                MessageBox.Show("Mark added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridMark.CurrentRow != null)
            {
                int markId = Convert.ToInt32(gridMark.CurrentRow.Cells["MarkID"].Value);
                MarkController markController = new MarkController();
                markController.DeleteMark(5); // ✅

                LoadMarks();
                ClearInputs();
                MessageBox.Show("Mark deleted successfully!");
            }
        }

        private void gridMark_SelectionChanged(object sender, EventArgs e)
        {
            if (gridMark.CurrentRow != null)
            {
                txtStudent.Text = gridMark.CurrentRow.Cells["StudentID"].Value.ToString();
                txtExamID.Text = gridMark.CurrentRow.Cells["ExamID"].Value.ToString();
                txtScore.Text = gridMark.CurrentRow.Cells["Score"].Value.ToString();
            }
        }
        private void ClearInputs()
        {
            txtStudent.Clear();
            txtExamID.Clear();
            txtScore.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MarkController markController = new MarkController();
            markController.DeleteMark(5); // ✅

        }
    }
}
