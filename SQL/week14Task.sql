Create database Week14Task
Use  Week14Task
Go

Create Table [Users](
UserId int Primary Key IDENTITY,
Username nvarchar(30) not null,
[Password] nvarchar(30) not null unique,
RegistrationDate datetime default GETDATE())

Create Table DocumentLevel(
DocumentLevelId int Primary Key IDENTITY,
[Name] nvarchar(50) not null,
UserId int,
[Order] int not null unique,
Constraint FK_DocumentLevel_User Foreign Key (UserId) References Users(UserId)
)
Create Table Document(
DocumentId int Primary Key IDENTITY,
Title nvarchar(50) not null ,
[Description] nvarchar(255) not null,
CreateById int,
RecordedDate datetime default GetDate(),
DocumentLevelId int,
CONSTRAINT FK_Document_DocumentLevelId Foreign Key (DocumentLevelId) References DocumentLevel(DocumentLevelId),
CONSTRAINT FK_Document_User FOREIGN KEY (CreateById ) REFERENCES Users(UserId)
)

Create Table [File](
FileId int Primary Key IDENTITY,
[FileName] nvarchar(50) not null,
FileUrl nvarchar(50) not null unique,
DocumentId int,
CONSTRAINT FK_File_Document FOREIGN KEY (DocumentId) REFERENCES Document(DocumentId)
)




Create Table [Status](
StatusId tinyint Primary Key IDENTITY,
[Name] nvarchar(30) not null
)

Create Table AprowOrRequest(
AprowOrRequestID int Primary Key IDENTITY,
CreateById int,
UpdateById int,
StatusId tinyint,
DocumentId int,
DocumentLevelId int,
CONSTRAINT FK_AprowOrRequest_Status Foreign Key (StatusId) References [Status](StatusId),
CONSTRAINT FK_AprowOrRequest_Document Foreign Key (DocumentId) References  Document(DocumentId),
CONSTRAINT FK_AprowOrRequest_DocumentLevel Foreign Key (DocumentLevelId) References  DocumentLevel(DocumentLevelId),
CONSTRAINT FK_AprowOrRequest_Users_Crd Foreign Key (CreateById) References Users(UserId),
CONSTRAINT FK_AprowOrRequest_Users_Upd Foreign Key (UpdateById) References Users(UserId)
)

Create Table DocumentComment(
CommentId int Primary Key IDENTITY,
Comment nvarchar(50),
CreateById int,
DocumentId int,
CONSTRAINT FK_DocumentComment_Users Foreign Key (CreateById) References Users(UserId),
CONSTRAINT FK_DocumentComment_Document Foreign Key (DocumentId) References  Document(DocumentId),
)

