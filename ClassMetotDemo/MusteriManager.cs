using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi +" "+ musteri.MusteriSoyadi + " isim soyadlı müşteri eklendi. ");
        }
        public void Cikar(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi +" "+ musteri.MusteriSoyadi + " isim soyadlı müşteri çıkarıldı. ");
        }
        public void Listele(Musteri[] musteri)
        {
            foreach (var musteriler in musteri)
            {
                Console.WriteLine(musteriler.MusteriAdi + " " + musteriler.MusteriSoyadi + " Bankamızda kayıtlı isim soyadlı müşterilerimiz ");

            }


        }
    }
}
