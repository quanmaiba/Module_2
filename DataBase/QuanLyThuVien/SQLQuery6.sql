CREATE TABLE AnhQuan
(
	Ma INT IDENTITY,
	ten NVARCHAR(40)
)
EXEC sp_addtype '@Name','nvarchar(40)','NOT NULL' ;
GO	
CREATE PROC Sp_quan
@i INT , @j INT 
AS
BEGIN 
	WHILE(@i < @j)
		BEGIN
		INSERT dbo.AnhQuan
		        (  ten )
		VALUES  ( 
		          CONCAT(N'mai bá quân ' , @i)  -- ten - nvarchar(40)
		          )
			SET @i+=1 
		END 
END 
GO	

EXEC sp_quan @i = 1 , @j = 10;
GO	

SELECT * FROM dbo.AnhQuan
