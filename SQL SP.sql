
Create Procedure dbo.GetAllUsers
AS
Select*from dbo.USERS

GO

Create Procedure dbo.GetAllChats
AS
Select*from dbo.CHATS

GO

Create Procedure dbo.GetAllMessages
AS
Select*from dbo.[MESSAGES]

go

Create Procedure dbo.GetAllChatparts
AS
Select*from dbo.CHATPARTS

GO

Create Procedure dbo.GetAllBusinessMeetings
AS
Select*from dbo.BUSINESSMEETINGS

GO

CREATE PROCEDURE dbo.AddUser	@ID int, @password varchar(20), @joinDate DateTime,	@firstName varchar(20),
								@lastName varchar(20), @birthday date,	@serialID int, 
								@email varchar(40), @role varchar(50), @profilePicture varchar(500)
AS
INSERT INTO dbo.USERS
Values (@ID, @password, @joinDate, @firstName, @lastName, @birthday, @serialID, @email, @role, @profilePicture)

GO 

CREATE PROCEDURE dbo.AddChat	@ID int, @name varchar(30), @openingDT DateTime, @description varchar(200), @manager int
AS
INSERT INTO dbo.CHATS
Values (@ID, @name, @openingDT, @description, @manager)

GO

CREATE PROCEDURE dbo.UpdateChat @ID int, @name varchar(30), @openingDT DateTime, @description varchar(200), @manager int
AS
Update dbo.CHATS
SET
[name] = @name,
openingDT = @openingDT,
[description] = @description,
manager = @manager
WHERE chatID = @id

GO

CREATE PROCEDURE dbo.deleteChat @id int
AS
Delete from  dbo.CHATS
WHERE chatID=@id



