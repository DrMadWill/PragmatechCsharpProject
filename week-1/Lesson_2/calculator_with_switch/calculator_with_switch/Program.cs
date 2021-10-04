using System;

namespace calculator_with_switch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------Leydis end Centilmen!-------------------");
            Console.WriteLine("-----------------Welcome to My Calculator-----------------");

            while (true)
            {

                Console.WriteLine("--------------Toplama emeliyyatı üçün (+) işaresini --------");
                Console.WriteLine("----------------Çıxma emeliyyatı üçün (-) işaresini --------");
                Console.WriteLine("----------------Vurma emeliyyatı üçün (*) işaresini --------");
                Console.WriteLine("----------------Bölmə emeliyyatı üçün (/) işaresini seçin --");

                Console.Write(">>>>>>>>>>>>>>>>>> Emeliyyat <<<<<<<<<<<<<<< :  ");
                string emeliyyat = Console.ReadLine();

                if (emeliyyat=="+" || emeliyyat == "-" || emeliyyat == "*" || emeliyyat == "/")
                {

                }
                else
                {
                    Console.WriteLine(">>>>>>>>>>>>  Yanlis emliyyat daxil edildi.Emeliyyati yeniden yaz.  <<<<<<<<<<<<<<<<<<");
                    continue;
                }



                switch (emeliyyat)
                {
                    case "+":
                        while (true)
                        {
                            Console.WriteLine("<<<<<<<<<<<<<<< Toplama emeliyyatı >>>>>>>>>>>>>>>");
                            Console.Write("Toplanan a : ");
                            int toplanan_a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Toplanan b : ");
                            int toplanan_b = Convert.ToInt32(Console.ReadLine());
                            int cem = toplanan_a + toplanan_b;
                            Console.WriteLine("Emeliyat toplama >>> " + toplanan_a + " + " + toplanan_b + " = " + cem);
                            Console.Write("Yeniden Cem emeliyyatı? ---> klavaturadan istenilen herf/n --->>>> : ");
                            string toplamadavamsorgusu = Console.ReadLine();
                            if (toplamadavamsorgusu == "n")
                            {
                                break;
                            }
                        }

                        break;


                    case "-":
                        while (true)
                        {
                            Console.WriteLine("<<<<<<<<<<<<<<< Çıxma emeliyyatı >>>>>>>>>>>>>>>");
                            Console.Write("Çıxılan a : ");
                            int cıxılan_a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Çıxan b : ");
                            int cıxan_b = Convert.ToInt32(Console.ReadLine());
                            int ferq = cıxılan_a - cıxan_b;
                            Console.WriteLine("Emeliyat çıxma >>> " + cıxılan_a + " - " + cıxan_b + " = " + ferq);
                            Console.Write("Yeniden Çıxma emeliyyatı? ---> klavaturadan istenilen herf/n --->>>> : ");
                            string toplamadavamsorgusu = Console.ReadLine();
                            if (toplamadavamsorgusu == "n")
                            {
                                break;
                            }
                        }

                        break;

                    case "*":
                        while (true)
                        {
                            Console.WriteLine("<<<<<<<<<<<<<<< Vurma emeliyyatı >>>>>>>>>>>>>>>");
                            Console.Write("Vurma a : ");
                            int vurulan_a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Vurma b : ");
                            int vurulan_b = Convert.ToInt32(Console.ReadLine());
                            int hasil = vurulan_a * vurulan_b;
                            Console.WriteLine("Emeliyat vurma >>> " + vurulan_a + " * " + vurulan_b + " = " + hasil);
                            Console.Write("Yeniden Vurma emeliyyatı? ---> klavaturadan istenilen herf/n --->>>> : ");
                            string toplamadavamsorgusu = Console.ReadLine();
                            if (toplamadavamsorgusu == "n")
                            {
                                break;
                            }
                        }

                        break;

                    case "/":

                        while (true)
                        {
                            Console.WriteLine("<<<<<<<<<<<<<<< Bölme emeliyyatı >>>>>>>>>>>>>>>");
                            Console.Write("Bölünen a : ");
                            int bolunen_a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Bölen b : ");
                            int bolen_b = Convert.ToInt32(Console.ReadLine());
                            int qismet = bolunen_a / bolen_b;
                            Console.WriteLine("Emeliyat bölme >>> " + bolunen_a + " / " + bolen_b + " = " + qismet);
                            Console.Write("Yeniden Bölme emeliyyatı? ---> klavaturadan istenilen herf/n --->>>> : ");
                            string toplamadavamsorgusu = Console.ReadLine();
                            if (toplamadavamsorgusu == "n")
                            {
                                break;
                            }
                        }

                        break;


                }


                Console.Write("Calculatordan Çıxmaq? ---> klavaturadan istenilen herf/n --->>>> : ");
                string davamsorgusu = Console.ReadLine();
                if (davamsorgusu == "n")
                {
                    Console.Write(">>>>>>>>>>>>>>>>>>>>>>> Good bay! <<<<<<<<<<<<<<<<<<<<<<<");
                    break;
                }


            }


        }
    }
}
