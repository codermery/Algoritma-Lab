///Meryem KOÇ 201307091 ÖDEV5
using System;

namespace Ödev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("En değerini giriniz: ");
            double genislik = Convert.ToInt32(Console.ReadLine());

            Console.Write("Boy değerini giriniz: ");
            double uzunluk = Convert.ToInt32(Console.ReadLine());

            Dortgen dortgen = new Dortgen(genislik, uzunluk);
            dortgen.Yazdir();
        }
    }
    class Dortgen
    {
        protected double genislik;
        protected double uzunluk;

        public Dortgen(double genislik, double uzunluk)
        {
            this.genislik = genislik;
            this.uzunluk = uzunluk;
        }

        protected double Alan()
        {
            return genislik * uzunluk;
        }

        protected string Karemi()
        {
            if (genislik == uzunluk)
                return "Bu bir karedir.";
            else
                return "Bu bir kare değildir.";
        }

        public void Yazdir()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("Genişlik:" + genislik);
            Console.WriteLine("Uzunluk:" + uzunluk);
            Console.WriteLine(Karemi());
            Console.WriteLine("Alan: " + Alan().ToString());
            Console.WriteLine("****************************\n");
        }
    }

    
}
