using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Unicom_TIC_Management_System.Controller;
using Unicom_TIC_Management_System.Models;

namespace Unicom_TIC_Management_System.View
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
            LoadRooms();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            r.RoomName = txtRoomName.Text;

            //RoomController.AddRoom(r);
            MessageBox.Show("Room added.");
        }
        private int selectedRoomId = -1;
        private void ShowsRoomList(object sender, EventArgs e)
        {
            if (dgvRooms.CurrentRow != null && dgvRooms.CurrentRow.Index >= 0)
            {
                selectedRoomId = Convert.ToInt32(dgvRooms.CurrentRow.Cells["RoomID"].Value);
                txtRoomName.Text = dgvRooms.CurrentRow.Cells["RoomName"].Value?.ToString();
               // txtPassword.Text = dgvRooms.CurrentRow.Cells["Password"].Value?.ToString();
                cmbRoomType.Text = dgvRooms.CurrentRow.Cells["RoomType"].Value?.ToString();
            }
            else
            {
                selectedRoomId = -1;
                txtRoomName.Clear();
              //  txtPassword.Clear();
                cmbRoomType.SelectedIndex = -1;
            }
        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvRooms.SelectedRows[0];

                // Assign values to text boxes
                txtRoomName.Text = selectedRow.Cells["RoomName"].Value?.ToString();

            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {

            {
                // Validate room name
                if (string.IsNullOrWhiteSpace(txtRoomName.Text))
                {
                    MessageBox.Show("Please enter a Room Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Optionally use a dropdown or set a default type
                string roomType = "Classroom"; // You can change this or get it from a ComboBox

                // Create new Room object
                Room room = new Room
                {
                    RoomName = txtRoomName.Text.Trim(),
                    RoomType = roomType
                };

                // Add to database using controller
                try
                {
                    RoomController roomController = new RoomController();
                    roomController.Create(room);
                    MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear input and refresh DataGridView
                    txtRoomName.Clear();
                    LoadRooms(); // You should define this method to reload dgvRooms
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding room: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }
        private void LoadRooms()
        {
            RoomController roomController = new RoomController();
            var roomList = roomController.GetAll(); // Get all rooms from DB

            dgvRooms.DataSource = null;
            dgvRooms.DataSource = roomList;

            // Optional: auto-size columns for better appearance
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearFields()
        {
            txtRoomName.Text = "";
        }

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {

            {
                Room updatedRoom = new Room
                {
                    RoomID = selectedRoomId,
                    RoomName = txtRoomName.Text.Trim(),
                    RoomType= cmbRoomType.Text.Trim()
                };

                RoomController roomController = new RoomController();
                roomController.Update(updatedRoom);

                LoadRooms(); // Refresh the grid after update

            }
        }

        private RoomController roomController = new RoomController();
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            {
            if (dgvRooms.CurrentRow == null)
            {
                MessageBox.Show("Please select a room to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roomId = Convert.ToInt32(dgvRooms.CurrentRow.Cells["RoomID"].Value);

            var result = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                try
                {
                    roomController.Delete(roomId);
                    MessageBox.Show("Room deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRooms(); // refresh the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete the room: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
}
}
