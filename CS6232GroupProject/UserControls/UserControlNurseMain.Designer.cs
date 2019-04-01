namespace CS6232GroupProject.UserControls
{
    partial class UserControlNurseMain
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
            this.tabControlNurseMain = new System.Windows.Forms.TabControl();
            this.tabPageNursePatientInformation = new System.Windows.Forms.TabPage();
            this.panelPatientSearch = new System.Windows.Forms.Panel();
            this.dataGridViewPatientInfo = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet11 = new CS6232GroupProject.clinicDataSet1();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.panelPatientInfoResults = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxStreetPatientInfoResult = new System.Windows.Forms.TextBox();
            this.labelStreetPatientInfoResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.labelStatePatientInfoResult = new System.Windows.Forms.Label();
            this.comboBoxStatePatientInfoResult = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxZipPatientInfoResult = new System.Windows.Forms.TextBox();
            this.labelZipPatientInfoResult = new System.Windows.Forms.Label();
            this.buttonPatientInfoResultUpdate = new System.Windows.Forms.Button();
            this.linkLabelDeletePatient = new System.Windows.Forms.LinkLabel();
            this.labelMailAddressPatentInfoResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPhonePatientInfoResult = new System.Windows.Forms.Label();
            this.textBoxLastNamePatientInfoResult = new System.Windows.Forms.TextBox();
            this.textBoxFirstNamePatientInfoResult = new System.Windows.Forms.TextBox();
            this.labelFirstNamePatientInfoResult = new System.Windows.Forms.Label();
            this.labelDOBPatientInfoResult = new System.Windows.Forms.Label();
            this.labelFlastNamePatientInfoResult = new System.Windows.Forms.Label();
            this.textBoxPhonePatientInfoResult = new System.Windows.Forms.TextBox();
            this.linkLabelRecordsPatientInfoVisitRecords = new System.Windows.Forms.LinkLabel();
            this.dateTimePickerDOBPatientInfoResult = new System.Windows.Forms.DateTimePicker();
            this.labelGenderPatientInfoResult = new System.Windows.Forms.Label();
            this.labelSSNPatientInfoResult = new System.Windows.Forms.Label();
            this.textBoxSSNPatientInfoResult = new System.Windows.Forms.TextBox();
            this.comboBoxGenderPatientInfoResult = new System.Windows.Forms.ComboBox();
            this.labelPatientInformation = new System.Windows.Forms.Label();
            this.linkLabelPatientInfoBack = new System.Windows.Forms.LinkLabel();
            this.tabPageNurseBook = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerBookAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBookAppointment = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPhysician = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.patientBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.labelSummary = new System.Windows.Forms.Label();
            this.labelPatient = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelPhysician = new System.Windows.Forms.Label();
            this.buttonBookSubmit = new System.Windows.Forms.Button();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.labelBookAppointment = new System.Windows.Forms.Label();
            this.tabPageNurseRegister = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxRegisterGender = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelRegisterZipcode = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRegisterZipcode = new System.Windows.Forms.TextBox();
            this.labelRegisterZipcode = new System.Windows.Forms.Label();
            this.labelRegisterAddress = new System.Windows.Forms.Label();
            this.textBoxRegisterLastName = new System.Windows.Forms.TextBox();
            this.textBoxRegisterFirstName = new System.Windows.Forms.TextBox();
            this.labelRegisterFirstName = new System.Windows.Forms.Label();
            this.labelRegisterDateOfBirth = new System.Windows.Forms.Label();
            this.labelRegisterLastName = new System.Windows.Forms.Label();
            this.textBoxRegisterPhone = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelRegisterStreet = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRegisterStreet = new System.Windows.Forms.TextBox();
            this.labelRegisterStreet = new System.Windows.Forms.Label();
            this.tableLayoutPanelRegisterCityState = new System.Windows.Forms.TableLayoutPanel();
            this.labelRegisterState = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.buttonRegisterSubmit = new System.Windows.Forms.Button();
            this.dateTimePickerRegisterDOB = new System.Windows.Forms.DateTimePicker();
            this.labelAddMessage = new System.Windows.Forms.Label();
            this.labelRegisterPhone = new System.Windows.Forms.Label();
            this.labelRegisterGender = new System.Windows.Forms.Label();
            this.labelRegisterSSN = new System.Windows.Forms.Label();
            this.textBoxSSN = new System.Windows.Forms.TextBox();
            this.labelRegisterPatient = new System.Windows.Forms.Label();
            this.doctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet = new CS6232GroupProject.clinicDataSet();
            this.doctorTableAdapter = new CS6232GroupProject.clinicDataSetTableAdapters.DoctorTableAdapter();
            this.clinicDataSet1 = new CS6232GroupProject.clinicDataSet();
            this.patientTableAdapter = new CS6232GroupProject.clinicDataSet1TableAdapters.PatientTableAdapter();
            this.tabControlNurseMain.SuspendLayout();
            this.tabPageNursePatientInformation.SuspendLayout();
            this.panelPatientSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet11)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelPatientInfoResults.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPageNurseBook.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource3)).BeginInit();
            this.tabPageNurseRegister.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanelRegisterZipcode.SuspendLayout();
            this.tableLayoutPanelRegisterStreet.SuspendLayout();
            this.tableLayoutPanelRegisterCityState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlNurseMain
            // 
            this.tabControlNurseMain.Controls.Add(this.tabPageNursePatientInformation);
            this.tabControlNurseMain.Controls.Add(this.tabPageNurseBook);
            this.tabControlNurseMain.Controls.Add(this.tabPageNurseRegister);
            this.tabControlNurseMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlNurseMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlNurseMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlNurseMain.Name = "tabControlNurseMain";
            this.tabControlNurseMain.SelectedIndex = 0;
            this.tabControlNurseMain.Size = new System.Drawing.Size(652, 1003);
            this.tabControlNurseMain.TabIndex = 0;
            this.tabControlNurseMain.SelectedIndexChanged += new System.EventHandler(this.tabControlNurseMain_SelectedIndexChanged);
            // 
            // tabPageNursePatientInformation
            // 
            this.tabPageNursePatientInformation.AutoScroll = true;
            this.tabPageNursePatientInformation.Controls.Add(this.panelPatientSearch);
            this.tabPageNursePatientInformation.Controls.Add(this.panelPatientInfoResults);
            this.tabPageNursePatientInformation.Controls.Add(this.labelPatientInformation);
            this.tabPageNursePatientInformation.Controls.Add(this.linkLabelPatientInfoBack);
            this.tabPageNursePatientInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.tabPageNursePatientInformation.Location = new System.Drawing.Point(4, 29);
            this.tabPageNursePatientInformation.Name = "tabPageNursePatientInformation";
            this.tabPageNursePatientInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNursePatientInformation.Size = new System.Drawing.Size(644, 970);
            this.tabPageNursePatientInformation.TabIndex = 0;
            this.tabPageNursePatientInformation.Text = "Patient Information";
            this.tabPageNursePatientInformation.UseVisualStyleBackColor = true;
            // 
            // panelPatientSearch
            // 
            this.panelPatientSearch.Controls.Add(this.dataGridViewPatientInfo);
            this.panelPatientSearch.Controls.Add(this.tableLayoutPanel1);
            this.panelPatientSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPatientSearch.Location = new System.Drawing.Point(3, 670);
            this.panelPatientSearch.Name = "panelPatientSearch";
            this.panelPatientSearch.Size = new System.Drawing.Size(621, 586);
            this.panelPatientSearch.TabIndex = 10;
            // 
            // dataGridViewPatientInfo
            // 
            this.dataGridViewPatientInfo.AllowUserToAddRows = false;
            this.dataGridViewPatientInfo.AllowUserToDeleteRows = false;
            this.dataGridViewPatientInfo.AutoGenerateColumns = false;
            this.dataGridViewPatientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.ssnDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressIDDataGridViewTextBoxColumn});
            this.dataGridViewPatientInfo.DataSource = this.patientBindingSource;
            this.dataGridViewPatientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPatientInfo.Location = new System.Drawing.Point(0, 223);
            this.dataGridViewPatientInfo.Name = "dataGridViewPatientInfo";
            this.dataGridViewPatientInfo.ReadOnly = true;
            this.dataGridViewPatientInfo.Size = new System.Drawing.Size(621, 363);
            this.dataGridViewPatientInfo.TabIndex = 5;
            this.dataGridViewPatientInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "patientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ssnDataGridViewTextBoxColumn
            // 
            this.ssnDataGridViewTextBoxColumn.DataPropertyName = "ssn";
            this.ssnDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.ssnDataGridViewTextBoxColumn.Name = "ssnDataGridViewTextBoxColumn";
            this.ssnDataGridViewTextBoxColumn.ReadOnly = true;
            this.ssnDataGridViewTextBoxColumn.Visible = false;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressIDDataGridViewTextBoxColumn
            // 
            this.addressIDDataGridViewTextBoxColumn.DataPropertyName = "addressID";
            this.addressIDDataGridViewTextBoxColumn.HeaderText = "Address ID";
            this.addressIDDataGridViewTextBoxColumn.Name = "addressIDDataGridViewTextBoxColumn";
            this.addressIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.clinicDataSet11;
            // 
            // clinicDataSet11
            // 
            this.clinicDataSet11.DataSetName = "clinicDataSet1";
            this.clinicDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelFirstName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDateOfBirth, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelLastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSearch, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDOB, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(621, 223);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(189, 60);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(186, 29);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(189, 10);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(186, 29);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(3, 15);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelFirstName.Size = new System.Drawing.Size(121, 20);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(3, 115);
            this.labelDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelDateOfBirth.Size = new System.Drawing.Size(137, 20);
            this.labelDateOfBirth.TabIndex = 3;
            this.labelDateOfBirth.Text = "Date of Birth";
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(3, 65);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelLastName.Size = new System.Drawing.Size(120, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(335, 169);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(137, 35);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(189, 112);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(186, 26);
            this.dateTimePickerDOB.TabIndex = 3;
            // 
            // panelPatientInfoResults
            // 
            this.panelPatientInfoResults.AutoScroll = true;
            this.panelPatientInfoResults.Controls.Add(this.tableLayoutPanel8);
            this.panelPatientInfoResults.Controls.Add(this.tableLayoutPanel4);
            this.panelPatientInfoResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPatientInfoResults.Location = new System.Drawing.Point(3, 32);
            this.panelPatientInfoResults.Name = "panelPatientInfoResults";
            this.panelPatientInfoResults.Size = new System.Drawing.Size(621, 638);
            this.panelPatientInfoResults.TabIndex = 5;
            this.panelPatientInfoResults.Visible = false;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel7, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.buttonPatientInfoResultUpdate, 1, 4);
            this.tableLayoutPanel8.Controls.Add(this.linkLabelDeletePatient, 1, 5);
            this.tableLayoutPanel8.Controls.Add(this.labelMailAddressPatentInfoResult, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 299);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 6;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(621, 336);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.textBoxStreetPatientInfoResult, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelStreetPatientInfoResult, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(189, 37);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 75);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // textBoxStreetPatientInfoResult
            // 
            this.textBoxStreetPatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxStreetPatientInfoResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStreetPatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStreetPatientInfoResult.Location = new System.Drawing.Point(3, 33);
            this.textBoxStreetPatientInfoResult.Name = "textBoxStreetPatientInfoResult";
            this.textBoxStreetPatientInfoResult.Size = new System.Drawing.Size(186, 29);
            this.textBoxStreetPatientInfoResult.TabIndex = 9;
            // 
            // labelStreetPatientInfoResult
            // 
            this.labelStreetPatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStreetPatientInfoResult.AutoSize = true;
            this.labelStreetPatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStreetPatientInfoResult.Location = new System.Drawing.Point(3, 0);
            this.labelStreetPatientInfoResult.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelStreetPatientInfoResult.Name = "labelStreetPatientInfoResult";
            this.labelStreetPatientInfoResult.Size = new System.Drawing.Size(59, 20);
            this.labelStreetPatientInfoResult.TabIndex = 11;
            this.labelStreetPatientInfoResult.Text = "Street";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.labelStatePatientInfoResult, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.comboBoxStatePatientInfoResult, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(189, 118);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 59);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // labelStatePatientInfoResult
            // 
            this.labelStatePatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStatePatientInfoResult.AutoSize = true;
            this.labelStatePatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatePatientInfoResult.Location = new System.Drawing.Point(3, 0);
            this.labelStatePatientInfoResult.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelStatePatientInfoResult.Name = "labelStatePatientInfoResult";
            this.labelStatePatientInfoResult.Size = new System.Drawing.Size(53, 20);
            this.labelStatePatientInfoResult.TabIndex = 14;
            this.labelStatePatientInfoResult.Text = "State";
            // 
            // comboBoxStatePatientInfoResult
            // 
            this.comboBoxStatePatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxStatePatientInfoResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatePatientInfoResult.FormattingEnabled = true;
            this.comboBoxStatePatientInfoResult.Location = new System.Drawing.Point(3, 25);
            this.comboBoxStatePatientInfoResult.Name = "comboBoxStatePatientInfoResult";
            this.comboBoxStatePatientInfoResult.Size = new System.Drawing.Size(179, 28);
            this.comboBoxStatePatientInfoResult.TabIndex = 12;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.textBoxZipPatientInfoResult, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.labelZipPatientInfoResult, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(189, 183);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(200, 59);
            this.tableLayoutPanel7.TabIndex = 13;
            // 
            // textBoxZipPatientInfoResult
            // 
            this.textBoxZipPatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxZipPatientInfoResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxZipPatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZipPatientInfoResult.Location = new System.Drawing.Point(3, 25);
            this.textBoxZipPatientInfoResult.Name = "textBoxZipPatientInfoResult";
            this.textBoxZipPatientInfoResult.Size = new System.Drawing.Size(186, 29);
            this.textBoxZipPatientInfoResult.TabIndex = 14;
            // 
            // labelZipPatientInfoResult
            // 
            this.labelZipPatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelZipPatientInfoResult.AutoSize = true;
            this.labelZipPatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZipPatientInfoResult.Location = new System.Drawing.Point(3, 0);
            this.labelZipPatientInfoResult.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelZipPatientInfoResult.Name = "labelZipPatientInfoResult";
            this.labelZipPatientInfoResult.Size = new System.Drawing.Size(73, 20);
            this.labelZipPatientInfoResult.TabIndex = 11;
            this.labelZipPatientInfoResult.Text = "Zipcode";
            // 
            // buttonPatientInfoResultUpdate
            // 
            this.buttonPatientInfoResultUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPatientInfoResultUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.buttonPatientInfoResultUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatientInfoResultUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatientInfoResultUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonPatientInfoResultUpdate.Location = new System.Drawing.Point(335, 252);
            this.buttonPatientInfoResultUpdate.Name = "buttonPatientInfoResultUpdate";
            this.buttonPatientInfoResultUpdate.Size = new System.Drawing.Size(137, 35);
            this.buttonPatientInfoResultUpdate.TabIndex = 15;
            this.buttonPatientInfoResultUpdate.Text = "Update";
            this.buttonPatientInfoResultUpdate.UseVisualStyleBackColor = false;
            this.buttonPatientInfoResultUpdate.Click += new System.EventHandler(this.buttonPatientInfoResultUpdate_Click);
            // 
            // linkLabelDeletePatient
            // 
            this.linkLabelDeletePatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelDeletePatient.AutoSize = true;
            this.linkLabelDeletePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDeletePatient.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.linkLabelDeletePatient.Location = new System.Drawing.Point(485, 295);
            this.linkLabelDeletePatient.Name = "linkLabelDeletePatient";
            this.linkLabelDeletePatient.Size = new System.Drawing.Size(133, 25);
            this.linkLabelDeletePatient.TabIndex = 16;
            this.linkLabelDeletePatient.TabStop = true;
            this.linkLabelDeletePatient.Text = "Delete Patient";
            // 
            // labelMailAddressPatentInfoResult
            // 
            this.labelMailAddressPatentInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMailAddressPatentInfoResult.AutoSize = true;
            this.labelMailAddressPatentInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMailAddressPatentInfoResult.Location = new System.Drawing.Point(3, 0);
            this.labelMailAddressPatentInfoResult.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelMailAddressPatentInfoResult.Name = "labelMailAddressPatentInfoResult";
            this.labelMailAddressPatentInfoResult.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelMailAddressPatentInfoResult.Size = new System.Drawing.Size(100, 34);
            this.labelMailAddressPatentInfoResult.TabIndex = 12;
            this.labelMailAddressPatentInfoResult.Text = "Mailing Address";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.98231F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.2217F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.79599F));
            this.tableLayoutPanel4.Controls.Add(this.labelPhonePatientInfoResult, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.textBoxLastNamePatientInfoResult, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBoxFirstNamePatientInfoResult, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelFirstNamePatientInfoResult, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelDOBPatientInfoResult, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelFlastNamePatientInfoResult, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBoxPhonePatientInfoResult, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.linkLabelRecordsPatientInfoVisitRecords, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePickerDOBPatientInfoResult, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelGenderPatientInfoResult, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.labelSSNPatientInfoResult, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.textBoxSSNPatientInfoResult, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxGenderPatientInfoResult, 1, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(621, 299);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // labelPhonePatientInfoResult
            // 
            this.labelPhonePatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPhonePatientInfoResult.AutoSize = true;
            this.labelPhonePatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhonePatientInfoResult.Location = new System.Drawing.Point(3, 265);
            this.labelPhonePatientInfoResult.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelPhonePatientInfoResult.Name = "labelPhonePatientInfoResult";
            this.labelPhonePatientInfoResult.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelPhonePatientInfoResult.Size = new System.Drawing.Size(85, 20);
            this.labelPhonePatientInfoResult.TabIndex = 11;
            this.labelPhonePatientInfoResult.Text = "Phone";
            // 
            // textBoxLastNamePatientInfoResult
            // 
            this.textBoxLastNamePatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLastNamePatientInfoResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastNamePatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastNamePatientInfoResult.Location = new System.Drawing.Point(189, 60);
            this.textBoxLastNamePatientInfoResult.Name = "textBoxLastNamePatientInfoResult";
            this.textBoxLastNamePatientInfoResult.Size = new System.Drawing.Size(186, 29);
            this.textBoxLastNamePatientInfoResult.TabIndex = 2;
            // 
            // textBoxFirstNamePatientInfoResult
            // 
            this.textBoxFirstNamePatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFirstNamePatientInfoResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstNamePatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstNamePatientInfoResult.Location = new System.Drawing.Point(189, 10);
            this.textBoxFirstNamePatientInfoResult.Name = "textBoxFirstNamePatientInfoResult";
            this.textBoxFirstNamePatientInfoResult.Size = new System.Drawing.Size(186, 29);
            this.textBoxFirstNamePatientInfoResult.TabIndex = 1;
            // 
            // labelFirstNamePatientInfoResult
            // 
            this.labelFirstNamePatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFirstNamePatientInfoResult.AutoSize = true;
            this.labelFirstNamePatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstNamePatientInfoResult.Location = new System.Drawing.Point(3, 15);
            this.labelFirstNamePatientInfoResult.Name = "labelFirstNamePatientInfoResult";
            this.labelFirstNamePatientInfoResult.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelFirstNamePatientInfoResult.Size = new System.Drawing.Size(121, 20);
            this.labelFirstNamePatientInfoResult.TabIndex = 1;
            this.labelFirstNamePatientInfoResult.Text = "First Name";
            // 
            // labelDOBPatientInfoResult
            // 
            this.labelDOBPatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDOBPatientInfoResult.AutoSize = true;
            this.labelDOBPatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOBPatientInfoResult.Location = new System.Drawing.Point(3, 115);
            this.labelDOBPatientInfoResult.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelDOBPatientInfoResult.Name = "labelDOBPatientInfoResult";
            this.labelDOBPatientInfoResult.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelDOBPatientInfoResult.Size = new System.Drawing.Size(137, 20);
            this.labelDOBPatientInfoResult.TabIndex = 3;
            this.labelDOBPatientInfoResult.Text = "Date of Birth";
            // 
            // labelFlastNamePatientInfoResult
            // 
            this.labelFlastNamePatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFlastNamePatientInfoResult.AutoSize = true;
            this.labelFlastNamePatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlastNamePatientInfoResult.Location = new System.Drawing.Point(3, 65);
            this.labelFlastNamePatientInfoResult.Name = "labelFlastNamePatientInfoResult";
            this.labelFlastNamePatientInfoResult.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelFlastNamePatientInfoResult.Size = new System.Drawing.Size(120, 20);
            this.labelFlastNamePatientInfoResult.TabIndex = 2;
            this.labelFlastNamePatientInfoResult.Text = "Last Name";
            // 
            // textBoxPhonePatientInfoResult
            // 
            this.textBoxPhonePatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPhonePatientInfoResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhonePatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhonePatientInfoResult.Location = new System.Drawing.Point(189, 260);
            this.textBoxPhonePatientInfoResult.Name = "textBoxPhonePatientInfoResult";
            this.textBoxPhonePatientInfoResult.Size = new System.Drawing.Size(186, 29);
            this.textBoxPhonePatientInfoResult.TabIndex = 6;
            // 
            // linkLabelRecordsPatientInfoVisitRecords
            // 
            this.linkLabelRecordsPatientInfoVisitRecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabelRecordsPatientInfoVisitRecords.AutoSize = true;
            this.linkLabelRecordsPatientInfoVisitRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRecordsPatientInfoVisitRecords.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.linkLabelRecordsPatientInfoVisitRecords.Location = new System.Drawing.Point(469, 12);
            this.linkLabelRecordsPatientInfoVisitRecords.Name = "linkLabelRecordsPatientInfoVisitRecords";
            this.linkLabelRecordsPatientInfoVisitRecords.Size = new System.Drawing.Size(149, 25);
            this.linkLabelRecordsPatientInfoVisitRecords.TabIndex = 18;
            this.linkLabelRecordsPatientInfoVisitRecords.TabStop = true;
            this.linkLabelRecordsPatientInfoVisitRecords.Text = "Patient Records";
            this.linkLabelRecordsPatientInfoVisitRecords.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRecordsPatientInfoVisitRecords_LinkClicked);
            // 
            // dateTimePickerDOBPatientInfoResult
            // 
            this.dateTimePickerDOBPatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerDOBPatientInfoResult.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDOBPatientInfoResult.Location = new System.Drawing.Point(189, 112);
            this.dateTimePickerDOBPatientInfoResult.Name = "dateTimePickerDOBPatientInfoResult";
            this.dateTimePickerDOBPatientInfoResult.Size = new System.Drawing.Size(186, 26);
            this.dateTimePickerDOBPatientInfoResult.TabIndex = 3;
            // 
            // labelGenderPatientInfoResult
            // 
            this.labelGenderPatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelGenderPatientInfoResult.AutoSize = true;
            this.labelGenderPatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenderPatientInfoResult.Location = new System.Drawing.Point(3, 215);
            this.labelGenderPatientInfoResult.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelGenderPatientInfoResult.Name = "labelGenderPatientInfoResult";
            this.labelGenderPatientInfoResult.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelGenderPatientInfoResult.Size = new System.Drawing.Size(94, 20);
            this.labelGenderPatientInfoResult.TabIndex = 19;
            this.labelGenderPatientInfoResult.Text = "Gender";
            // 
            // labelSSNPatientInfoResult
            // 
            this.labelSSNPatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSSNPatientInfoResult.AutoSize = true;
            this.labelSSNPatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSSNPatientInfoResult.Location = new System.Drawing.Point(3, 165);
            this.labelSSNPatientInfoResult.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelSSNPatientInfoResult.Name = "labelSSNPatientInfoResult";
            this.labelSSNPatientInfoResult.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelSSNPatientInfoResult.Size = new System.Drawing.Size(70, 20);
            this.labelSSNPatientInfoResult.TabIndex = 20;
            this.labelSSNPatientInfoResult.Text = "SSN";
            // 
            // textBoxSSNPatientInfoResult
            // 
            this.textBoxSSNPatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSSNPatientInfoResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSSNPatientInfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSSNPatientInfoResult.Location = new System.Drawing.Point(189, 160);
            this.textBoxSSNPatientInfoResult.Name = "textBoxSSNPatientInfoResult";
            this.textBoxSSNPatientInfoResult.Size = new System.Drawing.Size(186, 29);
            this.textBoxSSNPatientInfoResult.TabIndex = 4;
            // 
            // comboBoxGenderPatientInfoResult
            // 
            this.comboBoxGenderPatientInfoResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxGenderPatientInfoResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenderPatientInfoResult.FormattingEnabled = true;
            this.comboBoxGenderPatientInfoResult.Location = new System.Drawing.Point(189, 214);
            this.comboBoxGenderPatientInfoResult.Name = "comboBoxGenderPatientInfoResult";
            this.comboBoxGenderPatientInfoResult.Size = new System.Drawing.Size(186, 28);
            this.comboBoxGenderPatientInfoResult.TabIndex = 21;
            // 
            // labelPatientInformation
            // 
            this.labelPatientInformation.AutoSize = true;
            this.labelPatientInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPatientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientInformation.Location = new System.Drawing.Point(3, 3);
            this.labelPatientInformation.Name = "labelPatientInformation";
            this.labelPatientInformation.Size = new System.Drawing.Size(231, 29);
            this.labelPatientInformation.TabIndex = 0;
            this.labelPatientInformation.Text = "Patient Information";
            // 
            // linkLabelPatientInfoBack
            // 
            this.linkLabelPatientInfoBack.AutoSize = true;
            this.linkLabelPatientInfoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPatientInfoBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.linkLabelPatientInfoBack.Location = new System.Drawing.Point(568, 3);
            this.linkLabelPatientInfoBack.Name = "linkLabelPatientInfoBack";
            this.linkLabelPatientInfoBack.Size = new System.Drawing.Size(56, 25);
            this.linkLabelPatientInfoBack.TabIndex = 9;
            this.linkLabelPatientInfoBack.TabStop = true;
            this.linkLabelPatientInfoBack.Text = "Back";
            this.linkLabelPatientInfoBack.Visible = false;
            this.linkLabelPatientInfoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPatientInfoBack_LinkClicked);
            // 
            // tabPageNurseBook
            // 
            this.tabPageNurseBook.AutoScroll = true;
            this.tabPageNurseBook.BackColor = System.Drawing.Color.White;
            this.tabPageNurseBook.Controls.Add(this.tableLayoutPanel2);
            this.tabPageNurseBook.Controls.Add(this.labelBookAppointment);
            this.tabPageNurseBook.Location = new System.Drawing.Point(4, 29);
            this.tabPageNurseBook.Name = "tabPageNurseBook";
            this.tabPageNurseBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNurseBook.Size = new System.Drawing.Size(644, 970);
            this.tabPageNurseBook.TabIndex = 1;
            this.tabPageNurseBook.Text = "Book Appointment";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel9, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxPhysician, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxPatient, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelSummary, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelPatient, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelDateTime, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelPhysician, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonBookSubmit, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSummary, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(638, 377);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.dateTimePickerBookAppointmentTime, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.dateTimePickerBookAppointment, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(194, 103);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(337, 44);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // dateTimePickerBookAppointmentTime
            // 
            this.dateTimePickerBookAppointmentTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerBookAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerBookAppointmentTime.Location = new System.Drawing.Point(171, 9);
            this.dateTimePickerBookAppointmentTime.Name = "dateTimePickerBookAppointmentTime";
            this.dateTimePickerBookAppointmentTime.Size = new System.Drawing.Size(127, 26);
            this.dateTimePickerBookAppointmentTime.TabIndex = 5;
            // 
            // dateTimePickerBookAppointment
            // 
            this.dateTimePickerBookAppointment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerBookAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBookAppointment.Location = new System.Drawing.Point(3, 9);
            this.dateTimePickerBookAppointment.Name = "dateTimePickerBookAppointment";
            this.dateTimePickerBookAppointment.Size = new System.Drawing.Size(139, 26);
            this.dateTimePickerBookAppointment.TabIndex = 4;
            // 
            // comboBoxPhysician
            // 
            this.comboBoxPhysician.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxPhysician.DataSource = this.doctorBindingSource2;
            this.comboBoxPhysician.DisplayMember = "FullName";
            this.comboBoxPhysician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhysician.FormattingEnabled = true;
            this.comboBoxPhysician.Location = new System.Drawing.Point(194, 61);
            this.comboBoxPhysician.Name = "comboBoxPhysician";
            this.comboBoxPhysician.Size = new System.Drawing.Size(298, 28);
            this.comboBoxPhysician.TabIndex = 2;
            this.comboBoxPhysician.ValueMember = "doctorID";
            // 
            // doctorBindingSource2
            // 
            this.doctorBindingSource2.DataSource = typeof(CS6232GroupProject.Model.Doctor);
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxPatient.DataSource = this.patientBindingSource3;
            this.comboBoxPatient.DisplayMember = "FullName";
            this.comboBoxPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(194, 11);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(298, 28);
            this.comboBoxPatient.TabIndex = 1;
            this.comboBoxPatient.ValueMember = "patientID";
            // 
            // patientBindingSource3
            // 
            this.patientBindingSource3.DataSource = typeof(CS6232GroupProject.Model.Patient);
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelSummary.Location = new System.Drawing.Point(3, 150);
            this.labelSummary.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Padding = new System.Windows.Forms.Padding(25, 20, 0, 0);
            this.labelSummary.Size = new System.Drawing.Size(108, 40);
            this.labelSummary.TabIndex = 8;
            this.labelSummary.Text = "Summary";
            // 
            // labelPatient
            // 
            this.labelPatient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPatient.AutoSize = true;
            this.labelPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelPatient.Location = new System.Drawing.Point(3, 15);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelPatient.Size = new System.Drawing.Size(91, 20);
            this.labelPatient.TabIndex = 1;
            this.labelPatient.Text = "Patient";
            // 
            // labelDateTime
            // 
            this.labelDateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelDateTime.Location = new System.Drawing.Point(3, 115);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelDateTime.Size = new System.Drawing.Size(116, 20);
            this.labelDateTime.TabIndex = 3;
            this.labelDateTime.Text = "Date Time";
            // 
            // labelPhysician
            // 
            this.labelPhysician.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPhysician.AutoSize = true;
            this.labelPhysician.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhysician.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelPhysician.Location = new System.Drawing.Point(3, 65);
            this.labelPhysician.Name = "labelPhysician";
            this.labelPhysician.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelPhysician.Size = new System.Drawing.Size(109, 20);
            this.labelPhysician.TabIndex = 2;
            this.labelPhysician.Text = "Physician";
            // 
            // buttonBookSubmit
            // 
            this.buttonBookSubmit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonBookSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.buttonBookSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookSubmit.ForeColor = System.Drawing.Color.Black;
            this.buttonBookSubmit.Location = new System.Drawing.Point(498, 322);
            this.buttonBookSubmit.Name = "buttonBookSubmit";
            this.buttonBookSubmit.Size = new System.Drawing.Size(137, 35);
            this.buttonBookSubmit.TabIndex = 7;
            this.buttonBookSubmit.Text = "Submit";
            this.buttonBookSubmit.UseVisualStyleBackColor = false;
            this.buttonBookSubmit.Click += new System.EventHandler(this.buttonBookSubmit_Click);
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSummary.Location = new System.Drawing.Point(194, 166);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.Size = new System.Drawing.Size(427, 121);
            this.textBoxSummary.TabIndex = 6;
            // 
            // labelBookAppointment
            // 
            this.labelBookAppointment.AutoSize = true;
            this.labelBookAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBookAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelBookAppointment.Location = new System.Drawing.Point(3, 3);
            this.labelBookAppointment.Name = "labelBookAppointment";
            this.labelBookAppointment.Size = new System.Drawing.Size(226, 29);
            this.labelBookAppointment.TabIndex = 5;
            this.labelBookAppointment.Text = "Book Appointment";
            // 
            // tabPageNurseRegister
            // 
            this.tabPageNurseRegister.AutoScroll = true;
            this.tabPageNurseRegister.Controls.Add(this.tableLayoutPanel3);
            this.tabPageNurseRegister.Controls.Add(this.labelRegisterPatient);
            this.tabPageNurseRegister.Location = new System.Drawing.Point(4, 29);
            this.tabPageNurseRegister.Name = "tabPageNurseRegister";
            this.tabPageNurseRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNurseRegister.Size = new System.Drawing.Size(644, 970);
            this.tabPageNurseRegister.TabIndex = 2;
            this.tabPageNurseRegister.Text = "Register Patient";
            this.tabPageNurseRegister.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.comboBoxRegisterGender, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanelRegisterZipcode, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.labelRegisterAddress, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.textBoxRegisterLastName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxRegisterFirstName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelRegisterFirstName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelRegisterDateOfBirth, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelRegisterLastName, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxRegisterPhone, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanelRegisterStreet, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanelRegisterCityState, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.buttonRegisterSubmit, 1, 10);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerRegisterDOB, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelAddMessage, 1, 11);
            this.tableLayoutPanel3.Controls.Add(this.labelRegisterPhone, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.labelRegisterGender, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelRegisterSSN, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBoxSSN, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 12;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(638, 612);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // comboBoxRegisterGender
            // 
            this.comboBoxRegisterGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxRegisterGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegisterGender.FormattingEnabled = true;
            this.comboBoxRegisterGender.Location = new System.Drawing.Point(194, 214);
            this.comboBoxRegisterGender.Name = "comboBoxRegisterGender";
            this.comboBoxRegisterGender.Size = new System.Drawing.Size(186, 28);
            this.comboBoxRegisterGender.TabIndex = 6;
            // 
            // tableLayoutPanelRegisterZipcode
            // 
            this.tableLayoutPanelRegisterZipcode.ColumnCount = 1;
            this.tableLayoutPanelRegisterZipcode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRegisterZipcode.Controls.Add(this.textBoxRegisterZipcode, 0, 1);
            this.tableLayoutPanelRegisterZipcode.Controls.Add(this.labelRegisterZipcode, 0, 0);
            this.tableLayoutPanelRegisterZipcode.Location = new System.Drawing.Point(194, 463);
            this.tableLayoutPanelRegisterZipcode.Name = "tableLayoutPanelRegisterZipcode";
            this.tableLayoutPanelRegisterZipcode.RowCount = 3;
            this.tableLayoutPanelRegisterZipcode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRegisterZipcode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRegisterZipcode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRegisterZipcode.Size = new System.Drawing.Size(200, 59);
            this.tableLayoutPanelRegisterZipcode.TabIndex = 13;
            // 
            // textBoxRegisterZipcode
            // 
            this.textBoxRegisterZipcode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRegisterZipcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegisterZipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterZipcode.Location = new System.Drawing.Point(3, 23);
            this.textBoxRegisterZipcode.Name = "textBoxRegisterZipcode";
            this.textBoxRegisterZipcode.Size = new System.Drawing.Size(186, 29);
            this.textBoxRegisterZipcode.TabIndex = 14;
            // 
            // labelRegisterZipcode
            // 
            this.labelRegisterZipcode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRegisterZipcode.AutoSize = true;
            this.labelRegisterZipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterZipcode.Location = new System.Drawing.Point(3, 0);
            this.labelRegisterZipcode.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRegisterZipcode.Name = "labelRegisterZipcode";
            this.labelRegisterZipcode.Size = new System.Drawing.Size(73, 20);
            this.labelRegisterZipcode.TabIndex = 11;
            this.labelRegisterZipcode.Text = "Zipcode";
            // 
            // labelRegisterAddress
            // 
            this.labelRegisterAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRegisterAddress.AutoSize = true;
            this.labelRegisterAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterAddress.Location = new System.Drawing.Point(3, 305);
            this.labelRegisterAddress.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRegisterAddress.Name = "labelRegisterAddress";
            this.labelRegisterAddress.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelRegisterAddress.Size = new System.Drawing.Size(161, 20);
            this.labelRegisterAddress.TabIndex = 9;
            this.labelRegisterAddress.Text = "Mailing Address";
            // 
            // textBoxRegisterLastName
            // 
            this.textBoxRegisterLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRegisterLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegisterLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterLastName.Location = new System.Drawing.Point(194, 60);
            this.textBoxRegisterLastName.Name = "textBoxRegisterLastName";
            this.textBoxRegisterLastName.Size = new System.Drawing.Size(186, 29);
            this.textBoxRegisterLastName.TabIndex = 3;
            // 
            // textBoxRegisterFirstName
            // 
            this.textBoxRegisterFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRegisterFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegisterFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterFirstName.Location = new System.Drawing.Point(194, 10);
            this.textBoxRegisterFirstName.Name = "textBoxRegisterFirstName";
            this.textBoxRegisterFirstName.Size = new System.Drawing.Size(186, 29);
            this.textBoxRegisterFirstName.TabIndex = 2;
            // 
            // labelRegisterFirstName
            // 
            this.labelRegisterFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRegisterFirstName.AutoSize = true;
            this.labelRegisterFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterFirstName.Location = new System.Drawing.Point(3, 15);
            this.labelRegisterFirstName.Name = "labelRegisterFirstName";
            this.labelRegisterFirstName.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelRegisterFirstName.Size = new System.Drawing.Size(121, 20);
            this.labelRegisterFirstName.TabIndex = 1;
            this.labelRegisterFirstName.Text = "First Name";
            // 
            // labelRegisterDateOfBirth
            // 
            this.labelRegisterDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRegisterDateOfBirth.AutoSize = true;
            this.labelRegisterDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterDateOfBirth.Location = new System.Drawing.Point(3, 115);
            this.labelRegisterDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRegisterDateOfBirth.Name = "labelRegisterDateOfBirth";
            this.labelRegisterDateOfBirth.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelRegisterDateOfBirth.Size = new System.Drawing.Size(137, 20);
            this.labelRegisterDateOfBirth.TabIndex = 3;
            this.labelRegisterDateOfBirth.Text = "Date of Birth";
            // 
            // labelRegisterLastName
            // 
            this.labelRegisterLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRegisterLastName.AutoSize = true;
            this.labelRegisterLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterLastName.Location = new System.Drawing.Point(3, 65);
            this.labelRegisterLastName.Name = "labelRegisterLastName";
            this.labelRegisterLastName.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelRegisterLastName.Size = new System.Drawing.Size(120, 20);
            this.labelRegisterLastName.TabIndex = 2;
            this.labelRegisterLastName.Text = "Last Name";
            // 
            // textBoxRegisterPhone
            // 
            this.textBoxRegisterPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRegisterPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegisterPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterPhone.Location = new System.Drawing.Point(194, 260);
            this.textBoxRegisterPhone.Name = "textBoxRegisterPhone";
            this.textBoxRegisterPhone.Size = new System.Drawing.Size(186, 29);
            this.textBoxRegisterPhone.TabIndex = 7;
            // 
            // tableLayoutPanelRegisterStreet
            // 
            this.tableLayoutPanelRegisterStreet.ColumnCount = 1;
            this.tableLayoutPanelRegisterStreet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRegisterStreet.Controls.Add(this.textBoxRegisterStreet, 0, 1);
            this.tableLayoutPanelRegisterStreet.Controls.Add(this.labelRegisterStreet, 0, 0);
            this.tableLayoutPanelRegisterStreet.Location = new System.Drawing.Point(194, 333);
            this.tableLayoutPanelRegisterStreet.Name = "tableLayoutPanelRegisterStreet";
            this.tableLayoutPanelRegisterStreet.RowCount = 2;
            this.tableLayoutPanelRegisterStreet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRegisterStreet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRegisterStreet.Size = new System.Drawing.Size(200, 59);
            this.tableLayoutPanelRegisterStreet.TabIndex = 8;
            // 
            // textBoxRegisterStreet
            // 
            this.textBoxRegisterStreet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRegisterStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegisterStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterStreet.Location = new System.Drawing.Point(3, 25);
            this.textBoxRegisterStreet.Name = "textBoxRegisterStreet";
            this.textBoxRegisterStreet.Size = new System.Drawing.Size(186, 29);
            this.textBoxRegisterStreet.TabIndex = 9;
            // 
            // labelRegisterStreet
            // 
            this.labelRegisterStreet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRegisterStreet.AutoSize = true;
            this.labelRegisterStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterStreet.Location = new System.Drawing.Point(3, 0);
            this.labelRegisterStreet.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRegisterStreet.Name = "labelRegisterStreet";
            this.labelRegisterStreet.Size = new System.Drawing.Size(59, 20);
            this.labelRegisterStreet.TabIndex = 11;
            this.labelRegisterStreet.Text = "Street";
            // 
            // tableLayoutPanelRegisterCityState
            // 
            this.tableLayoutPanelRegisterCityState.ColumnCount = 1;
            this.tableLayoutPanelRegisterCityState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRegisterCityState.Controls.Add(this.labelRegisterState, 0, 0);
            this.tableLayoutPanelRegisterCityState.Controls.Add(this.comboBoxState, 0, 1);
            this.tableLayoutPanelRegisterCityState.Location = new System.Drawing.Point(194, 398);
            this.tableLayoutPanelRegisterCityState.Name = "tableLayoutPanelRegisterCityState";
            this.tableLayoutPanelRegisterCityState.RowCount = 2;
            this.tableLayoutPanelRegisterCityState.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRegisterCityState.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRegisterCityState.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanelRegisterCityState.Size = new System.Drawing.Size(200, 59);
            this.tableLayoutPanelRegisterCityState.TabIndex = 10;
            // 
            // labelRegisterState
            // 
            this.labelRegisterState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRegisterState.AutoSize = true;
            this.labelRegisterState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterState.Location = new System.Drawing.Point(3, 0);
            this.labelRegisterState.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRegisterState.Name = "labelRegisterState";
            this.labelRegisterState.Size = new System.Drawing.Size(53, 20);
            this.labelRegisterState.TabIndex = 14;
            this.labelRegisterState.Text = "State";
            // 
            // comboBoxState
            // 
            this.comboBoxState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(3, 25);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(184, 28);
            this.comboBoxState.TabIndex = 12;
            // 
            // buttonRegisterSubmit
            // 
            this.buttonRegisterSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegisterSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.buttonRegisterSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterSubmit.ForeColor = System.Drawing.Color.Black;
            this.buttonRegisterSubmit.Location = new System.Drawing.Point(346, 532);
            this.buttonRegisterSubmit.Name = "buttonRegisterSubmit";
            this.buttonRegisterSubmit.Size = new System.Drawing.Size(137, 35);
            this.buttonRegisterSubmit.TabIndex = 14;
            this.buttonRegisterSubmit.Text = "Register";
            this.buttonRegisterSubmit.UseVisualStyleBackColor = false;
            this.buttonRegisterSubmit.Click += new System.EventHandler(this.buttonRegisterSubmit_Click);
            // 
            // dateTimePickerRegisterDOB
            // 
            this.dateTimePickerRegisterDOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerRegisterDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRegisterDOB.Location = new System.Drawing.Point(194, 112);
            this.dateTimePickerRegisterDOB.Name = "dateTimePickerRegisterDOB";
            this.dateTimePickerRegisterDOB.Size = new System.Drawing.Size(186, 26);
            this.dateTimePickerRegisterDOB.TabIndex = 4;
            // 
            // labelAddMessage
            // 
            this.labelAddMessage.AutoSize = true;
            this.labelAddMessage.Location = new System.Drawing.Point(194, 575);
            this.labelAddMessage.Name = "labelAddMessage";
            this.labelAddMessage.Size = new System.Drawing.Size(0, 20);
            this.labelAddMessage.TabIndex = 14;
            // 
            // labelRegisterPhone
            // 
            this.labelRegisterPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRegisterPhone.AutoSize = true;
            this.labelRegisterPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterPhone.Location = new System.Drawing.Point(3, 265);
            this.labelRegisterPhone.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRegisterPhone.Name = "labelRegisterPhone";
            this.labelRegisterPhone.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelRegisterPhone.Size = new System.Drawing.Size(85, 20);
            this.labelRegisterPhone.TabIndex = 8;
            this.labelRegisterPhone.Text = "Phone";
            // 
            // labelRegisterGender
            // 
            this.labelRegisterGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRegisterGender.AutoSize = true;
            this.labelRegisterGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterGender.Location = new System.Drawing.Point(3, 215);
            this.labelRegisterGender.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRegisterGender.Name = "labelRegisterGender";
            this.labelRegisterGender.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelRegisterGender.Size = new System.Drawing.Size(94, 20);
            this.labelRegisterGender.TabIndex = 15;
            this.labelRegisterGender.Text = "Gender";
            // 
            // labelRegisterSSN
            // 
            this.labelRegisterSSN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRegisterSSN.AutoSize = true;
            this.labelRegisterSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterSSN.Location = new System.Drawing.Point(3, 165);
            this.labelRegisterSSN.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRegisterSSN.Name = "labelRegisterSSN";
            this.labelRegisterSSN.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelRegisterSSN.Size = new System.Drawing.Size(70, 20);
            this.labelRegisterSSN.TabIndex = 16;
            this.labelRegisterSSN.Text = "SSN";
            // 
            // textBoxSSN
            // 
            this.textBoxSSN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSSN.Location = new System.Drawing.Point(194, 160);
            this.textBoxSSN.Name = "textBoxSSN";
            this.textBoxSSN.Size = new System.Drawing.Size(186, 29);
            this.textBoxSSN.TabIndex = 5;
            // 
            // labelRegisterPatient
            // 
            this.labelRegisterPatient.AutoSize = true;
            this.labelRegisterPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRegisterPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.labelRegisterPatient.Location = new System.Drawing.Point(3, 3);
            this.labelRegisterPatient.Name = "labelRegisterPatient";
            this.labelRegisterPatient.Size = new System.Drawing.Size(200, 29);
            this.labelRegisterPatient.TabIndex = 5;
            this.labelRegisterPatient.Text = "Register Patient";
            // 
            // doctorBindingSource1
            // 
            this.doctorBindingSource1.DataSource = typeof(CS6232GroupProject.Model.Doctor);
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataSource = typeof(CS6232GroupProject.Model.Patient);
            // 
            // patientBindingSource2
            // 
            this.patientBindingSource2.DataSource = typeof(CS6232GroupProject.Model.Patient);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.clinicDataSet;
            this.doctorBindingSource.CurrentChanged += new System.EventHandler(this.doctorBindingSource_CurrentChanged);
            // 
            // clinicDataSet
            // 
            this.clinicDataSet.DataSetName = "clinicDataSet";
            this.clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // clinicDataSet1
            // 
            this.clinicDataSet1.DataSetName = "clinicDataSet";
            this.clinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // UserControlNurseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlNurseMain);
            this.Name = "UserControlNurseMain";
            this.Size = new System.Drawing.Size(652, 1003);
            this.tabControlNurseMain.ResumeLayout(false);
            this.tabPageNursePatientInformation.ResumeLayout(false);
            this.tabPageNursePatientInformation.PerformLayout();
            this.panelPatientSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet11)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelPatientInfoResults.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPageNurseBook.ResumeLayout(false);
            this.tabPageNurseBook.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource3)).EndInit();
            this.tabPageNurseRegister.ResumeLayout(false);
            this.tabPageNurseRegister.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanelRegisterZipcode.ResumeLayout(false);
            this.tableLayoutPanelRegisterZipcode.PerformLayout();
            this.tableLayoutPanelRegisterStreet.ResumeLayout(false);
            this.tableLayoutPanelRegisterStreet.PerformLayout();
            this.tableLayoutPanelRegisterCityState.ResumeLayout(false);
            this.tableLayoutPanelRegisterCityState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlNurseMain;
        private System.Windows.Forms.TabPage tabPageNursePatientInformation;
        private System.Windows.Forms.TabPage tabPageNurseBook;
        private System.Windows.Forms.TabPage tabPageNurseRegister;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPatientInformation;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelPhysician;
        private System.Windows.Forms.Button buttonBookSubmit;
        private System.Windows.Forms.Label labelBookAppointment;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.ComboBox comboBoxPhysician;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRegisterZipcode;
        private System.Windows.Forms.TextBox textBoxRegisterZipcode;
        private System.Windows.Forms.Label labelRegisterZipcode;
        private System.Windows.Forms.Label labelRegisterAddress;
        private System.Windows.Forms.TextBox textBoxRegisterLastName;
        private System.Windows.Forms.TextBox textBoxRegisterFirstName;
        private System.Windows.Forms.Label labelRegisterFirstName;
        private System.Windows.Forms.Label labelRegisterDateOfBirth;
        private System.Windows.Forms.Label labelRegisterLastName;
        private System.Windows.Forms.Label labelRegisterPhone;
        private System.Windows.Forms.TextBox textBoxRegisterPhone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRegisterStreet;
        private System.Windows.Forms.TextBox textBoxRegisterStreet;
        private System.Windows.Forms.Label labelRegisterStreet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRegisterCityState;
        private System.Windows.Forms.Label labelRegisterState;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Button buttonRegisterSubmit;
        private System.Windows.Forms.Label labelRegisterPatient;
        private System.Windows.Forms.Panel panelPatientInfoResults;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBoxLastNamePatientInfoResult;
        private System.Windows.Forms.TextBox textBoxFirstNamePatientInfoResult;
        private System.Windows.Forms.Label labelFirstNamePatientInfoResult;
        private System.Windows.Forms.Label labelDOBPatientInfoResult;
        private System.Windows.Forms.Label labelFlastNamePatientInfoResult;
        private System.Windows.Forms.Button buttonPatientInfoResultUpdate;
        private System.Windows.Forms.LinkLabel linkLabelPatientInfoBack;
        private System.Windows.Forms.Label labelPhonePatientInfoResult;
        private System.Windows.Forms.LinkLabel linkLabelDeletePatient;
        private System.Windows.Forms.Label labelMailAddressPatentInfoResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox textBoxStreetPatientInfoResult;
        private System.Windows.Forms.Label labelStreetPatientInfoResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label labelStatePatientInfoResult;
        private System.Windows.Forms.ComboBox comboBoxStatePatientInfoResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox textBoxZipPatientInfoResult;
        private System.Windows.Forms.Label labelZipPatientInfoResult;
        private System.Windows.Forms.TextBox textBoxPhonePatientInfoResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.LinkLabel linkLabelRecordsPatientInfoVisitRecords;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private clinicDataSet clinicDataSet;
        private clinicDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private clinicDataSet clinicDataSet1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private clinicDataSet1 clinicDataSet11;
        private clinicDataSet1TableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOBPatientInfoResult;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookAppointment;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegisterDOB;
        private System.Windows.Forms.Panel panelPatientSearch;
        private System.Windows.Forms.DataGridView dataGridViewPatientInfo;
        private System.Windows.Forms.Label labelAddMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookAppointmentTime;
        private System.Windows.Forms.Label labelRegisterGender;
        private System.Windows.Forms.Label labelRegisterSSN;
        private System.Windows.Forms.TextBox textBoxSSN;
        private System.Windows.Forms.Label labelGenderPatientInfoResult;
        private System.Windows.Forms.Label labelSSNPatientInfoResult;
        private System.Windows.Forms.TextBox textBoxSSNPatientInfoResult;
        private System.Windows.Forms.ComboBox comboBoxGenderPatientInfoResult;
        private System.Windows.Forms.ComboBox comboBoxRegisterGender;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.BindingSource patientBindingSource2;
        private System.Windows.Forms.BindingSource patientBindingSource3;
        private System.Windows.Forms.BindingSource doctorBindingSource1;
        private System.Windows.Forms.BindingSource doctorBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIDDataGridViewTextBoxColumn;
    }
}
