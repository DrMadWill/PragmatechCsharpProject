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
##### Variable-ları String ifadə də birləşdirmək
- Toplama methodu ilə  
- `string.Format()` methodundan istifadə edərək `string` dəyəri _variable_-lardan alaraq **index** uyğun yaza bilrərik daha çox time və rəqsal məlumatları göstərmək üçün istifadə edilir.
- [**Template String**](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/MyResearch/1_Foundation/1_4_String/1_4_String/Program.cs#L16) `$""` 




