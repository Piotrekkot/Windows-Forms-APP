use s13830;

CREATE TABLE Client(
ClientId INT IDENTITY PRIMARY KEY,
Name VARCHAR(50) NOT NULL,
Ename VARCHAR(50) NOT NULL,
AddDate DATETIME NOT NULL,
Email VARCHAR(50) NOT NULL,
ClientStatus Varchar(10) NOT NULL, 
Rabat INT NOT NULL

)
INSERT INTO Client
VALUES
('Adam','Kowalski',22-11-1995,'Kowalski@gmail.com','Zwykly','10'),
('Marcin','Kubica',21-04-1998,'Kubica@wp.pl','Vip','10'),
('Bo¿ydar','Ma³ysz',21-02-2001,'Bozydar@wp.pl','Vip','10')

GO

Drop PROCEDURE AddClient
Go


	
	
	
	
		CREATE PROCEDURE AddClient @ClientId INT, @Name VARCHAR(50)
,@Ename VARCHAR(50),@AddDate DATETIME,@Email VARCHAR(50),@ClientStatus Varchar(10), @Rabat INT
AS

IF @ClientId=0
BEGIN
	
	INSERT INTO Client(Name) VALUES (@Name)
	INSERT INTO Client(Ename) VALUES (@Ename)
	INSERT INTO Client(AddDate) VALUES (@AddDate)
	INSERT INTO Client(Email) VALUES (@Email)
	INSERT INTO Client(ClientStatus) VALUES (@ClientStatus)
	INSERT INTO Client(Rabat) VALUES (@Rabat)
	SELECT @@IDENTITY AS ClientId
	END
	ELSE
BEGIN
	UPDATE Client SET
	Name=@Name
	WHERE ClientId=@ClientId

	UPDATE Client SET
	Ename=@Ename
	WHERE ClientId=@ClientId
	
	UPDATE Client SET
	AddDate=@AddDate
	WHERE ClientId=@ClientId

	UPDATE Client SET
	Email=@Email
	WHERE ClientId=@ClientId

	UPDATE Client SET
	ClientStatus=@ClientStatus
	WHERE ClientId=@ClientId

	UPDATE Client SET
	Rabat = @Rabat
	WHERE ClientId=@ClientId
	
	SELECT ClientId FROM Client
	WHERE ClientId=@ClientId



	END
	

	SELECT ClientId,Name,Ename,ClientStatus,Rabat FROM Client WHERE ClientStatus = 'Vip'