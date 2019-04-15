using CS6232GroupProject.Controller;
using CS6232GroupProject.Model;
using CS6232GroupProject.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private List<Doctor> doctorList;
        private Appointment appointment;
        private PatientVisit visit;
        private int appointmentID;

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
            SetComboBox();
            SetAppointment();
            
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
                //MessageBox.Show(ex.Message, ex.GetType().ToString());
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

            if (this.textBoxRoutineChecksWeight.Text.Length == 0 || this.textBoxRoutineChecksWeight.Text == null)
            {
                labelAddMessageVisitRoutine.Text = "Please enter weight.";
                return false;
            }
            else if (this.textBoxRoutineChecksTemp.Text.Length == 0 || this.textBoxRoutineChecksTemp.Text == null)
            {
                labelAddMessageVisitRoutine.Text = "Please enter temperature.";
                return false;
            }
            else if (this.textboxRoutineChecksPulse.Text.Length == 0 || this.textboxRoutineChecksPulse == null)
            {
                labelAddMessageVisitRoutine.Text = "Please enter pulse.";
                return false;
            }
            else if (this.textBoxRoutineChecksSystolic.Text.Length == 0 || this.textBoxRoutineChecksSystolic == null)
            {
                labelAddMessageVisitRoutine.Text = "Please enter systolic blood pressure.";
                return false;
            }
            else if (this.textBoxRoutineChecksDiastolic.Text.Length == 0 || this.textBoxRoutineChecksDiastolic == null)
            {
                labelAddMessageVisitRoutine.Text = "Please enter diastolic blood pressure.";
                return false;
            }
            else if (this.textBoxRoutineChecksSummary.Text.Length == 0 || this.textBoxRoutineChecksSummary == null)
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
            }
            else
            {
                this.textBoxAppointmentsSummary.Enabled = false;
                this.comboBoxAppointmentsPhysician.Enabled = false;
                this.dateTimePickerAppointments.Enabled = false;
                this.dateTimePickerAppointmentsTime.Enabled = false;
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
            if (!String.IsNullOrEmpty(this.textBoxDiagnosisIntial.Text))
            {
                this.visit.Diagnosis = this.textBoxDiagnosisIntial.Text;
                try
                {
                    
                    this.visitController.EnterInitialDiagnosis(this.visit);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Initial diagnosis could not be updated");
                }

            }
            if (!String.IsNullOrEmpty(this.textBoxDiagnosisFinal.Text) & this.visitController.CheckForPendingTests(this.visit))
            {
                  try
                    {
                        this.visit.finalDiagnosis = this.textBoxDiagnosisFinal.Text;
                        this.visitController.EnterFinalDiagnosis(this.visit);
                    this.textBoxDiagnosisIntial.Enabled = false;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error: Final diagnosis could not be updated");
                    }
                }
                else {
                    this.textBoxDiagnosisFinal.Text = "";
                    MessageBox.Show("Final diagnosis could not be updated as there are tests pending");
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

        private void buttonLabTestsSubmit_Click(object sender, EventArgs e)
        {
            LabTestResult newResult = new LabTestResult();
            LabTest test = new LabTest();

            newResult.Result = this.textBoxLabTestResultsWBC.Text;
            test.Name = "White Blood Cell (WBC)";
            this.visitController.EnterTestResultForVisit(visit, test, newResult);

            newResult.Result = this.textBoxLabTestResultsLDL.Text;
            test.Name = "Low Density Lipoproteins (LDL)";
            this.visitController.EnterTestResultForVisit(visit, test, newResult);

            newResult.Result = this.textBoxLabTestResultsHepatitisA.Text;
            test.Name = "Hepatitis A";
            this.visitController.EnterTestResultForVisit(visit, test, newResult);
            
            newResult.Result = this.textBoxLabTestResultsHepatitisB.Text;
            test.Name = "Hepatitis B";
            this.visitController.EnterTestResultForVisit(visit,test,newResult);

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
                        this.visitController.OrderSelectedTestForVisit(this.visit, nameOfTestOrdered);
                        MessageBox.Show("Test(s) ordered.", "Confirm");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error: The test could not be ordered");
                    }
                }
            }
            else
            {
                MessageBox.Show("Tests cant be ordered without an inital diagnosis or after a final diagnosis");
            }
        }

        private void labTestResultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                this.labTestResultDataGridView.DataSource = this.visitController.GetLabTestResultByVisitID(this.visit);
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
                    this.buttonLabTestsUpdate.Enabled = true;
                    this.checkedListBoxLabTests.Enabled = true;
                } else if (!String.IsNullOrEmpty(this.visit.finalDiagnosis))
                {
                    this.buttonLabTestsUpdate.Enabled = false;
                    this.checkedListBoxLabTests.Enabled = false;
                }
                for (int index = 0; index < 4; index++)
                {
                    this.checkedListBoxLabTests.SetItemCheckState(index, CheckState.Unchecked);
                }
               
                List<LabTestResult> listOfResults = this.visitController.GetLabTestResultByVisitID(this.visit);
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
    }
}
