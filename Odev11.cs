using System;

namespace UçgenSayılar
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, i, toplam, basamak, deger, kalan;
            bool x,y;

            toplam = 0;
            try
            { 
                do
                {
                    Console.WriteLine("En çok 4 basamaklı pozitif bir sayi giriniz...");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    deger = sayi;
                    basamak = 0;
                    x = true;
                    y = true;

                    while (x)
                    {
                        kalan = deger / 10;
                        deger = (deger - kalan) / 10;
                        basamak = basamak + 1;

                        if (deger == 0)
                        {
                            x = false;
                        }
                    }
                    if(basamak<=4 && sayi>0)
                    {
                        y = false;
                    }
                }
                while (y);

                for (i = 1; i <= sayi; i++)
                {
                    toplam = toplam + i;
                    if (toplam == sayi)
                    {
                        Console.WriteLine(sayi + " bir üçgen sayıdır.");
                        break;
                    }
                }
                if (toplam != sayi)
                {
                    Console.WriteLine(sayi + " bir üçgen sayı değildir.");
                }
            }
            catch
            {
                Console.WriteLine("Geçersiz Karakter Girdiniz !");
            }


        }
        
    }

}
