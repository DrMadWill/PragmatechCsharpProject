# My Documantation

### Variable
***
> Variable qab və ya çərçivə olaraq düşünülə bilər. Bu qab özü kifayyət qədər açıqlaycı olamlıdır ki biz ona baxan zaman tuta biləcəyi dəyəri anlayaq. Məsələn `int` bu qaba baxaraq deyə bilər ki daxilində tutduğu dəyər rəqəmlərdən ibarətdir və dəyərin tuta biləcəyi genişlik 32 bitdir. Aşağıda **C#** olan _variable_-ları sadalaycam.
- **Textual**
    - **char**
    - **string**
- **Number**
    - **int**
    - **byte**
    - **long**
    - **sbyte**
- **Bool**
- **Object**
- **Var** Program Compiler olunan zaman qərar verilir.
- **DateTime** Tarix və zamanı göstərmək üçündür.


### Type Convert
***
> **C#**-da tipdən tipə çevrilmələr əsasən `Convert` `class`-ı və methodları vastəsi ilə həyata keçirilir.
> Təbii ki eyni tipdən olan `sbyte`,`byte`,`int` və `long` kim dəyərlər arasında çevrilmə edən zaman **Casting** hadisəsi baş verir.  
- **Up Casting** özündən _böyük_ , 
- **Down Casting** özündən _kiçik_  genişliyi olan dəyərə yuvarlamadan söhbət gedir.
> Mətin tipli dəyərlərin çevrilməsi zamanı  `Parse` methodundan istifadə edilə bilər.

###  String
***
> value olaraq `char` **array**ında ibaraətdir ancaq bu **array daxili dəyişməzdir**. [Linkdə verdiyim məsələ](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/MyResearch/1_Foundation/1_4_String/1_4_String/Program.cs#L22)dəki kimi `string`lərin yadaşda tutacağı yer son `resault`un tutacağı dəyər qədər deyildir hər toplamada `result`da alınan dəyər yaşada yer tutur. Bunu qaşısını alamq üçün `StringBuilder`-[dən istifadə edilməlidir.](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/MyResearch/1_Foundation/1_4_String/1_4_String/Program.cs#L29)
#### Variable-ları String ifadə də birləşdirmək
- Toplama methodu ilə  
- `string.Format()` methodundan istifadə edərək `string` dəyəri _variable_-lardan alaraq **index** uyğun yaza bilrərik daha çox time və rəqsal məlumatları göstərmək üçün istifadə edilir.
- [**Template String**](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/MyResearch/1_Foundation/1_4_String/1_4_String/Program.cs#L16) `$""`
#### String [Method](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/MyResearch/1_Foundation/1_4_String/1_4_String/Program.cs#L39)
- `Length` propertidir.İçərisinidə olan `char`-ın miqdarını göstərir.
- `ToLower()` methodu ilə `string` daxilindəki bütün hərifləri kiçik həriflərə çevirir.
- `ToUpper()` methodu ilə `string` daxilindəki bütün hərifləri böyük həriflərə çevirir.
- `Trim()` methodu ilə başdakı və sondakı boşluqları kəsə bilirik.`TrimStart()` başdakı `TrimEnd()` sondakı boşluğu silər.
- `Split()` methodu ilə methodun içərisinə yazılan dəyəri `string` dəyərin içərsində tatpıb oradan öcəni və sonra **kəsir** və **array** içərisinə atır döndürür.
- `StartsWith()` methodu ilə methodun daxilinə yazılan dəyər ilə `string` dəyərin başlayib başlamnadığını yoxlayır `bool` tipində dəyər döndürür.
- `EndsWith()` `string` sonu ilə methoda yazılan dəyərin bərəbərliyi.`bool` tipində dəyər döndürür.
- `Contains()` daxilinə yazılan ifadənin `string`in içərisində olub olmadadığını yoxlayır. `bool` tipində dəyər döndürür.
- `IndexOf()` daxilinə yazılan ifadənin `string`in içərisində yerini tapır. `int` tipində dəyər döndürür.
- `Substring()` daxilinə yazılan **index** etibarən sona qədər və ya **index** sonra **nə qədər** gedəcəyni yaza bilərik və o bizə həmin aralıqda ifadəni tapıb çıxarır.
- `Replace()` daxilinə yazılan ilk dəyəri `string` tapıb son yazılan dəyər ilə dəyişdirir.
- `Insert()`  daxilinə yazılan **index** sonra əlavə ediləcək `string`i yazırılır və o bizə **index** qabağına ələva edəcəmiyiz dəyəri yazıdır.
- `Remove()` daxilinə yazılan **index** etibarən sona qədər və ya **index** sonra **nə qədər** gedəcəyni yaza bilərik və o bizə **index** dən sonrasını silir.

### [Array](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/MyResearch/1_Foundation/1_5_Array/1_5_Array/Program.cs#L11)
***
> Yaddaşda arard arda yer alan koleksiyaya `array` deyilir.
> **Əvvəlcəndən Təyin edilmiş Bir genişliyi və tipi var**.
> Təyin edilməyən indexslərin yerinə uyğun olaraq ya `null` ya 0.
> `string[] text_list = { "Domation", "of", "Road", "Mad", "Will" };`
- yuxaridaki kimi kod blokumuz oldğunu düşünəlim.
    - Sonunc ifadəni almaq üçün `text_list[^text_list.Length]`  
    - a(int) və b(int)  aralıqda `array` üçün `text_list[a..b]`
    - a(int) sona kimi `array` üçün `text_list[a..]`
    - Əvvələdən b(int) kimi `array` üçün `text_list[..b]`kimi bir ifadədən istifadə edə bilərirk. 


### Loop
***
> Dövür üçün `for`,`while`,`foreach` və `do while` kimi dövürlərdən istifadə edilir.
- [`for`](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/MyResearch/1_Foundation/1_8_Loop/1_8_Loop/Program.cs#L11) döngü sayının müəyyən olundauqda istifadə edilir.`for` döngüsün başlığın sonuncu elementini yəni hər döngündə aratan `i++` yazılamasa sonsuz döngüyə düşür.
- `while` döngüsü döngü sayının müəyyən olmadıqda istifadə edilir.
- `do while` döngüsü ən az bir dəfə icra olunur.
- kod `continue` yazılan sətrə gəldikdə həmin döngünü başa vurur növbəti döngüyə keçir.
- kod `break` yazılan sətrə gəldikdə ondan sonraki bütün döngüləri sonlandırır.
