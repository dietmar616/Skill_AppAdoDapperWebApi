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
    public class OrderController : Controller
    {
        private readonly IOrderServices OrderServices;

        public OrderController(IOrderServices adServices) => this.OrderServices = adServices;

        // get all ads

        [HttpDelete("DelOrderById/{id}")]
        public async Task DeleteOrderById(int id)
        {
            await OrderServices.DeleteOrderById(id);
        }

        [HttpGet("GetOrderById/{id}")]
        public async Task<DTOOrder> GetOrderById(int id)
        {
            return await OrderServices.GetOrderById(id);
        }
    }
}
