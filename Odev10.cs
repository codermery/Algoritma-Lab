using System;

namespace ödev10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, toplam,sayac;
            string işlem="";
            Console.WriteLine("Sayı giriniz...");
            sayi = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[sayi];
            toplam = 0;
            sayac = 0;

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                    dizi[sayac] = i;
                    sayac ++;
                 
                }
            }
         
            for (int j=0; j < sayac ; j++)
            {
                if (j == sayac-1)
                {
                    işlem += Convert.ToString(dizi[j])+ "=" + toplam;
                }

                else
                {
                    işlem += Convert.ToString(dizi[j]) + "+";
                }
            }
            if (toplam == sayi)
            {
                Console.WriteLine(sayi + " mükemmel bir sayıdır. Pozitif tam bölenler(kendisi hariç): " + işlem);
            }
            else
            {
                Console.WriteLine(sayi + " mükemmel Sayı Değildir.");
            }
            Console.ReadLine();
        }
    }
}
