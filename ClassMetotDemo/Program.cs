using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123456789;
            musteri1.Ad = "Hamza";
            musteri1.Soyad = "Taskesen";
            musteri1.ParaMiktari = 3500;
            musteri1.Islem = "Hesaba para yatırma";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 984651489;
            musteri2.Ad = "Ali";
            musteri2.Soyad = "Gökdelen";
            musteri2.ParaMiktari = 300;
            musteri2.Islem = "Para transferi";

            Musteri[] musteri = new Musteri[] { musteri1,musteri2 };
            foreach (Musteri Kisi in musteri)
            {
                Console.WriteLine(Kisi.Id);
                Console.WriteLine(Kisi.Ad);
                Console.WriteLine(Kisi.Soyad);
                Console.WriteLine(Kisi.ParaMiktari);
                Console.WriteLine(Kisi.Islem);
                Console.WriteLine("************************");
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Hareket(musteri1);
           

        }
    }
}
