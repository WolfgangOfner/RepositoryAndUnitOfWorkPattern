using RepositoryAndUnitOfWork.DataAccess;
using RepositoryAndUnitOfWork.DataAccess.Repositories;

namespace RepositoryAndUnitOfWork.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CustomerDbEntities _context;

        public UnitOfWork(CustomerDbEntities context)
        {
            _context = context;
            Customers = new CustomerRepository(_context);
        }

        public ICustomerRepository Customers { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}