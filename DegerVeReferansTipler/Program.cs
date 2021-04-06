using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            //sayi1?  30
            Console.WriteLine(number1);
            Console.WriteLine(number2);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ? 999
            Console.WriteLine(sayilar1[0]);

            //int - decimal - float - double - bool = değer tip
            //array - class- interface              = referans tip



        }
    }
}
