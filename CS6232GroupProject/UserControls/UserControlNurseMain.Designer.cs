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
            this.tabControlNurseMain = new System.Windows.Forms.TabControl();
            this.tabPageNursePatientInformation = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelPatientInformation = new System.Windows.Forms.Label();
            this.tabPageNurseBook = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxPhysician = new System.Windows.Forms.ComboBox();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.labelSummary = new System.Windows.Forms.Label();
            this.textBoxDateTime = new System.Windows.Forms.TextBox();
            this.labelPatient = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelPhysician = new System.Windows.Forms.Label();
            this.buttonBookSubmit = new System.Windows.Forms.Button();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.labelBookAppointment = new System.Windows.Forms.Label();
            this.tabPageNurseRegister = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRegisterZipcode = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRegisterZipcode = new System.Windows.Forms.TextBox();
            this.labelRegisterZipcode = new System.Windows.Forms.Label();
            this.labelRegisterAddress = new System.Windows.Forms.Label();
            this.textBoxRegisterDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxRegisterLastName = new System.Windows.Forms.TextBox();
            this.textBoxRegisterFirstName = new System.Windows.Forms.TextBox();
            this.labelRegisterFirstName = new System.Windows.Forms.Label();
            this.labelRegisterDateOfBirth = new System.Windows.Forms.Label();
            this.labelRegisterLastName = new System.Windows.Forms.Label();
            this.labelRegisterPhone = new System.Windows.Forms.Label();
            this.textBoxRegisterPhone = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelRegisterStreet = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRegisterStreet = new System.Windows.Forms.TextBox();
            this.labelRegisterStreet = new System.Windows.Forms.Label();
            this.tableLayoutPanelRegisterCityState = new System.Windows.Forms.TableLayoutPanel();
            this.labelRegisterCity = new System.Windows.Forms.Label();
            this.labelRegisterState = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.buttonRegisterSubmit = new System.Windows.Forms.Button();
            this.labelRegisterPatient = new System.Windows.Forms.Label();
            this.tabControlNurseMain.SuspendLayout();
            this.tabPageNursePatientInformation.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageNurseBook.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageNurseRegister.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanelRegisterZipcode.SuspendLayout();
            this.tableLayoutPanelRegisterStreet.SuspendLayout();
            this.tableLayoutPanelRegisterCityState.SuspendLayout();
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
            this.tabControlNurseMain.Size = new System.Drawing.Size(692, 595);
            this.tabControlNurseMain.TabIndex = 0;
            // 
            // tabPageNursePatientInformation
            // 
            this.tabPageNursePatientInformation.Controls.Add(this.tableLayoutPanel1);
            this.tabPageNursePatientInformation.Controls.Add(this.labelPatientInformation);
            this.tabPageNursePatientInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.tabPageNursePatientInformation.Location = new System.Drawing.Point(4, 29);
            this.tabPageNursePatientInformation.Name = "tabPageNursePatientInformation";
            this.tabPageNursePatientInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNursePatientInformation.Size = new System.Drawing.Size(684, 562);
            this.tabPageNursePatientInformation.TabIndex = 0;
            this.tabPageNursePatientInformation.Text = "Patient Information";
            this.tabPageNursePatientInformation.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxDateOfBirth, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelFirstName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDateOfBirth, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelLastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSearch, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 230);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(206, 110);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(186, 29);
            this.textBoxDateOfBirth.TabIndex = 6;
            this.textBoxDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(206, 60);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(186, 29);
            this.textBoxLastName.TabIndex = 5;
            this.textBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(206, 10);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(186, 29);
            this.textBoxFirstName.TabIndex = 4;
            this.textBoxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.buttonSearch.Location = new System.Drawing.Point(372, 157);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(137, 35);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
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
            // tabPageNurseBook
            // 
            this.tabPageNurseBook.BackColor = System.Drawing.Color.White;
            this.tabPageNurseBook.Controls.Add(this.tableLayoutPanel2);
            this.tabPageNurseBook.Controls.Add(this.labelBookAppointment);
            this.tabPageNurseBook.Location = new System.Drawing.Point(4, 29);
            this.tabPageNurseBook.Name = "tabPageNurseBook";
            this.tabPageNurseBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNurseBook.Size = new System.Drawing.Size(684, 562);
            this.tabPageNurseBook.TabIndex = 1;
            this.tabPageNurseBook.Text = "Book Appointment";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.comboBoxPhysician, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxPatient, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelSummary, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDateTime, 1, 2);
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(678, 360);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // comboBoxPhysician
            // 
            this.comboBoxPhysician.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxPhysician.FormattingEnabled = true;
            this.comboBoxPhysician.Location = new System.Drawing.Point(206, 61);
            this.comboBoxPhysician.Name = "comboBoxPhysician";
            this.comboBoxPhysician.Size = new System.Drawing.Size(186, 28);
            this.comboBoxPhysician.TabIndex = 10;
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(206, 11);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(186, 28);
            this.comboBoxPatient.TabIndex = 7;
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
            // textBoxDateTime
            // 
            this.textBoxDateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateTime.Location = new System.Drawing.Point(206, 110);
            this.textBoxDateTime.Name = "textBoxDateTime";
            this.textBoxDateTime.Size = new System.Drawing.Size(186, 29);
            this.textBoxDateTime.TabIndex = 6;
            this.textBoxDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.labelDateTime.Size = new System.Drawing.Size(107, 20);
            this.labelDateTime.TabIndex = 3;
            this.labelDateTime.Text = "Datetime";
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
            this.buttonBookSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.buttonBookSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBookSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookSubmit.ForeColor = System.Drawing.Color.Black;
            this.buttonBookSubmit.Location = new System.Drawing.Point(538, 306);
            this.buttonBookSubmit.Name = "buttonBookSubmit";
            this.buttonBookSubmit.Size = new System.Drawing.Size(137, 51);
            this.buttonBookSubmit.TabIndex = 7;
            this.buttonBookSubmit.Text = "Submit";
            this.buttonBookSubmit.UseVisualStyleBackColor = false;
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSummary.Location = new System.Drawing.Point(206, 166);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.Size = new System.Drawing.Size(427, 121);
            this.textBoxSummary.TabIndex = 9;
            this.textBoxSummary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tabPageNurseRegister.Controls.Add(this.tableLayoutPanel3);
            this.tabPageNurseRegister.Controls.Add(this.labelRegisterPatient);
            this.tabPageNurseRegister.Location = new System.Drawing.Point(4, 29);
            this.tabPageNurseRegister.Name = "tabPageNurseRegister";
            this.tabPageNurseRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNurseRegister.Size = new System.Drawing.Size(684, 562);
            this.tabPageNurseRegister.TabIndex = 2;
            this.tabPageNurseRegister.Text = "Register Patient";
            this.tabPageNurseRegister.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanelRegisterZipcode, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.labelRegisterAddress, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.textBoxRegisterDateOfBirth, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxRegisterLastName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxRegisterFirstName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelRegisterFirstName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelRegisterDateOfBirth, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelRegisterLastName, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelRegisterPhone, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBoxRegisterPhone, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanelRegisterStreet, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanelRegisterCityState, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.buttonRegisterSubmit, 1, 8);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(678, 524);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanelRegisterZipcode
            // 
            this.tableLayoutPanelRegisterZipcode.ColumnCount = 1;
            this.tableLayoutPanelRegisterZipcode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRegisterZipcode.Controls.Add(this.textBoxRegisterZipcode, 0, 1);
            this.tableLayoutPanelRegisterZipcode.Controls.Add(this.labelRegisterZipcode, 0, 0);
            this.tableLayoutPanelRegisterZipcode.Location = new System.Drawing.Point(206, 363);
            this.tableLayoutPanelRegisterZipcode.Name = "tableLayoutPanelRegisterZipcode";
            this.tableLayoutPanelRegisterZipcode.RowCount = 2;
            this.tableLayoutPanelRegisterZipcode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRegisterZipcode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRegisterZipcode.Size = new System.Drawing.Size(200, 59);
            this.tableLayoutPanelRegisterZipcode.TabIndex = 14;
            // 
            // textBoxRegisterZipcode
            // 
            this.textBoxRegisterZipcode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRegisterZipcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegisterZipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterZipcode.Location = new System.Drawing.Point(3, 25);
            this.textBoxRegisterZipcode.Name = "textBoxRegisterZipcode";
            this.textBoxRegisterZipcode.Size = new System.Drawing.Size(186, 29);
            this.textBoxRegisterZipcode.TabIndex = 12;
            this.textBoxRegisterZipcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.labelRegisterAddress.Location = new System.Drawing.Point(3, 205);
            this.labelRegisterAddress.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRegisterAddress.Name = "labelRegisterAddress";
            this.labelRegisterAddress.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelRegisterAddress.Size = new System.Drawing.Size(161, 20);
            this.labelRegisterAddress.TabIndex = 9;
            this.labelRegisterAddress.Text = "Mailing Address";
            // 
            // textBoxRegisterDateOfBirth
            // 
            this.textBoxRegisterDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRegisterDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegisterDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterDateOfBirth.Location = new System.Drawing.Point(206, 110);
            this.textBoxRegisterDateOfBirth.Name = "textBoxRegisterDateOfBirth";
            this.textBoxRegisterDateOfBirth.Size = new System.Drawing.Size(186, 29);
            this.textBoxRegisterDateOfBirth.TabIndex = 6;
            this.textBoxRegisterDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRegisterLastName
            // 
            this.textBoxRegisterLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRegisterLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegisterLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterLastName.Location = new System.Drawing.Point(206, 60);
            this.textBoxRegisterLastName.Name = "textBoxRegisterLastName";
            this.textBoxRegisterLastName.Size = new System.Drawing.Size(186, 29);
            this.textBoxRegisterLastName.TabIndex = 5;
            this.textBoxRegisterLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRegisterFirstName
            // 
            this.textBoxRegisterFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRegisterFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegisterFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterFirstName.Location = new System.Drawing.Point(206, 10);
            this.textBoxRegisterFirstName.Name = "textBoxRegisterFirstName";
            this.textBoxRegisterFirstName.Size = new System.Drawing.Size(186, 29);
            this.textBoxRegisterFirstName.TabIndex = 4;
            this.textBoxRegisterFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // labelRegisterPhone
            // 
            this.labelRegisterPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRegisterPhone.AutoSize = true;
            this.labelRegisterPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterPhone.Location = new System.Drawing.Point(3, 165);
            this.labelRegisterPhone.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRegisterPhone.Name = "labelRegisterPhone";
            this.labelRegisterPhone.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelRegisterPhone.Size = new System.Drawing.Size(85, 20);
            this.labelRegisterPhone.TabIndex = 8;
            this.labelRegisterPhone.Text = "Phone";
            // 
            // textBoxRegisterPhone
            // 
            this.textBoxRegisterPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRegisterPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegisterPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterPhone.Location = new System.Drawing.Point(206, 160);
            this.textBoxRegisterPhone.Name = "textBoxRegisterPhone";
            this.textBoxRegisterPhone.Size = new System.Drawing.Size(186, 29);
            this.textBoxRegisterPhone.TabIndex = 10;
            this.textBoxRegisterPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanelRegisterStreet
            // 
            this.tableLayoutPanelRegisterStreet.ColumnCount = 1;
            this.tableLayoutPanelRegisterStreet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRegisterStreet.Controls.Add(this.textBoxRegisterStreet, 0, 1);
            this.tableLayoutPanelRegisterStreet.Controls.Add(this.labelRegisterStreet, 0, 0);
            this.tableLayoutPanelRegisterStreet.Location = new System.Drawing.Point(206, 233);
            this.tableLayoutPanelRegisterStreet.Name = "tableLayoutPanelRegisterStreet";
            this.tableLayoutPanelRegisterStreet.RowCount = 2;
            this.tableLayoutPanelRegisterStreet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRegisterStreet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRegisterStreet.Size = new System.Drawing.Size(200, 59);
            this.tableLayoutPanelRegisterStreet.TabIndex = 13;
            // 
            // textBoxRegisterStreet
            // 
            this.textBoxRegisterStreet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRegisterStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegisterStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterStreet.Location = new System.Drawing.Point(3, 25);
            this.textBoxRegisterStreet.Name = "textBoxRegisterStreet";
            this.textBoxRegisterStreet.Size = new System.Drawing.Size(186, 29);
            this.textBoxRegisterStreet.TabIndex = 12;
            this.textBoxRegisterStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tableLayoutPanelRegisterCityState.ColumnCount = 2;
            this.tableLayoutPanelRegisterCityState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRegisterCityState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRegisterCityState.Controls.Add(this.labelRegisterCity, 0, 0);
            this.tableLayoutPanelRegisterCityState.Controls.Add(this.labelRegisterState, 1, 0);
            this.tableLayoutPanelRegisterCityState.Controls.Add(this.comboBoxState, 1, 1);
            this.tableLayoutPanelRegisterCityState.Controls.Add(this.textBoxCity, 0, 1);
            this.tableLayoutPanelRegisterCityState.Location = new System.Drawing.Point(206, 298);
            this.tableLayoutPanelRegisterCityState.Name = "tableLayoutPanelRegisterCityState";
            this.tableLayoutPanelRegisterCityState.RowCount = 2;
            this.tableLayoutPanelRegisterCityState.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRegisterCityState.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRegisterCityState.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanelRegisterCityState.Size = new System.Drawing.Size(401, 59);
            this.tableLayoutPanelRegisterCityState.TabIndex = 14;
            // 
            // labelRegisterCity
            // 
            this.labelRegisterCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRegisterCity.AutoSize = true;
            this.labelRegisterCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterCity.Location = new System.Drawing.Point(3, 0);
            this.labelRegisterCity.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRegisterCity.Name = "labelRegisterCity";
            this.labelRegisterCity.Size = new System.Drawing.Size(39, 20);
            this.labelRegisterCity.TabIndex = 11;
            this.labelRegisterCity.Text = "City";
            // 
            // labelRegisterState
            // 
            this.labelRegisterState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRegisterState.AutoSize = true;
            this.labelRegisterState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterState.Location = new System.Drawing.Point(203, 0);
            this.labelRegisterState.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.labelRegisterState.Name = "labelRegisterState";
            this.labelRegisterState.Size = new System.Drawing.Size(53, 20);
            this.labelRegisterState.TabIndex = 14;
            this.labelRegisterState.Text = "State";
            // 
            // comboBoxState
            // 
            this.comboBoxState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(203, 25);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(100, 28);
            this.comboBoxState.TabIndex = 15;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.Location = new System.Drawing.Point(3, 25);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(186, 29);
            this.textBoxCity.TabIndex = 12;
            this.textBoxCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRegisterSubmit
            // 
            this.buttonRegisterSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegisterSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.buttonRegisterSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterSubmit.ForeColor = System.Drawing.Color.Black;
            this.buttonRegisterSubmit.Location = new System.Drawing.Point(372, 432);
            this.buttonRegisterSubmit.Name = "buttonRegisterSubmit";
            this.buttonRegisterSubmit.Size = new System.Drawing.Size(137, 35);
            this.buttonRegisterSubmit.TabIndex = 7;
            this.buttonRegisterSubmit.Text = "Register";
            this.buttonRegisterSubmit.UseVisualStyleBackColor = false;
            this.buttonRegisterSubmit.Click += new System.EventHandler(this.buttonRegisterSubmit_Click);
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
            // UserControlNurseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlNurseMain);
            this.Name = "UserControlNurseMain";
            this.Size = new System.Drawing.Size(692, 595);
            this.tabControlNurseMain.ResumeLayout(false);
            this.tabPageNursePatientInformation.ResumeLayout(false);
            this.tabPageNursePatientInformation.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageNurseBook.ResumeLayout(false);
            this.tabPageNurseBook.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.TextBox textBoxDateTime;
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
        private System.Windows.Forms.TextBox textBoxRegisterDateOfBirth;
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
        private System.Windows.Forms.Label labelRegisterCity;
        private System.Windows.Forms.Label labelRegisterState;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button buttonRegisterSubmit;
        private System.Windows.Forms.Label labelRegisterPatient;
    }
}
