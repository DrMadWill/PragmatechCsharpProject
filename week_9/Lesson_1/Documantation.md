## C# Thread

### MultiTasking
> Komputerin eyni adnda bir neçə programı içra etməsi **MultiTasking** deyilir.
> Program icrası zamanı həmin program **Process** kimi qəbul edilir və CPU dan istifadə edir.
- Hər **Process**in özünün Registiri və Stackı olur.


<img src="https://miro.medium.com/max/723/1*IT1r2bMD5n_d1xlmsrmudw.png">


### MltiTreeding
> Process icrası zamnanı bir program bir neçə Thread həyata keçirməsinə **MltiTreeding** deyilir.
> _Thread_-in icrası zamanı Programin yaddaşda tutduğu yerdən istifadə edir.
> Main Thread işini bitirdikdən sora digər Threadlər işini bitirə bilər.
> 2 tip Thread var 
- ForeGroupd Əsas Threadin işi bitdikdən sonra işini dayandırır.
- BackGroud
> Thread-i Background etmək üçün `isBackground` parametrini True etmək lazımdır. 




