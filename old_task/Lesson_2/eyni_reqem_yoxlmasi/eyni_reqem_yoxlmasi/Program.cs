using System;

namespace eyni_reqem_yoxlmasi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------------------  Tekrarlan eded sayi  -------------------------");
            while (true)
            {


                Console.Write("Reqemsayi : ");
                int reqemsayi = Convert.ToInt32(Console.ReadLine()) * 2;

                Console.Write("Eded : ");
                string eded = Console.ReadLine();
                int ededyoxlama = Convert.ToInt32(eded);
                int d = 0;
                for (int i = 0; i < eded.Length; i++)
                {
                    string[] eynilik = eded.Split(eded[i]);
                    d = d + eynilik.Length;

                }

                if (d == reqemsayi)
                    Console.WriteLine(">>>>>>>>>>>> Tekrarlan eded yoxdur <<<<<<<<<<<<<<<");
                else
                    Console.WriteLine(">>>>>>>>>> Tebrikler.Tekarlanan eded var <<<<<<<<<");



            }

        }
    }
}
