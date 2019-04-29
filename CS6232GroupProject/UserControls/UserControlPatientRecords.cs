using CS6232GroupProject.Controller;
using CS6232GroupProject.Model;
using CS6232GroupProject.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CS6232GroupProject.UserControls
{
    /// <summary>
    /// This class creates a user control to hold record information for 
    /// a Patient.
    /// </summary>
    public partial class UserControlPatientRecords : UserControl
    {

        private List<Appointment> appointmentList;
        private AppointmentController appointmentController;
        private DoctorController doctorController;
        private PatientVisitController visitController;
        private LabTestResultsController labTestResultsController;
        private List<Doctor> doctorList;
        private Appointment appointment;
        private PatientVisit visit;
        private int appointmentID;
        DateTimePicker dtp = new DateTimePicker();
        Rectangle rectangle;

        /// <summary>
        /// This constructs the UserControlPatientRecords objects and instatiates
        /// the needed variables.
        /// </summary>
        public UserControlPatientRecords()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.doctorController = new DoctorController();
            this.visitController = new PatientVisitController();
            this.labTestResultsController = new LabTestResultsController();
            SetComboBox();
            SetAppointment();
            labTestResultDataGridView.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);
        }

        /// <summary>
        /// Checks if a patient visit exists
        /// </summary>
        /// <param name="AppointmentID"></param>
        /// <returns></returns>
        private bool CheckIfPatientVisitExists(int AppointmentID)
        {
            
            if (this.visitController.DoesPatientVisitExist(AppointmentID))
            {
                
                return false;

            }
            else
            {
                
                return true;
            }
        }

        /// <summary>
        /// sets appointment for a patient
        /// </summary>
        private void SetAppointment()
        {
            try
            {
                if (CheckIfPatientVisitExists(this.appointmentID))
                {
                    this.visit = this.visitController.GetPatientVisitInfoByAppointment(this.appointmentID);
                }
                else
                {
                    CreateVisit();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("This patient has no appointments.");
            }
        }

        /// <summary>
        /// creates a visit
        /// </summary>
        private void CreateVisit()
        {
            PatientVisit newVisit = new PatientVisit();
            newVisit.AppointmentID = this.appointmentID;
            newVisit.NurseID = FormLogin.NurseID;
            newVisit.DoctorID = this.appointment.DoctorID;
            newVisit.Date = (DateTime)this.appointment.AppointmentDateTime;
            
            newVisit.Weight = 0.0m;
            newVisit.Systolic = 0;
            newVisit.Diastolic = 0;
            newVisit.Temperature = 0.0m;
            newVisit.Pulse = 0;
            newVisit.Symptoms = "";

            try
            {
                this.visitController.AddPatientVisit(newVisit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
            this.visit = this.visitController.GetPatientVisitInfoByAppointment(this.appointmentID);
        }

        /// <summary>
        /// sets the visit info for a patient
        /// </summary>
        private void SetVisitInfo()
        {
            try
            {
                this.labelPatientNameDisplay.Text = UserControlNurseMain.patientName;
                this.comboBoxAppointmentsPhysician.SelectedValue = this.appointment.DoctorID;
                this.textBoxAppointmentsSummary.Text = this.appointment.Reasons;
                this.dateTimePickerAppointments.Value = (DateTime)this.appointment.AppointmentDateTime;
                this.dateTimePickerAppointmentsTime.Value = (DateTime)this.appointment.AppointmentDateTime;

                this.textBoxRoutineChecksWeight.Text = this.visit.Weight.ToString();
                this.textBoxRoutineChecksSystolic.Text = this.visit.Systolic.ToString();
                this.textBoxRoutineChecksDiastolic.Text = this.visit.Diastolic.ToString();
                this.textBoxRoutineChecksTemp.Text = this.visit.Temperature.ToString();
                this.textboxRoutineChecksPulse.Text = this.visit.Pulse.ToString();
                this.textBoxRoutineChecksSummary.Text = this.visit.Symptoms;
                this.textBoxDiagnosisIntial.Text = this.visit.Diagnosis;
                this.textBoxDiagnosisFinal.Text = this.visit.finalDiagnosis;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        /// <summary>
        /// sets a combo box for the appointment list  and doctor
        /// </summary>
        private void SetComboBox()
        {
            try
            {
                this.appointmentList = this.appointmentController.GetAppointmentsForPatient(UserControlNurseMain.patientID);
                this.comboBoxPatientRecordsAppointment.DataSource = this.appointmentList;

                this.doctorList = this.doctorController.GetDoctors();
                this.comboBoxAppointmentsPhysician.DataSource = this.doctorList;
                this.comboBoxAppointmentsPhysician.SelectedValue = this.appointment.DoctorID;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private bool CheckFieldsVisitRoutine()
        {
            labelAddMessageVisitRoutine.ForeColor = Color.Red;
            string numberCheck = @"^[0-9]\d*(\.\d+)?$";

            if (String.IsNullOrEmpty(this.textBoxRoutineChecksWeight.Text) || !Regex.IsMatch(this.textBoxRoutineChecksWeight.Text, numberCheck))
            {
                labelAddMessageVisitRoutine.Text = "Please enter valid numerical weight.";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textBoxRoutineChecksTemp.Text) || !Regex.IsMatch(this.textBoxRoutineChecksTemp.Text, numberCheck))
            {
                labelAddMessageVisitRoutine.Text = "Please enter valid numerical temperature.";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textboxRoutineChecksPulse.Text) || !Regex.IsMatch(this.textboxRoutineChecksPulse.Text, numberCheck))
            {
                labelAddMessageVisitRoutine.Text = "Please enter valid numerical pulse.";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textBoxRoutineChecksSystolic.Text) || !Regex.IsMatch(this.textBoxRoutineChecksSystolic.Text, numberCheck))
            {
                labelAddMessageVisitRoutine.Text = "Please enter valid numerical systolic blood pressure.";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textBoxRoutineChecksDiastolic.Text) || !Regex.IsMatch(this.textBoxRoutineChecksDiastolic.Text, numberCheck))
            {
                labelAddMessageVisitRoutine.Text = "Please enter valid numerical diastolic blood pressure.";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textBoxRoutineChecksSummary.Text))
            {
                labelAddMessageVisitRoutine.Text = "Please fill out summary/symptoms.";
                return false;
            }
            else
            {
                labelAddMessageVisitRoutine.Text = "";
                return true;
            }
        }

        /// <summary>
        /// sets up check up info
        /// </summary>
        private void SetCheckUpInfo()
        {

            PatientVisit newVisit = new PatientVisit();
            if (CheckFieldsVisitRoutine())
            {
                try
                {
                    newVisit.VisitID = this.visit.VisitID;
                    newVisit.AppointmentID = this.visit.AppointmentID;
                    newVisit.Date = this.visit.Date;

                    newVisit.Weight = Convert.ToDecimal(this.textBoxRoutineChecksWeight.Text);
                    newVisit.Systolic = Convert.ToInt32(this.textBoxRoutineChecksSystolic.Text);
                    newVisit.Diastolic = Convert.ToInt32(this.textBoxRoutineChecksDiastolic.Text);
                    newVisit.Temperature = Convert.ToDecimal(this.textBoxRoutineChecksTemp.Text);
                    newVisit.Pulse = Convert.ToInt32(this.textboxRoutineChecksPulse.Text);
                    newVisit.Symptoms = this.textBoxRoutineChecksSummary.Text;

                    if (this.visitController.UpdateRoutineCheck(newVisit, this.visit))
                    {
                        MessageBox.Show("Routine Check information updated!", "Success");
                    }
                    else
                    {
                        MessageBox.Show("The information couldn't be updated.", "Error Updating Database");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("There was an issue updating the database.", "Error Updating Database");
                }

            }
        }

        /// <summary>
        /// disable textfield if meet criteria 
        /// </summary>
        private void AppointmentTimeCheck()
        {

            var appointment_time = Convert.ToDateTime(this.comboBoxPatientRecordsAppointment.Text);
            var time_now = DateTime.Now;
            if (time_now <= appointment_time)
            {
                this.textBoxAppointmentsSummary.Enabled = true;
                this.comboBoxAppointmentsPhysician.Enabled = true;
                this.dateTimePickerAppointments.Enabled = true;
                this.dateTimePickerAppointmentsTime.Enabled = true;
                this.linkLabelAppointmentsCancel.Enabled = true;
            }
            else
            {
                this.textBoxAppointmentsSummary.Enabled = false;
                this.comboBoxAppointmentsPhysician.Enabled = false;
                this.dateTimePickerAppointments.Enabled = false;
                this.dateTimePickerAppointmentsTime.Enabled = false;
                this.linkLabelAppointmentsCancel.Enabled = false;
            }
        }

        /// <summary>
        /// Update appointments if datetime is now or earlier.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAppointmentsUpdate_Click(object sender, EventArgs e)
        {
            Appointment newAppointment = new Appointment();
            var appointment_time = Convert.ToDateTime(comboBoxPatientRecordsAppointment.Text);
            var time_now = DateTime.Now;

            if (time_now <= appointment_time)
            {
                newAppointment.DoctorID = Convert.ToInt32(this.comboBoxAppointmentsPhysician.SelectedValue);
                newAppointment.AppointmentDateTime = this.dateTimePickerAppointments.Value.Date + this.dateTimePickerAppointmentsTime.Value.TimeOfDay;
                newAppointment.Reasons = this.textBoxAppointmentsSummary.Text;

                if (this.appointmentController.UpdateAppointment(newAppointment, this.appointment))
                {
                    MessageBox.Show("Appointment Updated!", "Sucess");
                    this.comboBoxAppointmentsPhysician.SelectedValue = newAppointment.DoctorID;
                    SetComboBox();
                }
                else
                {
                    MessageBox.Show("There was an issue updating the Appointment!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Appointment date has expired and can no longer be edited.", "Confirm");
            }
        }

        private void buttonRoutineChecksUpdate_Click(object sender, EventArgs e)
        {
            //If no PatientVisit exists, create one with the entered info and reload the page.
            SetCheckUpInfo();
        }

        /// <summary>
        /// Thie method updates diagnosis 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDiagnosisUpdate_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (!String.IsNullOrEmpty(this.textBoxDiagnosisIntial.Text) & this.textBoxDiagnosisIntial.Text != this.visit.Diagnosis)
            {
                this.visit.Diagnosis = this.textBoxDiagnosisIntial.Text;
                try
                {
                    
                    this.visitController.EnterInitialDiagnosis(this.visit);
                    count = 1;
                    MessageBox.Show("Initial diagnosis submitted.", "Success");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Initial diagnosis could not be updated");
                }

            }
            if (!String.IsNullOrEmpty(this.textBoxDiagnosisFinal.Text) & this.labTestResultsController.CheckForPendingTests(this.visit))
            {
                  try
                  {
                      this.visit.finalDiagnosis = this.textBoxDiagnosisFinal.Text;
                      this.visitController.EnterFinalDiagnosis(this.visit);
                      this.textBoxDiagnosisIntial.Enabled = false;
                    MessageBox.Show("Final diagnosis submitted.", "Success");
                  }
                  catch (Exception)
                  {

                      MessageBox.Show("Error: Final diagnosis could not be updated");
                  }
            }
            else
            {

                this.textBoxDiagnosisFinal.Text = "";

                if (!this.labTestResultsController.CheckForPendingTests(this.visit))
                {
                    MessageBox.Show("Final diagnosis could not be updated as there are tests pending");
                }
                else if(String.IsNullOrEmpty(this.textBoxDiagnosisFinal.Text) & count == 0)
                {
                    MessageBox.Show("Final diagnosis is null or empty");
                }
                   
            }
        }
            

        private void comboBoxPatientRecordsAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.appointmentID = (int)this.comboBoxPatientRecordsAppointment.SelectedValue;
            this.appointment = this.appointmentController.GetAppointmentByID(this.appointmentID);
            SetAppointment();
            this.comboBoxAppointmentsPhysician.SelectedValue = this.appointment.DoctorID;
            SetVisitInfo();
            AppointmentTimeCheck();
            this.tabControlPatientRecords_SelectedIndexChanged(null, null);
        }


        private void buttonLabTestsOrder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.visit.Diagnosis) & string.IsNullOrEmpty(this.visit.finalDiagnosis))
            {
                List<string> listOfTestsOrdered = this.checkedListBoxLabTests.CheckedItems.Cast<string>().ToList();

                foreach (var nameOfTestOrdered in listOfTestsOrdered)
                {
                    try
                    {
                        this.labTestResultsController.OrderSelectedTestForVisit(this.visit, nameOfTestOrdered);
                        MessageBox.Show("Test " + nameOfTestOrdered + " ordered successfully.", "Confirm");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(nameOfTestOrdered + " has already been ordered.","Confirm");
                    }

                }
            }
            else
            {
                MessageBox.Show("Tests cannot be ordered before an inital diagnosis or after a final diagnosis.", "Confirm");
            }
        }

        private void labTestResultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {


                rectangle = labTestResultDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Size = new Size(rectangle.Width, rectangle.Height);
                dtp.Location = new Point(rectangle.X, rectangle.Y);
                dtp.Visible = true;


            }
        }

        /// <summary>
        /// Drives the flow of application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlPatientRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlPatientRecords.SelectedIndex == 4)
            {
                this.labTestResultDataGridView.DataSource = this.labTestResultsController.GetLabTestResultByVisitID(this.visit);
            }
            else if (this.tabControlPatientRecords.SelectedIndex == 1)
            {
                this.buttonRoutineChecksUpdate.Enabled = true;
                if (!String.IsNullOrEmpty(this.visit.finalDiagnosis))
                {
                    this.buttonRoutineChecksUpdate.Enabled = false;
                }

            }
            else if (this.tabControlPatientRecords.SelectedIndex == 2 )
            {
                this.textBoxDiagnosisIntial.Enabled = true;
                this.textBoxDiagnosisFinal.Enabled = true;
                if (!String.IsNullOrEmpty(this.visit.finalDiagnosis))
                {
                    this.textBoxDiagnosisIntial.Enabled = false;
                }
                if (String.IsNullOrEmpty(this.visit.Diagnosis))
                {
                    this.textBoxDiagnosisFinal.Enabled = false;
                }

            }
            else if (this.tabControlPatientRecords.SelectedIndex == 3 )
            {
                if (String.IsNullOrEmpty(this.visit.finalDiagnosis))
                {
                    this.checkedListBoxLabTests.Enabled = true;
                } else if (!String.IsNullOrEmpty(this.visit.finalDiagnosis))
                {
                    this.checkedListBoxLabTests.Enabled = false;
                  
                }
                for (int index = 0; index < 4; index++)
                {
                    this.checkedListBoxLabTests.SetItemCheckState(index, CheckState.Unchecked);
                }
               
                List<LabTestResult> listOfResults = this.labTestResultsController.GetLabTestResultByVisitID(this.visit);
                foreach (var nameOfTestOrdered in listOfResults)
                {
                    if (nameOfTestOrdered.Name == "White Blood Cell (WBC)")
                    {
                        this.checkedListBoxLabTests.SetItemCheckState(0, CheckState.Checked);
                    }

                    if (nameOfTestOrdered.Name == "Low Density Lipoproteins (LDL)")
                    {
                        this.checkedListBoxLabTests.SetItemCheckState(1, CheckState.Checked);
                    }

                    if (nameOfTestOrdered.Name == "Hepatitis A")
                    {
                        this.checkedListBoxLabTests.SetItemCheckState(2, CheckState.Checked);
                    }

                    if (nameOfTestOrdered.Name == "Hepatitis B")
                    {
                        this.checkedListBoxLabTests.SetItemCheckState(3, CheckState.Checked);
                    }

                }
            }
        }

        private void linkLabelAppointmentsCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult confirmCancel = MessageBox.Show("Appointment will be cancelled and removed.\nContinue?", "Cancel Appointment Warning", MessageBoxButtons.YesNo);
            if (confirmCancel == DialogResult.Yes)
            {
                try
                {
                    this.appointmentController.CancelAppointment(appointmentID);
                    MessageBox.Show("The appointment has been cancelled!", "Appointment Cancelled!");
                    SetComboBox();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot cancel an appointment with pending test results!", "Error canceling appointment!");
                }
            }
            else if (confirmCancel == DialogResult.No)
            {
                return;
            }
        }

        private void dtp_TextChange(object sender, EventArgs e)
        {
            labTestResultDataGridView.CurrentCell.Value = dtp.Text.ToString();
        }

        private void labTestResultDataGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;

        }

        private void labTestResultDataGridView_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }

        private void labTestResultDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                try
                {
                    LabTestResult newResult = new LabTestResult();
                    LabTest test = new LabTest();

                    newResult.Result = this.labTestResultDataGridView.CurrentRow.Cells[2].Value.ToString();
                    newResult.VisitID = this.visit.VisitID;
                    newResult.TestID = (int)this.labTestResultDataGridView.CurrentRow.Cells[6].Value;
                    newResult.TestOrderedDate = visit.Date;
                    newResult.TestResultDate = Convert.ToDateTime(this.labTestResultDataGridView.CurrentRow.Cells[3].Value);

                    test.Name = this.labTestResultDataGridView.CurrentRow.Cells[0].Value.ToString();
                    this.labTestResultsController.EnterTestResultForVisit(visit, test, newResult);

                    MessageBox.Show("Test result updated.");
                }
                catch (Exception)
                {
                    MessageBox.Show("There was an issue updating the tests!", "Error");
                }
            }
        }
    }
}
