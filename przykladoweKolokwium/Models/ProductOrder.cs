 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace przykladoweKolokwium.Models
{
    public class ProductOrder
    {
        public int IdProduct { get; set; }
        
        public int IdOrder { get; set; }

        public int  Quantity { get; set; }
        
        public string Notes { get; set; }
       

        public Product Product { get; set; }

        public Order Order { get; set; }
    }
}
