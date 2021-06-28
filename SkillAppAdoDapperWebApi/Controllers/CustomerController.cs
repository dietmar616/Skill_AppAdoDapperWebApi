using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using DAL.DTO;

using DAL.Interfaces.IServices;

namespace WEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerServices CustomerServices;

        public CustomerController(ICustomerServices adServices) => this.CustomerServices = adServices;

        // get all ads

        [HttpDelete("DelCustomer1ById/{id}")]
        public async Task DeleteCustomerById(int id)
        {
            await CustomerServices.DeleteCustomerById(id);
        }


        [HttpGet("GetCustomer1ById/{id}")]
        public async Task<DTOCustomer> GetCustomerById(int id)
        {
            return await CustomerServices.GetCustomerById(id);
        }

    } 
}
