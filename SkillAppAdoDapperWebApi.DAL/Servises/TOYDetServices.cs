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
    public class TOYDetServices : ITOYDetServices
    {
        private readonly IUnitOfWork Database;
        private readonly IMapper mapper;
        public TOYDetServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            Database = unitOfWork;
            this.mapper = mapper;
        }


        public async Task DeleteTOYDetById(int id)
        {
            await Database.TOYDetRepository.DeleteById(id);
        }


        public async Task<DTOTOYDet> GetTOYDetById(int id)
        {
            var TOYDet = await Database.TOYDetRepository.GetById(id);
            var mappedTOYDet = mapper.Map<SQLTOYDet, DTOTOYDet>(TOYDet);

            return mappedTOYDet;
        }

    }
}



