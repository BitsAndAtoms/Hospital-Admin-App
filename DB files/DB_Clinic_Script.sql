USE [master]
GO
/******* Object:  Database [clinic]    Script Date: 3/4/2019 6:57:35 PM ******/
CREATE DATABASE [clinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'clinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\clinic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'clinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\clinic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [clinic] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [clinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [clinic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [clinic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [clinic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [clinic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [clinic] SET ARITHABORT OFF 
GO
ALTER DATABASE [clinic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [clinic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [clinic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [clinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [clinic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [clinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [clinic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [clinic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [clinic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [clinic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [clinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [clinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [clinic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [clinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [clinic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [clinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [clinic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [clinic] SET RECOVERY FULL 
GO
ALTER DATABASE [clinic] SET  MULTI_USER 
GO
ALTER DATABASE [clinic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [clinic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [clinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [clinic] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [clinic] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [clinic] SET QUERY_STORE = OFF
GO
USE [clinic]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 3/4/2019 6:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[state] [nchar](40) NOT NULL,
	[zip] [nchar](40) NOT NULL,
	[street] [nchar](40) NULL,
	[addressID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[addressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 3/4/2019 6:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[adminID] [int] IDENTITY(1,1) NOT NULL,
	[fname] [nchar](40) NULL,
	[lname] [nchar](40) NULL,
	[dob] [date] NULL,
	[ssn] [nchar](9) NOT NULL,
	[gender] [nchar](40) NULL,
	[phone] [nchar](10) NULL,
	[adminUsername] [int] NOT NULL,
	[addressID] [int] NOT NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[adminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Administrator] UNIQUE NONCLUSTERED 
(
	[adminUsername] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 3/4/2019 6:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[doctorID] [int] IDENTITY(1,1) NOT NULL,
	[fname] [nchar](40) NULL,
	[lname] [nchar](40) NULL,
	[dob] [date] NULL,
	[ssn] [nchar](9) NOT NULL,
	[gender] [nchar](40) NULL,
	[phone] [nchar](10) NULL,
	[doctorUsername] [int] NOT NULL,
	[addressID] [int] NOT NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Doctor] UNIQUE NONCLUSTERED 
(
	[doctorUsername] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HasAppointment]    Script Date: 3/4/2019 6:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HasAppointment](
	[appointmentID] [int] IDENTITY(1,1) NOT NULL,
	[doctorID] [int] NOT NULL,
	[patientID] [int] NOT NULL,
	[appointmentDateTime] [datetime] NOT NULL,
	[reasons] [nchar](120) NOT NULL,
 CONSTRAINT [PK_HasAppointment] PRIMARY KEY CLUSTERED 
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabTestList]    Script Date: 3/4/2019 6:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabTestList](
	[testID] [int] IDENTITY(1,1) NOT NULL,
	[testName] [nchar](40) NOT NULL,
 CONSTRAINT [PK_LabTestList] PRIMARY KEY CLUSTERED 
(
	[testID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabTestResult]    Script Date: 3/4/2019 6:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabTestResult](
	[labTestResultID] [int] IDENTITY(1,1) NOT NULL,
	[testID] [int] NOT NULL,
	[visitID] [int] NOT NULL,
	[testResult] [nchar](40) NULL,
	[testDate] [datetime] NULL,
 CONSTRAINT [PK_LabTestResult] PRIMARY KEY CLUSTERED 
(
	[labTestResultID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 3/4/2019 6:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[username] [int] NOT NULL,
	[password] [varchar](45) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nurse]    Script Date: 3/4/2019 6:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nurse](
	[nurseID] [int] IDENTITY(1,1) NOT NULL,
	[fname] [nchar](40) NULL,
	[lname] [nchar](40) NULL,
	[dob] [date] NULL,
	[ssn] [nchar](9) NOT NULL,
	[gender] [nchar](40) NULL,
	[phone] [nchar](10) NULL,
	[nurseUsername] [int] NOT NULL,
	[addressID] [int] NOT NULL,
 CONSTRAINT [PK_Nurse] PRIMARY KEY CLUSTERED 
(
	[nurseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Nurse] UNIQUE NONCLUSTERED 
(
	[nurseUsername] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 3/4/2019 6:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[patientID] [int] IDENTITY(1,1) NOT NULL,
	[fname] [nchar](40) NULL,
	[lname] [nchar](40) NULL,
	[dob] [date] NULL,
	[ssn] [nchar](9) NOT NULL,
	[gender] [nchar](40) NULL,
	[phone] [nchar](10) NULL,
	[addressID] [int] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientVisit]    Script Date: 3/4/2019 6:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientVisit](
	[visitID] [int] IDENTITY(1,1) NOT NULL,
	[appoitnementID] [int] NOT NULL,
	[nurseID] [int] NOT NULL,
	[visitDateTime] [datetime] NOT NULL,
	[diagnosis] [nchar](120) NULL,
	[weight] [decimal](18, 0) NOT NULL,
	[systolic] [int] NOT NULL,
	[diastolic] [int] NOT NULL,
	[temperature] [decimal](18, 0) NOT NULL,
	[pulse] [int] NOT NULL,
	[symptoms] [nchar](40) NOT NULL,
 CONSTRAINT [PK_PatientVisit] PRIMARY KEY CLUSTERED 
(
	[visitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialities]    Script Date: 3/4/2019 6:57:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialities](
	[doctorID] [int] NOT NULL,
	[specialityName] [nchar](40) NOT NULL,
 CONSTRAINT [PK_Specialities] PRIMARY KEY CLUSTERED 
(
	[specialityName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Administrator]  WITH CHECK ADD  CONSTRAINT [FK_Administrator_Address] FOREIGN KEY([addressID])
REFERENCES [dbo].[Address] ([addressID])
GO
ALTER TABLE [dbo].[Administrator] CHECK CONSTRAINT [FK_Administrator_Address]
GO
ALTER TABLE [dbo].[Administrator]  WITH CHECK ADD  CONSTRAINT [FK_Administrator_Login] FOREIGN KEY([adminUsername])
REFERENCES [dbo].[Login] ([username])
GO
ALTER TABLE [dbo].[Administrator] CHECK CONSTRAINT [FK_Administrator_Login]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Address] FOREIGN KEY([addressID])
REFERENCES [dbo].[Address] ([addressID])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Address]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Login] FOREIGN KEY([doctorUsername])
REFERENCES [dbo].[Login] ([username])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Login]
GO
ALTER TABLE [dbo].[HasAppointment]  WITH CHECK ADD  CONSTRAINT [FK_HasAppointment_Doctor] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Doctor] ([doctorID])
GO
ALTER TABLE [dbo].[HasAppointment] CHECK CONSTRAINT [FK_HasAppointment_Doctor]
GO
ALTER TABLE [dbo].[HasAppointment]  WITH CHECK ADD  CONSTRAINT [FK_HasAppointment_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[HasAppointment] CHECK CONSTRAINT [FK_HasAppointment_Patient]
GO
ALTER TABLE [dbo].[LabTestResult]  WITH CHECK ADD  CONSTRAINT [FK_LabTestResult_LabTestList] FOREIGN KEY([testID])
REFERENCES [dbo].[LabTestList] ([testID])
GO
ALTER TABLE [dbo].[LabTestResult] CHECK CONSTRAINT [FK_LabTestResult_LabTestList]
GO
ALTER TABLE [dbo].[LabTestResult]  WITH CHECK ADD  CONSTRAINT [FK_LabTestResult_PatientVisit] FOREIGN KEY([visitID])
REFERENCES [dbo].[PatientVisit] ([visitID])
GO
ALTER TABLE [dbo].[LabTestResult] CHECK CONSTRAINT [FK_LabTestResult_PatientVisit]
GO
ALTER TABLE [dbo].[Nurse]  WITH CHECK ADD  CONSTRAINT [FK_Nurse_Address] FOREIGN KEY([addressID])
REFERENCES [dbo].[Address] ([addressID])
GO
ALTER TABLE [dbo].[Nurse] CHECK CONSTRAINT [FK_Nurse_Address]
GO
ALTER TABLE [dbo].[Nurse]  WITH CHECK ADD  CONSTRAINT [FK_Nurse_Login] FOREIGN KEY([nurseUsername])
REFERENCES [dbo].[Login] ([username])
GO
ALTER TABLE [dbo].[Nurse] CHECK CONSTRAINT [FK_Nurse_Login]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Address] FOREIGN KEY([addressID])
REFERENCES [dbo].[Address] ([addressID])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Address]
GO
ALTER TABLE [dbo].[PatientVisit]  WITH CHECK ADD  CONSTRAINT [FK_PatientVisit_HasAppointment] FOREIGN KEY([appoitnementID])
REFERENCES [dbo].[HasAppointment] ([appointmentID])
GO
ALTER TABLE [dbo].[PatientVisit] CHECK CONSTRAINT [FK_PatientVisit_HasAppointment]
GO
ALTER TABLE [dbo].[PatientVisit]  WITH CHECK ADD  CONSTRAINT [FK_PatientVisit_Nurse] FOREIGN KEY([nurseID])
REFERENCES [dbo].[Nurse] ([nurseID])
GO
ALTER TABLE [dbo].[PatientVisit] CHECK CONSTRAINT [FK_PatientVisit_Nurse]
GO
ALTER TABLE [dbo].[Specialities]  WITH CHECK ADD  CONSTRAINT [FK_Specialities_Doctor] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Doctor] ([doctorID])
GO
ALTER TABLE [dbo].[Specialities] CHECK CONSTRAINT [FK_Specialities_Doctor]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Username must be presnet in login and will appear as forkeign key in administrator' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Administrator', @level2type=N'CONSTRAINT',@level2name=N'FK_Administrator_Login'
GO
USE [master]
GO
ALTER DATABASE [clinic] SET  READ_WRITE 
GO
