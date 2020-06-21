using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using przykladoweKolokwium.DTOs;
using przykladoweKolokwium.Exceptions;
using przykladoweKolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace przykladoweKolokwium.Services
{
   public class SqlServerDbService : IOrderDbService
    {
        private readonly  SweetShopContext _context;
        public SqlServerDbService(SweetShopContext context)
        {
            _context = context;
        }

        public IActionResult AddOrder(OrderRequest request, int id)
        {
            if (request.Products.Count() == 0)
                return new BadRequestObjectResult("Bad request");
            var order = new Order
            {

                OrderDate = request.OrderDate,
                Notes = request.Notes,
                IdClient = id,
                IdEmployee = 1
            };
            _context.Orders.Add(order);
            foreach (Products product in request.Products)
            {
                var productId = _context.Products.Where(k => k.Name == product.Product).Select(k => k.IdProduct).FirstOrDefault();
                if (productId == 0)
                    return new BadRequestObjectResult("Bad request");
                var productOrder = new ProductOrder
                {
                    IdProduct = productId,
                    IdOrder = order.IdOrder,
                    Quantity = product.Quantity,
                    Notes = product.Notes
                };
                _context.ProductOrders.Add(productOrder);
            }
            _context.SaveChanges();

            return new OkResult();
        }

        public IActionResult GetClientOrders(string surname)
        {
            var clientId = _context.Clients.Where(a => a.Surname == surname).Select(a => a.IdClient).FirstOrDefault();
            if (clientId == 0)
                return new BadRequestObjectResult("Bad request");

                List<ProductResponse> products = new List<ProductResponse>();
                var orderIds = _context.Orders.Where(o => o.IdClient == clientId).Select(o => o.IdOrder).ToList();
                foreach (int orderId in orderIds)
                    {
                    var productIds = _context.ProductOrders.Where(o => o.IdOrder == orderId).Select(o => o.IdProduct).ToList();
                    foreach (int productId in productIds)
                    {
                    var product = new ProductResponse()
                    {
                        Name = _context.Products.Where(p => p.IdProduct == productId).Select(p => p.Name).FirstOrDefault(),
                        Type = _context.Products.Where(p => p.IdProduct == productId).Select(p => p.Type).FirstOrDefault(),
                        Quantity = _context.ProductOrders.Where(p => p.IdProduct == productId).Select(p => p.Quantity).FirstOrDefault()
                    };
                    products.Add(product);
                }
            }
            return new OkObjectResult(products);

        }

        public IActionResult GetClientOrders()
        {
            List<ProductResponse> orders = new List<ProductResponse>();
            var orderIds = _context.Orders.Select(o => o.IdOrder).ToList();
            foreach (int orderId in orderIds)
            {
                var productIds = _context.ProductOrders.Where(o => o.IdOrder == orderId).Select(o => o.IdProduct).ToList();
                foreach (int productId in productIds)
                {
                    var product = new ProductResponse()
                    {
                        Name = _context.Products.Where(p => p.IdProduct == productId).Select(p => p.Name).FirstOrDefault(),
                        Type = _context.Products.Where(p => p.IdProduct == productId).Select(p => p.Type).FirstOrDefault(),
                        Quantity = _context.ProductOrders.Where(p => p.IdProduct == productId).Select(p => p.Quantity).FirstOrDefault()
                    };
                    orders.Add(product);
                }
            }
            return new OkObjectResult(orders);
        }
    }
}
