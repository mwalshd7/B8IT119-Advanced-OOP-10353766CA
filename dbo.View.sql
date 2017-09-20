EXEC uspGetStudents @StudentCity='Cork'

ALTER PROCEDURE uspGetStudents
@StudentCity nvarchar(50)
AS
SELECT * FROM Student WHERE StudentCity=@StudentCity
