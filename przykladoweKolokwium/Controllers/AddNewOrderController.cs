using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using przykladoweKolokwium.Services;

namespace przykladoweKolokwium.Controllers
{
   /* [Route("api/order")]
    [ApiController]
    public class AddNewOrderController : ControllerBase
    {
        private readonly IOrderDbService _dbService;

        public AddNewOrderController(IOrderDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpPost]
        public IActionResult InsertOrder()
        {
            try
            {
                _dbService.InsertOrder();
                return Ok();
            } 
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }*/
}