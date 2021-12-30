 -- select * from drmadwill.prodact;
-- select Name from drmadwill.prodact
 
 -- select * from drmadwill.prodact limit 1
-- select * from drmadwill.prodact order by Price asc limit 1

-- select * from drmadwill.prodact order by Price desc limit 1
-- select count(Id) as Count from drmadwill.prodact 
-- select avg(Price) as Ortalama from drmadwill.prodact
-- select name , concat(left(name,3),'....') as 'a bit of Head' from drmadwill.prodact
select Price ,concat('...',right(name,3)) as 'A bit of Last' from drmadwill.prodact
 
 