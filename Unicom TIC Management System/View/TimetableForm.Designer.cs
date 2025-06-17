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
            this.Lb.Location = new System.Drawing.Point(282, 58);
            this.Lb.Name = "Lb";
            this.Lb.Size = new System.Drawing.Size(63, 20);
            this.Lb.TabIndex = 0;
            this.Lb.Text = "Subject";
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(282, 155);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(75, 20);
            this.Lbl.TabIndex = 1;
            this.Lbl.Text = "Time Slot";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(282, 243);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(52, 20);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "Room";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(420, 58);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(133, 28);
            this.cmbSubject.TabIndex = 3;
            this.cmbSubject.Text = "DropDownList";
            // 
            // txtTimeSlot
            // 
            this.txtTimeSlot.Location = new System.Drawing.Point(431, 148);
            this.txtTimeSlot.Name = "txtTimeSlot";
            this.txtTimeSlot.Size = new System.Drawing.Size(100, 26);
            this.txtTimeSlot.TabIndex = 4;
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(431, 234);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(121, 28);
            this.cmbRoom.TabIndex = 5;
            this.cmbRoom.Text = "DropDownList";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(621, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Bt
            // 
            this.Bt.Location = new System.Drawing.Point(621, 155);
            this.Bt.Name = "Bt";
            this.Bt.Size = new System.Drawing.Size(75, 23);
            this.Bt.TabIndex = 7;
            this.Bt.Text = "Update";
            this.Bt.UseVisualStyleBackColor = true;
            this.Bt.Click += new System.EventHandler(this.Bt_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(621, 234);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetable.Location = new System.Drawing.Point(152, 317);
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.RowHeadersWidth = 62;
            this.dgvTimetable.RowTemplate.Height = 28;
            this.dgvTimetable.Size = new System.Drawing.Size(872, 281);
            this.dgvTimetable.TabIndex = 9;
            this.dgvTimetable.SelectionChanged += new System.EventHandler(this.dgvTimetable_systemchanged);
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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