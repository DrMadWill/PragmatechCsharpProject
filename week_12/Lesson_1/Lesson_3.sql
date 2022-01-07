 create view CostomertsDetal as
 select dbo.Costomers.Name as 'Name', dbo.Costomers.SureName as 'Sura Name', POSITIONS.Name as 'Positions',dbo.Costomers.Salary as 'Salary'
 from dbo.Costomers
 JOIN POSITIONS on Costomers.POSITIONID=POSITIONS.Id

select * from CostomertsDetal

create PROCEDURE us_Psoitio
@Name varchar(60)
as
select * from dbo.CostomertsDetal where Positions=@Name

EXECUTE dbo.us_Psoitio 'Mangaka'



