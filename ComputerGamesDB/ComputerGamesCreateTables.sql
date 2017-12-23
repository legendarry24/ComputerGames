USE ComputerGamesDB
GO

CREATE TABLE Developer
(
	ID INT IDENTITY PRIMARY KEY CLUSTERED,
	Name		   VARCHAR(35) NOT NULL,
	OfficialSite   VARCHAR(50) NOT NULL,
	FoundationYear DATE,
	Country		   NVARCHAR(20) NOT NULL,
	City		   NVARCHAR(20) NOT NULL,
	[State]		   NVARCHAR(20)
)
GO
-- new CK__Developer__Year
ALTER TABLE dbo.Developer
ADD CHECK (FoundationYear > '19470101' AND FoundationYear < GETDATE())
GO

CREATE TABLE Publisher
(
	ID INT IDENTITY PRIMARY KEY CLUSTERED,
	Name		   VARCHAR(35) NOT NULL,
	OfficialSite   VARCHAR(50) NOT NULL,
	FoundationYear DATE,
	Country		   NVARCHAR(20) NOT NULL,
	City		   NVARCHAR(20) NOT NULL,
	[State]		   NVARCHAR(20)
)
GO
-- new CK__Publisher__Year
ALTER TABLE dbo.Publisher
ADD CHECK (FoundationYear > '19470101' AND FoundationYear < GETDATE())
GO

CREATE TABLE Game
(
	ID INT IDENTITY PRIMARY KEY CLUSTERED,
	Name		  VARCHAR(35) NOT NULL,
	ReleaseDate   DATE NOT NULL,
	Rating		  TINYINT NOT NULL CHECK (Rating <= 100),
	Price		  SmallMoney,
	Multiplayer   BIT NOT NULL DEFAULT 0,
	Cybersport    BIT NOT NULL DEFAULT 0,
	Multiplatform BIT NOT NULL DEFAULT 0,
	DeveloperID   INT NOT NULL FOREIGN KEY REFERENCES Developer(ID)
	 ON DELETE CASCADE ON UPDATE CASCADE,
	PublisherID   INT NOT NULL FOREIGN KEY REFERENCES Publisher(ID)
	 ON DELETE CASCADE ON UPDATE CASCADE,
	GenreID		  INT NOT NULL,
	StylisticsID  INT NOT NULL
)
GO

ALTER TABLE dbo.Game
ALTER COLUMN GenreID INT 

ALTER TABLE dbo.Game
ALTER COLUMN StylisticsID INT 
-- new CK__Game__ReleaseDate
ALTER TABLE dbo.Game
ADD CHECK (ReleaseDate > '19470101' AND ReleaseDate < GETDATE())
GO

ALTER TABLE dbo.Game
ADD CHECK ([Price] > 0)
GO

CREATE TABLE Genre
(
	ID INT IDENTITY PRIMARY KEY CLUSTERED,
	Name		NVARCHAR(30) NOT NULL,
	Description NVARCHAR(MAX) NOT NULL
)
GO

CREATE TABLE Stylistics
(
	ID INT IDENTITY PRIMARY KEY CLUSTERED,
	Name		NVARCHAR(20) NOT NULL,
	Description NVARCHAR(MAX) NOT NULL
)
GO

ALTER TABLE Game
ADD CONSTRAINT FK_game_genre FOREIGN KEY (GenreID) REFERENCES Genre(ID)
	ON DELETE SET NULL ON UPDATE CASCADE
GO
ALTER TABLE Game
ADD CONSTRAINT FK_game_stylistics FOREIGN KEY (StylisticsID) REFERENCES Stylistics(ID)
	ON DELETE SET NULL ON UPDATE CASCADE
GO

CREATE TABLE [Platform]
(
	ID INT IDENTITY PRIMARY KEY CLUSTERED,
	[Type] NVARCHAR(20) NOT NULL
)
GO

CREATE TABLE SupportedPlatform
(
	ID INT IDENTITY PRIMARY KEY CLUSTERED,
	GameID INT NOT NULL FOREIGN KEY REFERENCES Game(ID)
	 ON DELETE CASCADE ON UPDATE CASCADE,
	PlatformID INT NOT NULL FOREIGN KEY REFERENCES [Platform](ID)
	 ON DELETE CASCADE ON UPDATE CASCADE,
	QualityOfSupport NVARCHAR(20) NOT NULL
	 CHECK (QualityOfSupport IN ('�������', '���������', '������')),
	MinCPUFrequency FLOAT,
	MinRAM			TINYINT,
	HardDiskStorage FLOAT NOT NULL,
	MinOC			VARCHAR(20)
)
GO
-- new
ALTER TABLE SupportedPlatform
ALTER COLUMN QualityOfSupport NVARCHAR(9) NOT NULL

