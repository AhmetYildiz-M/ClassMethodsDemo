using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {

            Console.WriteLine(customer.IdentifyNumber + " numbered customer is added to system");

        }

        public void Add2(Customer customer)
        {
            if (customer.RiskStatus == false)
            {
                Console.WriteLine(customer.IdentifyNumber + " identify number customer is added blacklist.");
            }
            else
            {
                Console.WriteLine(customer.IdentifyNumber + " identify number customer's status is not risky. It is added as not risky.");
            }

        }

        public void Remove(Customer customer)
        {

            Console.WriteLine(customer.FirstName + " " + customer.LastName + " named customer's informations has been deleted");
        }



        public void List(Customer[] customers)
        {

            Console.WriteLine("If you want to see customer's risk or age status. Please search by writing 'AgeStatus' or 'RiskStatus'.");

            string choice = Convert.ToString(Console.ReadLine());

            switch (choice)
            {
                case "RiskStatus":
                    foreach (var risky in customers)
                    {
                        Console.Write(risky.FirstName + " " + risky.LastName + ", ");

                        if (risky.RiskStatus == false)
                        {
                            Console.WriteLine(risky.IdentifyNumber + " identify number customer is added blacklist.");
                        }
                        else
                        {
                            Console.WriteLine(risky.IdentifyNumber + " identify number customer's status is not risky. It is added as not risky.");
                        }

                    }
                    break;
                case "AgeStatus":
                    foreach (var ages in customers)
                    {

                        if (ages.Age < 18)
                        {
                            Console.WriteLine(ages.FirstName + " " + ages.LastName + " " +
                                "is not eligible for personal loans. Because he/she is lower than 18.");
                        }
                        else if (ages.Age > 65)
                        {
                            Console.WriteLine(ages.FirstName + " " + ages.LastName + " " +
                                "is not eligible for personal loans. Because he/she is higher than 65.");
                        }
                        else
                        {
                            Console.WriteLine(ages.FirstName + " " + ages.LastName + " " +
                                "is eligible for personal loans.");
                        }

                    }
                    break;
                default:
                    Console.WriteLine("You typed incorret. Please type it again!");
                    break;

            }
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " named customer's informations has been updated");
        }
    }
}
