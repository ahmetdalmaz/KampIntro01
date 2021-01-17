using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "Çilek";
            double fiyati = 15;
            string Aciklama = "çilek gibi çilek";
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            //type-safe (tip güvenli)
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("----------------METOTLAR------------------");
            //instance (örnek)
            SepetManager manager = new SepetManager();
            manager.Ekle(urun1);
            manager.Ekle(urun2);

            manager.Ekle2("Armut", "Yeşil Armut",12,10);
            manager.Ekle2("Elma", "Yeşil Elma", 12,9);
            manager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);

        }
    }
}
