using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama

            string KategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar azalmıs");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Dolar artmıs");
            }
            else
            {
                Console.WriteLine("Dolar degismemis");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Sisteme Giris Yapılmis");
            }
            else
            {
                Console.WriteLine("Sisteme Giris Yapilmamis");
            }
        }
    }
}
