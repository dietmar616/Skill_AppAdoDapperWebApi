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
    public class VendorServices : IVendorServices
    {
        private readonly IUnitOfWork Database;
        private readonly IMapper mapper;
        public VendorServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            Database = unitOfWork;
            this.mapper = mapper;
        }


        public async Task DeleteVendorById(int id)
        {
            await Database.VendorRepository.DeleteById(id);
        }


        public async Task<DTOVendor> GetVendorById(int id)
        {
            var Vendor = await Database.VendorRepository.GetById(id);
            var mappedVendor = mapper.Map<SQLVendor, DTOVendor>(Vendor);

            return mappedVendor;
        }

    }
}


