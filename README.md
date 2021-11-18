# PragmatechCsharpProject

### Information structure
- <b> Lesson(a/b)</b>
    - _a_ Week
    - _b_ Lesson

### My Lessons 

#### Lesson(1/1) => CLI languages,For Loop,Switch Statement,Data Types,Stack Value Type,Heap Reference Type and Methods
- Include 
    - Task
        - [Content](https://github.com/PragmatechEducation/Csharp03#-lesson-1-11-oktyabr-2021-)
        ```
            1)5 ədədin orta qiymətinin tapılması algoritmi qurun;
            2)Düzbucaqlının sahə və perimetrini tapan algoritmi qurun;
            3)Daxil edilən ədədin vurma cədvəlini yazdiran algoritmi qurun;
            4)1 le verilmis eded arasinda kvadratlari cemi algoritmini qurun;
            5)0 la verilmiş ədəd arasındaki ədədlərin hasili ilə cəminin fərqini hesablayan algoritmi qurun;
            Hər birini methodlar vasitesile yazin. Ugurlar! :)
        ```
        - [Solution](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_1/Lesson_1/Task-1)
    - [Lesson](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_1/Lesson_1/Task-1)
        - Code
        - Documentation
#### Lesson(1/2) => String vs StringBuilder,Ref & out keyword,Method Overloading,Type Casting,Boxing and Unboxing,String Methods,String Methods 2,Arrays,Duplicate values
- Include 
    - Task
        - [Content](https://github.com/PragmatechEducation/Csharp03#-lesson-2-15-oktyabr-2021-)
        ```
            1)String Substring algorithmini qurun;
            2)Reverse algoritmi qurun : input: hello, output: olleh
            3)Verilmis sozun palindrome oldugunu yoxlayan algoritm mes:input: ana, output: ana (soldan ve sagdan eyni oxunur)
            4)Remove duplicate data algoritmini yazin input: csharpcorner, output: csharpone c
            azir methodlardan istifade etmeyin)) Meqsed hazir methodlarin algoritmini yazmaqdir Ugurlar! :)
        ```
        - [Solution](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_1/Lesson_2)
    - [Lesson](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_1/Lesson_2)
        - [Code](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_1/Lesson_2/Lesson/Lesson/Lesson/Program.cs)
        - Documentation

#### Lesson(2/1) => Params,Class and Object
- Include
    - Task
        - [Content](https://github.com/PragmatechEducation/Csharp03#-lesson-3-18-oktyabr-2021-)
        ```
            Student class-i yaradin:
            Fullname
            GroupNo
            Age
            Student classi ucun GetBirthYear() metodunu yazin.Bu metod Studentin dogum ilini geri qaytarir
            Student Arrayi yaradin.
            Qrup nomresini daxil etmekle bir qrupda nece telebenin oxudugunu check eden method yazin.(2ci parametr kimi     array       daxil edeceksiz)
            ps:Student yaradilarken butun deyerlerin verilmesi mecburidir
        ```
        - [Solution](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_2/Lesson_1/task_1/task_1/Program.cs)
    - [Lesson](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_2/Lesson_1)
        - [Code](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_2/Lesson_1/Lesson/Lesson/Program.cs)
        - Documentation

#### Lesson(2/2) => Static
- İnclude
    - Task
        - [Content](https://github.com/PragmatechEducation/Csharp03#-lesson-4-22-oktyabr-2021-)

        ```
            Account - class
            No - her bir account obyektinin unique nomersidir ve onun necenci yarandigini gosterir
            Username
            Password
            IsUserNameValid() method - username yanlizca digit ve herflerden ibaret ola biler yoxlanisi

            IsPasswordValid() method-uzunluq 8-25, siferenin icinde en az bir symbol,1 uppurcase letter ve en az bir digit          istifade olunmalidir yoxlanisi console readlinedan aldiginiz datani bu methodlarda yoxlayib sonra yeni obyekte          menimsedeceksiz...

            1.Constructorda name ve password qebul edilsin
        ```
        - [Solution](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_2/Lesson_2/Task/Lesson/Program.cs)

    - Lesson 
        - Code
        - Documentation

#### Lesson(3/1) => Array,Non-Generic and Generic
- Include
    - Task
        - [Content](https://github.com/PragmatechEducation/Csharp03#-lesson-5-25-oktyabr-2021-)
        ```
            1) Aşağıdaki tapşırığı yerinə yetirin:
            a) Key və value-su string tipində olan Dictionary yaradın.

            b) İstifadəçidən 10 dəfə iki söz yazılması istənilsin:

            b.1) Birinci söz ölkə adı. b.2) İkinci söz paytaxt adı.

            c) Daha sonra istifadəçi ölkə adı yazaraq daxil edilən list-dən paytaxt adını almalıdır.

            d) Əgər istifadəçi ölkə adı əvəzinə "all" sözü daxil edilərsə, dictionary-də olan bütün ölkə-paytaxlar print            edilsin.

            e) Nəticəni aldıqdan sonra yeni paytaxt axtarışı edilsin yoxsa proqram bitsin deyə istifadəçidən soruşulmalıdır və          cavaba müvafiq əməliyyat baş verməlidir.

            Misal üçün:

            Proqram çalışarkən aşağıdakilər baş verməlidi:

            Əvvəl belə mesaj çıxır: "Hörmətli istifadəçi! Zəhmət olmasa ölkə adı qeyd edin."

            Daha sonra ölkə adını yazmaq istənilir.

            Daha sonra bu mesaj çıxır: "Hörmətli istifadəçi! Zəhmət olmasa ölkəyə aid paytaxt qeyd edin."

            Paytaxt adını yazmaq istənilir.

            Bütün bu proses 10 dəfə təkrarlanır və dictionary dolur. Daha sonra istifadəçidən bir ölkə adı yazmaq istənilir:

            "Hörmətli istifadəçi! Zəhmət olmasa paytaxtını tapmaq istədiyiniz ölkənin adını qeyd edin."

            İstifadəçi "Azərbaycan" yazarsa dictionary-də həmin key-ə görə search edib, ona uyğun value-nu, yəni "Bakı" sözünü          qaytarıb, ekrana print etmək lazımdı. Əgər istifadəçi ölkə adı əvəzinə "all" sözü daxil edilərsə, dictionary-də         olan bütün ölkə-paytaxlar print edilsin.

            Print etdikdən sonra soruşulur: "Yeni paytaxt axtarılsın? Y/N"

            İstifadəçi "Y" yazarsa yeni axtarış üçün ölkə adı istənilsin, "N" basarsa proqramdan çıxsın.

            2) Aşağıdaki tapşırığı yerinə yetirin:
            a) string tipli Queue list-i yaradın.

            b) İçini müxtəlif mesajlarla doldurun.

            c) Əgər məlumat 10 item-dən çox olarsa, növbədə (queue-list) sonuncu olan elementi boşaldıb, yerinə yeni məlumatı           salın.

            3) Aşağıdaki tapşırığı yerinə yetirin:
            a) int tipində List yaradın.

            b) İstifadəçi 10 müxtəlif ədədlərlə listi doldursun.

            c) Daha sonra list-in son 5 elementi ilə ilk 5 elementinin yerlərini dəyişdirin.

            4) Aşağıdaki tapşırığı yerinə yetirin:
            a) int tipli elə bir kolleksiya yaradın ki, içində bütün item-lər unique olsun (təkrarlanma olmasın) və sort            edilmiş vəziyyətdə olsun.

            b) Daha sonra içini müxtəlif ədədlərlə doldurun. (Console-dan)

            c) Nəticəni ekrana çap edin.

        ```
        - [Solution](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_3/Lesson_1)
    - [Lesson](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_3/Lesson_1)
        - [Code](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_3/Lesson_1/Lesson/Lesson/Program.cs)
        - Documentation

#### Lesson(4/1) => OOP (Object Oriented Programming)
- Include
    - Task 
        - [Content](https://github.com/PragmatechEducation/Csharp03#oxumal%C4%B1-m%C3%B6vzular-5)
            ```
            Asagidaki metodlari olan Account abstract classi yaradirsiniz
                - PasswordChecker() - parameter oalraq string sifreni qebul edir (abstract metod)
                - ShowInfo() - virtual metod
            Asagidaki memberlerden ibaret User class-i yaradirsiniz ve Account-u miras verirsiniz: 
                - Fullname 
                - Email 
                - Password 
                - PasswordChecker() - PasswordChecker metodu - gelen string sifre deyerinin sertleri odeyib odemediyini yoxlayib true/false deyer qaytarir. 
            Şertler:
                - sifrede minimum 8 character olmalidir
                - sifreki buutun herfler boyuk olmamalidir
                - sifredeki butun herfler kicik olmamalidir (yeni sifrede hem boyuk hem kicik herf olmalidir)
                - ShowInfo() - bu metod Console-a user-in Fullanem ve email-inin yazdirir
            User classina Account class-i miras verilir.User yarandigi zaman email ve sifre teyin edilmesi mecburidir.Usere sifre teyin edilerken sifrenin PasswordChecker metodunun sertlerini odemesi lazimdir.
            ```
        - [Solution](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_4/Lesson_1/task/task/Program.cs)
    - [Lesson](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_4/Lesson_1) 
        - [Code](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_4/Lesson_1/Lesson/Lesson/Program.cs)
        - [Documentation](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_4/Lesson_1/OOP_Research_and_Lesson.md)

 #### Lesson(4/2) => Struct
 - Include
    - [Lesson](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_4/Lesson_2)
        - [Code](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_4/Lesson_2/Lesson/Lesson/Program.cs)
        - [Documentation](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_4/Lesson_2/different_Struct_and_Class.md)

 #### Lesson(5/1) => C# Interface and Access Modifiers
- Include 
    - Task
        - [Content](https://github.com/PragmatechEducation/Csharp03#-lesson-9-8-noyabr-2021-)
        ```
            Tapshiriq 1:
            Student.cs olsun, Name, Surname, Age propertyleri olsun, ancaq constructorda set olsun. Neche defe instance aldigimizi qaytaran Counter olsun, hansiniki yalniz constructorda set ede bilek.

            Tapshiriq 2:
            IFigure interface yaratmaq, CalculateArea ve CalculatePerimeter method-u olsun. Rectangle, Circle, Triangle, Square bu interface-in methodlarini implement etsin.

            Tapshiriq 3:
            ISum, IMultiply, IDifference, IDivide interface-leri olsun her birinde bir dene return type "double" olan ve parametrinde "params double[] numbers" method olsun. Bu 4 interface-i Calculator.cs class-inda her birini implement edin. Meselen: ISum interface-inde Sum() methodu olacaq ve arrayin butun elementlerini cemleyib qaytaracaq. Multiply - vurma, Difference -chixma, Divide - bolme. Sonda Program.cs-de Calculator.cs-i chagirib, verdiyiniz deyerlere uygun method chagirib neticeni gosterin.
        ```
        - [Solution](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_5/Lesson_1)
    - [Lesson](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_5/Lesson_1)
        - [Code](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_5/Lesson_1/Lesson/TestinInternal/Program.cs)
        - [Documatation](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_5/Lesson_1/Documantation.md)