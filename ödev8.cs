using System;

namespace ödev8
{
    class Program
    {
        static void Main(string[] args)
        {
            KrediHesap k1 = new KrediHesap();
            k1.HesapAc(1, "Ali", 500, 1000);
            k1.Yazdir();
            k1.ParaYatir(100);
            k1.Yazdir();
            k1.ParaCek(1590);
            k1.Yazdir();
            KrediHesap.kartSayisiYazdir();
            KrediHesap k2 = new KrediHesap();
            k2.HesapAc(2, "Ahmet", 300, 1000);
            k2.Yazdir();
            k2.ParaYatir(100);
            k2.Yazdir();
            k2.ParaCek(1500);
            k2.Yazdir();
            KrediHesap.kartSayisiYazdir();
            Console.ReadLine();

        }
    }
    class KrediHesap
    {
        private string musteri_adi_soyadi;
        private double bakiye;
        private double limit;
        private int musteri_no;
        static int kart_sayisi = 0;
        private int yukleme;

        public void HesapAc(int musteri_no,string musteri_adi_soyadi,double bakiye, double limit)
        {
            this.musteri_no = musteri_no;
            this.musteri_adi_soyadi = musteri_adi_soyadi;
            this.bakiye = bakiye;
            this.limit = limit;
            ToplamKartSayısı();
        }
        public void ParaCek(double cekme)
        {
           
            if (this.bakiye >= cekme)
            {
                this.bakiye -= cekme;

            }
            else if (this.bakiye + this.limit >= cekme)
            {
                this.bakiye -= cekme;
                this.limit += this.bakiye;
                this.bakiye = 0;
            }
            else
            {
                Console.WriteLine("Bakiye ve Limit Yetersiz.");
                this.bakiye = 0;
                this.limit = 0;
            }
                


        }
        public void ParaYatir(int yukleme)
        {
             bakiye += yukleme;
        }
        public void ToplamKartSayısı()
        {
            kart_sayisi += 1;
        }
        public static void kartSayisiYazdir()
        {
            Console.WriteLine("Toplam Kart Sayısı : " + kart_sayisi);
        }
        public void Yazdir()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Müşteri No :" + musteri_no);
            Console.WriteLine("Müşteri Adı Soyadı:" + musteri_adi_soyadi);
            Console.WriteLine("Bakiye: " + bakiye);
            Console.WriteLine("Limit: " + limit);
            Console.WriteLine("----------------------------------------");
        }
    }
}
