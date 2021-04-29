
using System;

namespace ODEV7
{
    class Cokgen
    {

        public int boy ;
        public int en;
        public double cevre;
        public double alan;
        public int birinci;
        public int ikinci;
        public int ucuncu;
        public double s;
        public virtual void VeriGiris()
        {
            Console.WriteLine("Boy uzunluğu giriniz...");
            boy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("En uzunluğu giriniz...");
            en = Convert.ToInt32(Console.ReadLine());
           
        }
        public virtual void AlanHesapla()
        {
            alan = boy * en;
            Console.WriteLine("Alan: " + alan);
        }
        public virtual void CevreHesapla()
        {
            cevre = boy * 2 + en * 2;
            Console.WriteLine("Çevre: " + cevre);
        }
        
        static void Main(string[] args)
        {
            Cokgen kurucu = new Cokgen();
            kurucu.VeriGiris();
            kurucu.AlanHesapla();
            kurucu.CevreHesapla();
            Cokgen kurucu1 = new Daire();
            kurucu1.VeriGiris();
            kurucu1.AlanHesapla();
            kurucu1.CevreHesapla();
            Cokgen kurucu2 = new Ucgen();
            kurucu2.VeriGiris();
            kurucu2.CevreHesapla();
            kurucu2.AlanHesapla();
            


        }
    }
    class Daire: Cokgen
    {
        public int r;
        public override void VeriGiris()
        {
            Console.WriteLine("Daire yarı çapını giriniz...");
            r = Convert.ToInt32(Console.ReadLine());
        }
        public override void AlanHesapla()
        {
          alan = Math.PI * r * r;
          Console.WriteLine("Alan: " + alan);
        }
        public override void CevreHesapla()
        {
          cevre = Math.PI * r * 2;
          Console.WriteLine("Çevre: " + cevre);
        }
        public Daire()
        {
            Console.WriteLine("Daire Kurucu Metodu Çalıştı\n");
            
        }

    }
    class  Ucgen: Cokgen 
    {
        public override void VeriGiris()
        {
            Console.WriteLine("Ucgenin 1. kenar uzunluğu giriniz...");
            birinci = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ucgenin 2. kenar uzunluğu giriniz...");
            ikinci = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ucgenin 3. kenar uzunluğu giriniz...");
            ucuncu = Convert.ToInt32(Console.ReadLine());
        }
        public override void CevreHesapla()
        {
            cevre = birinci + ikinci + ucuncu;
            Console.WriteLine("Çevre: " + cevre);

        }
        public override void AlanHesapla()
        {
            
            s = cevre / 2;
     
            alan = Math.Sqrt(s * (s-birinci)*(s-ikinci)*(s-ucuncu));
            Console.WriteLine("Alan: " + alan);
        }
        
        public Ucgen()
        {
            Console.WriteLine("Ucgen Kurucu Metodu Çalıştı\n");
        }
        
    }
}
