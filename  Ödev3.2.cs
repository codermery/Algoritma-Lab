using System;

namespace ödev3_2
{
    class Program
    {
        static int Toplam(params int[] sonuc)
        {
            int j,toplam = 0;
           
            for (j = 0; j < sonuc.Length; j++)
            {
                toplam += sonuc[j];
            }
            return toplam;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Toplam());
            Console.WriteLine(Toplam(5));
            Console.WriteLine(Toplam(5, 10));
            Console.WriteLine(Toplam(5, 10, 15));
            Console.WriteLine(Toplam(5, 10, 15, 20));

        }
    }
}
