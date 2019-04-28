USE [CS6232-g4]
GO

/****** Object:  StoredProcedure [dbo].[sp_mostPerformedTestsDuringDates]    Script Date: 4/27/2019 8:14:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[sp_mostPerformedTestsDuringDates] 
	-- Add the parameters for the stored procedure here
	@BeginDate DATETIME,   
    @EndDate DATETIME 
AS

 IF(@BeginDate IS NULL)
   BEGIN
      RAISERROR('Invalid begin date, can not be null', 18, 0)
   RETURN
 END;

  IF(@EndDate IS NULL)
   BEGIN
      RAISERROR('Invalid end date , can not be null', 18, 0)
   RETURN
 END;

 IF (@BeginDate > @EndDate)
   BEGIN
      RAISERROR('Invalid dates: begin date can not be after end date', 18, 0)
   RETURN
 END;
 
 BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
  SET NOCOUNT ON;
 
  SELECT  testID as testCode, testName, COUNT(testID) as timesTestPerformed,
  SUM(COUNT(testID)) OVER() totalTimesAllTestPerformed, 
  CONVERT(DECIMAL(10,2),(COUNT(testID)*100.0/SUM(COUNT(testID)) OVER())) as percentTestPerformed,
  COUNT(case when testResult = 'normal' then 1 else null end) as normalResultNumber,
  COUNT(case when testResult = 'abnormal' then 1 else null end) as abnormalResultNumber,
  CONVERT(DECIMAL(10,2),(COUNT(case when DATEADD(year,18,dob) <= testPerformedDate AND DATEADD(year,29,dob) >= testPerformedDate THEN 1 else null end)/COUNT(testID))) as percentTested18_29AgeGroup,
  CONVERT(DECIMAL(10,2),(COUNT(case when DATEADD(year,30,dob) <= testPerformedDate AND DATEADD(year,39,dob) >= testPerformedDate THEN 1 else null end)/COUNT(testID))) as percentTested30_39AgeGroup,
  CONVERT(DECIMAL(10,2),(COUNT(case when DATEADD(year,18,dob) > testPerformedDate OR DATEADD(year,39,dob) < testPerformedDate THEN 1 else null end)/COUNT(testID))) as percentTestOtherAgeGroup
  FROM (SELECT table3.testID, testName ,dob, patientID, testResult, testPerformedDate
  FROM (SELECT testID, dob, patientID,testResult, testPerformedDate
  FROM LabTestResult
  LEFT JOIN
  (SELECT patientID, dob, visitID 
  FROM    PatientVisit
  LEFT JOIN
  (SELECT HasAppointment.patientID, dob, appointmentID
  FROM HasAppointment
  LEFT JOIN Patient
  ON HasAppointment.patientID = Patient.patientID) AS table1
  ON PatientVisit.appointmentID =table1.appointmentID) as table2
  ON LabTestResult.visitID = table2.visitID
  WHERE testPerformedDate IS NOT NULL) as table3
  LEFT JOIN
  LabTestList
  ON table3.testID = LabTestList.testID) as table4 
  WHERE testPerformedDate Between @BeginDate AND @EndDate 
  GROUP BY testID, testName
  HAVING COUNT(testID)>1
  ORDER BY timesTestPerformed DESC, testCode DESC;
 END
GO


