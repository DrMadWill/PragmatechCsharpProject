# OOP => Object Oriented Programming -> Obyek yonlu praglamlasdirma

### Lesson 

 - Əsas xususiyyəti bir sinifə ait olan xususiyyətıəri başqa siniflərdə istifadə edilməsidir;

 - OOP 3 əsas prinsipi var
    - Inheritance
    - Encapsulation
    - Polymorphism

#### Inheritance
- A Class-ı B Classından inheritans alan zaman:
    - A Class _Base Class_
    - B Class _Drived Class_ kimi teyin edilir; 

- Multiple Inheritance mukun deyil bir neçə Classdan bir Class torəyə bilməz;
- Drived Classindan yardilan zaman biz Base Classinda yaradilan methodlara və fildlərə əl çata bilirik;

- Base Class yardilacak Classlarin əsas xususiyyətini özündə toplayir;
- Base Classini obyektinin yardılması düzgün deyil;
- Base Classindan obyekt yardıl masinin qarsinin alinmasi üçün _abstract_ KeyWord dən istifadə edilir;
- Base Class-ında teyin edilen Constractor prametrirə sahibdirsə Drived Classlarda Constractor yardılaraq hemin parametrləri _base_ keywordü sahəsində Base Classs-ın Canstractoruna göndərilməsi mütləqdir;
- _Sealed_ Keyword istfadə edilərək yardılan Class daxildə:
    - abstract Method ve Virtual Method işlədilə bilmir.
    - həmin Class  Base Class ola bilmir (Yəni Inheritance verə bilmir);
