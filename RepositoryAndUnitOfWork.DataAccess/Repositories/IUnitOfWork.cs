using System;

namespace RepositoryAndUnitOfWork.DataAccess.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }

        int Complete();
    }
}