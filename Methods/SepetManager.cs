using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention - İsimlendirme Kuralı
        //syntax - yazım bicimi
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi"+" : " + urun.UrunAdi);
        }

        //Aşağıda ki metot çalışıyor fakat bu şekil de teker teker yazmak yanlış bir kullanım şeklidir.Bu nedenler yukarıda ki gibi kapsülleme işmlemi yaparak kullanmak daha doğru olacaktır. Encapsulation
        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Sepete Eklendi" + " : " + urunAdi);
        }
    }
}
