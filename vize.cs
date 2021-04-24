
using System;

namespace vize
{
    class kisisel_bilgi
    {
        public static string[] adSoyad = new string[100];
        public static string[] bolum = new string[100];
        public static UInt64[] TC = new UInt64[100];
        public static string[] cinsiyet = new string[100];
        public static string[] ders1 = new string[100];
        public static string[] ders2 = new string[100];
        public static string[] ders3 = new string[100];
        public static int[] not1 = new int[100];
        public static int[] not2 = new int[100];
        public static int[] not3 = new int[100];
        public static int[] basarinotu = new int[100];
        public static string[] harfnotu = new string[100];
        public kisisel_bilgi()
        {
            Console.WriteLine("Parametreniz Kuruldu...");
        }
        public kisisel_bilgi(int abc)
        {
            Console.WriteLine("1 Parametreli Kurucu Oluşturuldu");
        }
        public kisisel_bilgi(int xyz,int qwerty)
        {
            Console.WriteLine("2 Parametreli Kurucu Oluşturuldu");
        }
        public kisisel_bilgi(kisisel_bilgi kopya_kişisel_bilgi)
        {
            Console.WriteLine("Kopyalandı...");
        }
        ~kisisel_bilgi()
        {
            Console.WriteLine("Kodumuz Yıkılıyor...");
        }
    }
    class uygulama
    {

        static string basarinotuhesabi(int a,int not1,int not2,int not3,int basarinotu,string harfnotu)
        {

            kisisel_bilgi.basarinotu[a] = (not1 + not2 + not3) / 3;

            if (kisisel_bilgi.basarinotu[a] >= 0 && kisisel_bilgi.basarinotu[a] < 45)

                kisisel_bilgi.harfnotu[a] = "FF";

            else if (kisisel_bilgi.basarinotu[a] >= 45 && kisisel_bilgi.basarinotu[a] < 50)

                kisisel_bilgi.harfnotu[a] = "DD";

            else if (kisisel_bilgi.basarinotu[a] >= 50 && kisisel_bilgi.basarinotu[a] < 60)

                kisisel_bilgi.harfnotu[a] = "CC";

            else if (kisisel_bilgi.basarinotu[a] >= 60 && kisisel_bilgi.basarinotu[a] < 70)

                kisisel_bilgi.harfnotu[a] = "CB";

            else if (kisisel_bilgi.basarinotu[a] >= 70 && kisisel_bilgi.basarinotu[a] < 80)

                kisisel_bilgi.harfnotu[a] = "BB";

            else if (kisisel_bilgi.basarinotu[a] >= 80 && kisisel_bilgi.basarinotu[a] < 90)

                kisisel_bilgi.harfnotu[a] = "BA";

            else if (kisisel_bilgi.basarinotu[a] >= 90 && kisisel_bilgi.basarinotu[a] < 100)

                kisisel_bilgi.harfnotu[a] = "AA";

            else
                Console.WriteLine("Geçersiz Değer Girdiniz");
            return harfnotu;
        }

