using DAL.Interfaces.ISQLRepositories;

namespace DAL.Interfaces

{
    public interface IUnitOfWork
    {
        ISQLCustomerRepository CustomerRepository { get; }
        ISQLOrderRepository OrderRepository { get; }
        ISQLTOYDetRepository TOYDetRepository { get; }
        ISQLToyRepository ToyRepository { get; }
        ISQLVENDORDetRepository VENDORDetRepository { get; }
        ISQLVendorRepository VendorRepository { get; }

        public IGenericRepository<Entity> GetRepository<Entity>() where Entity : class;
    
    }
}
