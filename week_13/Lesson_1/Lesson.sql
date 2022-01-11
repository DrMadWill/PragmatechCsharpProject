

create  table Employee(
Id int primary key identity(1,1),
[Name] nvarchar(60) not null,
Emp_Salary decimal(10,2)
)

create table HrContactData(
EmpId int,
[Name] nvarchar(60),
Emp_Salary decimal(10,2),
AddDateTime datetime default(getdate())
)

create trigger trgAfterInsertEmploye on 




