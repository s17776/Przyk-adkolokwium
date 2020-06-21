using Microsoft.AspNetCore.Mvc;
using przykladoweKolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace przykladoweKolokwium.Services
{
    public interface IOrderDbService
    {
        IActionResult GetClientOrders(string name);

        IActionResult GetClientOrders();

        IActionResult AddOrder(DTOs.OrderRequest request, int id);

   
    }
}
