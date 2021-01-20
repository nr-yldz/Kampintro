using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            // tip güvenliği= type safety
            //değer tutucu,alias
            string kategoriEtiketi = "Kategori";
            int ögrencisayisi = 32000;
            double faizOrani = 8.54;
            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            
        }

    }
}
