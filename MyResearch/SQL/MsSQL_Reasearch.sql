--select Salary as Qiymeti from dbo.Costomers 
--select Name as Adi from dbo.Costomers 

--select * from dbo.Costomers where Salary > 2000
--select Name as Ad from dbo.Costomers where Salary>2000 and Salary<4000 
--select * from dbo.Costomers where Name = 'Haru' 

--select * from dbo.Costomers where Salary > 1000 and Salary < 4000

--select Salary from dbo.Costomers 

--select * from dbo.Costomers where Salary Between 1000 and 4000
--select * from dbo.Costomers where Id Between 1 and 3


--select * from dbo.Costomers where Salary in(6000)

--select * from dbo.Costomers where Salary Not in(600)

----select * from dbo.Costomers where Name like '%Har%'

--select * from dbo.Costomers order by Salary

--select * from dbo.Costomers

--Delete from dbo.Costomers where Id>77
--select * from dbo.Costomers

--select * from dbo.Costomers order by Name 

--select * from dbo.Costomers order by Salary ASC
--select * from dbo.Costomers order by Salary DESC

--select MIN(Salary) from dbo.Costomers where Id <3 

--select MAX(Salary) from dbo.Costomers where Id > 10

--select SUM(Salary) as [Sum] from dbo.Costomers 
--select top 1 * from dbo.Costomers order by Salary 

--select top 1 * from dbo.Costomers order by Salary DESC

--select top 1 * from dbo.Costomers order by Salary DESC
--select AVG(Salary) as [Ortalama Maas] from dbo.Costomers 

--select LEN('Hello world') as [Count Letter]
--select Name , LEN(Name) as [Count Letter] from dbo.Costomers 

--select name , LEFT(Name,3) + '...' as Basliq from dbo.Costomers

--select SureName ,'...' + RIGHT(SureName,3) as [A bit of Last] from dbo.Costomers


select 
