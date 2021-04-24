using System;

namespace ödev9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,basamak,kalan,sayi;
            Boolean b= true;
            int[] dizi = new int[4];
            basamak = 0;
            Console.WriteLine("Bir sayı giriniz...");
            a= Convert.ToInt32(Console.ReadLine());
            sayi = a;

            try { 

            while (b)
            {
                kalan = a % 10;
                a = (a - kalan) / 10;
                dizi[basamak]= kalan;
                basamak ++;
                if(a==0)
                    b = false;

            }
            Console.WriteLine("Girdiğiniz sayı : " + sayi);

                switch(basamak)
                { 
                        case 3:
                            double sonuc = Math.Pow(dizi[0], 2) + Math.Pow(dizi[1], 2) + Math.Pow(dizi[2], 2);
                            Console.WriteLine("{0} sayısının basamak kareleri toplamı:" + sonuc, sayi);
                            break;
                        case 4:
                            if (sayi % 4 == 0)
                                Console.WriteLine("{0} sayısı 4 e tam bölünür", sayi);
                            else
                                Console.WriteLine("{0} sayısı 4'e tam bölünmez...", sayi);
                            break;
                }
            }
            catch
            {
                Console.WriteLine("Geçersiz sayı girdiniz...");
            }

        }
    }
}
