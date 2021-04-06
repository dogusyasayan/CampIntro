using System;
using System.Linq;

namespace Day3Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Toplama(3, 5);
            var result = Carpma(4, 5);
            var overloading = Carpma(2, 8, 2);
            Console.WriteLine(overloading);
            Console.WriteLine(result);
            Console.WriteLine(Toplamaİslemi(1,20,30,12));
            DefaultCarpma(10);
            int number1 = 20;
            int number2 = 100;
            var result2 = RefKeyword(ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static void Toplama(int number1, int number2)
        {
            int toplam = number1 + number2;
            Console.WriteLine(toplam);
        }
        //Asagıdaki örnek parametreli bir metotdur,
        static double Carpma(double number1, double number2)
        {
            var result = number1 * number2;
            return result;
        }
        //Asagıdaki örnekte Method Overloading yapılmıştır.Yani aynı metot ismi ile daha farklı bir işlem yapılmış.
        static double Carpma(double number1, double number2,double number3)
        {
            var result = number1 * number2*number3;
            return result;
        }
        //Asagidaki örnek Default Parametreli bir metotdur,
        static double DefaultCarpma(double number1, double number2=30)
        {
            var result = number1 * number2;
            Console.WriteLine(result);
            return result;
        }

        static int RefKeyword(ref int number1,int number2)
        {
            number1 = 97;
            return number1 + number2;
        }
        //**Params Metodu :Kaç tane saynının girileceği bilinmeyen durumlarda bunu kullanırız.

        static double Toplamaİslemi(params int[] numbers)
        {
            return numbers.Sum(); // Dizide ki bütün sayıları topla
        }
    }
}
