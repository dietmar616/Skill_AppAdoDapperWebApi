using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using DAL.Interfaces;
using DAL.DTO;
using DAL.Models;
using DAL.Interfaces.IServices;

namespace DAL.Servises
{
    public class OrderServices : IOrderServices
    {
        private readonly IUnitOfWork Database;
        private readonly IMapper mapper;
        public OrderServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            Database = unitOfWork;
            this.mapper = mapper;
        }


        public async Task DeleteOrderById(int id)
        {
            await Database.OrderRepository.DeleteById(id);
        }


        public async Task<DTOOrder> GetOrderById(int id)
        {
            var Order = await Database.OrderRepository.GetById(id);
            var mappedOrder = mapper.Map<SQLOrder, DTOOrder>(Order);

            return mappedOrder;
        }

    }
}



