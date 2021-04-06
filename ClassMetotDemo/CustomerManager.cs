using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Welcome(string isim,string sehir)
        {
            Console.WriteLine("Welcome to"+sehir+ " " +isim);

        }
        public void Add(Customer customer)
        {
            Console.WriteLine("----------Kullanıcı Eklendi----------");
            Console.WriteLine("Id      : " + customer.Id);
            Console.WriteLine("TcNo    : " + customer.TcNo);
            Console.WriteLine("İsim    : " + customer.customerName);
            Console.WriteLine("Soyisim : " + customer.customerLname);
            Console.WriteLine("İl      : " + customer.City);
            Console.WriteLine("İlçe    : " + customer.Town);
            Console.WriteLine("");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("-------Kullanıcı Güncelleme-------");
            string degisim;
            char devam;
            do
            {
                Console.WriteLine("İşlem görecek kişi : " + customer.customerName + " " + customer.customerLname);
                Console.WriteLine("değiştirmek istediğiniz alanı giriniz \n *İl \n *ilçe");
                degisim = Console.ReadLine();

                if (degisim == "il" || degisim == "İl")
                {
                    Console.WriteLine("Yeni İlin ismi : ");
                    customer.City = Console.ReadLine();
                    Console.WriteLine("yeni Şehir : " + customer.City);
                }
                else if (degisim == "ilçe" || degisim == "İlçe")
                {
                    Console.WriteLine("Yeni İlçenin ismi : ");
                    customer.Town = Console.ReadLine();
                    Console.WriteLine("yeni İlçe : " + customer.Town);
                }
                else
                {
                    Console.WriteLine("Yanlış islem seğenegiğini girdiniz !!!");
                }

                Console.WriteLine("Başka bir değişim yapmak istiyor musunuz : E/H?");
                devam = Convert.ToChar(Console.ReadLine());
            } while (devam == 'e' || devam == 'E');
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("----------Kullanıcı Silindi----------");
            Console.WriteLine(customer.customerName);
            Console.WriteLine("--------------------------------------");
        }
        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Id      : " + customer.Id);
                Console.WriteLine("TcNo    : " + customer.TcNo);
                Console.WriteLine("İsim    : " + customer.customerName);
                Console.WriteLine("Soyisim : " + customer.customerLname);
                Console.WriteLine("İl      : " + customer.City);
                Console.WriteLine("İlçe    : " + customer.Town);
                Console.WriteLine("************************");
            }
        }
    }
}
