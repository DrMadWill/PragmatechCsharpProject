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