using System.Collections.Generic;

namespace RepositoryAndUnitOfWork.DataAccess.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetBestCustomers(int amountOfCustomers);
    }
}