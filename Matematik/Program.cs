using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem(); //Dort islem class'ımızı tanıtıyoruz.
            dortIslem.Topla(5, 6);

            dortIslem.Topla(14, 6);
        }
    }
}
