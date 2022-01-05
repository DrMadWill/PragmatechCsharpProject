### CLI languages
> **C#** **Java**-ya baxılaraq yaradılmışdır.
> İşləmə mətiqi  Aşağıdakı kimidir.

<img src="../Z_Img/Working.jpg">

> **C#** kodunun `bult` edilmiş forması yəni `IL` dilinə çevirilmiş formas `.exe` filedır 

> **IL** dili **Intermediate Language** olub. Komputer **IL** dilindəki file işlədərək **JIT** dilinə çevir. Nəticə etibarı ilə Program icra edilir.**IL** dili adından göründüyü kimi hər şeyin işlərənərək işləməyə hazır  vəziyyət gətirilmə mərhələsidir. 

> **Ide** => **Integrated Development Environment** kod yazmağa hazır mühit. 

> **DLL** => **Dynamic Link Library** Dinamik Kitabxana Linki. 

## Data Type
> Hər `Data Taype` bir classdır. Variables `C#`üçü cür katogorizə edilir:
> - **Value Types** 
> - **Reference Type** 

#### Value Type
>**Value type**  **System.ValueType** classından yaradılır və bu variable tipində tutlan dəyər `Stack` yaddaşda tulur.

>**Value Type** misal olaraq aşğdakıları misal göstər bilrəik:

| Type | Represents | Range |
|--|--|--|
| bool | Boolean value | True or False |
| byte| 8-bit unsigned integer |  0 to 255 |
| char|16-bit Unicode character|  U +0000 to U +ffff |
| decimal| 128-bit precise decimal values with 28-29 significant digits|(-7.9 x 1028  to 7.9 x 1028) / 100  to 28 |
| double| 64-bit double-precision floating point type |(+/-)5.0 x 10-324  to (+/-)1.7 x 10308 |
| float| 32-bit single-precision floating point type | -3.4 x 1038  to + 3.4 x 1038 |
| int| 32-bit signed integer type | -2,147,483,648 to 2,147,483,647 |
| long| 64-bit signed integer type |  -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 |
|sbyte|8-bit signed integer type|-128 to 127|
|short|  16-bit signed integer type|-32,768 to 32,767|
|uint|32-bit unsigned integer type|0 to 4,294,967,295|
|ulong|64-bit unsigned integer type|0 to 18,446,744,073,709,551,615|
|ushort|16-bit unsigned integer type|0 to 65,535|
|enum|Enumeration types ||
|struct|represents data structures||

> value type stack yaddaşdan istifadə edir buna görə bir-birinə `a` və `b` value type bərbərləşdirsək `b`-ə `a`-ın dəyərini **kopyas**ı göndərilir. Yəni yadaşları bir birinə  bağlamır.

```c
    int a = 5;

    int b = a;

    a = 7;

    Console.WriteLine("a : " + a);
    Console.WriteLine("b : " + b);

    // we see
    //a : 7
    //b : 5
```
#### Reference Type
> **Reference Type** value type dan başqa bütün tiplər Reference tipə aidirlər. Reference tipin daxilindəki dəyər **Heap** yadddaşda tutlur. Stack yaddaşda isə həmin variablein adı və **Heap** yaddaşdakı dəyərin link tutulur. Reference type aşağıdakıları misal göstərmək olar:
- `string`
- `class`
- `interface` vs ə.

> Əgər item_b reference type item_a reference type birləşdirəriksə o zaman heap yaddaş linkləri eyni olur nəticə etibarı ilə dəyərlərdə eyni olur.

```c
class Program
    {
        static void Main(string[] args)
        {
            // Referance Type
            Item item_a = new Item();
            Item item_b = new Item();
            item_a.number = 5;
            item_b = item_a;

            item_a.number = 7;
            Console.WriteLine(item_a.number);//7
            Console.WriteLine(item_b.number);//7

        }

    }

    class Item
    {
        public int number;
    }

```

