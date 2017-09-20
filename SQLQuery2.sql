CREATE PROC uspCreateStudentTable
AS
CREATE TABLE Students
(
StudentId INT IDENTITY (50000000, 1) NOT NULL PRIMARY KEY,
StudentFirstName NVARCHAR (50)  NULL,
StudentSurname NVARCHAR (50)  NULL,
StudentEmail NVARCHAR (50)  NULL,
StudentPhone NVARCHAR (50)  NULL,
StudentAddress1 NVARCHAR (50)  NULL,
StudentAddress2 NVARCHAR (50)  NULL,
StudentCity NVARCHAR (50)  NULL,
StudentCounty NVARCHAR (50)  NULL,
StudentLevel NVARCHAR (50)  NULL,
StudentCourse NVARCHAR (MAX) NULL,
)
GO

CREATE PROCEDURE uspGetStudents
AS
SELECT * FROM Student
GO

CREATE PROC uspStaffLoginTable
AS
CREATE TABLE StaffLogin
(
StaffId INT IDENTITY (4000, 1) NOT NULL PRIMARY KEY,
StaffUserName NVARCHAR (50)  NULL,
StaffPassword NVARCHAR (MAX) NULL,
StaffFullName NVARCHAR (50)  NULL,
)
GO
CREATE PROC uspStaffLoginTable
AS

CREATE TABLE StaffLogin
(
StaffId INT IDENTITY (4000, 1) NOT NULL PRIMARY KEY,
StaffUserName NVARCHAR (50)  NULL,
StaffPassword NVARCHAR (MAX) NULL,
StaffFullName NVARCHAR (50)  NULL,
)
GO

INSERT INTO StaffLogin
(StaffUserName, StaffPassword, StaffFullName)
VALUES
('Admin', 'Admin', 'Admin'),
('MikeW', '1234', 'Michael Walsh')
GO

INSERT INTO Student
(StudentFirstName,StudentSurname,StudentEmail,StudentPhone,
StudentAddress1,StudentAddress2,StudentCity,StudentCounty,StudentLevel,StudentCourse)
VALUES
('Mary', 'ODea', '1234Test@gmail.com','061123456','1234Test','1234Road','Limerick','Limerick','Under Grad', 'Arts')
GO