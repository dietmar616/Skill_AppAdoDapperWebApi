using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Interfaces.IServices
{
    public interface ICustomerServices
    {

        public Task<DTOCustomer> GetCustomerById(int id);

       

        public Task DeleteCustomerById(int id);

 


    }
}
