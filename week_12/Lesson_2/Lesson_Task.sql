

--create database Academy

--create Table Groups(
--Id int primary key identity(1,1),
--[Name] nvarchar(170) unique not null
--)

--Create table Students(
--Id int primary key identity(1,1),
--[Name] nvarchar(170) not null,
--[SureName] nvarchar(200) not null,
--GroupId int not null,
--foreign key(GroupId) REFERENCES Groups(Id)
--)


--alter table Students add  Grade int

--Insert into Groups(Name)values('P221'),('P124'),('P221')



--Insert into Groups(Name)values('P221'),('P124')

--Insert into Students(Name,SureName,GroupId,Grade)values('Miyuki','Sirogane',5,10)





--select * from Groups
--select * from Students where GroupId=5

select COUNT(*) 'Say' from Students where GroupId=5

select COUNT(*) 'Say' from Students where GroupId=4

select Groups.Name,Count(GroupId)'Count' from Students
join Groups
on Students.GroupId=Groups.Id
group by Groups.Name

--Create view FullStudentList
--as
--select Students.Name ,Students.SureName,Groups.Name 'Group',Students.Grade
--from Students
--Join Groups on Students.GroupId=Groups.Id

select * from FullStudentList

create Procedure ShowStudent
@Grade int
as
select * from FullStudentList where Grade>@Grade 

execute ShowStudent 10
