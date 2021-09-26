Create database Week14Task
Use  Week14Task
Go

Create Table [Users](
Id int Primary Key IDENTITY,
Username nvarchar(30) not null,
[Password] nvarchar(30) not null unique,
RegistrationDate datetime default GETDATE())

Create Table DocumentLevel(
Id int Primary Key IDENTITY,
[Name] nvarchar(50) not null,
UserId int,
[Order] int not null unique,
Constraint FK_DocumentLevel_User Foreign Key (UserId) References Users(Id)
)
Create Table Document(
Id int Primary Key IDENTITY,
Title nvarchar(50) not null ,
[Description] nvarchar(255) not null,
CreateById int,
RecordedDate datetime default GetDate(),
DocumentLevelId int,
CONSTRAINT FK_Document_DocumentLevelId Foreign Key (DocumentLevelId) References DocumentLevel(Id),
CONSTRAINT FK_Document_User FOREIGN KEY (CreateById ) REFERENCES Users(Id)
)

Create Table [File](
Id int Primary Key IDENTITY,
[FileName] nvarchar(50) not null,
FileUrl nvarchar(50) not null unique,
DocumentId int,
CONSTRAINT FK_File_Document FOREIGN KEY (DocumentId) REFERENCES Document(Id)
)




Create Table [Status](
Id tinyint Primary Key IDENTITY,
[Name] nvarchar(30) not null
)

Create Table AprowOrRequest(
Id int Primary Key IDENTITY,
CreateById int,
UpdateById int,
StatusId tinyint,
DocumentId int,
DocumentLevelId int,
CONSTRAINT FK_AprowOrRequest_Status Foreign Key (StatusId) References [Status](Id),
CONSTRAINT FK_AprowOrRequest_Document Foreign Key (DocumentId) References  Document(Id),
CONSTRAINT FK_AprowOrRequest_DocumentLevel Foreign Key (DocumentLevelId) References  DocumentLevel(Id),
CONSTRAINT FK_AprowOrRequest_Users_Crd Foreign Key (CreateById) References Users(Id),
CONSTRAINT FK_AprowOrRequest_Users_Upd Foreign Key (UpdateById) References Users(Id)
)

Create Table DocumentComment(
Id int Primary Key IDENTITY,
Comment nvarchar(50),
CreateById int,
DocumentId int,
CONSTRAINT FK_DocumentComment_Users Foreign Key (CreateById) References Users(Id),
CONSTRAINT FK_DocumentComment_Document Foreign Key (DocumentId) References  Document(Id),
)


/*
Techizat:

1 Create Document 
- Document yaradilarken uygun sutunlara data insert edilmeli, file elave edilibse file cedveline insertde 
aparilmalidir. DocLevelId doc create edilerken verilir (order-i 1 olan level)
evvelceden yaradilan docLeveller orderlere uygun nomrelenmeli ve user cedveline bir nece ferqli ad soyad username passa sahib
userler elave edilmelidir. elave edilen userler ozude Her biri bir levele mesul sexs olaraq teyin edilecek.


GetAllDocument proc yaradilmalidir, Sened Yaradilarken hansi user createbyId olaraq elave edilibse 
sadece onun senedleri gosterilir

WaitingDocument Proc yaradilmalidir Senedin hazirki levelinde mesul user kimdirse sadece ona uygun senedler getirilir.


qeyd : Sql week 14 icersinde screenshotlara nezer yetirin orada cedvellerde hansi datalar gosterilmelidir suutunlara baxin.

1.a Userlerin insert edilmesi
    CreateById yeni bu emeliyyati hansi user yerine yetiribse onun idsini menimsedmek ucun istifade edilir.
    Buna gorede evvelceden cedvele insert edilen userleri dinamik sekilde hansi cedvelde creatBy varsa ora assign ede bilmelisiz,
    GetCurrentUser func yaradaraq username ve passworda uygun eger dbda varsa onun idsin geri donderib istifade ede bilersiz createBylar ucun
1.b Doc levellerin insert edilmesi
  - doclevelelleri getiren view yaradilmalidir.
  - doclevelId
  - Name
  - UserId
  - Username
  1.b.a Doc level ucun mesul userin update edilmesi 
    verilen username esasen dbdan user tapilir ve yeni responseUseridye assign edilir.
1.c Document Get By Id proc
1.d Document Comment Create proc 
1.e GetAllDocumentCommentByDocId proc 
    Username
    Comment
    Date
1.f CreateDocumentApprovalRequest proc 
    User documenti ya approve edir ya reject edir,
    her iki emeliyyatdada idye gore document tapilir, documentin hazirki docLevelIdsine gore current Level tapilir
    approve olarsa current levelin order + 1 yeni next level tapilir,
    reject olarse current levelin order - 1 yen prev levele tapilir - eger current level ozu ele 1 deyilse 

    tapilan evvelki ve ya novbeti levelId docLevelId-ye menimsedilir doc update olur 
    her bir halda DocApprovalRequest  ve DocHistory cedveline insert emeliyyati apariliacaq. 
1.g GetAllHistoryByDocId proc 


Umumi insert , delete , update emeliyyatlarindan sonra trigger islemeli ve elave edilen , redakte edilen ve ya silinen setr gosterilmelidir.
*/