        public static void SifirinciOgr()
        {
            Console.WriteLine("*************************************************************************\n");
            Console.WriteLine("0 Numaralı öğrenci ekleniyor...");

            kisisel_bilgi.adSoyad[0] = "Ahmet Ölmez";
            Console.WriteLine("Ad Soyad: "+ kisisel_bilgi.adSoyad[0]);
            kisisel_bilgi.bolum[0] = "Bilişim Sistemleri Mühendisliği";
            Console.WriteLine("Bölüm: "+kisisel_bilgi.bolum[0]);
            kisisel_bilgi.TC[0] = 34567345345;
            Console.WriteLine("TC No: "+kisisel_bilgi.TC[0]);
            kisisel_bilgi.cinsiyet[0] = "Erkek";
            Console.WriteLine("Cinsiyet: "+kisisel_bilgi.cinsiyet[0]);
            kisisel_bilgi.ders1[0] = "Algoritma Ve Programlama 2";
            Console.WriteLine("Aldığın 1. Ders: "+kisisel_bilgi.ders1[0]);
            kisisel_bilgi.ders2[0] = "Fizin 2";
            Console.WriteLine("Aldığın 2. Ders: "+kisisel_bilgi.ders2[0]);
            kisisel_bilgi.ders3[0] = "Mat 2";
            Console.WriteLine("Aldığın 3. Ders: "+kisisel_bilgi.ders3[0]);
            kisisel_bilgi.not1[0] = 80;
            Console.WriteLine("Aldığın 1. Dersin Notu: "+kisisel_bilgi.not1[0]);
            kisisel_bilgi.not2[0] = 90;
            Console.WriteLine("Aldığın 2. Dersin Notu: "+kisisel_bilgi.not2[0]);
            kisisel_bilgi.not3[0] = 100;
            Console.WriteLine("Aldığın 3. Dersin Notu: "+kisisel_bilgi.not3[0]);
            
            Console.WriteLine("0 Numaralı öğrenci başarıyla eklendi.\n");
            Console.WriteLine("*************************************************************************\n");
        }
        public static void BirinciOgr()
        {
            Console.WriteLine("*************************************************************************\n");
            Console.WriteLine("1 Numaralı öğrenci ekleniyor...");

            kisisel_bilgi.adSoyad[1] = "Mehmet Koç";
            Console.WriteLine("Ad Soyad: " + kisisel_bilgi.adSoyad[0]);
            kisisel_bilgi.bolum[1] = "Endüstri Mühendisliği";
            Console.WriteLine("Bölüm: " + kisisel_bilgi.bolum[0]);
            kisisel_bilgi.TC[1] = 56789787878;
            Console.WriteLine("TC No: " + kisisel_bilgi.TC[0]);
            kisisel_bilgi.cinsiyet[1] = "Erkek";
            Console.WriteLine("Cinsiyet: " + kisisel_bilgi.cinsiyet[0]);
            kisisel_bilgi.ders1[1] = "Algoritma Ve Programlama 2";
            Console.WriteLine("Aldığın 1. Ders: " + kisisel_bilgi.ders1[0]);
            kisisel_bilgi.ders2[1] = "İşletme Ekonomisi";
            Console.WriteLine("Aldığın 2. Ders: " + kisisel_bilgi.ders2[0]);
            kisisel_bilgi.ders3[1] = "Mat 2";
            Console.WriteLine("Aldığın 3. Ders: " + kisisel_bilgi.ders3[0]);
            kisisel_bilgi.not1[1] = 55;
            Console.WriteLine("Aldığın 1. Dersin Notu: " + kisisel_bilgi.not1[0]);
            kisisel_bilgi.not2[1] = 30;
            Console.WriteLine("Aldığın 2. Dersin Notu: " + kisisel_bilgi.not2[0]);
            kisisel_bilgi.not3[1] = 100;
            Console.WriteLine("Aldığın 3. Dersin Notu: " + kisisel_bilgi.not3[0]);

            Console.WriteLine("1 Numaralı öğrenci başarıyla eklendi.");
            Console.WriteLine("*************************************************************************\n");
        }
        public static void IkinciOgr()
        {
            Console.WriteLine("*************************************************************************\n");
            Console.WriteLine("2 Numaralı öğrenci ekleniyor...");

            kisisel_bilgi.adSoyad[2] = "Leyla Çelik";
            Console.WriteLine("Ad Soyad: " + kisisel_bilgi.adSoyad[0]);
            kisisel_bilgi.bolum[2] = "Bilgisayar Mühendisliği";
            Console.WriteLine("Bölüm: " + kisisel_bilgi.bolum[0]);
            kisisel_bilgi.TC[2] = 567897899889;
            Console.WriteLine("TC No: " + kisisel_bilgi.TC[0]);
            kisisel_bilgi.cinsiyet[2] = "Kadın";
            Console.WriteLine("Cinsiyet: " + kisisel_bilgi.cinsiyet[0]);
            kisisel_bilgi.ders1[2] = "Nesneye Dayalı Programlama";
            Console.WriteLine("Aldığın 1. Ders: " + kisisel_bilgi.ders1[0]);
            kisisel_bilgi.ders2[2] = "İşletim Sistemleri";
            Console.WriteLine("Aldığın 2. Ders: " + kisisel_bilgi.ders2[0]);
            kisisel_bilgi.ders3[2] = "Elektrik devreleri";
            Console.WriteLine("Aldığın 3. Ders: " + kisisel_bilgi.ders3[0]);
            kisisel_bilgi.not1[2] = 70;
            Console.WriteLine("Aldığın 1. Dersin Notu: " + kisisel_bilgi.not1[0]);
            kisisel_bilgi.not2[2] = 80;
            Console.WriteLine("Aldığın 2. Dersin Notu: " + kisisel_bilgi.not2[0]);
            kisisel_bilgi.not3[2] = 90;
            Console.WriteLine("Aldığın 3. Dersin Notu: " + kisisel_bilgi.not3[0]);

            Console.WriteLine("2 Numaralı öğrenci başarıyla eklendi.");
            Console.WriteLine("*************************************************************************\n");
        }
        public static void HesapEkle()
        {
            Console.WriteLine("Kaçıncı sıraya eklemek istersiniz...");

            int b= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ad Soyad");
            kisisel_bilgi.adSoyad[b] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Bölüm");
            kisisel_bilgi.bolum[b] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("TC No:");
            kisisel_bilgi.TC[b] = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Cinsiyet");
            kisisel_bilgi.cinsiyet[b] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Aldığın 1. Ders");
            kisisel_bilgi.ders1[b] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Aldığın 2. Ders");
            kisisel_bilgi.ders2[b] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Aldığın 3. Ders");
            kisisel_bilgi.ders3[b] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Aldığın 1. Dersin Notu");
            kisisel_bilgi.not1[b] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aldığın 2. Dersin Notu");
            kisisel_bilgi.not2[b] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aldığın 3. Dersin Notu");
            kisisel_bilgi.not3[b] = Convert.ToInt32(Console.ReadLine());
        }

