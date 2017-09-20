CREATE TRIGGER trgAfterInsert ON [dbo].[Student]
AFTER INSERT
AS
declare @fn int;
declare @sn NVARCHAR (50);
declare @em NVARCHAR (50);
declare @ph NVARCHAR (50);
declare @ad1 NVARCHAR (50);
declare @ad2 NVARCHAR (50);
declare @cy NVARCHAR (50);
declare @ct NVARCHAR (50);
declare @lv NVARCHAR (50);
declare @co NVARCHAR (50);
declare @aa NVARCHAR (50);

select @id=i.StudentId from inserted i;
select @fn=i.StudentFirstName from inserted i;
select @sn=i.StudentSurname from inserted i;
select @em=i.StudentEmail from inserted i;
select @ph=i.StudentPhone from inserted i;
select @ad1=i.StudentAddress1 from inserted i;
select @ad2=i.StudentAddress2 from inserted i;
select @cy=i.StudentCity from inserted i;
select @ct=i.StudentCounty from inserted i;
select @lv=i.StudentLevel from inserted i;
select @co=i.StudentCourse from inserted i;
set @aa='Record Inserted';
INSERT INTO Student_Audit
(StudentId,StudentFirstName,StudentSurname, StudentEmail, StudentPhone,StudentAddress1, StudentAddress2,StudentCity,StudentCounty,StudentLevel, StudentCourse, AuditAction, AuditDate )
VALUES
(@id,@fn,@sn,@em,@ph,@ad1,@ad2,@cy,@ct,@lv,@co,@aa,getdate());

PRINT 'AFTER INSERT TRIGGER FIRED.'
GO
