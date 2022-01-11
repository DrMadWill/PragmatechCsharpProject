--create database Register


create trigger trgAfterInsertUser on
dbo.[User] 
for insert
as
declare @User_Id int;
declare @User_Name nvarchar(60);
declare @User_UserName nvarchar(40);
declare @User_Tel int;
declare @User_Region nvarchar(70);
declare @User_JobId int;
select @User_Id = u.Id from inserted u
select @User_Name = u.Name from inserted u
select @User_UserName = u.UserName from inserted u
select @User_Tel = u.Tel from inserted u
select @User_Region = u.Region from inserted u
select @User_JobId = u.JobId from inserted u

Insert into Register.dbo.CoyUser(UserId,Name,UserName,Tel,Region,JobId)
values(@User_Id,@User_Name,@User_UserName,@User_Tel,@User_Region,@User_JobId)

Print(' After Insert Trigger')
go

Insert into Register.dbo.[User](Name,UserName,Tel,Region,JobId)values('Ahmed','Ahmed00',555554,'Balaken',2)



create view FullInfoUser
as
select [User].Id,[User].Name,[User].UserName,[User].Region,[User].Tel,Job.Name 'Job'
from [User]
Join Job on [User].JobId=Job.Id

create procedure usp_SearchJobId 
@Name nvarchar(60),
@UserName nvarchar(40),
@Tel int,
@Region nvarchar(70),
@Job nvarchar(40)
as
Insert into Register.dbo.[User](Name,UserName,Tel,Region,JobId) 
values(@Name,@UserName,@Tel,@Region,(select y.Id from dbo.Job y where y.Name=@Job))


