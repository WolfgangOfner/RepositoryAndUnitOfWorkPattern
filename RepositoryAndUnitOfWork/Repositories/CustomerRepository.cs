using System;
using System.Collections.Generic;
using System.Linq;
using RepositoryAndUnitOfWork.DataAccess;
using RepositoryAndUnitOfWork.DataAccess.Repositories;

namespace RepositoryAndUnitOfWork.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly CustomerDbEntities _customerDbEntities;

        public CustomerRepository(CustomerDbEntities context) : base(context)
        {
            _customerDbEntities = context;
        }

        public IEnumerable<Customer> GetBestCustomers(int amountOfCustomers)
        {
            if (amountOfCustomers > _customerDbEntities.Customer.ToList().Count)
            {
                throw new IndexOutOfRangeException();
            }

            return _customerDbEntities.Customer.OrderByDescending(x => x.Revenue).Take(amountOfCustomers).ToList();
        }
    }
}