using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace przykladoweKolokwium.DTOs
{
    public class OrderRequest
    {
        public DateTime OrderDate { get; set; }
        public string Notes { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
