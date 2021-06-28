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
    public class VENDORDetServices : IVENDORDetServices
    {
        private readonly IUnitOfWork Database;
        private readonly IMapper mapper;
        public VENDORDetServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            Database = unitOfWork;
            this.mapper = mapper;
        }


        public async Task DeleteVENDORDetById(int id)
        {
            await Database.VENDORDetRepository.DeleteById(id);
        }


        public async Task<DTOVENDORDet> GetVENDORDetById(int id)
        {
            var VENDORDet = await Database.VENDORDetRepository.GetById(id);
            var mappedVENDORDet = mapper.Map<SQLVENDORDet, DTOVENDORDet>(VENDORDet);

            return mappedVENDORDet;
        }

    }
}



