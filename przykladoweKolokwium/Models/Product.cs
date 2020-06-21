using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace przykladoweKolokwium.Models
{
    public class Product
    {
        public int IdProduct { get; set; }
        
        public string Name { get; set; }
        
        public float Price { get; set; }
    
        public string Type { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
