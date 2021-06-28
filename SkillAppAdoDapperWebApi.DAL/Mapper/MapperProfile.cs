using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.DTO;
using DAL.Models;

namespace DAL.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
           

            // category Mapper
            CreateMap<DTOCustomer, SQLCustomer>();
            CreateMap<SQLCustomer, DTOCustomer>();

            // category Mapper
            CreateMap<DTOOrder, SQLOrder>();
            CreateMap<SQLOrder, DTOOrder>();

            // category Mapper
            CreateMap<DTOTOYDet, SQLTOYDet>();
            CreateMap<SQLTOYDet, DTOTOYDet>();

            // category Mapper
            CreateMap<DTOToy, SQLToy>();
            CreateMap<SQLToy, DTOToy>();

            // category Mapper
            CreateMap<DTOVENDORDet, SQLVENDORDet>();
            CreateMap<SQLVENDORDet, DTOVENDORDet>();

            // category Mapper
            CreateMap<DTOVendor, SQLVendor>();
            CreateMap<SQLVendor, DTOVendor>();



        }
    }
}
