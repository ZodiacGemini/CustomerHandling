using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web2.Models
{
    public static class DataManager
    {
        static List<Customer> customerList = new List<Customer>
        {
            new Customer { Id = 1, CompanyName = "Spotify", Address = "Spotifygatan", EmployeeCount = 3000 },
            new Customer { Id = 2, CompanyName = "Skype", Address = "Skypegatan", EmployeeCount = 10 },
            new Customer { Id = 3, CompanyName = "Warm Kitten", Address = "PontusLand", EmployeeCount = 1 },
            new Customer { Id = 4, CompanyName = "Izettle", Address = "Sofiaspartnergatan", EmployeeCount = 2 },
        };

        public static void AddCustomer(Customer customer)
        {
            customer.Id = (customerList.Max(c => c.Id) + 1);

            customerList.Add(customer);
        }

        static public Customer[] GetAllCustomers() => customerList.ToArray();

       public static void Remove(int id)
        {
            customerList.Remove(customerList.SingleOrDefault(c => c.Id == id));
        }

        public static Customer GetCustomer(int id)
        {
            return customerList.SingleOrDefault(c => c.Id == id);
        }

        public static void UpdateCustomer(Customer customer)
        {
            var index = customerList.FindIndex(c => c.Id == customer.Id);
            customerList[index] = customer;
        }
    }
}
