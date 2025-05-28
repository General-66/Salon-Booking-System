namespace Salon_Appointment_System
{
    partial class CreateAppointment
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
            this.lblNew = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblStaffMember = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.cmbStaffMember = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.Location = new System.Drawing.Point(37, 25);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(255, 38);
            this.lblNew.TabIndex = 0;
            this.lblNew.Text = "New Appointment";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(18, 136);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(110, 23);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Client Name:";
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(59, 196);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(69, 23);
            this.lblService.TabIndex = 2;
            this.lblService.Text = "Service:";
            this.lblService.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStaffMember
            // 
            this.lblStaffMember.AutoSize = true;
            this.lblStaffMember.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffMember.Location = new System.Drawing.Point(9, 255);
            this.lblStaffMember.Name = "lblStaffMember";
            this.lblStaffMember.Size = new System.Drawing.Size(119, 23);
            this.lblStaffMember.TabIndex = 3;
            this.lblStaffMember.Text = "Staff Member:";
            this.lblStaffMember.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(77, 317);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 23);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(69, 386);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(59, 23);
            this.lblNotes.TabIndex = 5;
            this.lblNotes.Text = "Notes:";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(526, 458);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(632, 458);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(151, 136);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(241, 25);
            this.txtClientName.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 317);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 25);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Items.AddRange(new object[] {
            "Manicure",
            "Pedicure",
            "Haircut",
            "Facial",
            "Waxing",
            "Massage"});
            this.cmbService.Location = new System.Drawing.Point(151, 193);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(241, 26);
            this.cmbService.TabIndex = 11;
            // 
            // cmbStaffMember
            // 
            this.cmbStaffMember.FormattingEnabled = true;
            this.cmbStaffMember.Items.AddRange(new object[] {
            "Max",
            "Reabetsoe",
            "Munaka"});
            this.cmbStaffMember.Location = new System.Drawing.Point(151, 253);
            this.cmbStaffMember.Name = "cmbStaffMember";
            this.cmbStaffMember.Size = new System.Drawing.Size(241, 26);
            this.cmbStaffMember.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 386);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 74);
            this.textBox2.TabIndex = 13;
            // 
            // CreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Salon_Appointment_System.Properties.Resources._BG;
            this.ClientSize = new System.Drawing.Size(742, 504);
            this.ControlBox = false;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cmbStaffMember);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblStaffMember);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblNew);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold);
            this.Name = "CreateAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblStaffMember;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.ComboBox cmbStaffMember;
        private System.Windows.Forms.TextBox textBox2;
    }
}