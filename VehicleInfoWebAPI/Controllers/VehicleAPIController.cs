using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperDataAccessLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VehicleInfoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleAPIController : ControllerBase
    {
        IVehicleInfoRepository obj;
        public VehicleAPIController ()
        {
            obj = new VehicleInfoRepository();
        }
        // GET: api/<VehicleAPIController>
        [HttpGet]
        public IEnumerable<VehicleInfo> Get()
        {
            return obj.GetVehicleInfoSP();
        }

        // GET api/<VehicleAPIController>/5
        //[HttpGet("{id}")]
        //public VehicleInfo Get(int id)
        //{
        //    return obj.UpdateVehicleInfoSP(id);
        //}

        //// POST api/<VehicleAPIController>
        [HttpPost]
        public void Post([FromBody] VehicleInfo value)
        {
            obj.InsertSP(value);
        }

        // PUT api/<VehicleAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] VehicleInfo value)
        {
            obj.UpdateVehicleInfoSP(id, value);
        }

        // DELETE api/<VehicleAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            obj.DeleteVehicleInfoSP(id);
        }
    }
}
