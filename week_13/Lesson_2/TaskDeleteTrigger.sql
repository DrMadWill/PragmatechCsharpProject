create trigger trgAfterDeletetUser on
dbo.[User] 
for Delete
as
declare @User_Id int;
select @User_Id = u.Id from deleted u

Delete Register.dbo.CoyUser where UserId = @User_Id
Print(' After Delete Trigger')
go



Delete [User] where Id= 8
Delete Register.dbo.CoyUser where UserId = 10
select * from [User]
select * from Register.dbo.CoyUser