--1 Create Document 
--- Document yaradilarken uygun sutunlara data insert edilmeli, file elave edilibse file cedveline insertde 
--aparilmalidir. DocLevelId doc create edilerken verilir (order-i 1 olan level)
--evvelceden yaradilan docLeveller orderlere uygun nomrelenmeli ve user cedveline bir nece ferqli ad soyad username passa sahib
--userler elave edilmelidir. elave edilen userler ozude Her biri bir levele mesul sexs olaraq teyin edilecek.




-- Document cedvelinə datalarin əlavə edilməsi ucun Store Prosedurun Yaradilmasi
-- document yerinə qisa olaraq doc yazmişam
Create proc Create_Document(
@doc_title nvarchar(50),
@doc_desc nvarchar(50), 
@createbyid int,
@doc_levelid nvarchar(50)
)
as
begin
Insert Into Document(Title,[Description],CreateById,DocumentLevelId) values (@doc_title,@doc_desc,@createbyid,@doc_levelid)
end

-- Create_Document Store Prosedurunun cagrilmasi

exec Create_Document 
@doc_title='JavaScript ',
@doc_desc='JavaScript (/ˈdʒɑːvəˌskrɪpt/),[9] often abbreviated as JS, is a programming language that conforms to the ECMAScript specification',
@createbyid=2,
@doc_levelid=3

Select * From DocumentLevel
Select * From Users 
Select * From Document
--Users cedvelinə datalarin əlavə edilməsi ucun Store Prosedurun Yaradilmasi

Create proc Create_Users(
@username nvarchar(50),
@password nvarchar(50), 
@firstname nvarchar(50),
@lasrname nvarchar(50)
)
as
begin
Insert Into Users(Username,[Password],FirstName,LastName) values (@username,@password,@firstname,@lasrname)
end

--Create_Users Store Prosedurunun cagrilmasi

exec Create_Users
@username='sergey_brin',
@password='sergey12345+',
@firstname='Sergey',
@lasrname='Brin'




--DocumentLevelId cedvelinə datalarin əlavə edilməsi ucun Store Prosedurun Yaradilmasi

Create proc Insert_DocumentLevelId(
@doc_level_name nvarchar(50),
@fk_user_id tinyint,
@order tinyint
)
as
begin
Insert Into DocumentLevel([Name],UserId,[Order]) values (@doc_level_name,@fk_user_id,@order)
end

--Insert_DocumentLevelId Store Prosedurunun cagrilmasi

exec Insert_DocumentLevelId 
@doc_level_name='sixth level',
@fk_user_id=1,
@order=6


--File cedvelinə datalarin əlavə edilməsi ucun Store Prosedurun Yaradilmasi

Create proc Insert_File(
@file_name nvarchar(50),
@file_url nvarchar(50), 
@document_id tinyint
)
as
begin
Insert Into [File]([FileName],FileUrl,DocumentId) values (@file_name,@file_url,@document_id)
end

----Insert_File Store Prosedurunun cagrilmasi

exec Insert_File @file_name='javascript.png',@file_url='C:\Images\javascript.png',@document_id=8




--2.
--GetAllDocument proc yaradilmalidir, Sened Yaradilarken hansi user createbyId olaraq elave edilibse 
--sadece onun senedleri gosterilir

create proc GetAllDocument (@create_by_id tinyint)
as
begin
Select (FirstName+' '+LastName)as UserFullName ,(Title) as DocumentTitle 
From
Document as p inner join Users as u ON  p.CreateById=u.Id Where u.Id=@create_by_id
end

exec GetAllDocument @create_by_id=2



--3.
--WaitingDocument Proc yaradilmalidir Senedin hazirki levelinde mesul user kimdirse sadece ona uygun senedler getirilir.


