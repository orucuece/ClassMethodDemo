using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Elif";
            customer1.Surname = "Bol";
            customer1.Salary = 3000;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Orhan";
            customer2.Surname = "Yalı";
            customer2.Salary = 4000;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Sevil";
            customer3.Surname = "Zeki";
            customer3.Salary = 5000;

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Ziya";
            customer4.Surname = "Petek";
            customer4.Salary = 6000;

            Customer[] currentCustomers = new Customer[] { customer1, customer2, customer3, customer4 };
            int customerNumber = currentCustomers.Length;

            Customer customerNew = new Customer();
            customerNew.Id = 5;
            customerNew.Name = "Ali";
            customerNew.Surname = "Tekir";
            customerNew.Salary = 6000;


            Customer[] updatedCustList = new Customer[] { customer1, customer2, customer3, customer4, customerNew};
            
            if(currentCustomers.Length < updatedCustList.Length )
            {
                CustomerManager custAlias = new CustomerManager();
                {
                    custAlias.Listing(currentCustomers);
                    Console.WriteLine("");
                    custAlias.Add(currentCustomers.Length, customerNew);
                    Console.WriteLine("");
                    custAlias.Listing(updatedCustList);
                    Console.WriteLine("");
                }
                customerNumber++;

            }

            if (currentCustomers.Length >= updatedCustList.Length)
            {
                CustomerManager customerMngAlias2 = new CustomerManager();
                {
                    customerMngAlias2.Listing(currentCustomers);
                    Console.WriteLine("");
                    customerMngAlias2.Delete(customerNumber, customer4);
                    customerMngAlias2.Listing(updatedCustList);
                    Console.WriteLine("");

                }

            }

        }
    }

}


