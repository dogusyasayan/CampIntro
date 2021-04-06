using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.TcNo = "11111111111";
            customer.customerName = "Dogus";
            customer.customerLname = "Yasayan";
            customer.City = "İstanbul City";
            customer.Town = "Gaziosmanpasa";

            Customer customer1 = new Customer();
            customer1.Id = 2;
            customer1.TcNo = "333333333333";
            customer1.customerName = "Gizem";
            customer1.customerLname = "Yildiz İzgi";
            customer1.City = "Amsterdam";
            customer1.Town = "Harlem";

            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new Customer[] { customer, customer1 };
            customerManager.Add(customer);
            customerManager.Delete(customer1);
            customerManager.Update(customer);
            customerManager.List(customers);

        }
    }
}
