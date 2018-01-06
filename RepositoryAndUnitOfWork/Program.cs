using System.Collections.Generic;
using System.Linq;
using RepositoryAndUnitOfWork.DataAccess;
using RepositoryAndUnitOfWork.Repositories;


namespace RepositoryAndUnitOfWork
{
    class Program
    {
        private static void Main(string[] args)
        {
            var customers = new List<Customer>()
            {
                new Customer()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 55,
                    ZipCode = "7777",
                    Revenue = 50
                },
                new Customer()
                {
                    FirstName = "Jane",
                    LastName = "Smith",
                    Age = 22,
                    ZipCode = "6666",
                    Revenue = 25
                },
                new Customer()
                {
                    FirstName = "Sarah",
                    LastName = "Doe",
                    Age = 46,
                    ZipCode = "8765",
                    Revenue = 20000
                }
            };

            var annoyingCustomer = new Customer()
            {
                FirstName = "Jack",
                LastName = "Annoying",
                Age = 33,
                ZipCode = "5432",
                Revenue = 5
            };
            
            // select the desired operation
            using (var unitOfWork = new UnitOfWork(new CustomerDbEntities()))
            {
                //unitOfWork.Customers.Add(new Customer() { FirstName = "Wolfgang", LastName = "Ofner", Age = 28, ZipCode = "1234", Revenue = 9_999_999 });
                //unitOfWork.Customers.Add(annoyingCustomer);
                //unitOfWork.Customers.AddRange(customers);

                //var foundCustomers =unitOfWork.Customers.Find(x => x.LastName == "Annoying" || x.Revenue <= 50).ToList();
                //unitOfWork.Customers.Remove(foundCustomers[0]);
                //foundCustomers.RemoveAt(0);
                //unitOfWork.Customers.RemoveRange(foundCustomers);

                //var bestCustomers = unitOfWork.Customers.GetBestCustomers(2);

                unitOfWork.Complete();
            }
        }
    }
}