# C# Thread

  

## MultiTasking

> Komputerin eyni adnda bir neçə programı içra etməsi **MultiTasking** deyilir.

> Program icrası zamanı həmin program **Process** kimi qəbul edilir və CPU dan istifadə edir.

- Hər **Process**in özünün Registiri və Stackı olur.

  
  

<img  src="https://miro.medium.com/max/723/1*IT1r2bMD5n_d1xlmsrmudw.png">

  
  

## MltiTreeding

> Process icrası zamnanı bir program bir neçə Thread həyata keçirməsinə **MltiTreeding** deyilir.

>  _Thread_-in icrası zamanı Programin yaddaşda tutduğu yerdən istifadə edir.

> Main Thread işini bitirdikdən sora digər Threadlər işini bitirə bilər.

> 2 tip Thread var

- ForeGroupd Əsas Threadin işi bitdikdən sonra işini dayandırır.

- BackGroud

> Thread-i Background etmək üçün `isBackground` parametrini True etmək lazımdır.

  

## Race Condition Problem

> Müəyyən Bir `for` döngüsü var onun daxilində yeni `Thread` yaradıb ekrana `for`un _index_-ini çıxarmağa çalışırıq ancaq kodu _run_ etsək görərik ki rəqəmlər ardıcılığı qarışıb . məsələn(0223557799) səbəb hər dəfə `for`un  icrası zamanı _index_ eyni yaddaş yerinə aid olmasıdır.

  
- Problem
```c
	for (int i = 0; i < 10; i++) 
		new Thread(() => Console.WriteLine(i)).Start();
```
- Problem Solved
```c
for (int i = 0; i < 10; i++)
{
	int temp = i;
	new Thread(() => Console.WriteLine(temp)).Start();
}
```
## Thread Methods
- **Abort()**  methodu yazılmış `Thread`i  sonlandırır.
- **Join()**   yazılmış `Thread`i digər `Thread`ləri gözləyir.
- **Sleep ()**  method təyin edilmiş vaxt ərzində icrasını dayadırır və davam bu döngü şəklində `Thread` icrasını bitirir.
- **Thread Priority** `Thread`in aktivliyinə nəzərət edir.