ALTER TABLE SupportedPlatform
ALTER COLUMN MinRAM FLOAT
GO

ALTER TABLE [dbo].[Platform]
ADD CONSTRAINT UNIQ_Platform_Type UNIQUE([Type])
GO

ALTER TABLE [dbo].[Publisher]
ADD CONSTRAINT UNIQ_Publisher_Name UNIQUE(Name)
GO

ALTER TABLE [dbo].[Publisher]
ADD CONSTRAINT UNIQ_Publisher_Site UNIQUE([OfficialSite])
GO

ALTER TABLE [dbo].[Developer]
ADD CONSTRAINT UNIQ_Developer_Name UNIQUE(Name)
GO

ALTER TABLE [dbo].[Developer]
ADD CONSTRAINT UNIQ_Developer_Site UNIQUE([OfficialSite])
GO

ALTER TABLE [dbo].[Game]
ADD CONSTRAINT UNIQ_Game_Name UNIQUE(Name)
GO

ALTER TABLE [dbo].[Genre]
ADD CONSTRAINT UNIQ_Genre_Name UNIQUE(Name)
GO

ALTER TABLE [dbo].[Stylistics]
ADD CONSTRAINT UNIQ_Stylistics_Name UNIQUE(Name)
GO
-- Views
ALTER VIEW [GameRequirements]
AS 
SELECT g.[Name] ����, p.[Type] ���������, sp.[MinOC] [���������� ��������� ��],
	   [MinCPUFrequency] [MinCPUFrequency, ���], [MinRAM] [MinRAM, ��], 
	   [HardDiskStorage] [HardDiskStorage, ��]
FROM [Game] g
JOIN [SupportedPlatform] sp 	ON sp.GameID = g.ID
JOIN [Platform] p				ON sp.PlatformID = p.ID
GO

ALTER VIEW SearchGame
AS
	SELECT g.Name ����, d.Name �����������, pub.Name ��������, g.ReleaseDate [���� �������], 
	gen.Name ����, s.Name ����������, g.Rating �������, [Price] ����,
	[Multiplayer] [������� ������������], [Cybersport] ���������������
	FROM Game g
	JOIN [Developer] d			ON d.ID		 = g.DeveloperID
	JOIN [Publisher] pub		ON pub.ID    = g.PublisherID
	LEFT JOIN [Genre] gen		ON gen.ID	 = g.GenreID
	LEFT JOIN [Stylistics] s	ON s.ID		 = g.StylisticsID 
	
GO
-- Procedures
ALTER PROC FindGame
	@Name		varchar (35) = '%', -- �������� �� ���������
	@Developer  varchar (35) = '%', 
	@Publisher  varchar (35) = '%',
	@Genre	    nvarchar(30) = '%',
	@Stylistics nvarchar(20) = '%'
AS
	SELECT @Name	   = RTRIM(@Name)		+ '%'; 
	SELECT @Developer  = RTRIM(@Developer)  + '%';
	SELECT @Publisher  = RTRIM(@Publisher)  + '%';
	SELECT @Genre	   = RTRIM(@Genre)		+ '%';
	SELECT @Stylistics = RTRIM(@Stylistics) + '%';

	SELECT g.Name ����, d.Name �����������, pub.Name ��������, g.ReleaseDate [���� �������], 
	gen.Name ����, s.Name ����������, g.Rating �������, [Price] ����,
	[Multiplayer] [������� ������������], [Cybersport] ���������������
	FROM [Game] g
	JOIN [Developer] d			ON d.ID		 = g.DeveloperID  AND d.[Name]   LIKE @Developer
	JOIN [Publisher] pub		ON pub.ID    = g.PublisherID  AND pub.[Name] LIKE @Publisher
	JOIN [Genre] gen			ON gen.ID	 = g.GenreID	  AND gen.[Name] LIKE @Genre
	JOIN [Stylistics] s			ON s.ID		 = g.StylisticsID AND s.[Name]   LIKE @Stylistics
	WHERE g.[Name] LIKE @Name
GO

ALTER PROC SearchGameByPlatform 
	@PlatformName nvarchar(25) = '%',  
	@GameName	  varchar(35)  = '%'
