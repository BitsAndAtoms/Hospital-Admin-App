

CS6232 Group G4


The All Database Files are located in the Folder DB Files.

****************************************************************************************************************

Please note: If you set a nurse to inactive, or they are already set to inactive,
you cannot log in with that nurse.

If it is unclear, the Result Date of the Lab Test Results tab can be changed.

The Patient's Information below is for testing that a patient with an incomplete appointment (in progress) and 
a patient with pending test results cannot be deleted.

****************************************************************************************************************
Nurse Information:
    Login:
		Username: Betty
		Password: password
	
	Login:
		Username: Omar
		Password: password
		
	Login:
		Username: Tyson
		Password: password
		
Administrator Information:
	Login:
		Username: Chester
		Password: password
		
Patient Information:

	Name:
		Marvin Ronda
	
	Name:
		Ram Ram
		
Known Bugs:

	Patient Records: This is less of a bug, and more of a comment. A user can order lab tests after an appointment has passed, along with 
		routine checkup information. That said, we left the possibility open as often the need to correct information is important. If 
		a nurse accidentally stated that the patient's weight was 12, not 120, the need to correct that is important. That is one of the 
		reasons we left the ability to edit the appointment, but not cancel it, after the appointment had passed available.

    FormPatientRecords.cs: When opening the designer view of the Patient Records Form, but not the User Control, a message about and object 
		reference not set to an instance of an object as well as a notification about a patient having no appointments. This is due to one of 
		our built-in checks for displaying the page if, and only if, the patient has an appointment. It doesn't effect the running of the application 
		in any way.
		
	PatientRecords: This is more of our only bug that we found. If the appointment has passed, the user can still update the results of the lab tests.
		We tried to disable this, but as it required some custom coding to get to work, it was a bit difficult, thus, we left it possible to update the 
		results after the appointment had passed.
		
	FormLogin: The username entered isn't case sensitive, and accepts upper or lowercase letters. The password is case sensitive.