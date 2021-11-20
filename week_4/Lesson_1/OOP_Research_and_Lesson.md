# OOP => Object Oriented Programming -> Obyek yonlu praglamlasdirma

## Lesson 
***
 - Əsas xususiyyəti bir sinifə ait olan xususiyyətıəri başqa siniflərdə istifadə edilməsidir;

 - OOP 3 əsas prinsipi var
    - Inheritance
    - Encapsulation
    - Polymorphism

### Inheritance
- A Class-ı B Classından inheritans alan zaman:
    - A Class _Base Class_
    - B Class _Drived Class_ kimi teyin edilir; 

- Multiple Inheritance mukun deyil bir neçə Classdan bir Class torəyə bilməz;
- Drived Classindan yardilan zaman biz Base Classinda yaradilan methodlara və fildlərə əl çata bilirik;

- Base Class yardilacak Classlarin əsas xususiyyətini özündə toplayir;
- Base Classini obyektinin yardılması düzgün deyil;
- Base Classindan obyekt yardıl masinin qarsinin alinmasi üçün _abstract_ KeyWord dən istifadə edilir;
- _abstract_ keywordlü Methodun xususiyyətləri:
    - Base Classda təyin edilir;
    - Body-si olmur;
    - Drived Classda mütləq təyin olunmalidir;
    - Drived Classda _teyin edilən zaman_(initialized) _override_  keyworddən istfadə edlir;
- Base Class-ında teyin edilen Constractor prametrirə sahibdirsə Drived Classlarda Constractor yardılaraq hemin parametrləri _base_ keywordü sahəsində Base Classs-ın Canstractoruna göndərilməsi mütləqdir;
- _Sealed_ Keyword istfadə edilərək yardılan Class daxildə:
    - abstract Method ve Virtual Method işlədilə bilmir.
    - həmin Class  Base Class ola bilmir (Yəni Inheritance verə bilmir);

### Encapsulation  
> Encapsulation əsas xususiyyət bir Class daxildəki hər hansi fildi və ya property digər Classlardan qorumasıdır.Bunu üçün _set_ və _get_ methodundan istfadə edirik.
- _set_ İnformasiyani yoxlayib yazdırmaq üçündür;
- _get_ İnformasiyanı oxumaq üçündür;
- propertydə  tək _get_ methodundan istfifadə edərə bilərik. Ancaq tək _set_ methodundan xeyir.

### Polymorphism
- Eyni adli methodu Static və Dynamic Polymorphism istfadə edərək müxtəlif cür istfadə etmək;
    - Static Polymorphism aiddir Method Overloading;
    - Dynamic Polymorphism aiddir Virtual and Override Keyword;

#### Virtual and Override Keyword

- Base Class-da _virtual_ keyword-ü vastəsi ilə təyin edilmiş Methodlar Drived Classlarda _override_ keyword-ü sahəsində body-si yenidən təyin edlə bilər.Xususiyyətlər:
    - Body-si olmaldir;
    - Drived Classda təyin edildiyi zaman Base Classda təyin edilmiş bütün fildlər burda sifirlanır;
    - _virtual_ keyword-ü təyin edilmiş bir Method Drived Classlarda dəyişdirlməsi mütləq deyildir;