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
    public class CustomerServices : ICustomerServices
    {
        private readonly IUnitOfWork Database;
        private readonly IMapper mapper;
        public CustomerServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            Database = unitOfWork;
            this.mapper = mapper;
        }

  
        public async Task DeleteCustomerById(int id)
        {
            await Database.CustomerRepository.DeleteById(id);
        }
  

        public async Task<DTOCustomer> GetCustomerById(int id)
        {
            var Customer = await Database.CustomerRepository.GetById(id);
            var mappedCustomer = mapper.Map<SQLCustomer, DTOCustomer>(Customer);

            return mappedCustomer;
        }

      

        
    }
}









/*  public async Task AddNewCustomer(DTOCustomer CreatorDTO)
    {
        await Database.SQLCustomerRepository.Add(mapper.Map<CategoryInfoCreateDTO, category>(CreatorDTO));
    }*/




/*    public async Task<PagedList<CategoryInfoCreateDTO>> GetAllCategorys(QueryStringParameters parameters)
    {
        var allCategorys = await Database.CategoryDRepository.GetAll();
        List<CategoryInfoCreateDTO> CategoryInfoCreateDTOs = new();
        foreach (var Category in allCategorys)
        {
            var mappedcreator = mapper.Map<category, CategoryInfoCreateDTO>(Category);
            CategoryInfoCreateDTOs.Add(mappedcreator);
        }
        var result = PagedList<CategoryInfoCreateDTO>.ToPagedList(CategoryInfoCreateDTOs, parameters.PageNumber, parameters.PageSize);
        return result;
    }*/