AS
	SELECT @PlatformName = RTRIM(@PlatformName)	+ '%'; 
	SELECT @GameName	 = RTRIM(@GameName)		+ '%';

	SELECT g.Name ����, p.[Type] ���������, sp.QualityOfSupport [�������� ������������]
	FROM [Game] g
	JOIN [SupportedPlatform] sp ON sp.GameID = g.ID
	JOIN [Platform] p			ON p.ID	 = sp.PlatformID AND p.[Type] LIKE @PlatformName
	WHERE g.[Name] LIKE @GameName
GO

ALTER PROC ADDGame
	@Name varchar(35),
	@ReleaseDate date,
	@Rating tinyint,
	@Price smallmoney,
	@Multiplayer bit,
	@Cybersport bit,
	@Multiplatform bit,
	@DevName varchar(35),
	@PubName varchar(35),
	@GenreName nvarchar(30) = NULL,
	@StylisticsName nvarchar(20) = NULL
AS
	INSERT [Game] 
	VALUES (@Name, @ReleaseDate, @Rating, @Price, @Multiplayer, @Cybersport, @Multiplatform,
		    [dbo].[GetDevID](@DevName), [dbo].[GetPubID](@PubName),
			[dbo].[GetGenID](@GenreName), [dbo].[GetStID](@StylisticsName))
GO

CREATE PROC UpdateGame
	@CurrentName varchar(35),
	@Name varchar(35),
	@ReleaseDate date,
	@Rating tinyint,
	@Price smallmoney,
	@Multiplayer bit,
	@Cybersport bit,
	@Multiplatform bit,
	@DevName varchar(35),
	@PubName varchar(35),
	@GenreName nvarchar(30) = NULL,
	@StylisticsName nvarchar(20) = NULL
AS
	UPDATE [Game] 
	SET [Name] = @Name, [ReleaseDate] = @ReleaseDate, [Rating] = @Rating, [Price] = @Price,
	[Multiplayer] =  @Multiplayer, [Cybersport] = @Cybersport, [Multiplatform] = @Multiplatform,
	[DeveloperID] = [dbo].[GetDevID](@DevName), [PublisherID] = [dbo].[GetPubID](@PubName),
	[GenreID] =	[dbo].[GetGenID](@GenreName), [StylisticsID] = [dbo].[GetStID](@StylisticsName)
	WHERE [Name] = @CurrentName
GO

CREATE PROC ADDDeveloper
	@Name varchar(35),
	@OfficialSite varchar(50),
	@FoundationYear date,
	@Country nvarchar(20),
	@City nvarchar(20),
	@State nvarchar(20) = NULL
AS
	INSERT [Developer]
	VALUES (@Name, @OfficialSite, @FoundationYear, @Country, @City, @State)
GO

CREATE PROC UpdateDeveloper
	@CurrentName varchar(35),
	@Name varchar(35),
	@OfficialSite varchar(50),
	@FoundationYear date,
	@Country nvarchar(20),
	@City nvarchar(20),
	@State nvarchar(20) = NULL
AS
	UPDATE [Developer]
	SET [Name] = @Name, [OfficialSite] = @OfficialSite, [FoundationYear] = @FoundationYear,
	[Country] = @Country, [City] = @City, [State] = @State
	WHERE [Name] = @CurrentName
GO

CREATE PROC ADDPublisher
	@Name varchar(35),
	@OfficialSite varchar(50),
	@FoundationYear date,
	@Country nvarchar(20),
	@City nvarchar(20),
	@State nvarchar(20) = NULL
AS
	INSERT [Publisher]
	VALUES (@Name, @OfficialSite, @FoundationYear, @Country, @City, @State)
GO

CREATE PROC UpdatePublisher
	@CurrentName varchar(35),
	@Name varchar(35),
	@OfficialSite varchar(50),
	@FoundationYear date,
	@Country nvarchar(20),
	@City nvarchar(20),
	@State nvarchar(20) = NULL
AS
	UPDATE [Publisher]
	SET [Name] = @Name, [OfficialSite] = @OfficialSite, [FoundationYear] = @FoundationYear,
	[Country] = @Country, [City] = @City, [State] = @State
	WHERE [Name] = @CurrentName
GO

CREATE PROC ADDGenre
	@Name nvarchar(30),
	@Description nvarchar(max)
AS
	INSERT [Genre]
	VALUES (@Name, @Description)
