/****** Script for SelectTopNRows command from SSMS  ******/
if exists(Select 'Nurse' as Role, fname, lname FROM Nurse WHERE nurseUserName = 'N12000')
 Select 'Nurse' as Role, fname, lname from Nurse WHERE nurseUserName = 'N12000'
 else if exists(Select 'Admin' as Role, fname, lname FROM Admininstrator WHERE adminUserName = 'N12000')
 Select 'Admin' as Role, fname, lname from Admin WHERE adminUserName = 'N12000'
 else if exists(Select 'Doctor' as Role, fname, lname FROM Doctor WHERE doctorUserName = 'N12000')
 Select 'Doctor' as Role, fname, lname from Doctor WHERE doctorUserName = 'N12000' 
 else PRINT 'no records returned from tables'  