/****** Script for inserting nurse passwords  ******/
/******
INSERT INTO Login (username, password)
VALUES ('N12000', PWDENCRYPT( 'test1234' ));
 ******/


  /****** Script for inserting Address  ******/
  /**
INSERT INTO Address ([state]
      ,[zip]
      ,[street])
VALUES ('Georgia', '79513','Kathmandu');
**/


 /****** Script for inserting nurse data  ******/
 /****
INSERT INTO Nurse ([fname]
      ,[lname]
      ,[dob]
      ,[ssn]
      ,[gender]
      ,[phone]
      ,[nurseUsername]
      ,[addressID])
VALUES ('Tiffany','Rice','11/11/1970','838108382','F','8067008062','N12321', 2);

***/