GO

CREATE PROC UpdateGenre
	@CurrentName nvarchar(30),
	@Name nvarchar(30),
	@Description nvarchar(max)
AS
	UPDATE [Genre]
	SET [Name] = @Name, [Description] = @Description
	WHERE [Name] = @CurrentName
GO

CREATE PROC ADDStylistics
	@Name nvarchar(20),
	@Description nvarchar(max)
AS
	INSERT [Stylistics]
	VALUES (@Name, @Description)
GO

CREATE PROC UpdateStylistics
	@CurrentName nvarchar(20),
	@Name nvarchar(20),
	@Description nvarchar(max)
AS
	UPDATE [Stylistics]
	SET [Name] = @Name, [Description] = @Description
	WHERE [Name] = @CurrentName
GO

ALTER PROC DeleteLastDev
	@Name varchar(35) = NULL
AS
IF @Name IS NULL
	DELETE Developer
	WHERE ID = (SELECT MAX(ID) FROM Developer)
ELSE
	DELETE Developer WHERE [Name] = @Name 
GO

ALTER PROC DeleteLastPub
	@Name varchar(35) = NULL
AS
IF @Name IS NULL
	DELETE Publisher
	WHERE ID = (SELECT MAX(ID) FROM Publisher)
ELSE
	DELETE Publisher WHERE [Name] = @Name 
GO

ALTER PROC DeleteLastGame
	@Name varchar(35) = NULL
AS
IF @Name IS NULL
	DELETE Game
	WHERE ID = (SELECT MAX(ID) FROM Game)
ELSE
	DELETE Game WHERE [Name] = @Name 
GO

ALTER PROC DeleteLastGenre
	@Name nvarchar(30) = NULL
AS
IF @Name IS NULL
	DELETE Genre
	WHERE ID = (SELECT MAX(ID) FROM Genre)
ELSE
	DELETE Genre WHERE [Name] = @Name 
GO

ALTER PROC DeleteLastStylistics
	@Name nvarchar(20) = NULL	
AS
IF @Name IS NULL
	DELETE Stylistics
	WHERE ID = (SELECT MAX(ID) FROM Stylistics)
ELSE
	DELETE Stylistics WHERE [Name] = @Name 
GO

-- Functions
CREATE FUNCTION GetDevID (@Name VARCHAR(35))
RETURNS INT
AS
BEGIN
	RETURN
	(
		SELECT ID FROM Developer WHERE [Name] = @Name
	)
END
GO

CREATE FUNCTION GetPubID (@Name VARCHAR(35))
RETURNS INT
AS
BEGIN
	RETURN
	(
		SELECT ID FROM Publisher WHERE [Name] = @Name
	)
END
GO

CREATE FUNCTION GetGenID (@Name NVARCHAR(30))
RETURNS INT
AS
BEGIN
	RETURN
	(
		SELECT ID FROM Genre WHERE [Name] = @Name
	)
END
GO

CREATE FUNCTION GetStID (@Name NVARCHAR(20))
RETURNS INT
AS
BEGIN
	RETURN
	(
		SELECT ID FROM Stylistics WHERE [Name] = @Name
	)
END
GO

CREATE FUNCTION GetGameID (@Name VARCHAR(35))
RETURNS INT
AS
BEGIN
	RETURN
	(
		SELECT ID FROM Game WHERE [Name] = @Name
	)
END
GO

CREATE FUNCTION GetPlID (@Name NVARCHAR(20))
RETURNS INT
AS
BEGIN
	RETURN
	(
		SELECT ID FROM [Platform] WHERE [Type] = @Name
	)
END
GO

-- Triggers
CREATE TRIGGER trDenyDeletePlatform
ON [Platform]
INSTEAD OF DELETE
AS
-- ����� �� ��������, ���� �� ����� ������� �� �����������
	IF @@ROWCOUNT = 0 
		RETURN
-- ������������ SELECT 1 ������ SELECT * ��� ���������� ������������������, �.�. ������������ ������
-- �� ������������; ����� ��� ���� �������� (true ��� false).
	IF EXISTS (SELECT 1 FROM [Platform] p
			   JOIN deleted d ON p.ID = d.ID
			   WHERE p.ID <= 3)
		RAISERROR('������� �������� ������ ���������!', 10, 1)
	ELSE
		DELETE [Platform] WHERE ID IN (SELECT ID FROM deleted)
GO

