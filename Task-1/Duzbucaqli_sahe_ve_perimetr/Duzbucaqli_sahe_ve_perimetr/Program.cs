using System;

namespace Duzbucaqli_sahe_ve_perimetr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duzbucaqli Sahe ve Perimetr");
            Console.Write("Eni : ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzunu : ");
            int height = Convert.ToInt32(Console.ReadLine());

            Area_and_Perimeter(width, height);

        }

        public static void Area_and_Perimeter(int width,int height)
        {
            int area = width * height;
            int perimeter = 2 * (width + height);

            Console.WriteLine($" Sahesi : {area} , Perimetri : {perimeter}");
        }

    }
}
