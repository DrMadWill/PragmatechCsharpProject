using System;

namespace artansirlali_5_reqmli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededleri artan sirlari olmaqi");

            while (true)
            {
                Console.Write("Nece reqemli ededdir? : ");
                int emeliyat_sayi = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.Write("Eded : ");
                string eded = Console.ReadLine();
                int ededyoxlama = Convert.ToInt32(eded);

                int emeliyyat = 0;
                for (int i = 0; i < eded.Length - 1; i++)
                {
                    if (Convert.ToInt32(eded[i]) < Convert.ToInt32(eded[i + 1]))
                    {
                        emeliyyat++;
                    }
                }

                if (emeliyyat == emeliyat_sayi)
                {
                    Console.WriteLine(">>>>> Tebrikler.Ededler artan siralidir <<<<<<<<<<<<");
                }
                else
                {
                    Console.WriteLine(">>>>> Artan sirali deyil <<<<<<<<<<<<");
                }

            }
        }
    }
}
