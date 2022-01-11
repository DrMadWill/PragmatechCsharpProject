

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
[Employee]
for insert
as 
declare @emp_Id int;
declare @emp_name nvarchar(60);
declare @emp_salary decimal(10,2);
declare @addedDate datetime;
select @emp_Id=y.Id from inserted y
select @emp_name=y.Name from inserted y
select @emp_salary=y.Emp_Salary from inserted y

insert into HrContactData(EmpId,Name,Emp_Salary,AddDateTime)
values(@emp_Id,@emp_name,@emp_salary,@addedDate)

Print('-- After Insert Trigger')
go


insert into Employee(Name,Emp_Salary)values('Salahedin',1500)




