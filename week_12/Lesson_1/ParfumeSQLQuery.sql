--Drop Database Parfumshop
--Drop table Parfum
--Drop table Brend
--Drop table Gender
--Drop table Density

--create database Parfumshop


--Create table Brend(
--Id int primary key identity(1,1),
--[Name] nvarchar(170) not null,
--Descrition ntext default('This is ideal Brend')
--)


--Create table Gender(
--Id int primary key identity(1,1),
--[Name] nvarchar(10) not null,
--)

--Create table Density(
--Id int primary key identity(1,1),
--[Name] nvarchar(50) not null,
--)


--Create table Parfum(
--Id int primary key identity(1,1),
--[Name] nvarchar(170) not null,
--[Image] varchar(250) default('a.jpg'),
--Descrition ntext default('This is ideal Parfum'),
--BrendID int not null,
--Foreign key (BrendID) REFERENCES Brend(Id),
--GenderId int not null,
--Foreign key (GenderId) REFERENCES Gender(Id),
--DensityId int not null,
--Foreign key (DensityId) REFERENCES Density(Id),
--News bit not null
--)

--Insert into dbo.Brend(Name)values('MOLECULE'),('KİLİAN'),('INİTİO'),('DAVİDOFF'),('CHLOE')
--select * from dbo.Brend

--create PROCEDURE InsertBrend
--@Name varchar(60)
--as
--Insert into dbo.Brend(Name)values(@Name)

--EXECUTE InsertBrend 'Christian Dior'

--create PROCEDURE DeleteBrend
--@Id int
--as
--delete dbo.Brend where Id = @Id

--EXECUTE DeleteBrend 6


--create PROCEDURE UpdateBrend
--@Id int,
--@Name nvarchar(170),
--@Descrition ntext
--as
--Update dbo.Brend set Name=@Name,Descrition=@Descrition where Id = @Id

--EXECUTE UpdateBrend 5,'Chole','A Greate Breand'

--select * from dbo.Brend

--Insert into dbo.Gender(Name)values('Qadın'),('Kişi'),('Unisex')

--select * from dbo.Gender

--Insert into dbo.Density(Name)values('Eau De Parfum'),('Eau De Toilette'),('Extrait de Parfum')
--select * from dbo.Density


