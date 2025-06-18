namespace Unicom_TIC_Management_System.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimetableForm));
            this.Lb = new System.Windows.Forms.Label();
            this.Lbl = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.txtTimeSlot = new System.Windows.Forms.TextBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Bt = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb
            // 
            this.Lb.AutoSize = true;
            this.Lb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lb.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb.Location = new System.Drawing.Point(127, 34);
            this.Lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb.Name = "Lb";
            this.Lb.Size = new System.Drawing.Size(59, 13);
            this.Lb.TabIndex = 0;
            this.Lb.Text = "Subject";
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl.Location = new System.Drawing.Point(127, 77);
            this.Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(71, 13);
            this.Lbl.TabIndex = 1;
            this.Lbl.Text = "Time Slot";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb3.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb3.Location = new System.Drawing.Point(127, 117);
            this.lb3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(42, 13);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "Room";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(226, 31);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(144, 21);
            this.cmbSubject.TabIndex = 3;
            this.cmbSubject.Text = "DropDownList";
            // 
            // txtTimeSlot
            // 
            this.txtTimeSlot.Location = new System.Drawing.Point(226, 77);
            this.txtTimeSlot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimeSlot.Name = "txtTimeSlot";
            this.txtTimeSlot.Size = new System.Drawing.Size(144, 20);
            this.txtTimeSlot.TabIndex = 4;
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(226, 117);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(144, 21);
            this.cmbRoom.TabIndex = 5;
            this.cmbRoom.Text = "DropDownList";
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(414, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 24);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Bt
            // 
            this.Bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bt.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bt.Location = new System.Drawing.Point(413, 77);
            this.Bt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bt.Name = "Bt";
            this.Bt.Size = new System.Drawing.Size(70, 23);
            this.Bt.TabIndex = 7;
            this.Bt.Text = "Update";
            this.Bt.UseVisualStyleBackColor = false;
            this.Bt.Click += new System.EventHandler(this.Bt_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(413, 117);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 22);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetable.Location = new System.Drawing.Point(66, 159);
            this.dgvTimetable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.RowHeadersWidth = 62;
            this.dgvTimetable.RowTemplate.Height = 28;
            this.dgvTimetable.Size = new System.Drawing.Size(489, 181);
            this.dgvTimetable.TabIndex = 9;
            this.dgvTimetable.SelectionChanged += new System.EventHandler(this.dgvTimetable_systemchanged);
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 376);
            this.Controls.Add(this.dgvTimetable);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Bt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.txtTimeSlot);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.Lb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimetableForm";
            this.Text = "TimetableForm";
            this.Load += new System.EventHandler(this.TimetableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.TextBox txtTimeSlot;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Bt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTimetable;
    }
}