namespace Unicom_TIC_Management_System.View
{
    partial class RoomForm
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
            this.Roomname = new System.Windows.Forms.Label();
            this.RoomType = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // Roomname
            // 
            this.Roomname.AutoSize = true;
            this.Roomname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Roomname.Location = new System.Drawing.Point(342, 151);
            this.Roomname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Roomname.Name = "Roomname";
            this.Roomname.Size = new System.Drawing.Size(108, 20);
            this.Roomname.TabIndex = 0;
            this.Roomname.Text = "ROOM NAME";
            // 
            // RoomType
            // 
            this.RoomType.AutoSize = true;
            this.RoomType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RoomType.Location = new System.Drawing.Point(344, 232);
            this.RoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(103, 20);
            this.RoomType.TabIndex = 2;
            this.RoomType.Text = "ROOM TYPE";
            // 
            // txtRoomName
            // 
            this.txtRoomName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtRoomName.Location = new System.Drawing.Point(528, 146);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(234, 26);
            this.txtRoomName.TabIndex = 3;
            this.txtRoomName.TextChanged += new System.EventHandler(this.txtRoomName_TextChanged);
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(508, 228);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(253, 28);
            this.cmbRoomType.TabIndex = 4;
            this.cmbRoomType.Text = "Values: Room  ,   Hall";
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.Coral;
            this.btnDeleteRoom.Location = new System.Drawing.Point(346, 325);
            this.btnDeleteRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(104, 32);
            this.btnDeleteRoom.TabIndex = 5;
            this.btnDeleteRoom.Text = "DELETE";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateRoom.Location = new System.Drawing.Point(508, 325);
            this.btnUpdateRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(104, 32);
            this.btnUpdateRoom.TabIndex = 6;
            this.btnUpdateRoom.Text = "UPDATE ";
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddRoom.Location = new System.Drawing.Point(675, 325);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(104, 32);
            this.btnAddRoom.TabIndex = 7;
            this.btnAddRoom.Text = "ADD ROOM";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // dgvRooms
            // 
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(346, 388);
            this.dgvRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersWidth = 62;
            this.dgvRooms.Size = new System.Drawing.Size(590, 224);
            this.dgvRooms.TabIndex = 8;
            this.dgvRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
            this.dgvRooms.SelectionChanged += new System.EventHandler(this.ShowsRoomList);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.RoomType);
            this.Controls.Add(this.Roomname);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Roomname;
        private System.Windows.Forms.Label RoomType;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.DataGridView dgvRooms;
    }

}