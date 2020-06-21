using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using przykladoweKolokwium.Exceptions;
using przykladoweKolokwium.Services;

namespace przykladoweKolokwium.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderDbService _dbService;

        public OrderController(IOrderDbService dbService)
        {
            _dbService = dbService;
        }

        // Zadanie 1 -> GET: api/orders

        [HttpGet("{surname}")]
        public IActionResult GetClientOrders(string surname)
        {
            try
            {
                var result = _dbService.GetClientOrders( surname);
                return Ok(result);
            }
            catch (ClientDoesNotExistsException e)
            {
                return NotFound(e.Message);
            }
        }

        
    }
}