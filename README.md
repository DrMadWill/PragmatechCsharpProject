# PragmatechCsharpProject

### Information structure
- <b> Lesson(a/b)</b>
    - _a_ Week
    - _b_ Lesson
.
.
.
#### Lesson(3/1) Array,Non-Generic and Generic
- Include
    - Task
        - [Task Content](https://github.com/PragmatechEducation/Csharp03#-lesson-5-25-oktyabr-2021-)
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
        - [Task Solution](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_3/Lesson_1)
    - [Lesson](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_3/Lesson_1)
        - [Code](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_3/Lesson_1/Lesson/Lesson/Program.cs)
        - Lesson Documentation

#### Lesson(4/1) => OOP (Object Oriented Programming)
- Include
    - Task 
        - [Task Content](https://github.com/PragmatechEducation/Csharp03#oxumal%C4%B1-m%C3%B6vzular-5)
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
        - [Task Solution](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_4/Lesson_1/task/task/Program.cs)
    - [Lesson](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_4/Lesson_1) 
        - [Code](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_4/Lesson_1/Lesson/Lesson/Program.cs)
        - [Lesson Documentation](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_4/Lesson_1/OOP_Research_and_Lesson.md)

 #### Lesson(4/2) => Struct
 - Include
    - [Lesson](https://github.com/DrMadWill/PragmatechCsharpProject/tree/main/week_4/Lesson_2)
        - [Code](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_4/Lesson_2/Lesson/Lesson/Program.cs)
        - [Lesson Documentation](https://github.com/DrMadWill/PragmatechCsharpProject/blob/main/week_4/Lesson_2/different_Struct_and_Class.md)