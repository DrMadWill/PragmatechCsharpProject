## String and String Bilder
> String tip `char` arrayında ibarət olmasına baxmayaraq bu arrayın daxildəki `char`lara müraciyyət eib dəyişdirmək olmur. 

```c#
    // 1 Using
    string txt = "Hello I like Anime. ";
    txt = txt + "Ofcorse I like manga";

    StringBuilder stringBuilder = new StringBuilder();

    // 2 Using
    stringBuilder.Append("Hello I like Anime ");
    stringBuilder.Append("Ofcorse I like manga");

```

> String və StringBuilder arasındakı əsas fərq stringin variablelları dəyişməz olduğu üçün `1` ifadədəki kimi istfadələrdə string arxada `txt` mətini öznü saxlayır və yeni yardılan zaman mətin kopyalanır. StringBuilder isə bunu qarşısına keçilir.
> - Stringin bəzi methodları bu [linkdədir](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/MyResearch/CSharp/Documatation/Documatation.md#string-method).

## Casting
> value typelar arasındakı eyni dəyər tipnə sahib olan dəyrlər arasındakı keçitdir.

### Casting Up
> Özüdən kiçikdəyər tipinin özündə yerləşməsidir.

```c#
    int int_number = 5;
    long long_number = int_number;
```
### Casting Down
> Özündən böyük dəyər tipinin özündə yerləşməsidir. Bu zaman dəyərdə itki baş verir.
```c#
    long long_number = 5;
    int int_number = (int) long_number;
```

## Boxing 
> value type-ın referance type çevirilməsidir.
```c#
    int number = 7;
    object obj = number;
```
## UnBoxing
> referance type-ın value type çevirilməsidir. Belə hallarda error olma ehtimalı yüksəkdir.

```c#
    object obj = 7;
    int number = (int)obj;
```

## Ref and Out keyword
> ref və out keyləri vastəsi ilə biz methodlara value type dəyərləri referance type dəyərlər kimi yaddaşda tutuğu yerin linkini göndərə bilərik. Bu bizə göndərilən dəyərin özünün üzərində oynama imkanı yaradır. 
### Ref 
> Göndərilən value mütləq əvəlcədən içərində dəyər atamış olmalıdır.
```c#
 static void Main(string[] args)
        {
           
            int j = 7;

            Console.WriteLine(j);//7

            RefMethod(ref j);

            Console.WriteLine(j);//10
        }


        static void RefMethod(ref int number)
        {
            number = 10;
            
        }
```

### Out 
> Methoda göndərilən valueunun içərisinə dəyər atamaq mütləq deyildir anca mütləq methodda yenidən **override** edilməlidir.Yəni həmindəyərə nəsə mənimsədilməlidir.

```c#
 static void Main(string[] args)
        {
           
            int j;

            OutMethod(out j);

            Console.WriteLine(j);//5
        }


        static void OutMethod(out int number)
        {
            number = 5;
        }
```

## Method Overloading
> **Methodların Eyni Addan** istafadə etməsinə ancaq daxilində fərqli method olmasına gətirib çıxarır. Bu **fərqləndirmə** :
> - return və ya void olmasına görə 
> - parametir sayına görə fərqlənə bilir.

## Array
> Yaddaşda sıralı yer tutan Collectiondır (dəyər toplusu). Arrayların əsas xususiyyətləri aşağıdakılardı :
> - `Length` **öndcədən qeyd edilməlidir**.
> - **Bir tipi olmalıdır**.

Təyin edilmə üsulları aşağıdakı kimidir.

```c#

        string[] text1 = new string[3];

        string[] text2 = new string[5] { "Strange", " Book", "Live", "Void","End" };

        string[] text3 = new string[] { "Apple", "Orange" };

        string[] text4 = { "Will", "Mad" };
```

## Params Keyword 
> Methoda bir neçə eyni tipli variable göndərmək istəyiriksə mütləq array yaradıb onları onların daxilə yığmalı sonra methoda göndərə bilrərdik.Params bizi bu əziyyətdən xilas edir. Daxilinə **göndərilən variableları özü bir arraya yığır** və göndərir. Əsas xususiyyətləri belədir:
> - Methoda t'yin edilən parametrin qaşısına  `param` key yazılır.
> - Əgər methoda daha təyin edilən varaiblelardan başqa variable göndərmək istəyiriksə o zman paramsdan əvvəl qeyd edilməlidir.

```c#

    static void Main(string[] args)
    {
        ParamKeyWord(1, 5, 7);
        //1
        //5
        //7

        ParamKeyWord("Will", 7, 8);
        //Will
        //7
        //Will
        //8
    }

    static void ParamKeyWord(params int[] numbers)
    {
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }

    static void ParamKeyWord(string name,params int[] numbers)
    {
        foreach (var item in numbers)
        {
            Console.WriteLine(name);
            Console.WriteLine(item);
        }
    }

```

