using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };
            Product urun1 = new Product();
            urun1.UrunAdi = "Portakal";
            urun1.UrunFiyat = 17;
            urun1.Aciklama = "Turuncu Renk";

            Product urun2 = new Product();
            urun2.UrunAdi = "Karpuz";
            urun2.UrunFiyat = 70;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] {urun1,urun2};

            //type-safe -- tip güvenli
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.UrunFiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("**************");
            }

            Console.WriteLine("--------Methods---------");

            //encapsulation

            SepetManager sepetManager = new SepetManager();
            //Metotlar(Fonksiyonlar) bize aynı işlemleri tekrar tekrar yazıp kendimizi tekrar etmemizi önleyen bir yapıdır.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //Bu alan çalışıyor fakat bu şekil de teker teker yazmak yanlış bir kullanım şeklidir.Bu nedenler yukarıda ki gibi kapsülleme işmlemi yaparak kullanmak daha doğru olacaktır. Encapsulation
            sepetManager.Ekle2("Armut","Yeşil Armut",12);
            sepetManager.Ekle2("Ayva", "Sarı Ayva", 16);
            sepetManager.Ekle2("Muz", "Sarı Muz", 18);
            sepetManager.Ekle2("Erik", "Yeşil Erik", 12);
            
        }
    }
}


//Do not repeat yourself - DRY -Kendini tekrar etme DRY - Clean Code - Best Practice(En iyi Uygulama Teknikleri)