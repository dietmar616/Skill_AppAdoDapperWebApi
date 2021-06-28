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
    public class VENDORDetController : Controller
    {
        private readonly IVENDORDetServices VENDORDetServices;

        public VENDORDetController(IVENDORDetServices adServices) => this.VENDORDetServices = adServices;

        // get all ads

        [HttpDelete("DelVENDORDetById/{id}")]
        public async Task DeleteVENDORDetById(int id)
        {
            await VENDORDetServices.DeleteVENDORDetById(id);
        }

        [HttpGet("GetVENDORDetById/{id}")]
        public async Task<DTOVENDORDet> GetVENDORDetById(int id)
        {
            return await VENDORDetServices.GetVENDORDetById(id);
        }
    }
}
