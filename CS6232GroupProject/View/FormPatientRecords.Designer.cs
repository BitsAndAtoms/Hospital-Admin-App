namespace CS6232GroupProject.View
{
    partial class FormPatientRecords
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatientRecords));
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPatientRecordsAppointment = new System.Windows.Forms.Label();
            this.comboBoxPatientRecordsAppointment = new System.Windows.Forms.ComboBox();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPatientRecords = new System.Windows.Forms.Label();
            this.userControlPatientRecords1 = new CS6232GroupProject.UserControls.UserControlPatientRecords();
            this.appointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 395F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.labelPatientRecordsAppointment, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.comboBoxPatientRecordsAppointment, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.labelPatientRecords, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(806, 54);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // labelPatientRecordsAppointment
            // 
            this.labelPatientRecordsAppointment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPatientRecordsAppointment.AutoSize = true;
            this.labelPatientRecordsAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientRecordsAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelPatientRecordsAppointment.Location = new System.Drawing.Point(398, 17);
            this.labelPatientRecordsAppointment.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelPatientRecordsAppointment.Name = "labelPatientRecordsAppointment";
            this.labelPatientRecordsAppointment.Size = new System.Drawing.Size(167, 20);
            this.labelPatientRecordsAppointment.TabIndex = 12;
            this.labelPatientRecordsAppointment.Text = "Select Appointment";
            // 
            // comboBoxPatientRecordsAppointment
            // 
            this.comboBoxPatientRecordsAppointment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxPatientRecordsAppointment.DataSource = this.appointmentBindingSource1;
            this.comboBoxPatientRecordsAppointment.DisplayMember = "AppointmentDateTime";
            this.comboBoxPatientRecordsAppointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatientRecordsAppointment.FormattingEnabled = true;
            this.comboBoxPatientRecordsAppointment.Location = new System.Drawing.Point(595, 16);
            this.comboBoxPatientRecordsAppointment.Name = "comboBoxPatientRecordsAppointment";
            this.comboBoxPatientRecordsAppointment.Size = new System.Drawing.Size(179, 21);
            this.comboBoxPatientRecordsAppointment.TabIndex = 2;
            this.comboBoxPatientRecordsAppointment.ValueMember = "AppointmentID";
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(CS6232GroupProject.Model.Appointment);
            // 
            // labelPatientRecords
            // 
            this.labelPatientRecords.AutoSize = true;
            this.labelPatientRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelPatientRecords.Location = new System.Drawing.Point(3, 0);
            this.labelPatientRecords.Name = "labelPatientRecords";
            this.labelPatientRecords.Size = new System.Drawing.Size(199, 29);
            this.labelPatientRecords.TabIndex = 1;
            this.labelPatientRecords.Text = "Patient Records";
            // 
            // userControlPatientRecords1
            // 
            this.userControlPatientRecords1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControlPatientRecords1.Location = new System.Drawing.Point(0, 57);
            this.userControlPatientRecords1.Name = "userControlPatientRecords1";
            this.userControlPatientRecords1.Size = new System.Drawing.Size(806, 506);
            this.userControlPatientRecords1.TabIndex = 2;
            // 
            // appointmentBindingSource1
            // 
            this.appointmentBindingSource1.DataSource = typeof(CS6232GroupProject.Model.Appointment);
            // 
            // FormPatientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 563);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Controls.Add(this.userControlPatientRecords1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPatientRecords";
            this.Text = "ClinicCare - Patient Records";
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.UserControlPatientRecords userControlPatientRecords1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label labelPatientRecordsAppointment;
        private System.Windows.Forms.ComboBox comboBoxPatientRecordsAppointment;
        private System.Windows.Forms.Label labelPatientRecords;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.BindingSource appointmentBindingSource1;
    }
}