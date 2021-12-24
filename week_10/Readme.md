
## Async and Await
> Məlumatlar ardıcıl icrası zamanı `return` type olan methodlar bir cavab gözlədiyi üçün həmin methodun icrası bitənə qədər növbəti method gözlədilir. Nəticə etibarı ilə bizim böyük problemiz olur bunu qaşısını almaq üçün  **asinxron sistem**-dən istifadə edilir. Nədir bu asinxron ? Yəni method bir nəticə gözləyirsə və ya methodun arxada icra olunacaq uzun funksiyası varsa və s.  kimi hallara baxmayaraq bütün methodlar gəlib icra tələblərni göndərir sonra hansı methodun icrası başa çatıbsa həmin method nəticəni götürüb aralaşır.
- Fail oxumaq üçün StreamRead classında istifadə edilir və bu `using`  içərisində yazılır.

## Reflection
> Bu `class` sayəsində biz **Assembly** daxilindəki bütün class, method və s. kimi bütün məlumatları əldə edə bilərik. Əsasən bizə array qaytarır.
> - Reflection vastəsi ilə yalnız `get`i olan propertiyə `set` etmək imkanı tanıyır.
> - Privet olan fildi set etmək olur və Reflectionda axtarış zamanı fild görsənir.


##  Garbage Collection
> İstifadə edilməyən referanceləri silərək komputerə düşən yükü azaldır. Necə ?
> kod  **CLR** da işə düşdükdə onun üçün **managed heap** adında yer açılır. Əgər yardılan obyektlər istifadə edilmirsə həmin obyekti silərək növbəti obyekt üçün yer açır. 3 layerdən ibarətdir.
-  **Generation 0(Gen0)** ilk yarılan obyektlər burada tutulur. Əgər bura dolarsa və yaradılan obyektər arsinda işləyən varsa növbəti _Generation_-a (Gen1) keçirilir.İşləməyən silinir.
-  **Generation 1(Gen1)** Gen0-dan  bura düşən obyektər artiq programda istifadəsi ən azı bir dəfə olur və əgər bura dolarsa bura düşən obyektlər arasindan işləyən obyektləri növbəti _Generation_-a (Gen2) keçirilir işləməyən silinir.
- **Generation 2(Gen2)** Gen2-dan  bura düşən obyektər artiq programda istifadəsi  daimidir məsələn static və s. Əgər bura dolarsa o vaxt error atacaq OutOfRange Yaddaşın dolması ilə bağlı.