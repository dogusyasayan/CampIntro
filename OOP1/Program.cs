using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;
            
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Pencil", UnitPrice = 35 };

            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //int sayi = 100;
            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi);
            Console.WriteLine("1.SAYİ GİR");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.SAYİ GİR");
            int y = Convert.ToInt32(Console.ReadLine());
            productManager.Topla2(x,y);
            int toplamSonucu = productManager.Topla(x, y);

            //int,double,bool... değer tip
            //diziler,class,abstract class,interface ... referans tip

        }
    }
}
