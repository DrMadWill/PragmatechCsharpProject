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


## Ado.net
> Databese ilə bağlantı qurmaq üçün istifadə edilirir.
> İki növ girişi var 
> - Connected
> - Disconnected


### Connected
> Database qoşulduqdan sonra ona uyğun məlumatları ötrə və ala bilirik ta ki biz əlqəni kəsənə kimi.

- `using System.Data.SqlClient` namespace-i sqlə qoşulmaq və crud əmliyyatları üçün istifadə edirik.
- `ConnectionString` database-in yerini göstəmək üçün app config file-na yazılır.
    1. `Data Source` və ya `Server` serverin adını və ya ip ünvanını qeyd edirik.
    2. `Initial Catalog` və ya `Database` data bazanin adı.
    3. `Integrated Security`-Windows Authentication istifadə edərək sqlə bağlanır.

- `Open()` Method ilə bağlantı qurulur.
- `Close()` Əlaqə kəsilir.

**SqlCommand** - sqldə yazılan kodları burda icrasını tələb edirik.
Nəticə almaq üçün :
1. `ExecuteNonQuery`- geriyə int qaytarır, bu komandanı insert,update,delete-də stifadə edə bilərsiz.
2. `ExecuteReader`- Datanı oxuyur.Select-də istifadə edirik.
3. `ExecuteScalar`- 1 row 1 column qaytarır, bunu skalyar ifadələrdə istifadə edə bilərik məs: select count(*)


