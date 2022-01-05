## Existation
> Hər hansı bir methodun çağırılması üçün `Class`-a və ya `Struct`-a müraciyyət edərək yaradılan dəyərdən istfadə etmək lazımdır. Bunu prosesin qarşısını almaq üçün `Existation method`-undan istfadə edilir.`Existation method`-method üçün əsas tələblər bunlardır:
- Method `static` clasin içərisində olmalıdır.
- Extend ediləcək methodun parametrini qaşısına `this` key yazılır.
- `Existation method`-da yalnız bir parametir `this` key-i ilə yazıla bilər.

## Delegate
> `delegate` Methodların adresini özündə tutan accessible(Methodu methoda parametir kimi godərdiyimiz) structurdur.
- _Referance_ tipdir.
- Obyekti yaradılır.
- 16 yaxin parametir ala bilir.
- `delegate` sonuna _Handler_ yazmaq kod yazılım qaydasıdır.
- Yaradılan `delegate`-in _return_ type-ı nədirsə çağırlacaq methodlarında _return_ type-ı eyni olmalıdır.
- `delegate`-ə göndərilən methodun parmetirləri və sayı  `delegate`-in parmetrləri və sayı ilə eyni olmalıdır.
- 3-cür çağırmaq olur:
    - _Method_ adı ilə
    - _Anonim Method_-la
    - _Lambda expression_-la

### Action
- `void` `delegate`-in yaradılmasında istfadə edilir.
- 16 parametir ala bilir.
### Func
- `return` type olan `delegate`-dir.
- yalniz sonuncu type `return` dəyər olaraq götürür.
