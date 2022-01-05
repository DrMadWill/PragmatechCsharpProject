## Access Modifiers
- Class daxildəki məlumatlarin xaricdən accessibility nəzarət etmək üçün istfadə edilir.
    - _public_ bu keyword işlənən fild istənən yerdən accessible olmasını sağlayır.
    - _private_ işlən fild yalnız Class daxildə accessibledır.
    - _protected_ işlən fild yalnız o Class və ondan törəyən Classlar daxildə accessibledır.
    - _internal_ yazılan Class yalnız həmin program daxildə işlənir.


## Interface
- Classlara yol gostərmək üçün isfadə edilir.
    - Body su olmur.
    - Implemente edilen methodlar Puclic olaraq işlədilir.
    - Decler edilərəkən _public_ keydən isfadə edilmir. Zatən publicdir deyə.
    - Interface bir birlərindən törəyə bilir ancaq Class və Stuctdan yox.
    - Törənən Classlarda mütələq Implemente edilməlidir.


## Iterface new Fuction(C#8)
- Body add.
- Access modifaers add.
- _static_ keyden istifade.
- override add.
## Solid
- Single Responsibility Class ve daxilde yardilan method ve propertiler o Clasin uardilma meqsedine uyğun olmadlıdır.
- Open/Closed yazilan methodun mükün qədər əsas fuksiyasını təyin edərək  gələcək dəşikliklərə acıq olamsını sağlyır
- Liskov Substitution Bases Classda verilən methodlar tam istfadə edilməsi.
- Interface Segregation Öz fiksiyaları olan iterfeysler istfadə etməliyik.