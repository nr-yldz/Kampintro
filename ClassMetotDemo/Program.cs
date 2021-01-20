using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Emrah";
            musteri1.Soyadi = "Yıldız";
            musteri1.SiparisNo = 159;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Nur";
            musteri2.Soyadi = "Yıldız";
            musteri2.SiparisNo = 160;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Talha";
            musteri3.Soyadi = "Yalçın";
            musteri3.SiparisNo = 152;

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Cansu";
            musteri4.Soyadi = "Yalçın";
            musteri4.SiparisNo = 152;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.SiparisNo);
                Console.WriteLine("----------------------");
            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);

            musteriManager.Silme(musteri4);




        }
    }
}
