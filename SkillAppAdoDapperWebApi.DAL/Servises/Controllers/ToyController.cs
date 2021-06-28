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
    public class ToyController : Controller
    {
        private readonly IToyServices ToyServices;

        public ToyController(IToyServices adServices) => this.ToyServices = adServices;

        // get all ads

        [HttpDelete("DelToyById/{id}")]
        public async Task DeleteToyById(int id)
        {
            await ToyServices.DeleteToyById(id);
        }

        [HttpGet("GetToyById/{id}")]
        public async Task<DTOToy> GetToyById(int id)
        {
            return await ToyServices.GetToyById(id);
        }
    }
}
