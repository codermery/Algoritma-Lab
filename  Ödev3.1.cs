using System;

namespace Ödev3_1
{
    class Program
    {
        static int Metot(int num)
        {
            Console.WriteLine("1 parametreli sonuc...: " + num);
            return num;
        }

        static int Metot(double num1, double num2)
        {
            double cikti = num1 * num2;
            cikti = Math.Round(cikti, 2);
            Console.WriteLine("2 parametreli sonuc...: " + cikti);
            return 0;
        }

        static string Metot(String ad, String soyad)
        {
            Console.WriteLine("3 parametreli sonuc...: " + ad + soyad);
            return ad + soyad;
        }


        static void Main(string[] args)
        {
            Metot(10);
            Metot(10.2, 5.1);
            Metot("Seda", "Balta");

        }

    }
}
