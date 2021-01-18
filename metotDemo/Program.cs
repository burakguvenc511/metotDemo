using System;

namespace metotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "ahmet";
            musteri1.SoyAdi = "gul";
            musteri1.Yas = 25;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "murat";
            musteri2.SoyAdi = "avcı";
            musteri2.Yas = 43;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "hatice";
            musteri3.SoyAdi = "ersoy";
            musteri3.Yas = 28;

            Musteri[] liste = new Musteri[] { musteri1 };

            Console.WriteLine("mevcut müşteriler: ");
            foreach (Musteri Listeleme in liste)
            {
                Console.WriteLine(Listeleme.Adi + " " + Listeleme.SoyAdi);
                Console.WriteLine("--------------------------------");
            }
            MusteriManager musteriman = new MusteriManager();
            musteriman.MusteriEkle(musteri3);
            musteriman.MusteriEkle(musteri2);

            Console.WriteLine("mevcut müşteriler: ");

            Musteri[] liste1 = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri Listeleme1 in liste1)
            {
                Console.WriteLine("___________");
                Console.WriteLine("| " + Listeleme1.Adi + " " + Listeleme1.SoyAdi);

            }
            Console.WriteLine("--------------------------------");

            MusteriManager musteriman1 = new MusteriManager();
            musteriman1.Mustericikar(musteri2);

            Console.WriteLine("mevcut müşteriler: ");

            Musteri[] liste2 = new Musteri[] { musteri1, musteri3 };

            foreach (Musteri Listeleme2 in liste2)
            {
                Console.WriteLine("___________");
                Console.WriteLine("| " + Listeleme2.Adi + " " + Listeleme2.SoyAdi);

            }
        }
    }
}
