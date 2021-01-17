using System;

namespace KampIntro01
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Ahmet Dalmaz";
            kurs2.IzlenmeOranı = 85;

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs 
    {
        public string KursAdi { get; set; }

        public string Egitmeni { get; set; }

        public int IzlenmeOranı { get; set; }

    }
}
