using System;
using System.Collections.Generic;
using System.Text;

namespace metotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri ekle)
        {
            Console.WriteLine("kayıt olan müşteri");
            Console.WriteLine(ekle.Adi + " " + ekle.SoyAdi);
            Console.WriteLine("kaydınız oluşturuldu. tebrikler.");
            Console.WriteLine("----------------------");
        }
        public void Mustericikar(Musteri cikar)
        {
            Console.WriteLine("bankamızdan ayrılan müşteri");
            Console.WriteLine(cikar.Adi + " " + cikar.SoyAdi);
            Console.WriteLine("çıkış işlemleriniz başlatıldı.");
            Console.WriteLine("----------------------");

        }
    }
}
