﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " +musteri.Adi+ " " + musteri.Soyadi);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: "+musteri.Adi+" "+musteri.Soyadi);
        }


    }
}
