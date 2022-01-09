# SQL  => Structured Query Language
- Progamlaşdırma dilidir.
- CRUD Əməliyatları və İnformasiyalar üzərində bir neçə əm\liyyatlar yazılır.
- 3 Kaigoriyaya bolunur.
	- **DML** => Data Manuplation Language = (İnoramtion) select,insert,update and delete
	- **DDL**=> Data Defition Language  = (Tabel) create ,alert(edit),drop(delete) and rename
	- **DCL**=> Data Control Language = Databesa girişi yoxlayır.

## DataType
***
### String
- `varchar ` String deyer tutur
- `nvarchar` Uniq key(yazi tipii) Strig deyerler tutur.
- .....
### Number
- `Bool` 0 ve 1 arasinda deyer
- `Doble`
- `Decimal`
- ....
### Date and DateTime => Zaman
- Date
- Date Time
- ...
### Some Keywords
***
- `create`  keywordu vastesi ile yaradilir.
- `select` informasiyani axtaran zaman yazilan ilk keyword
- `update` informasiyani update eden zaman basda yazilir.
- `delete` informasiyani silmek ucundur
- `alter tabel` tabeli editlemek ucundur
- `top` ilk basliqdan secmeyimizi icaze verir
- `fetch` müəyyən araliqdan seşmeyimizə icazə verir.
- `offset` müəyyən araliqdan seşmeyimizə icazə verir. 
- `like` codda müəyyən verdiyimiz elemetə oxasralari tapır.
- `Update` ve `Delete` mutleq `where` cadition olmalidir.
- `ordere by` Siralma etmək istədikdə istifadə edilir. Sonuna :
	- `ASC` Artan şəkildə siralar.
	- `DESC` Azalan şəkildə sırlar.
- `Between a and b`  `a` ilə `b` aralığını istədikdə `a` və `b` daxil olaraq gətirir.
- `in(a)`  içərisində olan `a` dəyəri olan bütün datanı gətirir.
- `Not` qeyd edilən element xaricində bütün elemetlər. 
## Constrains (Qadağa)
***
> - `not null` göndərilən dəyərlər boş ola bilməz.
> - `uniq` həmin columnda yalnız bir dəfə işlənə bilər.
> - `primary key`  = uniq + not null bir tableda adətən bir dənə olur.
> - `check` keywordu gonderilen deyerleri yoxlayib sonra menimsede bilerik.
>- `Default`  deyer gonderilmedikde default olaraq qebul edeceyi deyeri gosterir.

### Aggregation func (Umumi func)

> - `Count`  Müəyyən aralıq daki informasiyani göstərir.
> - `Sum`  Müəyyən araliqdaki informasiyani toplayır
> - `Min` En azini gosterir
> - `Max` Maksimumunu göstərir
> - `avg` ortalama deyer

### Relation
> - One to one
> - One to many
> - Many to  Many
**One to one** iki tərəfində əlqəsi uniqdir
**One to many**  bir tərəfin əlqəsi uniqdir digər tərəf azadır.
**Many to  Many**  iki tərəfində əlqəsi azadır.



# Code Shcema

## DataBases
***
### Create
```sql
Create database Acedemy
```

### Delete 
```sql
DROP DATABASE Acedemy
```

## Table
***
### Create

```sql
CREATE TABLE table_name (
    column1 datatype,
    column2 datatype,
    column3 datatype,
   ....
);
```
### Delete 

```sql
DROP TABLE table_name;
```
### Update(Rename)
```sql
ALTER TABLE table_name
RENAME TO new_table_name;
```
## Table Column
***
### Add
```sql
ALTER TABLE table_name
ADD column_name datatype;
```
### Delete
```sql
ALTER TABLE Customers
DROP COLUMN Email;
```

### Update
```sql
ALTER TABLE table_name
ALTER COLUMN column_name datatype;
```


## UNIQUE 
### Add
```sql
ALTER TABLE Persons
ADD UNIQUE (ID);

-- Multiple columns
ALTER TABLE Persons
ADD CONSTRAINT UC_Person UNIQUE (ID,LastName);

```

### Delete 
```sql
ALTER TABLE Persons
DROP CONSTRAINT UC_Person;
```

## FOREIGN KEY
### Add
```sql
ALTER TABLE Orders
ADD FOREIGN KEY (PersonID) REFERENCES Persons(PersonID);

-- Multiple columns

ALTER TABLE Orders
ADD CONSTRAINT FK_PersonOrder
FOREIGN KEY (PersonID) REFERENCES Persons(PersonID);
```

### Delete
```sql
ALTER TABLE Orders
DROP CONSTRAINT FK_PersonOrder;
```

## Information 
### Add
```sql
INSERT INTO Customers (CustomerName, ContactName, Address, City, PostalCode, Country)
VALUES ('Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway');
```
### Delete
```sql
DELETE FROM table_name WHERE condition;
```
### Update
```sql
UPDATE table_name
SET column_name=value
WHERE condition;
```
## Join
```sql
SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate
FROM Orders
JOIN Customers ON Orders.CustomerId=Customers.Id;
```


## ViEW
```sql
CREATE VIEW view_name AS
SELECT column1, column2, ...
FROM table_name
WHERE condition;

SELECT * FROM view_name
```

