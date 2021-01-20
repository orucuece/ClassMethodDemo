using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public int Add(int totalCustomer, Customer newCustomer)  
        {
            totalCustomer++;
            Console.WriteLine("New Customer is added: " + newCustomer.Name + " " + newCustomer.Surname);
            Console.WriteLine("Total Customer is updated: " + totalCustomer);

            return totalCustomer;
            
        }

        public int Delete(int totalCustomer, Customer oldCustomer)
        {
            totalCustomer--;
            Console.WriteLine("Old Customer is removed: " + oldCustomer.Name + " " + oldCustomer.Surname);
            Console.WriteLine("Total Customer is updated: " + totalCustomer);
            return totalCustomer;
        }

        public void Listing(Customer[] customerArray)
        {
            foreach (Customer item in customerArray)
            {
                Console.WriteLine("Customer List: " + "[" + item.Id + "] " + item.Name + " " + item.Surname);
            }
            //Console.WriteLine("Customer List: " + customerName + " " + customerSurname);
        }
    }
}
