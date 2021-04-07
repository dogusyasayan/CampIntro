using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Dogus", "Murat", "Fırat", "Dogukan" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            List<string> names2 = new List<string>{"Dogus", "Murat", "Fırat", "Dogukan"};
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Turan");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
            Console.ReadLine();
        }
    }
}
