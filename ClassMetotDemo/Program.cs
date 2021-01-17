using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();
            Musteri1.MusteriAdi = "Ahmet";
            Musteri1.MusteriSoyadi = "Solmaz";
            Musteri1.Id = 12366;

            Musteri Musteri2 = new Musteri();
            Musteri2.MusteriAdi = "Ezgi";
            Musteri2.MusteriSoyadi = "Özgen";
            Musteri2.Id = 09018;

            Musteri Musteri3 = new Musteri();
            Musteri3.MusteriAdi = "Tülay";
            Musteri3.MusteriSoyadi = "Uzun";
            Musteri3.Id = 22667;

            Musteri[] Musteriler = new Musteri[] { Musteri1, Musteri2, Musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Müşterilerin hepsinin ismi ve soyadı:");

            musteriManager.Listele(Musteriler);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Eklenen Müşterilerin hepsinin ismi ve soyadı:");
            
            musteriManager.Ekle(Musteri1);
            musteriManager.Ekle(Musteri2);
            musteriManager.Ekle(Musteri3);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Çıkarılan Müşterilerin hepsinin ismi ve soyadı: ");

            musteriManager.Cikar(Musteri1);
            musteriManager.Cikar(Musteri2);
            musteriManager.Cikar(Musteri3);
            



        }
    }
}