        public static void yazdir()
        {
            
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*************************************************************************\n");
            Console.WriteLine("Ad Soyad: " + kisisel_bilgi.adSoyad[a]);
            Console.WriteLine("Bölüm: " + kisisel_bilgi.bolum[a]);
            Console.WriteLine("TC no: " + kisisel_bilgi.TC[a]);
            Console.WriteLine("Cinsiyet: " + kisisel_bilgi.cinsiyet[a]);
            Console.WriteLine("1. Ders: " + kisisel_bilgi.ders1[a]);
            Console.WriteLine("2. Ders: " + kisisel_bilgi.ders2[a]);
            Console.WriteLine("3.Ders: " + kisisel_bilgi.ders3[a]);
            Console.WriteLine("1. Dersin Notu: " + kisisel_bilgi.not1[a]);
            Console.WriteLine("2. Dersin Notu: " + kisisel_bilgi.not2[a]);
            Console.WriteLine("3. Dersin Notu: " +kisisel_bilgi.not3[a]);
            basarinotuhesabi(a, kisisel_bilgi.not1[a], kisisel_bilgi.not2[a], kisisel_bilgi.not3[a], kisisel_bilgi.basarinotu[a], kisisel_bilgi.harfnotu[a]);
            Console.WriteLine(a + ". numaralı öğrencinin basari notu degeri: " + kisisel_bilgi.harfnotu[a]);
            Console.WriteLine("*************************************************************************\n");

        }

        static void Main(string[] args)
        {
            SifirinciOgr();
            BirinciOgr();
            IkinciOgr();
            Console.WriteLine("*************************************************************************\n");
            Console.WriteLine("Yeni Kayıt Eklemek İster Misiniz?(E/h)");
            string yanıt =Console.ReadLine();
            if(yanıt == "E")
                uygulama.HesapEkle();
            
            kisisel_bilgi kullanıcı = new kisisel_bilgi();
            kisisel_bilgi kullanıcı1 = new kisisel_bilgi(12);
            kisisel_bilgi kullanıcı2 = new kisisel_bilgi(56,100);
            Console.WriteLine("*************************************************************************\n");
            Console.WriteLine("Başarı Notunu Yazdırmak İstediğiniz Öğrenci No Giriniz...");
            uygulama.yazdir();
            Console.WriteLine("*************************************************************************\n");

        }
        
    }
}
