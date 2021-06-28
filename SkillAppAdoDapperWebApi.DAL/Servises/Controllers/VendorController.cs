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
    public class VendorController : Controller
    {
        private readonly IVendorServices VendorServices;

        public VendorController(IVendorServices adServices) => this.VendorServices = adServices;

        // get all ads

        [HttpDelete("DelVendorById/{id}")]
        public async Task DeleteVendorById(int id)
        {
            await VendorServices.DeleteVendorById(id);
        }

        [HttpGet("GetVendorById/{id}")]
        public async Task<DTOVendor> GetVendorById(int id)
        {
            return await VendorServices.GetVendorById(id);
        }
    }
}