CREATE TRIGGER trDenyDeleteDeveloper
ON [dbo].[Developer]
INSTEAD OF DELETE
AS
-- ����� �� ��������, ���� �� ����� ������� �� �����������
	IF @@ROWCOUNT = 0 
		RETURN
-- ��������� ����� ��������� � ���-�� ������������ �������, ��� ������������ ������ �� ������������������
	SET NOCOUNT ON
-- ������������ SELECT 1 ������ SELECT * ��� ���������� ������������������, �.�. ������������ ������
-- �� ������������; ����� ��� ���� �������� (true ��� false).
	IF EXISTS (SELECT 1 FROM [Developer] dev
			   JOIN deleted d ON dev.ID = d.ID
			   WHERE dev.ID <= 12)
		RAISERROR('������� �������� ������ ���������!', 10, 1)
	ELSE
		DELETE [Developer] WHERE ID IN (SELECT ID FROM deleted)
GO

CREATE TRIGGER trDenyDeletePublisher
ON [dbo].[Publisher]
INSTEAD OF DELETE
AS
-- ����� �� ��������, ���� �� ����� ������� �� �����������
	IF @@ROWCOUNT = 0 
		RETURN
-- ��������� ����� ��������� � ���-�� ������������ �������, ��� ������������ ������ �� ������������������
	SET NOCOUNT ON
-- ������������ SELECT 1 ������ SELECT * ��� ���������� ������������������, �.�. ������������ ������
-- �� ������������; ����� ��� ���� �������� (true ��� false).
	IF EXISTS (SELECT 1 FROM [Publisher] p
			   JOIN deleted d ON p.ID = d.ID
			   WHERE p.ID <= 11)
		RAISERROR('������� �������� ������ ���������!', 10, 1)
	ELSE
		DELETE [Publisher] WHERE ID IN (SELECT ID FROM deleted)
GO

ALTER TRIGGER trDenyDeleteGenre
ON [dbo].[Genre]
INSTEAD OF DELETE
AS
-- ����� �� ��������, ���� �� ����� ������� �� �����������
	IF @@ROWCOUNT = 0 
		RETURN
-- ��������� ����� ��������� � ���-�� ������������ �������, ��� ������������ ������ �� ������������������
	SET NOCOUNT ON
-- ������������ SELECT 1 ������ SELECT * ��� ���������� ������������������, �.�. ������������ ������
-- �� ������������; ����� ��� ���� �������� (true ��� false).
	IF EXISTS (SELECT 1 FROM [Genre] g
			   JOIN deleted d ON g.ID = d.ID
			   WHERE g.ID <= 8)
		RAISERROR('������� �������� ������ ���������!', 10, 1)
	ELSE
		DELETE [Genre] WHERE ID IN (SELECT ID FROM deleted)
GO

CREATE TRIGGER trDenyDeleteStylistics
ON [dbo].[Stylistics]
INSTEAD OF DELETE
AS
-- ����� �� ��������, ���� �� ����� ������� �� �����������
	IF @@ROWCOUNT = 0 
		RETURN
-- ��������� ����� ��������� � ���-�� ������������ �������, ��� ������������ ������ �� ������������������
	SET NOCOUNT ON
-- ������������ SELECT 1 ������ SELECT * ��� ���������� ������������������, �.�. ������������ ������
-- �� ������������; ����� ��� ���� �������� (true ��� false).
	IF EXISTS (SELECT 1 FROM [Stylistics] s
			   JOIN deleted d ON s.ID = d.ID
			   WHERE s.ID <= 6)
		RAISERROR('������� �������� ������ ���������!', 10, 1)
	ELSE
		DELETE [Stylistics] WHERE ID IN (SELECT ID FROM deleted)
GO

ALTER PROC spGameCount
	@ID int = null OUTPUT -- ��� ���������� ��������� �������� ������������ �������� ����� OUTPUT
AS
IF @ID IS NULL
BEGIN
	SET @ID =(SELECT Count(*) From Game);
END
ELSE SELECT Name FROM Game WHERE ID = @ID
GO

DECLARE @MyID int;
EXEC spGameCount @MyID OUTPUT; -- ��� ������ �������� ���������� �������� ����� OUTPUT ������ �������������� ��� �� ��� � ��� ����������, �������� �������� ��� ������������� �������� ������� ����������
PRINT CAST (@MyID as varchar);
GO

DECLARE @MyID int;
SET @MyID = 4;
-- ����� � �������� IN ���������
EXEC spGameCount @MyID;