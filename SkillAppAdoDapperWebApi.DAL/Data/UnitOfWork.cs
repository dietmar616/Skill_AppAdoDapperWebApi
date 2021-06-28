using Microsoft.AspNetCore.Identity;
using DAL.Repositories;
using DAL.Interfaces;
using System;
using System.Threading.Tasks;
using DAL.Repositories.SQLRepositories;
using DAL.Interfaces.ISQLRepositories;

namespace DAL.Data
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;


        public UnitOfWork(Context context )
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));


            CustomerRepository = new SQLCustomerRepository(_context);
            OrderRepository = new SQLOrderRepository(_context);
            TOYDetRepository = new SQLTOYDetRepository(_context);
            ToyRepository = new SQLToyRepository(_context);
            VENDORDetRepository = new SQLVENDORDetRepository(_context);
            VendorRepository = new SQLVendorRepository(_context);

  
        }  
        public ISQLCustomerRepository CustomerRepository { get; private set; }
        public ISQLOrderRepository OrderRepository { get; private set; }
        public ISQLTOYDetRepository TOYDetRepository { get; private set; }
        public ISQLToyRepository ToyRepository { get; private set; }
        public ISQLVENDORDetRepository VENDORDetRepository { get; private set; }
        public ISQLVendorRepository VendorRepository { get; private set; }



        public Task<int> Complete() => _context.SaveChangesAsync();

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }



        public IGenericRepository<Entity> GetRepository<Entity>() where Entity : class
        {

            GenericRepository<Entity> repository = new GenericRepository<Entity>(_context);

            return repository;
        }

    }
}

