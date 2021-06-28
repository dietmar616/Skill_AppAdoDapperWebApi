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
    public class TOYDetController : Controller
    {
        private readonly ITOYDetServices TOYDetServices;

        public TOYDetController(ITOYDetServices adServices) => this.TOYDetServices = adServices;

        // get all ads

        [HttpDelete("DelTOYDetById/{id}")]
        public async Task DeleteTOYDetById(int id)
        {
            await TOYDetServices.DeleteTOYDetById(id);
        }

        [HttpGet("GetTOYDetById/{id}")]
        public async Task<DTOTOYDet> GetTOYDetById(int id)
        {
            return await TOYDetServices.GetTOYDetById(id);
        }
    }
}
