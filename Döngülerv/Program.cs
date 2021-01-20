using System;

namespace Döngülerv
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            //string kurs2 = "Programlamaya başlamgıç için temel kurs";
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlamgıç için temel kurs","python","C#"};
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("forbitti");
            foreach (string kurs in kurslar) // sadece diziler için
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
