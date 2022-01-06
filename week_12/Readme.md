## SQL Veiw
> DataBasesdə əlavə bir table kimi düşünülə bilər. Sadəcə istənilən halda sadə bir ifadə vastəsi ilə bu table cağıra bilirk. Üstünlükləri:
> - Kod qarışıqlığını qarşısını alır.
> - Kod Təkrarının qarşısını alır.
> - Joinlə yazılan böyük sorğularda rahatlıqla yerinə yetiriləsinə imkan yaradır.
> - Insert etmək mükündür.
Yaaradılma şablonu aşağıdakı kimidir:

```sql
CREATE VIEW view_name AS
SELECT column1, column2.....
FROM table_name
WHERE condition;
JOIN  
```
or

```sql
CREATE VIEW view_name AS
SELECT column1, column2.....
FROM table_name
JOIN  ....
JOIN  ....
JOIN  ....
```

Silinmə şablonu belədir:
```sql
DROP VIEW deleteveiw;
```





