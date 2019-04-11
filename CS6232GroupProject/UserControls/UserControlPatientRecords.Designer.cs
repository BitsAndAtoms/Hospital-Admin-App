namespace CS6232GroupProject.UserControls
{
    partial class UserControlPatientRecords
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlPatientRecords = new System.Windows.Forms.TabControl();
            this.tabPageAppointments = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerAppointmentsTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAppointments = new System.Windows.Forms.DateTimePicker();
            this.textBoxAppointmentsSummary = new System.Windows.Forms.TextBox();
            this.labelAppointmentsSummary = new System.Windows.Forms.Label();
            this.labelAppointmentsPhysician = new System.Windows.Forms.Label();
            this.buttonAppointmentsUpdate = new System.Windows.Forms.Button();
            this.linkLabelAppointmentsCancel = new System.Windows.Forms.LinkLabel();
            this.comboBoxAppointmentsPhysician = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelAppointmentsDateTime = new System.Windows.Forms.Label();
            this.labelAppointments = new System.Windows.Forms.Label();
            this.tabPageRoutineChecks = new System.Windows.Forms.TabPage();
            this.tableLayoutRoutineChecks = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRoutineChecksSummary = new System.Windows.Forms.Label();
            this.textBoxRoutineChecksSummary = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRoutineChecksDiastolic = new System.Windows.Forms.TextBox();
            this.labelRoutineChecksSystolic = new System.Windows.Forms.Label();
            this.labelRoutineChecksDiastolic = new System.Windows.Forms.Label();
            this.textBoxRoutineChecksSystolic = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textRoutineChecksPulse = new System.Windows.Forms.TextBox();
            this.labelRoutineChecksPulse = new System.Windows.Forms.Label();
            this.buttonRoutineChecksUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRoutineChecksTemp = new System.Windows.Forms.TextBox();
            this.labelRoutineChecksWeight = new System.Windows.Forms.Label();
            this.labelRoutineChecksTemp = new System.Windows.Forms.Label();
            this.textBoxRoutineChecksWeight = new System.Windows.Forms.TextBox();
            this.labelRoutineChecksBloodPressure = new System.Windows.Forms.Label();
            this.labelRoutineChecks = new System.Windows.Forms.Label();
            this.tabPageDiagnosis = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelDiagnosis = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDiagnosisInitial = new System.Windows.Forms.Label();
            this.textBoxDiagnosisIntial = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDiagnosisFinal = new System.Windows.Forms.Label();
            this.textBoxDiagnosisFinal = new System.Windows.Forms.TextBox();
            this.buttonDiagnosisUpdate = new System.Windows.Forms.Button();
            this.checkBoxPendingLabTests = new System.Windows.Forms.CheckBox();
            this.labelDiagnosis = new System.Windows.Forms.Label();
            this.tabPageLabTests = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelLabTestsInformation = new System.Windows.Forms.Label();
            this.checkedListBoxLabTests = new System.Windows.Forms.CheckedListBox();
            this.buttonLabTestsSubmit = new System.Windows.Forms.Button();
            this.labelLabTests = new System.Windows.Forms.Label();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPatientRecordsAppointment = new System.Windows.Forms.Label();
            this.comboBoxPatientRecordsAppointment = new System.Windows.Forms.ComboBox();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPatientRecords = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlPatientRecords.SuspendLayout();
            this.tabPageAppointments.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.tabPageRoutineChecks.SuspendLayout();
            this.tableLayoutRoutineChecks.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabPageDiagnosis.SuspendLayout();
            this.tableLayoutPanelDiagnosis.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPageLabTests.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPatientRecords
            // 
            this.tabControlPatientRecords.Controls.Add(this.tabPageAppointments);
            this.tabControlPatientRecords.Controls.Add(this.tabPageRoutineChecks);
            this.tabControlPatientRecords.Controls.Add(this.tabPageDiagnosis);
            this.tabControlPatientRecords.Controls.Add(this.tabPageLabTests);
            this.tabControlPatientRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPatientRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPatientRecords.ItemSize = new System.Drawing.Size(147, 25);
            this.tabControlPatientRecords.Location = new System.Drawing.Point(0, 0);
            this.tabControlPatientRecords.Name = "tabControlPatientRecords";
            this.tabControlPatientRecords.SelectedIndex = 0;
            this.tabControlPatientRecords.Size = new System.Drawing.Size(839, 534);
            this.tabControlPatientRecords.TabIndex = 0;
            // 
            // tabPageAppointments
            // 
            this.tabPageAppointments.AutoScroll = true;
            this.tabPageAppointments.Controls.Add(this.tableLayoutPanel7);
            this.tabPageAppointments.Controls.Add(this.labelAppointments);
            this.tabPageAppointments.Location = new System.Drawing.Point(4, 29);
            this.tabPageAppointments.Name = "tabPageAppointments";
            this.tabPageAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppointments.Size = new System.Drawing.Size(831, 501);
            this.tabPageAppointments.TabIndex = 3;
            this.tabPageAppointments.Text = "Appointments";
            this.tabPageAppointments.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.87879F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.12122F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.textBoxAppointmentsSummary, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.labelAppointmentsSummary, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.labelAppointmentsPhysician, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.buttonAppointmentsUpdate, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.linkLabelAppointmentsCancel, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.comboBoxAppointmentsPhysician, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.labelAppointmentsDateTime, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(825, 460);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.dateTimePickerAppointmentsTime, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.dateTimePickerAppointments, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(166, 52);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(337, 44);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // dateTimePickerAppointmentsTime
            // 
            this.dateTimePickerAppointmentsTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerAppointmentsTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerAppointmentsTime.Location = new System.Drawing.Point(171, 9);
            this.dateTimePickerAppointmentsTime.Name = "dateTimePickerAppointmentsTime";
            this.dateTimePickerAppointmentsTime.Size = new System.Drawing.Size(127, 26);
            this.dateTimePickerAppointmentsTime.TabIndex = 5;
            // 
            // dateTimePickerAppointments
            // 
            this.dateTimePickerAppointments.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerAppointments.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAppointments.Location = new System.Drawing.Point(3, 9);
            this.dateTimePickerAppointments.Name = "dateTimePickerAppointments";
            this.dateTimePickerAppointments.Size = new System.Drawing.Size(162, 26);
            this.dateTimePickerAppointments.TabIndex = 4;
            // 
            // textBoxAppointmentsSummary
            // 
            this.textBoxAppointmentsSummary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAppointmentsSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAppointmentsSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAppointmentsSummary.Location = new System.Drawing.Point(166, 113);
            this.textBoxAppointmentsSummary.Multiline = true;
            this.textBoxAppointmentsSummary.Name = "textBoxAppointmentsSummary";
            this.textBoxAppointmentsSummary.Size = new System.Drawing.Size(427, 121);
            this.textBoxAppointmentsSummary.TabIndex = 6;
            // 
            // labelAppointmentsSummary
            // 
            this.labelAppointmentsSummary.AutoSize = true;
            this.labelAppointmentsSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentsSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelAppointmentsSummary.Location = new System.Drawing.Point(3, 99);
            this.labelAppointmentsSummary.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelAppointmentsSummary.Name = "labelAppointmentsSummary";
            this.labelAppointmentsSummary.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelAppointmentsSummary.Size = new System.Drawing.Size(108, 20);
            this.labelAppointmentsSummary.TabIndex = 3;
            this.labelAppointmentsSummary.Text = "Summary";
            // 
            // labelAppointmentsPhysician
            // 
            this.labelAppointmentsPhysician.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAppointmentsPhysician.AutoSize = true;
            this.labelAppointmentsPhysician.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentsPhysician.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelAppointmentsPhysician.Location = new System.Drawing.Point(3, 14);
            this.labelAppointmentsPhysician.Name = "labelAppointmentsPhysician";
            this.labelAppointmentsPhysician.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelAppointmentsPhysician.Size = new System.Drawing.Size(109, 20);
            this.labelAppointmentsPhysician.TabIndex = 2;
            this.labelAppointmentsPhysician.Text = "Physician";
            // 
            // buttonAppointmentsUpdate
            // 
            this.buttonAppointmentsUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAppointmentsUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.buttonAppointmentsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAppointmentsUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentsUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonAppointmentsUpdate.Location = new System.Drawing.Point(425, 256);
            this.buttonAppointmentsUpdate.Name = "buttonAppointmentsUpdate";
            this.buttonAppointmentsUpdate.Size = new System.Drawing.Size(137, 35);
            this.buttonAppointmentsUpdate.TabIndex = 7;
            this.buttonAppointmentsUpdate.Text = "Update";
            this.buttonAppointmentsUpdate.UseVisualStyleBackColor = false;
            this.buttonAppointmentsUpdate.Click += new System.EventHandler(this.buttonAppointmentsUpdate_Click);
            // 
            // linkLabelAppointmentsCancel
            // 
            this.linkLabelAppointmentsCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelAppointmentsCancel.AutoSize = true;
            this.linkLabelAppointmentsCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAppointmentsCancel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.linkLabelAppointmentsCancel.Location = new System.Drawing.Point(633, 299);
            this.linkLabelAppointmentsCancel.Name = "linkLabelAppointmentsCancel";
            this.linkLabelAppointmentsCancel.Size = new System.Drawing.Size(189, 25);
            this.linkLabelAppointmentsCancel.TabIndex = 8;
            this.linkLabelAppointmentsCancel.TabStop = true;
            this.linkLabelAppointmentsCancel.Text = "Cancel Appointment";
            this.linkLabelAppointmentsCancel.Visible = false;
            // 
            // comboBoxAppointmentsPhysician
            // 
            this.comboBoxAppointmentsPhysician.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxAppointmentsPhysician.DataSource = this.doctorBindingSource;
            this.comboBoxAppointmentsPhysician.DisplayMember = "FullName";
            this.comboBoxAppointmentsPhysician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAppointmentsPhysician.FormattingEnabled = true;
            this.comboBoxAppointmentsPhysician.Location = new System.Drawing.Point(166, 10);
            this.comboBoxAppointmentsPhysician.Name = "comboBoxAppointmentsPhysician";
            this.comboBoxAppointmentsPhysician.Size = new System.Drawing.Size(298, 28);
            this.comboBoxAppointmentsPhysician.TabIndex = 3;
            this.comboBoxAppointmentsPhysician.ValueMember = "DoctorID";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(CS6232GroupProject.Model.Doctor);
            // 
            // labelAppointmentsDateTime
            // 
            this.labelAppointmentsDateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAppointmentsDateTime.AutoSize = true;
            this.labelAppointmentsDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentsDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelAppointmentsDateTime.Location = new System.Drawing.Point(3, 64);
            this.labelAppointmentsDateTime.Name = "labelAppointmentsDateTime";
            this.labelAppointmentsDateTime.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelAppointmentsDateTime.Size = new System.Drawing.Size(116, 20);
            this.labelAppointmentsDateTime.TabIndex = 16;
            this.labelAppointmentsDateTime.Text = "Date Time";
            // 
            // labelAppointments
            // 
            this.labelAppointments.AutoSize = true;
            this.labelAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelAppointments.Location = new System.Drawing.Point(3, 3);
            this.labelAppointments.Name = "labelAppointments";
            this.labelAppointments.Size = new System.Drawing.Size(172, 29);
            this.labelAppointments.TabIndex = 6;
            this.labelAppointments.Text = "Appointments";
            // 
            // tabPageRoutineChecks
            // 
            this.tabPageRoutineChecks.AutoScroll = true;
            this.tabPageRoutineChecks.Controls.Add(this.tableLayoutRoutineChecks);
            this.tabPageRoutineChecks.Controls.Add(this.labelRoutineChecks);
            this.tabPageRoutineChecks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageRoutineChecks.Location = new System.Drawing.Point(4, 29);
            this.tabPageRoutineChecks.Name = "tabPageRoutineChecks";
            this.tabPageRoutineChecks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoutineChecks.Size = new System.Drawing.Size(831, 501);
            this.tabPageRoutineChecks.TabIndex = 0;
            this.tabPageRoutineChecks.Text = "Routine Checks";
            this.tabPageRoutineChecks.UseVisualStyleBackColor = true;
            // 
            // tableLayoutRoutineChecks
            // 
            this.tableLayoutRoutineChecks.AutoScroll = true;
            this.tableLayoutRoutineChecks.ColumnCount = 2;
            this.tableLayoutRoutineChecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutRoutineChecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tableLayoutRoutineChecks.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutRoutineChecks.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tableLayoutRoutineChecks.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutRoutineChecks.Controls.Add(this.buttonRoutineChecksUpdate, 1, 5);
            this.tableLayoutRoutineChecks.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutRoutineChecks.Controls.Add(this.labelRoutineChecksBloodPressure, 1, 2);
            this.tableLayoutRoutineChecks.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutRoutineChecks.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutRoutineChecks.Name = "tableLayoutRoutineChecks";
            this.tableLayoutRoutineChecks.RowCount = 6;
            this.tableLayoutRoutineChecks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutRoutineChecks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutRoutineChecks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutRoutineChecks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutRoutineChecks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutRoutineChecks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoutineChecks.Size = new System.Drawing.Size(825, 405);
            this.tableLayoutRoutineChecks.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelRoutineChecksSummary, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxRoutineChecksSummary, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(77, 203);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(465, 147);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // labelRoutineChecksSummary
            // 
            this.labelRoutineChecksSummary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRoutineChecksSummary.AutoSize = true;
            this.labelRoutineChecksSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoutineChecksSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelRoutineChecksSummary.Location = new System.Drawing.Point(3, 0);
            this.labelRoutineChecksSummary.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRoutineChecksSummary.Name = "labelRoutineChecksSummary";
            this.labelRoutineChecksSummary.Size = new System.Drawing.Size(83, 20);
            this.labelRoutineChecksSummary.TabIndex = 11;
            this.labelRoutineChecksSummary.Text = "Summary";
            // 
            // textBoxRoutineChecksSummary
            // 
            this.textBoxRoutineChecksSummary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRoutineChecksSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRoutineChecksSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoutineChecksSummary.Location = new System.Drawing.Point(3, 23);
            this.textBoxRoutineChecksSummary.Multiline = true;
            this.textBoxRoutineChecksSummary.Name = "textBoxRoutineChecksSummary";
            this.textBoxRoutineChecksSummary.Size = new System.Drawing.Size(427, 121);
            this.textBoxRoutineChecksSummary.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxRoutineChecksDiastolic, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRoutineChecksSystolic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRoutineChecksDiastolic, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRoutineChecksSystolic, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(77, 143);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 54);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // textBoxRoutineChecksDiastolic
            // 
            this.textBoxRoutineChecksDiastolic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRoutineChecksDiastolic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRoutineChecksDiastolic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoutineChecksDiastolic.Location = new System.Drawing.Point(208, 23);
            this.textBoxRoutineChecksDiastolic.Name = "textBoxRoutineChecksDiastolic";
            this.textBoxRoutineChecksDiastolic.Size = new System.Drawing.Size(186, 29);
            this.textBoxRoutineChecksDiastolic.TabIndex = 10;
            // 
            // labelRoutineChecksSystolic
            // 
            this.labelRoutineChecksSystolic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRoutineChecksSystolic.AutoSize = true;
            this.labelRoutineChecksSystolic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoutineChecksSystolic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelRoutineChecksSystolic.Location = new System.Drawing.Point(3, 0);
            this.labelRoutineChecksSystolic.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRoutineChecksSystolic.Name = "labelRoutineChecksSystolic";
            this.labelRoutineChecksSystolic.Size = new System.Drawing.Size(71, 20);
            this.labelRoutineChecksSystolic.TabIndex = 11;
            this.labelRoutineChecksSystolic.Text = "Systolic";
            // 
            // labelRoutineChecksDiastolic
            // 
            this.labelRoutineChecksDiastolic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRoutineChecksDiastolic.AutoSize = true;
            this.labelRoutineChecksDiastolic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoutineChecksDiastolic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelRoutineChecksDiastolic.Location = new System.Drawing.Point(208, 0);
            this.labelRoutineChecksDiastolic.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRoutineChecksDiastolic.Name = "labelRoutineChecksDiastolic";
            this.labelRoutineChecksDiastolic.Size = new System.Drawing.Size(78, 20);
            this.labelRoutineChecksDiastolic.TabIndex = 14;
            this.labelRoutineChecksDiastolic.Text = "Diastolic";
            // 
            // textBoxRoutineChecksSystolic
            // 
            this.textBoxRoutineChecksSystolic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRoutineChecksSystolic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRoutineChecksSystolic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoutineChecksSystolic.Location = new System.Drawing.Point(3, 23);
            this.textBoxRoutineChecksSystolic.Name = "textBoxRoutineChecksSystolic";
            this.textBoxRoutineChecksSystolic.Size = new System.Drawing.Size(186, 29);
            this.textBoxRoutineChecksSystolic.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.textRoutineChecksPulse, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelRoutineChecksPulse, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(77, 63);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 54);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // textRoutineChecksPulse
            // 
            this.textRoutineChecksPulse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textRoutineChecksPulse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRoutineChecksPulse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRoutineChecksPulse.Location = new System.Drawing.Point(3, 23);
            this.textRoutineChecksPulse.Name = "textRoutineChecksPulse";
            this.textRoutineChecksPulse.Size = new System.Drawing.Size(186, 29);
            this.textRoutineChecksPulse.TabIndex = 7;
            // 
            // labelRoutineChecksPulse
            // 
            this.labelRoutineChecksPulse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRoutineChecksPulse.AutoSize = true;
            this.labelRoutineChecksPulse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoutineChecksPulse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelRoutineChecksPulse.Location = new System.Drawing.Point(3, 0);
            this.labelRoutineChecksPulse.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRoutineChecksPulse.Name = "labelRoutineChecksPulse";
            this.labelRoutineChecksPulse.Size = new System.Drawing.Size(53, 20);
            this.labelRoutineChecksPulse.TabIndex = 11;
            this.labelRoutineChecksPulse.Text = "Pulse";
            // 
            // buttonRoutineChecksUpdate
            // 
            this.buttonRoutineChecksUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRoutineChecksUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.buttonRoutineChecksUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoutineChecksUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoutineChecksUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonRoutineChecksUpdate.Location = new System.Drawing.Point(381, 361);
            this.buttonRoutineChecksUpdate.Name = "buttonRoutineChecksUpdate";
            this.buttonRoutineChecksUpdate.Size = new System.Drawing.Size(137, 35);
            this.buttonRoutineChecksUpdate.TabIndex = 13;
            this.buttonRoutineChecksUpdate.Text = "Update";
            this.buttonRoutineChecksUpdate.UseVisualStyleBackColor = false;
            this.buttonRoutineChecksUpdate.Click += new System.EventHandler(this.buttonRoutineChecksUpdate_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.textBoxRoutineChecksTemp, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.labelRoutineChecksWeight, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.labelRoutineChecksTemp, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBoxRoutineChecksWeight, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(77, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(410, 54);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // textBoxRoutineChecksTemp
            // 
            this.textBoxRoutineChecksTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRoutineChecksTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRoutineChecksTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoutineChecksTemp.Location = new System.Drawing.Point(208, 23);
            this.textBoxRoutineChecksTemp.Name = "textBoxRoutineChecksTemp";
            this.textBoxRoutineChecksTemp.Size = new System.Drawing.Size(186, 29);
            this.textBoxRoutineChecksTemp.TabIndex = 5;
            // 
            // labelRoutineChecksWeight
            // 
            this.labelRoutineChecksWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRoutineChecksWeight.AutoSize = true;
            this.labelRoutineChecksWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoutineChecksWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelRoutineChecksWeight.Location = new System.Drawing.Point(3, 0);
            this.labelRoutineChecksWeight.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRoutineChecksWeight.Name = "labelRoutineChecksWeight";
            this.labelRoutineChecksWeight.Size = new System.Drawing.Size(65, 20);
            this.labelRoutineChecksWeight.TabIndex = 11;
            this.labelRoutineChecksWeight.Text = "Weight";
            // 
            // labelRoutineChecksTemp
            // 
            this.labelRoutineChecksTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRoutineChecksTemp.AutoSize = true;
            this.labelRoutineChecksTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoutineChecksTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelRoutineChecksTemp.Location = new System.Drawing.Point(208, 0);
            this.labelRoutineChecksTemp.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRoutineChecksTemp.Name = "labelRoutineChecksTemp";
            this.labelRoutineChecksTemp.Size = new System.Drawing.Size(111, 20);
            this.labelRoutineChecksTemp.TabIndex = 14;
            this.labelRoutineChecksTemp.Text = "Temperature";
            // 
            // textBoxRoutineChecksWeight
            // 
            this.textBoxRoutineChecksWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRoutineChecksWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRoutineChecksWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoutineChecksWeight.Location = new System.Drawing.Point(3, 23);
            this.textBoxRoutineChecksWeight.Name = "textBoxRoutineChecksWeight";
            this.textBoxRoutineChecksWeight.Size = new System.Drawing.Size(186, 29);
            this.textBoxRoutineChecksWeight.TabIndex = 4;
            // 
            // labelRoutineChecksBloodPressure
            // 
            this.labelRoutineChecksBloodPressure.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRoutineChecksBloodPressure.AutoSize = true;
            this.labelRoutineChecksBloodPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoutineChecksBloodPressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelRoutineChecksBloodPressure.Location = new System.Drawing.Point(77, 120);
            this.labelRoutineChecksBloodPressure.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRoutineChecksBloodPressure.Name = "labelRoutineChecksBloodPressure";
            this.labelRoutineChecksBloodPressure.Size = new System.Drawing.Size(131, 20);
            this.labelRoutineChecksBloodPressure.TabIndex = 13;
            this.labelRoutineChecksBloodPressure.Text = "Blood Pressure";
            // 
            // labelRoutineChecks
            // 
            this.labelRoutineChecks.AutoSize = true;
            this.labelRoutineChecks.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRoutineChecks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoutineChecks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelRoutineChecks.Location = new System.Drawing.Point(3, 3);
            this.labelRoutineChecks.Name = "labelRoutineChecks";
            this.labelRoutineChecks.Size = new System.Drawing.Size(196, 29);
            this.labelRoutineChecks.TabIndex = 6;
            this.labelRoutineChecks.Text = "Routine Checks";
            // 
            // tabPageDiagnosis
            // 
            this.tabPageDiagnosis.AutoScroll = true;
            this.tabPageDiagnosis.Controls.Add(this.tableLayoutPanelDiagnosis);
            this.tabPageDiagnosis.Controls.Add(this.labelDiagnosis);
            this.tabPageDiagnosis.Location = new System.Drawing.Point(4, 29);
            this.tabPageDiagnosis.Name = "tabPageDiagnosis";
            this.tabPageDiagnosis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDiagnosis.Size = new System.Drawing.Size(831, 501);
            this.tabPageDiagnosis.TabIndex = 1;
            this.tabPageDiagnosis.Text = "Diagnosis";
            this.tabPageDiagnosis.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelDiagnosis
            // 
            this.tableLayoutPanelDiagnosis.AutoScroll = true;
            this.tableLayoutPanelDiagnosis.ColumnCount = 2;
            this.tableLayoutPanelDiagnosis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelDiagnosis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelDiagnosis.Controls.Add(this.tableLayoutPanel10, 1, 0);
            this.tableLayoutPanelDiagnosis.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanelDiagnosis.Controls.Add(this.buttonDiagnosisUpdate, 1, 3);
            this.tableLayoutPanelDiagnosis.Controls.Add(this.checkBoxPendingLabTests, 1, 1);
            this.tableLayoutPanelDiagnosis.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelDiagnosis.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanelDiagnosis.Name = "tableLayoutPanelDiagnosis";
            this.tableLayoutPanelDiagnosis.RowCount = 4;
            this.tableLayoutPanelDiagnosis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanelDiagnosis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelDiagnosis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanelDiagnosis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelDiagnosis.Size = new System.Drawing.Size(825, 436);
            this.tableLayoutPanelDiagnosis.TabIndex = 8;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.labelDiagnosisInitial, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.textBoxDiagnosisIntial, 0, 1);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(85, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(465, 147);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // labelDiagnosisInitial
            // 
            this.labelDiagnosisInitial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDiagnosisInitial.AutoSize = true;
            this.labelDiagnosisInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiagnosisInitial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelDiagnosisInitial.Location = new System.Drawing.Point(3, 0);
            this.labelDiagnosisInitial.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelDiagnosisInitial.Name = "labelDiagnosisInitial";
            this.labelDiagnosisInitial.Size = new System.Drawing.Size(137, 20);
            this.labelDiagnosisInitial.TabIndex = 11;
            this.labelDiagnosisInitial.Text = "Initial Diagnosis";
            // 
            // textBoxDiagnosisIntial
            // 
            this.textBoxDiagnosisIntial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDiagnosisIntial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDiagnosisIntial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiagnosisIntial.Location = new System.Drawing.Point(3, 23);
            this.textBoxDiagnosisIntial.Multiline = true;
            this.textBoxDiagnosisIntial.Name = "textBoxDiagnosisIntial";
            this.textBoxDiagnosisIntial.Size = new System.Drawing.Size(427, 121);
            this.textBoxDiagnosisIntial.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.labelDiagnosisFinal, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxDiagnosisFinal, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(85, 206);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(465, 147);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // labelDiagnosisFinal
            // 
            this.labelDiagnosisFinal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDiagnosisFinal.AutoSize = true;
            this.labelDiagnosisFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiagnosisFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelDiagnosisFinal.Location = new System.Drawing.Point(3, 0);
            this.labelDiagnosisFinal.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelDiagnosisFinal.Name = "labelDiagnosisFinal";
            this.labelDiagnosisFinal.Size = new System.Drawing.Size(132, 20);
            this.labelDiagnosisFinal.TabIndex = 11;
            this.labelDiagnosisFinal.Text = "Final Diagnosis";
            // 
            // textBoxDiagnosisFinal
            // 
            this.textBoxDiagnosisFinal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDiagnosisFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDiagnosisFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiagnosisFinal.Location = new System.Drawing.Point(3, 23);
            this.textBoxDiagnosisFinal.Multiline = true;
            this.textBoxDiagnosisFinal.Name = "textBoxDiagnosisFinal";
            this.textBoxDiagnosisFinal.Size = new System.Drawing.Size(427, 121);
            this.textBoxDiagnosisFinal.TabIndex = 6;
            // 
            // buttonDiagnosisUpdate
            // 
            this.buttonDiagnosisUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDiagnosisUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.buttonDiagnosisUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiagnosisUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiagnosisUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonDiagnosisUpdate.Location = new System.Drawing.Point(385, 378);
            this.buttonDiagnosisUpdate.Name = "buttonDiagnosisUpdate";
            this.buttonDiagnosisUpdate.Size = new System.Drawing.Size(137, 35);
            this.buttonDiagnosisUpdate.TabIndex = 7;
            this.buttonDiagnosisUpdate.Text = "Update";
            this.buttonDiagnosisUpdate.UseVisualStyleBackColor = false;
            this.buttonDiagnosisUpdate.Visible = false;
            this.buttonDiagnosisUpdate.Click += new System.EventHandler(this.buttonDiagnosisUpdate_Click);
            // 
            // checkBoxPendingLabTests
            // 
            this.checkBoxPendingLabTests.AutoSize = true;
            this.checkBoxPendingLabTests.Location = new System.Drawing.Point(85, 156);
            this.checkBoxPendingLabTests.Name = "checkBoxPendingLabTests";
            this.checkBoxPendingLabTests.Size = new System.Drawing.Size(210, 24);
            this.checkBoxPendingLabTests.TabIndex = 4;
            this.checkBoxPendingLabTests.Text = "Pending Lab Test Results";
            this.checkBoxPendingLabTests.UseVisualStyleBackColor = true;
            // 
            // labelDiagnosis
            // 
            this.labelDiagnosis.AutoSize = true;
            this.labelDiagnosis.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiagnosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelDiagnosis.Location = new System.Drawing.Point(3, 3);
            this.labelDiagnosis.Name = "labelDiagnosis";
            this.labelDiagnosis.Size = new System.Drawing.Size(129, 29);
            this.labelDiagnosis.TabIndex = 6;
            this.labelDiagnosis.Text = "Diagnosis";
            // 
            // tabPageLabTests
            // 
            this.tabPageLabTests.Controls.Add(this.tableLayoutPanel3);
            this.tabPageLabTests.Controls.Add(this.labelLabTests);
            this.tabPageLabTests.Location = new System.Drawing.Point(4, 29);
            this.tabPageLabTests.Name = "tabPageLabTests";
            this.tabPageLabTests.Size = new System.Drawing.Size(831, 501);
            this.tabPageLabTests.TabIndex = 4;
            this.tabPageLabTests.Text = "Lab Tests";
            this.tabPageLabTests.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.Controls.Add(this.labelLabTestsInformation, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkedListBoxLabTests, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonLabTestsSubmit, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(831, 208);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // labelLabTestsInformation
            // 
            this.labelLabTestsInformation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLabTestsInformation.AutoSize = true;
            this.labelLabTestsInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLabTestsInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelLabTestsInformation.Location = new System.Drawing.Point(86, 4);
            this.labelLabTestsInformation.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelLabTestsInformation.Name = "labelLabTestsInformation";
            this.labelLabTestsInformation.Size = new System.Drawing.Size(156, 20);
            this.labelLabTestsInformation.TabIndex = 11;
            this.labelLabTestsInformation.Text = "Select Lab Test(s)";
            // 
            // checkedListBoxLabTests
            // 
            this.checkedListBoxLabTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxLabTests.FormattingEnabled = true;
            this.checkedListBoxLabTests.Items.AddRange(new object[] {
            "White Blood Cell (WBC)",
            "Low Density Lipoproteins (LDL)",
            "Hepatitis A",
            "Hepatitis B"});
            this.checkedListBoxLabTests.Location = new System.Drawing.Point(86, 31);
            this.checkedListBoxLabTests.Name = "checkedListBoxLabTests";
            this.checkedListBoxLabTests.Size = new System.Drawing.Size(251, 84);
            this.checkedListBoxLabTests.TabIndex = 12;
            // 
            // buttonLabTestsSubmit
            // 
            this.buttonLabTestsSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLabTestsSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.buttonLabTestsSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLabTestsSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLabTestsSubmit.ForeColor = System.Drawing.Color.Black;
            this.buttonLabTestsSubmit.Location = new System.Drawing.Point(388, 152);
            this.buttonLabTestsSubmit.Name = "buttonLabTestsSubmit";
            this.buttonLabTestsSubmit.Size = new System.Drawing.Size(137, 35);
            this.buttonLabTestsSubmit.TabIndex = 7;
            this.buttonLabTestsSubmit.Text = "Submit";
            this.buttonLabTestsSubmit.UseVisualStyleBackColor = false;
            this.buttonLabTestsSubmit.Click += new System.EventHandler(this.buttonLabTestsSubmit_Click);
            // 
            // labelLabTests
            // 
            this.labelLabTests.AutoSize = true;
            this.labelLabTests.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLabTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLabTests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelLabTests.Location = new System.Drawing.Point(0, 0);
            this.labelLabTests.Name = "labelLabTests";
            this.labelLabTests.Size = new System.Drawing.Size(128, 29);
            this.labelLabTests.TabIndex = 7;
            this.labelLabTests.Text = "Lab Tests";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(CS6232GroupProject.Model.Patient);
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
            this.tableLayoutPanel8.Size = new System.Drawing.Size(839, 54);
            this.tableLayoutPanel8.TabIndex = 4;
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
            this.comboBoxPatientRecordsAppointment.DataSource = this.appointmentBindingSource;
            this.comboBoxPatientRecordsAppointment.DisplayMember = "AppointmentDateTime";
            this.comboBoxPatientRecordsAppointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatientRecordsAppointment.FormattingEnabled = true;
            this.comboBoxPatientRecordsAppointment.Location = new System.Drawing.Point(595, 16);
            this.comboBoxPatientRecordsAppointment.Name = "comboBoxPatientRecordsAppointment";
            this.comboBoxPatientRecordsAppointment.Size = new System.Drawing.Size(179, 21);
            this.comboBoxPatientRecordsAppointment.TabIndex = 2;
            this.comboBoxPatientRecordsAppointment.ValueMember = "AppointmentID";
            this.comboBoxPatientRecordsAppointment.SelectedIndexChanged += new System.EventHandler(this.comboBoxPatientRecordsAppointment_SelectedIndexChanged);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlPatientRecords);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 534);
            this.panel1.TabIndex = 5;
            // 
            // UserControlPatientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Name = "UserControlPatientRecords";
            this.Size = new System.Drawing.Size(839, 607);
            this.tabControlPatientRecords.ResumeLayout(false);
            this.tabPageAppointments.ResumeLayout(false);
            this.tabPageAppointments.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.tabPageRoutineChecks.ResumeLayout(false);
            this.tabPageRoutineChecks.PerformLayout();
            this.tableLayoutRoutineChecks.ResumeLayout(false);
            this.tableLayoutRoutineChecks.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tabPageDiagnosis.ResumeLayout(false);
            this.tabPageDiagnosis.PerformLayout();
            this.tableLayoutPanelDiagnosis.ResumeLayout(false);
            this.tableLayoutPanelDiagnosis.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPageLabTests.ResumeLayout(false);
            this.tabPageLabTests.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPatientRecords;
        private System.Windows.Forms.TabPage tabPageRoutineChecks;
        private System.Windows.Forms.TabPage tabPageDiagnosis;
        private System.Windows.Forms.TabPage tabPageAppointments;
        private System.Windows.Forms.Label labelRoutineChecks;
        private System.Windows.Forms.Label labelDiagnosis;
        private System.Windows.Forms.Label labelAppointments;
        private System.Windows.Forms.TableLayoutPanel tableLayoutRoutineChecks;
        private System.Windows.Forms.Button buttonRoutineChecksUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label labelRoutineChecksWeight;
        private System.Windows.Forms.Label labelRoutineChecksTemp;
        private System.Windows.Forms.TextBox textBoxRoutineChecksWeight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox textRoutineChecksPulse;
        private System.Windows.Forms.Label labelRoutineChecksPulse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelRoutineChecksSummary;
        private System.Windows.Forms.TextBox textBoxRoutineChecksSummary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelRoutineChecksSystolic;
        private System.Windows.Forms.Label labelRoutineChecksDiastolic;
        private System.Windows.Forms.TextBox textBoxRoutineChecksSystolic;
        private System.Windows.Forms.Label labelRoutineChecksBloodPressure;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDiagnosis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label labelDiagnosisInitial;
        private System.Windows.Forms.TextBox textBoxDiagnosisIntial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelDiagnosisFinal;
        private System.Windows.Forms.TextBox textBoxDiagnosisFinal;
        private System.Windows.Forms.Button buttonDiagnosisUpdate;
        private System.Windows.Forms.CheckBox checkBoxPendingLabTests;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label labelAppointmentsSummary;
        private System.Windows.Forms.Label labelAppointmentsPhysician;
        private System.Windows.Forms.Button buttonAppointmentsUpdate;
        private System.Windows.Forms.LinkLabel linkLabelAppointmentsCancel;
        private System.Windows.Forms.ComboBox comboBoxAppointmentsPhysician;
        private System.Windows.Forms.Label labelAppointmentsDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointments;
        private System.Windows.Forms.TextBox textBoxAppointmentsSummary;
        private System.Windows.Forms.TextBox textBoxRoutineChecksDiastolic;
        private System.Windows.Forms.TextBox textBoxRoutineChecksTemp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentsTime;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label labelPatientRecordsAppointment;
        private System.Windows.Forms.ComboBox comboBoxPatientRecordsAppointment;
        private System.Windows.Forms.Label labelPatientRecords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.TabPage tabPageLabTests;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelLabTestsInformation;
        private System.Windows.Forms.CheckedListBox checkedListBoxLabTests;
        private System.Windows.Forms.Button buttonLabTestsSubmit;
        private System.Windows.Forms.Label labelLabTests;
    }
}
