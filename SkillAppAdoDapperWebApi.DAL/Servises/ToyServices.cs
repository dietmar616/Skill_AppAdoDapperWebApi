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
    public class ToyServices : IToyServices
    {
        private readonly IUnitOfWork Database;
        private readonly IMapper mapper;
        public ToyServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            Database = unitOfWork;
            this.mapper = mapper;
        }


        public async Task DeleteToyById(int id)
        {
            await Database.CustomerRepository.DeleteById(id);
        }


        public async Task<DTOToy> GetToyById(int id)
        {
            var Toy = await Database.ToyRepository.GetById(id);
            var mappedToy = mapper.Map<SQLToy, DTOToy>(Toy);

            return mappedToy;
        }

    }
}



