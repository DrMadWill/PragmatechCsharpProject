## Trigger
> Tableların bir-birindən xəbəri olmasını sağlayır.
### Create
```sql
create trigger trgAfterInsertEmploye on 
[table_name_insert]-- Hansi tablela insert gedendə digrərinədə insert gedəcək
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
```