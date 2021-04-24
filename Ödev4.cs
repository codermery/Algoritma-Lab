using System;

namespace ödev4
{
   
    class Program
    {

        public static void giris()
        {
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Meryem Koç 201307091 Odev4 Ozyinelemeli Fonksiyonlar\n");
            Console.WriteLine("1 - Fibonacci Hesaplama (iteratif) ");
            Console.WriteLine("2 - Fibonacci Hesaplama(özyinelemeli");
            Console.WriteLine("3 - Us alma(özyinelemeli");
            Console.WriteLine("4 - Çıkış");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz: ");
            Console.WriteLine("*****************************************************************************");

        }

        static int fibonacciInteratif()
        {
            int a = 0, b = 1, c, asama;
            Console.Write("Hangi siradaki sayiyi görmek istiyorsunuz:");
            asama = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < asama; i++)
            {
                c = a;
                a = b;
                b += c;
            }
            Console.WriteLine(asama + ". sırada ki fibonacci degeri: " + a + "(iteratif)");
            return a;
        }

        static int fibonacciOzyinelemeli(int sayi1)
        {
           

            if (sayi1 < 1)
            {
                return 0;
            }
            else if (sayi1 == 1)
            {
                return 1;
            }
            else
            {
                return fibonacciOzyinelemeli(sayi1 - 1) + fibonacciOzyinelemeli(sayi1 - 2);
            }
        }
 
        static int UsOzyinelemeli(int us1,int us2)
        {
            if (us2 == 0)
                return 1;
            else
                return us1 * UsOzyinelemeli(us1, us2 - 1);

        }
        

        static void Main()
        {
            while (true)
            {
                giris();
                int sayi;
                sayi = Convert.ToInt16(Console.ReadLine());

                if (sayi == 1)
                {
                    fibonacciInteratif();
                }

                else if (sayi == 2)
                {
                    Console.WriteLine("Kaçıncı sıradaki fibonacci değerini görmek istiyorsunuz?");
                    int asama = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}. sıradaki fibonacci değeri {1} olarak hesaplanmıştır.", asama, fibonacciOzyinelemeli(asama));
                }

                else if (sayi == 3)
                {
                    Console.WriteLine("Üssünü almak istediğininiz sayıyı girin...");
                    int us1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Almak istediğininiz üs sayısını girin...");
                    int us2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("{0} üzeri {1} : {2} ", us1,us2, UsOzyinelemeli(us1, us2));
                }

                else if (sayi == 4)
                {
                    break;
                }

                else
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz...");
            }
        }

    }
}