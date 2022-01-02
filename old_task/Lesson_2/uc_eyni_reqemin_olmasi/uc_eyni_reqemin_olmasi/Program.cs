using System;

namespace uc_eyni_reqemin_olmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------  Tekrarlan 3 reqem sayi   -------------------------");
            while (true)
            {


                

                Console.Write("Eded : ");
                string eded = Console.ReadLine();
                int ededyoxlama = Convert.ToInt32(eded);
                if (ededyoxlama / 1000 > 0 && ededyoxlama / 10000 == 0)
                {


                    int d = 0;
                    for (int i = 0; i < eded.Length; i++)
                    {
                        string[] eynilik = eded.Split(eded[i]);
                        d = d + eynilik.Length;

                    }

                    int reqemsayi = 14;

                    if (d == reqemsayi)
                        Console.WriteLine(">>>>>>>>>> Tebrikler.Tekarlanan 3 reqem var <<<<<<<<<");
                    else
                        Console.WriteLine(">>>>>>>>>>>> Tekrarlan 3 reqem yoxdur <<<<<<<<<<<<<<<");


                }
                else
                {
                    break;
                }


            }
        }
    }
}
