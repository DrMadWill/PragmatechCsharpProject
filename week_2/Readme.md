
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

## Class
> Bir neçə methodu, fildi və propertiyi bir başlıqda yığmağa kömək edir. 
> Class daxildə class yazılmır. C# daxildəki hər şey classlardan törəmişdir.


## Static
> `static` keywordü ilə yazılan method ramda özünə yer tutur. Artıq həmin fildə müraciyyət üçün instance yaratmağa ehtiyac yoxdur.

> - `static` class daxilində **yalnız `static` fild ola bilər**.  
> - `static` class daxilində **unstatic fild method ola bilməz**

> - `static` olmayan class daxilində **static fildə static olmayan fildə ola bilər**.

