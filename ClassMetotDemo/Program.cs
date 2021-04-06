using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }





    class Musteri
    {
        public int Id { get; set; }
        public string MüsteriAdi { get; set; }
        public string MüsteriSoyad { get; set; }
    }

    public static void MüsteriEkleme()
    {
        Console.WriteLine("Müsteri Eklendi");
    }
}
