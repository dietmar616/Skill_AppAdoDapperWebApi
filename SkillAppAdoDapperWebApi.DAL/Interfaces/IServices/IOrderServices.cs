using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Interfaces.IServices
{
    public interface IOrderServices
    {

        public Task<DTOOrder> GetOrderById(int id); 

        public Task DeleteOrderById(int id);

       
    }
}
