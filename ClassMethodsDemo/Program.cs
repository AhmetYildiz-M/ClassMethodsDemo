using System;

namespace ClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 101, FirstName = "Ali Osman", LastName = "Yıldız", IdentifyNumber = "152545552", RiskStatus = false, Age = 67 };
            Customer customer2 = new Customer() { Id = 102, FirstName = "Ahmet", LastName = "Yıldız", IdentifyNumber = "145855644", RiskStatus = false, Age = 35 };
            Customer customer3 = new Customer() { Id = 103, FirstName = "Ömer", LastName = "Yıldız", IdentifyNumber = "245512252", RiskStatus = true, Age = 12 };
            Customer customer4 = new Customer() { Id = 104, FirstName = "Refika", LastName = "Yıldız", IdentifyNumber = "118588554", RiskStatus = true, Age = 60 };
            Customer customer5 = new Customer() { Id = 105, FirstName = "Uğur", LastName = "Yıldız", IdentifyNumber = "518987278", RiskStatus = false, Age = 40 };

            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };

            Console.WriteLine("------Customers are loading to system------");
            Console.WriteLine();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
            customerManager.Add(customer5);

            Console.WriteLine();
            Console.WriteLine("***********Cheking Credibility Status**************");

            for (int i = 1; i < customers.Length; i++)
            {
                Console.WriteLine();
                customerManager.List(customers);

                Console.WriteLine();
                customerManager.Remove(customer1);

                Console.WriteLine();
                customerManager.Update(customer5);
                Console.ReadKey();
            }



        }
    }
}