--Insert into dbo.Parfum(Name,BrendID,GenderId,DensityId,News) values('Christian Dior
--Miss Dior 2021',7,1,1,1)

--create PROCEDURE InsertParfum
--@Name nvarchar(170),
--@Image varchar(250),
--@Descrition ntext,
--@BrendID int,
--@GenderId int ,
--@DensityId int ,
--@News bit 
--as
--Insert into dbo.Parfum(Name,Image,Descrition,BrendID,GenderId,DensityId,News) values(@Name,@Image,@Descrition,@BrendID,@GenderId,@DensityId,@News)

--EXECUTE InsertParfum 'Mondio','b.png','Great Parfum',2,3,1,1

--create PROCEDURE UpdateParfum
--@Id int,
--@Name nvarchar(170),
--@Image varchar(250),
--@Descrition ntext,
--@BrendID int,
--@GenderId int ,
--@DensityId int ,
--@News bit 
--as
--Update dbo.Parfum set Name =@Name,Image=@Image,Descrition=@Descrition,BrendID=@BrendID,GenderId=@GenderId,DensityId=@DensityId,News=News where Id=@Id

--EXECUTE UpdateParfum 4,'Miss Dior 2021','b.png','Great Parfum',2,1,1,1

--create PROCEDURE DeleteParfum
--@Id int
--as
--Delete dbo.Parfum where Id=@Id

--EXECUTE DeleteParfum 5

--select * from dbo.Brend
--select * from dbo.Gender
--select * from dbo.Density
-- select * from dbo.Parfum

--create view MiniDetailsParfume
--as
--select Parfum.Id 'I4',Parfum.Name 'Name',Brend.Name 'Brend ',Gender.Name 'Gender',Density.Name 'Densty'
--from dbo.Parfum
--Join Brend on Parfum.BrendID=Brend.Id
--Join Gender on Parfum.GenderId=Gender.Id
--Join Density on Parfum.DensityId=Density.Id

--select * from MiniDetailsParfume


---------------------------

--create table SizeML(
--Id int primary key identity(1,1),
--Size int unique not null)

--create PROCEDURE InsertSizeML
--@Size int
--as
--Insert into dbo.SizeML(Size)values(@Size)

--EXECUTE InsertSizeML 30
--EXECUTE InsertSizeML 50
--EXECUTE InsertSizeML 60
--EXECUTE InsertSizeML 75
  

--create PROCEDURE DeleteSizeML
--@Size int
--as
--Delete dbo.SizeML where Size=@Size 

--EXECUTE DeleteSizeML 60
 
--select * from dbo.SizeML 

--create table SealsPrice(
--Id int primary key identity(1,1),
--SizeMLId int not null,
--Foreign key(SizeMLId) REFERENCES  SizeML(Id),
--Price int 
--)

--create PROCEDURE InsertSealsPrice
--@SizeMLId int,
--@Price int 
--as
--Insert into dbo.SealsPrice(SizeMLId,Price)values(@SizeMLId,@Price)

--EXECUTE InsertSealsPrice 1,567
--EXECUTE InsertSealsPrice 2,67
--EXECUTE InsertSealsPrice 4,125
--EXECUTE InsertSealsPrice 1,25
--select * from dbo.SealsPrice

--create PROCEDURE UpdateSealsPrice
--@Id int ,
--@SizeMLId int,
--@Price int 
--as
--Update dbo.SealsPrice set SizeMLId = @SizeMLId,Price=@Price where ID=@Id 
--EXECUTE UpdateSealsPrice 1,1,30


--create PROCEDURE DEleteSealsPrice
--@Id int  
--as
--Delete dbo.SealsPrice where ID=@Id 
--EXECUTE DEleteSealsPrice 6

--select * from dbo.SealsPrice


--Create table ParfumeToPrice(
--Id int primary key identity(1,1),
--SealsPriceId int not null,
--Foreign key(SealsPriceId) REFERENCES SealsPrice(Id),
--ParfumId int not null,
--Foreign key(ParfumId) REFERENCES Parfum(Id)
--)

--Create PROCEDURE InsertParfumeToPrice
--@SealsPriceId int ,
--@ParfumId int 
--as
--Insert into dbo.ParfumeToPrice(SealsPriceId,ParfumId)values(@SealsPriceId,@ParfumId)

--EXECUTE InsertParfumeToPrice 1,4
--EXECUTE InsertParfumeToPrice 3,4



--select * from dbo.ParfumeToPrice


--Create PROCEDURE UpdateParfumeToPrice
--@Id int,
--@SealsPriceId int ,
--@ParfumId int 
--as
--Update dbo.ParfumeToPrice set SealsPriceId=@SealsPriceId,ParfumId=@ParfumId where Id=@Id

--Create PROCEDURE DeleteParfumeToPrice
--@Id int
--as
--Delete dbo.ParfumeToPrice  where Id=@Id
--EXECUTE DeleteParfumeToPrice 6



--create view MidDeatalParfum
--as
--select Parfum.Id 'Id',Parfum.Name 'Name',Brend.Name 'Brend ',Gender.Name 'Gender',Density.Name 'Densty',SealsPrice.Price 'Price',SizeML.Size
--from ParfumeToPrice
--Join Parfum on ParfumeToPrice.ParfumId=Parfum.Id
--Join Brend on Parfum.BrendID=Brend.Id
--Join Gender on Parfum.GenderId=Gender.Id
--Join Density on Parfum.DensityId=Density.Id
--Join SealsPrice on ParfumeToPrice.SealsPriceId=SealsPrice.Id
--Join SizeML on SealsPrice.SizeMLId = SizeML.Id

--select * from dbo.ParfumeToPrice
--select * from dbo.MidDeatalParfum

--create table Catogory(
--Id int primary key identity(1,1),
--Name nvarchar(250) not null
--)

--create PROCEDURE InsertCatogory
--@Name nvarchar(250)
--as
--Insert into dbo.Catogory(Name)values(@Name)

--EXECUTE InsertCatogory 'Qadin'
--EXECUTE InsertCatogory 'Kişi'
--EXECUTE InsertCatogory 'Yeni'


--create PROCEDURE UpdateCatogory
--@Id int,
--@Name nvarchar(250)
--as
--Update dbo.Catogory set Name = @Name where Id = @Id

--create PROCEDURE DeleteCatogory
--@Id int
--as
--Delete dbo.Catogory where Id = @Id



--create table CatogoryToParfumSeals(
--Id int primary key identity(1,1),
--CatogoryId int not null,
--Foreign key(CatogoryId) REFERENCES Catogory(Id),
--ParfumeToPriceId int not null,
--Foreign key(ParfumeToPriceId) REFERENCES ParfumeToPrice(Id)
--)


--create PROCEDURE InsertCatogoryToParfumSeals
--@CatogoryId int,
--@ParfumeToPriceId int 
--as
--Insert into dbo.CatogoryToParfumSeals(CatogoryId,ParfumeToPriceId)values(@CatogoryId,@ParfumeToPriceId)

--EXECUTE InsertCatogoryToParfumSeals 3,2

--select * from MidDeatalParfum 

--select * from ParfumeToPrice
--select * from Catogory
--select * from CatogoryToParfumSeals

--create PROCEDURE UpdateCatogoryToParfumSeals
--@Id int,
--@CatogoryId int,
--@ParfumeToPriceId int 
--as
--Update dbo.CatogoryToParfumSeals set CatogoryId=@CatogoryId,ParfumeToPriceId=@ParfumeToPriceId where Id=@Id



--create PROCEDURE DeleteCatogoryToParfumSeals
--@Id int,
--@CatogoryId int,
--@ParfumeToPriceId int 
--as
--Delete dbo.CatogoryToParfumSeals where Id=@Id





--select Parfum.Id 'Id',Parfum.Name 'Name',Brend.Name 'Brend ',Catogory.Name 'Catogory'
--from CatogoryToParfumSeals
--Join ParfumeToPrice on CatogoryToParfumSeals.ParfumeToPriceId=ParfumeToPrice.Id
--Join Parfum on ParfumeToPrice.ParfumId=Parfum.Id
--Join Brend on Parfum.BrendID=Brend.Id
--Join Density on Parfum.DensityId=Density.Id
--Join SealsPrice on ParfumeToPrice.SealsPriceId=SealsPrice.Id
--Join SizeML on SealsPrice.SizeMLId = SizeML.Id
--Join Catogory on CatogoryToParfumSeals.CatogoryId = Catogory.Id


