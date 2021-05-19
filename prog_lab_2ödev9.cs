using System;

namespace ödev9
{
    class first
    {
        public string marka;
        public string model;
        public string islemci;
        public float EkranBoyutu;
        public string Cozunurluk;
        public int ram;
        public int ssd;


        public virtual void VeriGiris()
        {
            marka = "LENOVO ";
            model = "IdeaPad 3";
            islemci = " AMD Ryzen 3 3250U";
            EkranBoyutu = 15.6f;
            Cozunurluk = "1366 x 768";
            ram = 8;
            ssd =256;

            Console.WriteLine("****************************************************");
            Console.WriteLine("Bilgisayarın Markası: "+ marka);
            Console.WriteLine("Bilgisayarın Model: " + model);
            Console.WriteLine("Bilgisayarın islemci: " + islemci);
            Console.WriteLine("Bilgisayarın Ekran Boyutu: " + EkranBoyutu);
            Console.WriteLine("Bilgisayarın Ekran Çözünürlüğü: " + Cozunurluk);
            Console.WriteLine("Bilgisayarın RAM 'i : " + ram + "GB");
            Console.WriteLine("Bilgisayarın SSD'si : " + ssd + "GB");

        }
        static void Main(string[] args)
        {
            first notebook = new first();
            notebook.VeriGiris();
            
            first notebook1 = new second();
            notebook1.VeriGiris();
           
            first notebook2 = new third();
            notebook2.VeriGiris();
        }
    }

    class second : first
    {
        
        public override void VeriGiris()
        {
            marka = "ASUS";
            model = " X515MA-BR091T ";
            islemci = " Intel Celeron N4020 Processor 1.1 GHz";
            EkranBoyutu = 15.6f;
            Cozunurluk = "1366 x 768";
            ram = 4;
            ssd = 128;
            Console.WriteLine("****************************************************");
            Console.WriteLine("Bilgisayarın Markası: " + marka);
            Console.WriteLine("Bilgisayarın Model: " + model);
            Console.WriteLine("Bilgisayarın islemci: " + islemci);
            Console.WriteLine("Bilgisayarın Ekran Boyutu: " + EkranBoyutu + "inch");
            Console.WriteLine("Bilgisayarın Ekran Çözünürlüğü: " + Cozunurluk);
            Console.WriteLine("Bilgisayarın RAM 'i : " + ram + "GB");
            Console.WriteLine("Bilgisayarın SSD'si : " + ssd + "GB");
        }
    }

    class third : first
    {
        
        public override void VeriGiris()
        {
            marka = "APPLE";
            model = " MacBook Air";
            islemci = " M1 ";
            EkranBoyutu = 13.3f;
            Cozunurluk = "2560 x 1600";
            ram = 8;
            ssd = 256;
            Console.WriteLine("****************************************************");
            Console.WriteLine("Bilgisayarın Markası: " + marka);
            Console.WriteLine("Bilgisayarın Model: " + model);
            Console.WriteLine("Bilgisayarın islemci: " + islemci);
            Console.WriteLine("Bilgisayarın Ekran Boyutu: " + EkranBoyutu + "inch");
            Console.WriteLine("Bilgisayarın Ekran Çözünürlüğü: " + Cozunurluk);
            Console.WriteLine("Bilgisayarın RAM 'i : " + ram + "GB");
            Console.WriteLine("Bilgisayarın SSD'si : " + ssd + "GB");
        }
    }

}
