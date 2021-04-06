using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi

            string[] kurslar = new string[] { "Fenerbahce", "Galatasaray", "Beşiktaş", "Trabzonspor" };

            for (int i = 0; i <kurslar.Length;  i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("****** For Bitti ******");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Page End - Footer");
        }
    }
}
