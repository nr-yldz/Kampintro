using System;

namespace ClassÖdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Cool Water Edt 125 Ml Erkek Parfüm";
            urun1.UrunMarka = "Davidoff";
            urun1.UrunFiyat = 109;
            urun1.UrunİndirimOrani = 76;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Essential Edt 125 Ml Erkek Parfüm";
            urun2.UrunMarka = "Lacoste";
            urun2.UrunFiyat = 129;
            urun2.UrunİndirimOrani = 70;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Eros Edt 100 Ml Erkek Parfüm";
            urun3.UrunMarka = "Versace";
            urun3.UrunFiyat = 175;
            urun3.UrunİndirimOrani = 69;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi +" "+ urun.UrunMarka  + " %" + urun.UrunİndirimOrani  + " " + urun.UrunFiyat+"TL");

            }


        }
    }
}
class Urun
{
    public string UrunAdi { get; set; }
    public string UrunMarka { get; set; }
    public int UrunFiyat { get; set; }
    public int UrunİndirimOrani { get; set; }
}
